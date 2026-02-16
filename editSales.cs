using sellular_shop.Data;
using sellular_shop.shopDataSetTableAdapters;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace sellular_shop
{
    public partial class editSales : Form
    {
        private readonly StoredProcedureExecutor _procedureExecutor;

        public editSales()
        {
            InitializeComponent();
            _procedureExecutor = new StoredProcedureExecutor(Properties.Settings.Default.shopConnectionString);
        }

        private void editSales_Load(object sender, EventArgs e)
        {
            salesTableAdapter.Fill(shopDataSet.sales);
            clientsTableAdapter.Fill(shopDataSet.clients);
            employeesTableAdapter.Fill(shopDataSet.employees);

            ConfigurePersonDisplay(clientsBindingSource);
            ConfigurePersonDisplay(employeesBindingSource);

            _procedureExecutor.LoadAllProcedures();
        }

        private static void ConfigurePersonDisplay(BindingSource bindingSource)
        {
            var dataSet = bindingSource.DataSource as DataSet;
            if (dataSet == null || !dataSet.Tables.Contains(bindingSource.DataMember))
            {
                return;
            }

            var table = dataSet.Tables[bindingSource.DataMember];
            const string fullNameColumn = "full_name";

            if (!table.Columns.Contains(fullNameColumn))
            {
                table.Columns.Add(fullNameColumn, typeof(string));
            }

            foreach (DataRow row in table.Rows)
            {
                var lastName = row["last_name"]?.ToString()?.Trim();
                var firstName = row["first_name"]?.ToString()?.Trim();

                row[fullNameColumn] = string.Join(" ", new[] { lastName, firstName }
                    .Where(value => !string.IsNullOrWhiteSpace(value)));
            }
        }

        private void btnPrevios_Click(object sender, EventArgs e)
        {
            salesBindingSource.MovePrevious();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var call = new StoredProcedureCall(
                    procedureName: "sp_create_sale",
                    parameters: new[]
                    {
                        new StoredProcedureParameterMap("@id_сотрудника", () => employee_idComboBox.SelectedValue),
                        new StoredProcedureParameterMap("@id_клиента", () => client_idComboBox.SelectedValue),
                        new StoredProcedureParameterMap("@тип_оплаты", () => payment_typeListBox.Text)
                    });

                _procedureExecutor.Execute(call);

                salesTableAdapter.Fill(shopDataSet.sales);
                MessageBox.Show("Продажа начата через хранимую процедуру.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка выполнения процедуры: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            salesBindingSource.MoveNext();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            salesBindingSource.MoveFirst();
        }

        private void btnFinalize_Click(object sender, EventArgs e)
        {
            try
            {
                var call = new StoredProcedureCall(
                    procedureName: "sp_finalize_sale",
                    parameters: new[]
                    {
                        new StoredProcedureParameterMap("@id_продажи", () => Convert.ToInt32(sale_idLabel1.Text)),
                    });

                _procedureExecutor.Execute(call);

                salesTableAdapter.Fill(shopDataSet.sales);
                MessageBox.Show("Продажа завершена через хранимую процедуру.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка выполнения процедуры: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Validate();
            salesBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(shopDataSet);
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            salesBindingSource.MoveLast();
        }

        private void addProd_Click(object sender, EventArgs e)
        {
            try
            {
                if (!TryGetCurrentSaleId(out var saleId))
                {
                    return;
                }

                var productsTable = new shopDataSet.vw_products_in_stockDataTable();

                using (var productsAdapter = new vw_products_in_stockTableAdapter())
                {
                    productsAdapter.Fill(productsTable);
                }

                using (var dialog = new SelectSaleEntryDialog(
                    title: "Выбор товара",
                    sourceTable: productsTable,
                    idColumnName: "product_id",
                    quantityColumnName: "quantity",
                    supportsQuantitySelection: true))
                {
                    if (dialog.ShowDialog(this) != DialogResult.OK)
                    {
                        return;
                    }

                    var call = new StoredProcedureCall(
                        procedureName: "sp_add_product_to_sale",
                        parameters: new[]
                        {
                            new StoredProcedureParameterMap("@id_продажи", () => saleId),
                            new StoredProcedureParameterMap("@id_товара", () => dialog.SelectedItemId),
                            new StoredProcedureParameterMap("@количество", () => dialog.SelectedQuantity)
                        });

                    _procedureExecutor.Execute(call);
                }

                salesTableAdapter.Fill(shopDataSet.sales);
                MessageBox.Show("Товар добавлен в продажу через хранимую процедуру.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка выполнения процедуры: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void salesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Validate();
            salesBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(shopDataSet);
        }

        private void addService_Click(object sender, EventArgs e)
        {
            try
            {
                if (!TryGetCurrentSaleId(out var saleId))
                {
                    return;
                }

                var servicesTable = new shopDataSet.vw_active_servicesDataTable();

                using (var servicesAdapter = new vw_active_servicesTableAdapter())
                {
                    servicesAdapter.Fill(servicesTable);
                }

                using (var dialog = new SelectSaleEntryDialog(
                    title: "Выбор услуги",
                    sourceTable: servicesTable,
                    idColumnName: "service_id",
                    quantityColumnName: null,
                    supportsQuantitySelection: false))
                {
                    if (dialog.ShowDialog(this) != DialogResult.OK)
                    {
                        return;
                    }

                    var call = new StoredProcedureCall(
                        procedureName: "sp_add_service_to_sale",
                        parameters: new[]
                        {
                            new StoredProcedureParameterMap("@id_продажи", () => saleId),
                            new StoredProcedureParameterMap("@id_услуги", () => dialog.SelectedItemId)
                        });

                    _procedureExecutor.Execute(call);
                }

                salesTableAdapter.Fill(shopDataSet.sales);
                MessageBox.Show("Услуга добавлена в продажу через хранимую процедуру.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка выполнения процедуры: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool TryGetCurrentSaleId(out int saleId)
        {
            if (int.TryParse(sale_idLabel1.Text, out saleId))
            {
                return true;
            }

            MessageBox.Show("Не удалось определить текущую продажу.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
    }

    internal sealed class SelectSaleEntryDialog : Form
    {
        private readonly string _idColumnName;
        private readonly string _quantityColumnName;
        private readonly bool _supportsQuantitySelection;
        private readonly DataGridView _itemsGrid;
        private readonly NumericUpDown _quantityInput;

        public SelectSaleEntryDialog(string title, DataTable sourceTable, string idColumnName, string quantityColumnName, bool supportsQuantitySelection)
        {
            _idColumnName = idColumnName;
            _quantityColumnName = quantityColumnName;
            _supportsQuantitySelection = supportsQuantitySelection;

            Text = title;
            StartPosition = FormStartPosition.CenterParent;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            ClientSize = new Size(640, supportsQuantitySelection ? 380 : 340);

            _itemsGrid = new DataGridView
            {
                Dock = DockStyle.Top,
                Height = 280,
                ReadOnly = true,
                MultiSelect = false,
                SelectionMode = DataGridViewSelectionMode.FullRowSelect,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                DataSource = sourceTable
            };

            var quantityLabel = new Label
            {
                Left = 20,
                Top = 294,
                Width = 140,
                Text = "Количество:"
            };

            _quantityInput = new NumericUpDown
            {
                Left = 170,
                Top = 290,
                Width = 90,
                Minimum = 1,
                Maximum = 999
            };

            var okButton = new Button
            {
                Text = "ОК",
                Width = 100,
                Left = 408,
                Top = supportsQuantitySelection ? 328 : 294,
                DialogResult = DialogResult.OK
            };

            var cancelButton = new Button
            {
                Text = "Отмена",
                Width = 100,
                Left = 520,
                Top = supportsQuantitySelection ? 328 : 294,
                DialogResult = DialogResult.Cancel
            };

            okButton.Click += OkButton_Click;

            Controls.Add(_itemsGrid);
            Controls.Add(okButton);
            Controls.Add(cancelButton);

            if (supportsQuantitySelection)
            {
                Controls.Add(quantityLabel);
                Controls.Add(_quantityInput);
            }

            AcceptButton = okButton;
            CancelButton = cancelButton;
        }

        public long SelectedItemId { get; private set; }

        public int SelectedQuantity => Convert.ToInt32(_quantityInput.Value);

        private void OkButton_Click(object sender, EventArgs e)
        {
            if (_itemsGrid.CurrentRow == null)
            {
                MessageBox.Show("Выберите запись из списка.", "Проверка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.None;
                return;
            }

            if (!long.TryParse(_itemsGrid.CurrentRow.Cells[_idColumnName].Value?.ToString(), out var selectedId))
            {
                MessageBox.Show("Не удалось определить выбранный элемент.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DialogResult = DialogResult.None;
                return;
            }

            if (_supportsQuantitySelection
                && !string.IsNullOrWhiteSpace(_quantityColumnName)
                && int.TryParse(_itemsGrid.CurrentRow.Cells[_quantityColumnName].Value?.ToString(), out var availableQuantity)
                && SelectedQuantity > availableQuantity)
            {
                MessageBox.Show("Введенное количество превышает остаток на складе.", "Проверка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                DialogResult = DialogResult.None;
                return;
            }

            SelectedItemId = selectedId;
        }
    }
}