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
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }



        private void OpenForm<T>() where T : Form, new()
        {
            SetNavigationControlsVisible(false);

            foreach (Form child in this.MdiChildren)
            {
                child.Close();
            }

            // Создаем и показываем новую форму
            T formInstance = new T();
            formInstance.MdiParent = this;
            formInstance.FormBorderStyle = FormBorderStyle.None;
            formInstance.Dock = DockStyle.Fill;
            formInstance.FormClosed += ChildFormClosed;
            formInstance.Show();
        }

        private void ChildFormClosed(object sender, FormClosedEventArgs e)
        {
            SetNavigationControlsVisible(true);
        }

        private void SetNavigationControlsVisible(bool isVisible)
        {
            changePass.Visible = isVisible;
            btnEmployees.Visible = isVisible;
            btnClients.Visible = isVisible;
            btnServices.Visible = isVisible;
            category.Visible = isVisible;
            products.Visible = isVisible;
            contracts.Visible = isVisible;
        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            OpenForm<btnChangePass>();
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            OpenForm<employees>();
        }

        private void btnClients_Click(object sender, EventArgs e)
        {
            OpenForm<clients>();
        }

        private void btnServices_Click(object sender, EventArgs e)
        {
            OpenForm<services>();
        }

        private void category_Click(object sender, EventArgs e)
        {
            OpenForm<category>();
        }

        private void products_Click(object sender, EventArgs e)
        {
            OpenForm<products>();   
        }

        private void contracts_Click(object sender, EventArgs e)
        {
            OpenForm<contracts>();
        }
    }





}

