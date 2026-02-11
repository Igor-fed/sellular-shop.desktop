using sellular_shop.Data;
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
    public partial class editClients : Form
    {
        private readonly StoredProcedureExecutor _procedureExecutor;
        public editClients()
        {
            InitializeComponent();
            _procedureExecutor = new StoredProcedureExecutor(Properties.Settings.Default.shopConnectionString);
        }

        private void clientsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clientsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.shopDataSet);

        }

        private void editEmployee_Load(object sender, EventArgs e)
        {

            // TODO: данная строка кода позволяет загрузить данные в таблицу "shopDataSet.clients". При необходимости она может быть перемещена или удалена.
            clientsTableAdapter.Fill(shopDataSet.clients);
            _procedureExecutor.LoadAllProcedures();

        }

        private void btnPrevios_Click(object sender, EventArgs e)
        {
            clientsBindingSource.MovePrevious();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var call = new StoredProcedureCall(
                    procedureName: "sp_create_client", 
                    parameters: new[]
                    {
                        new StoredProcedureParameterMap("@Фамилия", () => last_nameTextBox.Text),
                        new StoredProcedureParameterMap("@Имя", () => first_nameTextBox.Text),
                        new StoredProcedureParameterMap("Отчество", () => patronymicTextBox.Text),  
                        new StoredProcedureParameterMap("@дата_рождения", () => Convert.ToDateTime(birth_dateDateTimePicker.Value)),
                        new StoredProcedureParameterMap("@телефон", () => phoneTextBox.Text),
                        new StoredProcedureParameterMap("@email", () => emailTextBox.Text)
                    });

                _procedureExecutor.Execute(call);

                this.clientsTableAdapter.Fill(this.shopDataSet.clients);
                MessageBox.Show("Клиент добавлен через хранимую процедуру.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка выполнения процедуры: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            clientsBindingSource.MoveNext();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            clientsBindingSource.MoveFirst();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clientsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.shopDataSet);

        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            clientsBindingSource.MoveLast();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var call = new StoredProcedureCall(
                    procedureName: "deactivate_client",
                    parameters: new[]
                    {
                   
                        new StoredProcedureParameterMap("@id_клиента", () => Convert.ToInt32(client_idLabel1.Text))
                    });

                _procedureExecutor.Execute(call);

                this.clientsTableAdapter.Fill(this.shopDataSet.clients);
                MessageBox.Show($"Клиент ушел с помощью хранимой процедуры.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
