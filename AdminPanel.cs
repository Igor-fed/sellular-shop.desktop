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
 

            // Создаем и показываем новую форму
            T formInstance = new T();
            formInstance.MdiParent = this;
            formInstance.FormBorderStyle = FormBorderStyle.None;
            formInstance.Dock = DockStyle.Fill;
            formInstance.Show();

            
        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            OpenForm<btnChangePass>();
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            OpenForm<employees>();
        }
    }





}

