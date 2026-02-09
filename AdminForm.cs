using sellular_shop.shopDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sellular_shop
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            employeesTableAdapter.Fill(shopDataSet.employees);
            UpdateSelectedEmployeeDetails();
        }

        private void employeesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employeesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.shopDataSet);
        }

        private void employeeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateSelectedEmployeeDetails();
        }

        private void showPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            passwordTextBox.UseSystemPasswordChar = !showPasswordCheckBox.Checked;
        }

        private void useManualButton_Click(object sender, EventArgs e)
        {
            var password = passwordTextBox.Text;
            if (string.IsNullOrWhiteSpace(password))
            {
                ShowStatus("Введите пароль вручную.", MessageBoxIcon.Warning);
                return;
            }

            UpdatePassword(password);
        }

        private void useEmailButton_Click(object sender, EventArgs e)
        {
            var employee = GetSelectedEmployee();
            if (employee == null)
            {
                ShowStatus("Выберите сотрудника.", MessageBoxIcon.Warning);
                return;
            }

            var email = employee.email?.Trim();
            if (string.IsNullOrWhiteSpace(email))
            {
                ShowStatus("У выбранного сотрудника нет email.", MessageBoxIcon.Warning);
                return;
            }

            var atIndex = email.IndexOf('@');
            if (atIndex <= 0)
            {
                ShowStatus("Email должен содержать символ @.", MessageBoxIcon.Warning);
                return;
            }

            var password = email.Substring(0, atIndex);
            passwordTextBox.Text = password;
            UpdatePassword(password);
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            var password = GeneratePassword(12);
            passwordTextBox.Text = password;
            UpdatePassword(password);
        }

        private void UpdateSelectedEmployeeDetails()
        {
            var employee = GetSelectedEmployee();
            if (employee == null)
            {
                emailValueLabel.Text = "—";
                return;
            }

            emailValueLabel.Text = string.IsNullOrWhiteSpace(employee.email) ? "—" : employee.email;
        }

        private shopDataSet.employeesRow GetSelectedEmployee()
        {
            if (employeesBindingSource.Current is DataRowView rowView)
            {
                return rowView.Row as shopDataSet.employeesRow;
            }

            return null;
        }

        private void UpdatePassword(string password)
        {
            var employee = GetSelectedEmployee();
            if (employee == null)
            {
                ShowStatus("Выберите сотрудника.", MessageBoxIcon.Warning);
                return;
            }

            employee.password_hash = ComputeSha256Hash(password);
            employeesBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(shopDataSet);
            ShowStatus($"Пароль обновлен для {employee.login}.", MessageBoxIcon.Information);
        }

        private void ShowStatus(string message, MessageBoxIcon icon)
        {
            statusLabel.Text = message;
            MessageBox.Show(message, "Панель администратора", MessageBoxButtons.OK, icon);
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

        private static string GeneratePassword(int length)
        {
            const string chars = "ABCDEFGHJKLMNPQRSTUVWXYZabcdefghijkmnopqrstuvwxyz23456789";
            var data = new byte[length];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(data);
            }

            var builder = new StringBuilder(length);
            for (var i = 0; i < length; i++)
            {
                builder.Append(chars[data[i] % chars.Length]);
            }

            return builder.ToString();
        }
    }
}

