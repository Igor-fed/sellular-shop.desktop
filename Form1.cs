using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Security.Cryptography;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sellular_shop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (!LoginTextBox.Visible)
            {
                loginLabel.Visible = true;
                LoginTextBox.Visible = true;
                PassLabel.Visible = true;
                PassTextBox.Visible = true;
                PassTextBox.UseSystemPasswordChar = true;
                LoginButton.Size = new System.Drawing.Size(160, 30);
                LoginButton.Location = new System.Drawing.Point(60, 160);
                return;
            }

            var login = LoginTextBox.Text.Trim();
            var password = PassTextBox.Text;

            if (string.IsNullOrWhiteSpace(login) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Введите логин и пароль.", "Ошибка входа", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var hashedPassword = ComputeSha256Hash(password);
            var employee = shopDataSet.employees
                .FirstOrDefault(item =>
                    string.Equals(item.login, login, StringComparison.OrdinalIgnoreCase) &&
                    string.Equals(item.password_hash, hashedPassword, StringComparison.OrdinalIgnoreCase));

            if (employee == null || !employee.is_active)
            {
                MessageBox.Show("Неверный логин или пароль.", "Ошибка входа", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            OpenRoleForm(employee.position);
        }

        private void employeesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employeesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.shopDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "shopDataSet.employees". При необходимости она может быть перемещена или удалена.
            this.employeesTableAdapter.Fill(this.shopDataSet.employees);

        }



        private void OpenRoleForm(string position)
        {
            if (string.Equals(position, "Администратор", StringComparison.OrdinalIgnoreCase))
            {
                var adminForm = new AdminForm();
                ShowChildForm(adminForm);
                return;
            }

            if (string.Equals(position, "Менеджер", StringComparison.OrdinalIgnoreCase))
            {
                var managerForm = new ManagerForm();
                ShowChildForm(managerForm);
                return;
            }

            MessageBox.Show("Для этой роли нет доступной формы.", "Ошибка входа", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ShowChildForm(Form childForm)
        {
            this.Hide();
            childForm.FormClosed += (_, __) => this.Show();
            childForm.Show();
        }

        private static string ComputeSha256Hash(string input)
        {
            using (var sha256 = SHA256.Create())
            {
                var bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(input));
                var builder = new StringBuilder(bytes.Length * 2);
                foreach (var b in bytes)
                {
                    builder.Append(b.ToString("x2", CultureInfo.InvariantCulture));
                }
                return builder.ToString();
            }
        }
    
    }
}
