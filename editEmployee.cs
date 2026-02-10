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
    public partial class editEmployee : Form
    {
        private readonly StoredProcedureExecutor _procedureExecutor;
        public editEmployee()
        {
            InitializeComponent();
            _procedureExecutor = new StoredProcedureExecutor(Properties.Settings.Default.shopConnectionString);
        }

        private void employeesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employeesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.shopDataSet);

        }

        private void editEmployee_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "shopDataSet.employees". При необходимости она может быть перемещена или удалена.
            employeesTableAdapter.Fill(shopDataSet.employees);
            _procedureExecutor.LoadAllProcedures();

        }

        private void btnPrevios_Click(object sender, EventArgs e)
        {
            employeesBindingSource.MovePrevious();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var call = new StoredProcedureCall(
                    procedureName: "sp_add_employee", 
                    parameters: new[]
                    {
                        new StoredProcedureParameterMap("@last_name", () => last_nameTextBox.Text),
                        new StoredProcedureParameterMap("@first_name", () => first_nameTextBox.Text),
                        new StoredProcedureParameterMap("@position", () => positionTextBox.Text),
                        new StoredProcedureParameterMap("@phone", () => phoneTextBox.Text),
                        new StoredProcedureParameterMap("@email", () => emailMaskedTextBox.Text),
                        new StoredProcedureParameterMap("@login", () => loginTextBox.Text),
                        new StoredProcedureParameterMap("@is_active", () => is_activeCheckBox.Checked)
                    });

                _procedureExecutor.Execute(call);

                this.employeesTableAdapter.Fill(this.shopDataSet.employees);
                MessageBox.Show("Сотрудник добавлен через хранимую процедуру.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка выполнения процедуры: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            employeesBindingSource.MoveNext();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            employeesBindingSource.MoveFirst();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employeesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.shopDataSet);

        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            employeesBindingSource.MoveLast();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
