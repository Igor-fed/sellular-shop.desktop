using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace sellular_shop.Data
{
    public sealed class StoredProcedureExecutor
    {
        private readonly string _connectionString;
        private Dictionary<string, string> _availableProcedures;

        public StoredProcedureExecutor(string connectionString)
        {
            if (string.IsNullOrWhiteSpace(connectionString))
            {
                throw new ArgumentException("Connection string is required.", nameof(connectionString));
            }

            _connectionString = connectionString;
            _availableProcedures = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        }

        /// <summary>
        /// Загружает все процедуры из базы и кэширует их в формате: ключ = имя для вызова, значение = полное имя [schema].[procedure].
        /// </summary>
        public IReadOnlyDictionary<string, string> LoadAllProcedures()
        {
            var procedures = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);

            using (var connection = new SqlConnection(_connectionString))
            using (var command = new SqlCommand(@"
SELECT SPECIFIC_SCHEMA, SPECIFIC_NAME
FROM INFORMATION_SCHEMA.ROUTINES
WHERE ROUTINE_TYPE = 'PROCEDURE'
ORDER BY SPECIFIC_SCHEMA, SPECIFIC_NAME;", connection))
            {
                connection.Open();

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var schema = reader.GetString(0);
                        var procedureName = reader.GetString(1);

                        var shortName = procedureName;
                        var schemaDotName = schema + "." + procedureName;
                        var fullName = string.Format("[{0}].[{1}]", schema, procedureName);

                        if (!procedures.ContainsKey(shortName))
                        {
                            procedures[shortName] = fullName;
                        }

                        procedures[schemaDotName] = fullName;
                        procedures[fullName] = fullName;
                    }
                }
            }

            _availableProcedures = procedures;
            return _availableProcedures;
        }

        public int Execute(StoredProcedureCall call)
        {
            if (call == null)
            {
                throw new ArgumentNullException(nameof(call));
            }

            var requestedName = NormalizeProcedureName(call.ProcedureName);
            var resolvedProcedureName = ResolveProcedureName(requestedName);

            using (var connection = new SqlConnection(_connectionString))
            using (var command = new SqlCommand(resolvedProcedureName, connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                foreach (var parameter in call.Parameters)
                {
                    var value = parameter.ValueFactory();
                    command.Parameters.AddWithValue(parameter.ParameterName, value ?? DBNull.Value);
                }

                connection.Open();
                return command.ExecuteNonQuery();
            }
        }

        private string ResolveProcedureName(string requestedName)
        {
            if (_availableProcedures.Count > 0)
            {
                if (_availableProcedures.TryGetValue(requestedName, out var resolvedByCache))
                {
                    return resolvedByCache;
                }
            }

            if (_availableProcedures.Count == 0)
            {
                try
                {
                    LoadAllProcedures();

                    if (_availableProcedures.TryGetValue(requestedName, out var resolvedAfterLoad))
                    {
                        return resolvedAfterLoad;
                    }
                }
                catch
                {
                    // Если нет прав на INFORMATION_SCHEMA.ROUTINES или каталог недоступен,
                    // пробуем выполнить процедуру напрямую по имени.
                }
            }

            if (requestedName.IndexOf('.') >= 0)
            {
                return requestedName;
            }

            return "dbo." + requestedName;
        }

        private static string NormalizeProcedureName(string procedureName)
        {
            if (string.IsNullOrWhiteSpace(procedureName))
            {
                throw new ArgumentException("Procedure name is required.", nameof(procedureName));
            }

            return procedureName.Trim().Trim('{', '}');
        }
    }

    public sealed class StoredProcedureCall
    {
        public StoredProcedureCall(string procedureName, IEnumerable<StoredProcedureParameterMap> parameters)
        {
            if (string.IsNullOrWhiteSpace(procedureName))
            {
                throw new ArgumentException("Procedure name is required.", nameof(procedureName));
            }

            ProcedureName = procedureName;
            Parameters = parameters?.ToList() ?? new List<StoredProcedureParameterMap>();
        }

        public string ProcedureName { get; }

        public IReadOnlyCollection<StoredProcedureParameterMap> Parameters { get; }
    }

    public sealed class StoredProcedureParameterMap
    {
        public StoredProcedureParameterMap(string parameterName, Func<object> valueFactory)
        {
            if (string.IsNullOrWhiteSpace(parameterName))
            {
                throw new ArgumentException("Parameter name is required.", nameof(parameterName));
            }

            ParameterName = parameterName.StartsWith("@", StringComparison.Ordinal)
                ? parameterName
                : "@" + parameterName;
            ValueFactory = valueFactory ?? throw new ArgumentNullException(nameof(valueFactory));
        }

        public string ParameterName { get; }

        public Func<object> ValueFactory { get; }
    }
}
