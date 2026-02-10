using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sellular_shop
{
    public partial class employees : Form
    {
        private string _lastSortedColumnName;
        private ListSortDirection _lastSortDirection = ListSortDirection.Ascending;

        public employees()
        {
            InitializeComponent();
            dataGridView1.ColumnHeaderMouseClick += dataGridView1_ColumnHeaderMouseClick;
        }

        private void employees_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "shopDataSet.employees". При необходимости она может быть перемещена или удалена.
            employeesTableAdapter.Fill(shopDataSet.employees);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewColumn clickedColumn = dataGridView1.Columns[e.ColumnIndex];
            string dataPropertyName = clickedColumn.DataPropertyName;

            if (string.IsNullOrWhiteSpace(dataPropertyName))
            {
                return;
            }

            ListSortDirection nextSortDirection = ListSortDirection.Ascending;

            if (_lastSortedColumnName == dataPropertyName)
            {
                nextSortDirection = _lastSortDirection == ListSortDirection.Ascending
                    ? ListSortDirection.Descending
                    : ListSortDirection.Ascending;
            }

            string sortDirectionText = nextSortDirection == ListSortDirection.Ascending ? "ASC" : "DESC";
            employeesBindingSource.Sort = $"{dataPropertyName} {sortDirectionText}";

            clickedColumn.HeaderCell.SortGlyphDirection = nextSortDirection == ListSortDirection.Ascending
                ? SortOrder.Ascending
                : SortOrder.Descending;

            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                if (column != clickedColumn)
                {
                    column.HeaderCell.SortGlyphDirection = SortOrder.None;
                }
            }

            _lastSortedColumnName = dataPropertyName;
            _lastSortDirection = nextSortDirection;
        }

        private void filter_Click(object sender, EventArgs e)
        {
            DataTable sourceTable = shopDataSet.employees;
            if (sourceTable == null)
            {
                return;
            }

            using (FilterDialog dialog = new FilterDialog(GetFilterColumns(sourceTable)))
            {
                if (dialog.ShowDialog(this) != DialogResult.OK)
                {
                    return;
                }

                if (string.IsNullOrWhiteSpace(dialog.SearchValue))
                {
                    MessageBox.Show("Введите значение для поиска.", "Фильтр", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (dialog.SelectedColumn == null)
                {
                    MessageBox.Show("Выберите поле для фильтрации.", "Фильтр", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                Regex compiledRegex = null;
                if (dialog.UseRegex)
                {
                    try
                    {
                        compiledRegex = new Regex(dialog.SearchValue, RegexOptions.IgnoreCase | RegexOptions.CultureInvariant);
                    }
                    catch (ArgumentException ex)
                    {
                        MessageBox.Show($"Некорректное регулярное выражение: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                IEnumerable<DataRow> rows = sourceTable.AsEnumerable().Where(row => IsMatch(row, dialog, compiledRegex));

                DataTable filtered = sourceTable.Clone();
                foreach (DataRow row in rows)
                {
                    filtered.ImportRow(row);
                }

                employeesBindingSource.DataSource = filtered;
            }
        }


        private List<FilterColumnOption> GetFilterColumns(DataTable sourceTable)
        {
            Dictionary<string, string> headerByProperty = dataGridView1.Columns
                .Cast<DataGridViewColumn>()
                .Where(column => !string.IsNullOrWhiteSpace(column.DataPropertyName))
                .ToDictionary(column => column.DataPropertyName, column => column.HeaderText);

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

        private bool IsMatch(DataRow row, FilterDialog dialog, Regex compiledRegex)
        {
            object cellValue = row[dialog.SelectedColumn.Column.ColumnName];
            if (cellValue == DBNull.Value)
            {
                return false;
            }

            string valueText = Convert.ToString(cellValue, CultureInfo.InvariantCulture) ?? string.Empty;

            if (dialog.UseRegex)
            {
                return compiledRegex != null && compiledRegex.IsMatch(valueText);
            }

            return EvaluateCondition(cellValue, dialog.SearchValue);
        }

        private bool EvaluateCondition(object cellValue, string condition)
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

        private bool Compare<T>(T left, T right, string op) where T : IComparable<T>
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

        private void button1_Click(object sender, EventArgs e)
        {
            employeesBindingSource.DataSource = shopDataSet.employees;
            employeesBindingSource.RemoveFilter();
            employeesBindingSource.Sort = string.Empty;

            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.HeaderCell.SortGlyphDirection = SortOrder.None;
            }

            _lastSortedColumnName = null;
            _lastSortDirection = ListSortDirection.Ascending;
        }

        private class FilterColumnOption
        {
            public DataColumn Column { get; set; }

            public string DisplayName { get; set; }
        }

        private class FilterDialog : Form
        {
            private readonly ComboBox _fieldComboBox;
            private readonly TextBox _valueTextBox;
            private readonly CheckBox _regexCheckBox;

            public FilterDialog(List<FilterColumnOption> columns)
            {
                Text = "Параметры фильтра";
                StartPosition = FormStartPosition.CenterParent;
                FormBorderStyle = FormBorderStyle.FixedDialog;
                MaximizeBox = false;
                MinimizeBox = false;
                Width = 420;
                Height = 230;

                Label fieldLabel = new Label { Left = 20, Top = 20, Width = 360, Text = "Поле для поиска" };
                _fieldComboBox = new ComboBox
                {
                    Left = 20,
                    Top = 45,
                    Width = 360,
                    DropDownStyle = ComboBoxStyle.DropDownList,
                    DisplayMember = "DisplayName",
                    DataSource = columns
                };

                Label valueLabel = new Label
                {
                    Left = 20,
                    Top = 80,
                    Width = 360,
                    Text = "Что искать (поддержка операторов: >, <, >=, <=, =, !=)"
                };
                _valueTextBox = new TextBox { Left = 20, Top = 105, Width = 360 };

                _regexCheckBox = new CheckBox
                {
                    Left = 20,
                    Top = 135,
                    Width = 360,
                    Text = "Использовать регулярное выражение"
                };

                Button okButton = new Button
                {
                    Text = "Применить",
                    Left = 224,
                    Width = 75,
                    Top = 160,
                    DialogResult = DialogResult.OK
                };

                Button cancelButton = new Button
                {
                    Text = "Отмена",
                    Left = 305,
                    Width = 75,
                    Top = 160,
                    DialogResult = DialogResult.Cancel
                };

                AcceptButton = okButton;
                CancelButton = cancelButton;

                Controls.Add(fieldLabel);
                Controls.Add(_fieldComboBox);
                Controls.Add(valueLabel);
                Controls.Add(_valueTextBox);
                Controls.Add(_regexCheckBox);
                Controls.Add(okButton);
                Controls.Add(cancelButton);
            }

            public FilterColumnOption SelectedColumn => _fieldComboBox.SelectedItem as FilterColumnOption;

            public string SearchValue => _valueTextBox.Text;

            public bool UseRegex => _regexCheckBox.Checked;
        }

        private void edit_Click(object sender, EventArgs e)
        {

        }
    }
}