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
    public partial class ManagerForm : Form
    {
        public ManagerForm()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        private void ChildFormClosed(object sender, FormClosedEventArgs e)
        {
            SetNavigationControlsVisible(true);
        }

        private void SetNavigationControlsVisible(bool isVisible)
        {
            client.Visible = isVisible;
            services.Visible = isVisible;
            products.Visible = isVisible;

      
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

        private void client_Click(object sender, EventArgs e)
        {
            OpenForm<clients>();
        }

        private void services_Click(object sender, EventArgs e)
        {
            OpenForm<active_services>();
        }

        private void products_Click(object sender, EventArgs e)
        {
            OpenForm<vw_products_in_stock>();
        }

        private void contracts_Click(object sender, EventArgs e)
        {
            OpenForm<contracts>();
        }

        private void sales_Click(object sender, EventArgs e)
        {
            OpenForm<sales>();
        }

        private void report_Click(object sender, EventArgs e)
        {
            OpenForm<vw_report>();
        }

        private void sale_item_Click(object sender, EventArgs e)
        {

        }
    }
    
}
