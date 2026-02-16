using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using sellular_shop.Filtering;
using sellular_shop.shopDataSetTableAdapters;
using sellular_shop.Sorting;
using sellular_shop.UI;

namespace sellular_shop
{
    public partial class vw_report : Form
    {
        private readonly GridSortState _sortState = new GridSortState();

        public vw_report()
        {
            InitializeComponent();
            dataGridView1.ColumnHeaderMouseClick += dataGridView1_ColumnHeaderMouseClick;
        }

        private void vw_report_Load(object sender, EventArgs e)
        {
            try
            {
                shopDataSet.EnforceConstraints = false;
                vw_reportTableAdapter.Fill(shopDataSet.vw_report);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки отчета: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            vwreportBindingSource.Sort = $"{dataPropertyName} {sortDirectionText}";

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
                    vwreportBindingSource.DataSource = filtered;
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
            vwreportBindingSource.DataSource = shopDataSet.services;
            vwreportBindingSource.RemoveFilter();
            vwreportBindingSource.Sort = string.Empty;

            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.HeaderCell.SortGlyphDirection = SortOrder.None;
            }

            _sortState.Reset();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            List<long> saleIds = shopDataSet.vw_report
                .Select(row => row.sale_id)
                .Distinct()
                .OrderBy(id => id)
                .ToList();

            if (saleIds.Count == 0)
            {
                MessageBox.Show("Нет данных для экспорта.", "Экспорт", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            long? selectedSaleId = ShowSaleIdSelectionDialog(saleIds);
            if (!selectedSaleId.HasValue)
            {
                return;
            }

            List<shopDataSet.vw_reportRow> selectedRows = shopDataSet.vw_report
                .Where(row => row.sale_id == selectedSaleId.Value)
                .ToList();

            if (selectedRows.Count == 0)
            {
                MessageBox.Show("Не найдены позиции для выбранной продажи.", "Экспорт", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            shopDataSetTableAdapters.salesTableAdapter salesAdapter = new salesTableAdapter();
            shopDataSet.salesDataTable salesData = salesAdapter.GetData();
            shopDataSet.salesRow saleRow = salesData.FirstOrDefault(row => row.sale_id == selectedSaleId.Value);

            if (saleRow == null)
            {
                MessageBox.Show("Не удалось получить данные о продаже.", "Экспорт", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SaveFileDialog saveDialog = new SaveFileDialog())
            {
                saveDialog.Filter = "PDF файл (*.pdf)|*.pdf";
                saveDialog.FileName = $"check_sale_{selectedSaleId.Value}.pdf";

                if (saveDialog.ShowDialog(this) != DialogResult.OK)
                {
                    return;
                }

                ReceiptPdfExporter.ExportSaleReceipt(saveDialog.FileName, BuildReceiptData(selectedRows, saleRow));

                MessageBox.Show("PDF-чек успешно сохранён.", "Экспорт", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private ReceiptData BuildReceiptData(List<shopDataSet.vw_reportRow> saleItems, shopDataSet.salesRow saleRow)
        {
            shopDataSet.vw_reportRow first = saleItems.First();
            string clientName = first.Isclient_nameNull() ? "Не указан" : first.client_name;
            string employeeName = first.Isemployee_nameNull() ? "Не указан" : first.employee_name;
            DateTime saleDate = saleRow.Issale_dateNull() ? DateTime.Now : saleRow.sale_date;

            List<ReceiptItemData> items = saleItems
                .OrderBy(item => item.item_name)
                .Select(item => new ReceiptItemData
                {
                    ItemName = item.Isitem_nameNull() ? "Позиция" : item.item_name,
                    Quantity = item.quantity,
                    Price = item.price
                })
                .ToList();

            return new ReceiptData
            {
                SaleDate = saleDate,
                Items = items,
                TotalAmount = saleRow.total_amount,
                PaymentType = saleRow.payment_type,
                ClientName = clientName,
                EmployeeName = employeeName
            };
        }

        private long? ShowSaleIdSelectionDialog(List<long> saleIds)
        {
            using (Form dialog = new Form())
            {
                dialog.Text = "Выбор продажи";
                dialog.FormBorderStyle = FormBorderStyle.FixedDialog;
                dialog.StartPosition = FormStartPosition.CenterParent;
                dialog.MaximizeBox = false;
                dialog.MinimizeBox = false;
                dialog.ClientSize = new Size(300, 135);

                Label label = new Label
                {
                    Text = "Выберите ID продажи:",
                    Left = 12,
                    Top = 15,
                    Width = 260
                };

                ComboBox combo = new ComboBox
                {
                    Left = 12,
                    Top = 45,
                    Width = 260,
                    DropDownStyle = ComboBoxStyle.DropDownList
                };
                combo.Items.AddRange(saleIds.Cast<object>().ToArray());
                combo.SelectedIndex = 0;

                Button okButton = new Button
                {
                    Text = "OK",
                    Left = 116,
                    Width = 75,
                    Top = 86,
                    DialogResult = DialogResult.OK
                };

                Button cancelButton = new Button
                {
                    Text = "Отмена",
                    Left = 197,
                    Width = 75,
                    Top = 86,
                    DialogResult = DialogResult.Cancel
                };

                dialog.Controls.Add(label);
                dialog.Controls.Add(combo);
                dialog.Controls.Add(okButton);
                dialog.Controls.Add(cancelButton);
                dialog.AcceptButton = okButton;
                dialog.CancelButton = cancelButton;

                if (dialog.ShowDialog(this) != DialogResult.OK)
                {
                    return null;
                }

                return combo.SelectedItem as long?;
            }
        }

    }
}