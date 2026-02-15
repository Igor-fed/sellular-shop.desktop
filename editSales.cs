using sellular_shop.Data;
using sellular_shop.shopDataSetTableAdapters;
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
    public partial class editSales  : Form
    {
        private readonly StoredProcedureExecutor _procedureExecutor;
        public editSales()
        {
            InitializeComponent();
            _procedureExecutor = new StoredProcedureExecutor(Properties.Settings.Default.shopConnectionString);
        }



        private void editSales_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "shopDataSet.sales". При необходимости она может быть перемещена или удалена.
            salesTableAdapter.Fill(shopDataSet.sales);
            clientsTableAdapter.Fill(shopDataSet.clients);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "shopDataSet.employees". При необходимости она может быть перемещена или удалена.
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
                        new StoredProcedureParameterMap("@id_клиента", () => client_idComboBox.SelectedItem),
                        new StoredProcedureParameterMap("@тип_оплаты", () => payment_typeListBox.Text)

                    });

                _procedureExecutor.Execute(call);

                this.salesTableAdapter.Fill(this.shopDataSet.sales);
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

                this.salesTableAdapter.Fill(this.shopDataSet.sales);
                MessageBox.Show("Продажа завершена через хранимую процедуру.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка выполнения процедуры: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.Validate();
            this.salesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.shopDataSet);

        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            salesBindingSource.MoveLast();
        }

        private void addProd_Click(object sender, EventArgs e)
        {
            try
            {
                var call = new StoredProcedureCall(
                    procedureName: "sp_update_contract_status",
                    parameters: new[]
                    {
                   
                        new StoredProcedureParameterMap("@id_договора", () => Convert.ToInt32(sale_idLabel1.Text)),
                        new StoredProcedureParameterMap("@Статус", () => "Закрыт")
                    });

                _procedureExecutor.Execute(call);

                this.salesTableAdapter.Fill(this.shopDataSet.sales);
                MessageBox.Show($"Договор расторгнут с помощью хранимой процедуры.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка выполнения процедуры: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void salesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.salesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.shopDataSet);

        }

        private void addService_Click(object sender, EventArgs e)
        {

        }
    }
}
