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
    public partial class editServices : Form
    {
        private readonly StoredProcedureExecutor _procedureExecutor;
        public editServices()
        {
            InitializeComponent();
            _procedureExecutor = new StoredProcedureExecutor(Properties.Settings.Default.shopConnectionString);
        }



        private void editServices_Load(object sender, EventArgs e)
        {


            // TODO: данная строка кода позволяет загрузить данные в таблицу "shopDataSet.services". При необходимости она может быть перемещена или удалена.
            servicesTableAdapter.Fill(shopDataSet.services);
            _procedureExecutor.LoadAllProcedures();

        }

        private void btnPrevios_Click(object sender, EventArgs e)
        {
            servicesBindingSource.MovePrevious();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var call = new StoredProcedureCall(
                    procedureName: "add_service", 
                    parameters: new[]
                    {
                        new StoredProcedureParameterMap("@Название_услуги", () => nameTextBox.Text),
                        new StoredProcedureParameterMap("@описание", () => descriptionTextBox.Text),
                        new StoredProcedureParameterMap("абонентская_плата", () => Convert.ToDecimal(monthly_feeTextBox.Text)),  
                        new StoredProcedureParameterMap("@плата_за_подключение", () => Convert.ToDecimal(connection_feeTextBox.Text)),
                        new StoredProcedureParameterMap("@активна", () => Convert.ToByte(is_activeCheckBox))
                    });

                _procedureExecutor.Execute(call);

                this.servicesTableAdapter.Fill(this.shopDataSet.services);
                MessageBox.Show("Клиент добавлен через хранимую процедуру.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка выполнения процедуры: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            servicesBindingSource.MoveNext();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            servicesBindingSource.MoveFirst();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.servicesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.shopDataSet);

        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            servicesBindingSource.MoveLast();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var call = new StoredProcedureCall(
                    procedureName: "deactivate_service",
                    parameters: new[]
                    {
                   
                        new StoredProcedureParameterMap("@id_услуги", () => Convert.ToInt32(service_idLabel1.Text))
                    });

                _procedureExecutor.Execute(call);

                this.servicesTableAdapter.Fill(this.shopDataSet.services);
                MessageBox.Show($"Услуга перестала предоставляться с помощью хранимой процедуры.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void servicesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.servicesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.shopDataSet);

        }
    }
}
