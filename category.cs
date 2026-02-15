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
    public partial class category : Form
    {
        private readonly GridSortState _sortState = new GridSortState();

        public category()
        {
            InitializeComponent();
            dataGridView1.ColumnHeaderMouseClick += dataGridView1_ColumnHeaderMouseClick;
        }

        private void category_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "shopDataSet.clients". При необходимости она может быть перемещена или удалена.
            categoryTableAdapter.Fill(shopDataSet.category);
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

        }

        private void delete_Click(object sender, EventArgs e)
        {

        }
    }
}