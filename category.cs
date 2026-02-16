using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using sellular_shop.Data;
using sellular_shop.Filtering;
using sellular_shop.shopDataSetTableAdapters;
using sellular_shop.Sorting;
using sellular_shop.UI;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace sellular_shop
{
    public partial class category : Form
    {
        private readonly GridSortState _sortState = new GridSortState();
        private readonly StoredProcedureExecutor _procedureExecutor;

        public category()
        {
            InitializeComponent();
            dataGridView1.ColumnHeaderMouseClick += dataGridView1_ColumnHeaderMouseClick;
            _procedureExecutor = new StoredProcedureExecutor(Properties.Settings.Default.shopConnectionString);
        }

        private void category_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "shopDataSet.clients". При необходимости она может быть перемещена или удалена.
            categoryTableAdapter.Fill(shopDataSet.category);

            try
            {
                RefreshCategoryData();
                _procedureExecutor.LoadAllProcedures();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки категорий: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

            ListSortDirection nextSortDirection = _sortState.GetNextDirection(dataPropertyName);
            string sortDirectionText = GridSortState.ToSortDirectionText(nextSortDirection);
            categoryBindingSource.Sort = $"{dataPropertyName} {sortDirectionText}";

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
        }

        private void add_Click(object sender, EventArgs e)
        {
            string categoryName = categoryNametTextBox.Text?.Trim();
            if (string.IsNullOrWhiteSpace(categoryName))
            {
                MessageBox.Show("Введите название категории.", "Проверка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                categoryNametTextBox.Focus();
                return;
            }

            try
            {
                var call = new StoredProcedureCall(
                    procedureName: "add_category",
                    parameters: new[]
                    {
                        new StoredProcedureParameterMap("@название_категории", () => categoryName)
                    });

                _procedureExecutor.Execute(call);

                RefreshCategoryData();
                categoryNametTextBox.Clear();
                MessageBox.Show("Категория добавлена через хранимую процедуру.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка выполнения процедуры: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (!TryGetSelectedCategoryId(out int categoryId))
            {
                MessageBox.Show("Выберите id категории для удаления.", "Проверка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comboBox1.Focus();
                return;
            }

            try
            {
                var call = new StoredProcedureCall(
                    procedureName: "deactivate_category",
                    parameters: new[]
                    {
                        new StoredProcedureParameterMap("@id_категории", () => categoryId)
                    });

                _procedureExecutor.Execute(call);

                RefreshCategoryData();
                MessageBox.Show("Категория удалена через хранимую процедуру.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка выполнения процедуры: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool TryGetSelectedCategoryId(out int categoryId)
        {
            categoryId = 0;

            if (comboBox1.SelectedValue != null && int.TryParse(comboBox1.SelectedValue.ToString(), out categoryId))
            {
                return true;
            }

            if (comboBox1.SelectedItem is DataRowView selectedRow && int.TryParse(selectedRow["id"]?.ToString(), out categoryId))
            {
                return true;
            }

            return int.TryParse(comboBox1.Text, out categoryId);
        }

        private void RefreshCategoryData()
        {
            categoryTableAdapter.Fill(shopDataSet.category);
            comboBox1.SelectedIndex = shopDataSet.category.Rows.Count > 0 ? 0 : -1;
        }
    }
}