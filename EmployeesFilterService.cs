using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace sellular_shop.Filtering
{
    /// <summary>
    /// Универсальный сервис фильтрации табличных данных для DataTable/DataGridView.
    /// Можно использовать в любой форме, не только в employees.
    /// </summary>
    public static class TableFilterService
    {
        public static List<FilterColumnOption> GetFilterColumns(DataTable sourceTable, DataGridView dataGridView)
        {
            Dictionary<string, string> headerByProperty = dataGridView.Columns
                .Cast<DataGridViewColumn>()
                .Where(column => !string.IsNullOrWhiteSpace(column.DataPropertyName))
                .ToDictionary(column => column.DataPropertyName, column => column.HeaderText);

            return GetFilterColumns(sourceTable, headerByProperty);
        }

        public static List<FilterColumnOption> GetFilterColumns(DataTable sourceTable, Dictionary<string, string> headerByProperty)
        {
            return sourceTable.Columns
                .Cast<DataColumn>()
                .Select(column => new FilterColumnOption
                {
                    Column = column,
                    DisplayName = headerByProperty.TryGetValue(column.ColumnName, out string header)
                        ? header
                        : column.ColumnName
                })
                .ToList();
        }

        public static DataTable ApplyFilter(DataTable sourceTable, FilterColumnOption selectedColumn, string searchValue, bool useRegex)
        {
            IEnumerable<DataRow> rows = FilterRows(sourceTable, selectedColumn, searchValue, useRegex);

            DataTable filtered = sourceTable.Clone();
            foreach (DataRow row in rows)
            {
                filtered.ImportRow(row);
            }

            return filtered;
        }

        public static IEnumerable<DataRow> FilterRows(DataTable sourceTable, FilterColumnOption selectedColumn, string searchValue, bool useRegex)
        {
            Regex compiledRegex = null;
            if (useRegex)
            {
                compiledRegex = new Regex(searchValue, RegexOptions.IgnoreCase | RegexOptions.CultureInvariant);
            }

            return sourceTable.AsEnumerable().Where(row => IsMatch(row, selectedColumn, searchValue, useRegex, compiledRegex));
        }

        private static bool IsMatch(DataRow row, FilterColumnOption selectedColumn, string searchValue, bool useRegex, Regex compiledRegex)
        {
            object cellValue = row[selectedColumn.Column.ColumnName];
            if (cellValue == DBNull.Value)
            {
                return false;
            }

            string valueText = Convert.ToString(cellValue, CultureInfo.InvariantCulture) ?? string.Empty;

            if (useRegex)
            {
                return compiledRegex != null && compiledRegex.IsMatch(valueText);
            }

            return EvaluateCondition(cellValue, searchValue);
        }

        private static bool EvaluateCondition(object cellValue, string condition)
        {
            string trimmed = condition.Trim();
            string[] operators = { ">=", "<=", "!=", ">", "<", "=" };
            string op = operators.FirstOrDefault(trimmed.StartsWith);

            if (op == null)
            {
                return Convert.ToString(cellValue, CultureInfo.InvariantCulture)
                    ?.IndexOf(trimmed, StringComparison.OrdinalIgnoreCase) >= 0;
            }

            string rightPart = trimmed.Substring(op.Length).Trim();
            if (string.IsNullOrWhiteSpace(rightPart))
            {
                return false;
            }

            if (cellValue is DateTime dateValue)
            {
                if (int.TryParse(rightPart, out int yearOnly))
                {
                    return Compare(dateValue.Year, yearOnly, op);
                }

                if (DateTime.TryParse(rightPart, out DateTime parsedDate))
                {
                    return Compare(dateValue.Date, parsedDate.Date, op);
                }
            }

            if (decimal.TryParse(Convert.ToString(cellValue, CultureInfo.InvariantCulture), NumberStyles.Any, CultureInfo.InvariantCulture, out decimal cellNumber)
                && decimal.TryParse(rightPart.Replace(',', '.'), NumberStyles.Any, CultureInfo.InvariantCulture, out decimal conditionNumber))
            {
                return Compare(cellNumber, conditionNumber, op);
            }

            int compareResult = string.Compare(
                Convert.ToString(cellValue, CultureInfo.InvariantCulture),
                rightPart,
                StringComparison.OrdinalIgnoreCase);

            return Compare(compareResult, 0, op);
        }

        private static bool Compare<T>(T left, T right, string op) where T : IComparable<T>
        {
            int result = left.CompareTo(right);

            switch (op)
            {
                case ">":
                    return result > 0;
                case "<":
                    return result < 0;
                case ">=":
                    return result >= 0;
                case "<=":
                    return result <= 0;
                case "=":
                    return result == 0;
                case "!=":
                    return result != 0;
                default:
                    return false;
            }
        }
    }

    /// <summary>
    /// Обратная совместимость со старым именем.
    /// </summary>
    public static class EmployeesFilterService
    {
        public static List<FilterColumnOption> GetFilterColumns(DataTable sourceTable, Dictionary<string, string> headerByProperty)
        {
            return TableFilterService.GetFilterColumns(sourceTable, headerByProperty);
        }

        public static IEnumerable<DataRow> FilterRows(DataTable sourceTable, FilterColumnOption selectedColumn, string searchValue, bool useRegex)
        {
            return TableFilterService.FilterRows(sourceTable, selectedColumn, searchValue, useRegex);
        }
    }
}
