using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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

    }
}
