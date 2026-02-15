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
    public partial class editProducts : Form
    {
        private readonly StoredProcedureExecutor _procedureExecutor;
        public editProducts()
        {
            InitializeComponent();
            _procedureExecutor = new StoredProcedureExecutor(Properties.Settings.Default.shopConnectionString);
        }



        private void editProducts_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "shopDataSet.category". При необходимости она может быть перемещена или удалена.
            this.categoryTableAdapter.Fill(this.shopDataSet.category);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "shopDataSet.products". При необходимости она может быть перемещена или удалена.
            this.productsTableAdapter.Fill(this.shopDataSet.products);


            // TODO: данная строка кода позволяет загрузить данные в таблицу "shopDataSet.services". При необходимости она может быть перемещена или удалена.
            productsTableAdapter.Fill(shopDataSet.products);
            _procedureExecutor.LoadAllProcedures();

        }

        private void btnPrevios_Click(object sender, EventArgs e)
        {
            productsBindingSource.MovePrevious();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var call = new StoredProcedureCall(
                    procedureName: "add_product", 
                    parameters: new[]
                    {
                        new StoredProcedureParameterMap("@наименование_товара", () => nameTextBox.Text),
                        new StoredProcedureParameterMap("@id_категории", () => GetSelectedCategoryId()),
                        new StoredProcedureParameterMap("бренд", () => (brandTextBox.Text)),  
                        new StoredProcedureParameterMap("@цена", () => Convert.ToDecimal(priceTextBox.Text)),
                        new StoredProcedureParameterMap("@количество", () => quantityNumericUpDown.Value),
                        new StoredProcedureParameterMap("@imei", () => Convert.ToInt64(imeiTextBox.Text))

               
                    });

                _procedureExecutor.Execute(call);

                this.productsTableAdapter.Fill(this.shopDataSet.products);
                MessageBox.Show("Товар добавлен через хранимую процедуру.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка выполнения процедуры: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int GetSelectedCategoryId()
        {
            if (id_categoryListBox.SelectedValue != null && int.TryParse(id_categoryListBox.SelectedValue.ToString(), out var categoryId))
            {
                return categoryId;
            }

            if (id_categoryListBox.SelectedItem is DataRowView selectedRow &&
                int.TryParse(selectedRow["id"]?.ToString(), out categoryId))
            {
                return categoryId;
            }

            throw new InvalidOperationException("Не удалось определить выбранную категорию.");
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            productsBindingSource.MoveNext();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            productsBindingSource.MoveFirst();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.shopDataSet);

        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            productsBindingSource.MoveLast();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var call = new StoredProcedureCall(
                    procedureName: "deactivate_product",
                    parameters: new[]
                    {
                   
                        new StoredProcedureParameterMap("@id_продукта", () => Convert.ToInt32(product_idLabel1.Text))
                    });

                _procedureExecutor.Execute(call);

                this.productsTableAdapter.Fill(this.shopDataSet.products);
                MessageBox.Show($"Товар перестал предоставляться с помощью хранимой процедуры.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

    

        private void productsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.shopDataSet);

        }


    }
}
