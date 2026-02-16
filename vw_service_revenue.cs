using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using sellular_shop.Filtering;
using sellular_shop.shopDataSetTableAdapters;
using sellular_shop.Sorting;
using sellular_shop.UI;

namespace sellular_shop
{
    public partial class vw_service_revenue : Form
    {
        private readonly GridSortState _sortState = new GridSortState();

        public vw_service_revenue()
        {
            InitializeComponent();
            dataGridView1.ColumnHeaderMouseClick += dataGridView1_ColumnHeaderMouseClick;
        }

        private void vw_service_revenue_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "shopDataSet.vw_service_revenue". При необходимости она может быть перемещена или удалена.
            vw_service_revenueTableAdapter.Fill(shopDataSet.vw_service_revenue);




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
            vwservicerevenueBindingSource.Sort = $"{dataPropertyName} {sortDirectionText}";

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

        private void filter_Click(object sender, EventArgs e)
        {
            DataTable sourceTable = shopDataSet.services;
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

                try
                {
                    DataTable filtered = TableFilterService.ApplyFilter(sourceTable, dialog.SelectedColumn, dialog.SearchValue, dialog.UseRegex);
                    vwservicerevenueBindingSource.DataSource = filtered;
                }
                catch (ArgumentException ex)
                {
                    MessageBox.Show($"Некорректное регулярное выражение: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private List<FilterColumnOption> GetFilterColumns(DataTable sourceTable)
        {
            return TableFilterService.GetFilterColumns(sourceTable, dataGridView1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            vwservicerevenueBindingSource.DataSource = shopDataSet.services;
            vwservicerevenueBindingSource.RemoveFilter();
            vwservicerevenueBindingSource.Sort = string.Empty;

            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.HeaderCell.SortGlyphDirection = SortOrder.None;
            }

            _sortState.Reset();
        }

    }
}