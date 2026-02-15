namespace sellular_shop
{
    partial class editSales
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label sale_idLabel;
            System.Windows.Forms.Label sale_dateLabel;
            System.Windows.Forms.Label total_amountLabel;
            System.Windows.Forms.Label payment_typeLabel;
            this.client_idLabel = new System.Windows.Forms.Label();
            this.employee_idLabel = new System.Windows.Forms.Label();
            this.shopDataSet = new sellular_shop.shopDataSet();
            this.btnPrevios = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnFinalize = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.addProd = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.tableAdapterManager = new sellular_shop.shopDataSetTableAdapters.TableAdapterManager();
            this.client_idComboBox = new System.Windows.Forms.ComboBox();
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientsTableAdapter = new sellular_shop.shopDataSetTableAdapters.clientsTableAdapter();
            this.employee_idComboBox = new System.Windows.Forms.ComboBox();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeesTableAdapter = new sellular_shop.shopDataSetTableAdapters.employeesTableAdapter();
            this.salesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salesTableAdapter = new sellular_shop.shopDataSetTableAdapters.salesTableAdapter();
            this.sale_idLabel1 = new System.Windows.Forms.Label();
            this.sale_dateLabel1 = new System.Windows.Forms.Label();
            this.total_amountLabel1 = new System.Windows.Forms.Label();
            this.payment_typeListBox = new System.Windows.Forms.ListBox();
            this.addService = new System.Windows.Forms.Button();
            sale_idLabel = new System.Windows.Forms.Label();
            sale_dateLabel = new System.Windows.Forms.Label();
            total_amountLabel = new System.Windows.Forms.Label();
            payment_typeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.shopDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // sale_idLabel
            // 
            sale_idLabel.AutoSize = true;
            sale_idLabel.Location = new System.Drawing.Point(215, 69);
            sale_idLabel.Name = "sale_idLabel";
            sale_idLabel.Size = new System.Drawing.Size(86, 16);
            sale_idLabel.TabIndex = 37;
            sale_idLabel.Text = "id Продажи: ";
            // 
            // sale_dateLabel
            // 
            sale_dateLabel.AutoSize = true;
            sale_dateLabel.Location = new System.Drawing.Point(215, 96);
            sale_dateLabel.Name = "sale_dateLabel";
            sale_dateLabel.Size = new System.Drawing.Size(102, 16);
            sale_dateLabel.TabIndex = 38;
            sale_dateLabel.Text = "Дата продажи:";
            // 
            // total_amountLabel
            // 
            total_amountLabel.AutoSize = true;
            total_amountLabel.Location = new System.Drawing.Point(215, 195);
            total_amountLabel.Name = "total_amountLabel";
            total_amountLabel.Size = new System.Drawing.Size(53, 16);
            total_amountLabel.TabIndex = 39;
            total_amountLabel.Text = "Сумма:";
            // 
            // payment_typeLabel
            // 
            payment_typeLabel.AutoSize = true;
            payment_typeLabel.Location = new System.Drawing.Point(215, 226);
            payment_typeLabel.Name = "payment_typeLabel";
            payment_typeLabel.Size = new System.Drawing.Size(91, 16);
            payment_typeLabel.TabIndex = 40;
            payment_typeLabel.Text = "payment type:";
            // 
            // client_idLabel
            // 
            this.client_idLabel.AutoSize = true;
            this.client_idLabel.Location = new System.Drawing.Point(215, 129);
            this.client_idLabel.Name = "client_idLabel";
            this.client_idLabel.Size = new System.Drawing.Size(57, 16);
            this.client_idLabel.TabIndex = 30;
            this.client_idLabel.Text = "Клиент:";
            // 
            // employee_idLabel
            // 
            this.employee_idLabel.AutoSize = true;
            this.employee_idLabel.Location = new System.Drawing.Point(215, 159);
            this.employee_idLabel.Name = "employee_idLabel";
            this.employee_idLabel.Size = new System.Drawing.Size(81, 16);
            this.employee_idLabel.TabIndex = 32;
            this.employee_idLabel.Text = "Сотрудник:";
            // 
            // shopDataSet
            // 
            this.shopDataSet.DataSetName = "shopDataSet";
            this.shopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnPrevios
            // 
            this.btnPrevios.Location = new System.Drawing.Point(85, 306);
            this.btnPrevios.Name = "btnPrevios";
            this.btnPrevios.Size = new System.Drawing.Size(156, 33);
            this.btnPrevios.TabIndex = 21;
            this.btnPrevios.Text = "Предыдущая";
            this.btnPrevios.UseVisualStyleBackColor = true;
            this.btnPrevios.Click += new System.EventHandler(this.btnPrevios_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(430, 306);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(156, 33);
            this.btnNext.TabIndex = 22;
            this.btnNext.Text = "Следующая";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnFinalize
            // 
            this.btnFinalize.Location = new System.Drawing.Point(258, 355);
            this.btnFinalize.Name = "btnFinalize";
            this.btnFinalize.Size = new System.Drawing.Size(156, 33);
            this.btnFinalize.TabIndex = 23;
            this.btnFinalize.Text = "Завершить";
            this.btnFinalize.UseVisualStyleBackColor = true;
            this.btnFinalize.Click += new System.EventHandler(this.btnFinalize_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(85, 355);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(156, 33);
            this.btnFirst.TabIndex = 24;
            this.btnFirst.Text = "Первая";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // addProd
            // 
            this.addProd.Location = new System.Drawing.Point(171, 394);
            this.addProd.Name = "addProd";
            this.addProd.Size = new System.Drawing.Size(156, 33);
            this.addProd.TabIndex = 25;
            this.addProd.Text = "Добавить товар";
            this.addProd.UseVisualStyleBackColor = true;
            this.addProd.Click += new System.EventHandler(this.addProd_Click);
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(430, 355);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(156, 33);
            this.btnLast.TabIndex = 26;
            this.btnLast.Text = "Последняя";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(258, 306);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(156, 33);
            this.btnAdd.TabIndex = 27;
            this.btnAdd.Text = "Создать";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(13, 31);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(35, 34);
            this.btnBack.TabIndex = 28;
            this.btnBack.Text = "←";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.categoryTableAdapter = null;
            this.tableAdapterManager.clientsTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.contractsTableAdapter = null;
            this.tableAdapterManager.employeesTableAdapter = null;
            this.tableAdapterManager.productsTableAdapter = null;
            this.tableAdapterManager.sale_itemsTableAdapter = null;
            this.tableAdapterManager.salesTableAdapter = null;
            this.tableAdapterManager.servicesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = sellular_shop.shopDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // client_idComboBox
            // 
            this.client_idComboBox.DataSource = this.clientsBindingSource;
            this.client_idComboBox.DisplayMember = "full_name";
            this.client_idComboBox.FormattingEnabled = true;
            this.client_idComboBox.Location = new System.Drawing.Point(340, 122);
            this.client_idComboBox.Name = "client_idComboBox";
            this.client_idComboBox.Size = new System.Drawing.Size(214, 24);
            this.client_idComboBox.TabIndex = 31;
            this.client_idComboBox.ValueMember = "client_id";
            // 
            // clientsBindingSource
            // 
            this.clientsBindingSource.DataMember = "clients";
            this.clientsBindingSource.DataSource = this.shopDataSet;
            // 
            // clientsTableAdapter
            // 
            this.clientsTableAdapter.ClearBeforeFill = true;
            // 
            // employee_idComboBox
            // 
            this.employee_idComboBox.DataSource = this.employeesBindingSource;
            this.employee_idComboBox.DisplayMember = "full_name";
            this.employee_idComboBox.FormattingEnabled = true;
            this.employee_idComboBox.Location = new System.Drawing.Point(340, 156);
            this.employee_idComboBox.Name = "employee_idComboBox";
            this.employee_idComboBox.Size = new System.Drawing.Size(214, 24);
            this.employee_idComboBox.TabIndex = 33;
            this.employee_idComboBox.ValueMember = "employee_id";
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataMember = "employees";
            this.employeesBindingSource.DataSource = this.shopDataSet;
            // 
            // employeesTableAdapter
            // 
            this.employeesTableAdapter.ClearBeforeFill = true;
            // 
            // salesBindingSource
            // 
            this.salesBindingSource.DataMember = "sales";
            this.salesBindingSource.DataSource = this.shopDataSet;
            // 
            // salesTableAdapter
            // 
            this.salesTableAdapter.ClearBeforeFill = true;
            // 
            // sale_idLabel1
            // 
            this.sale_idLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.salesBindingSource, "sale_id", true));
            this.sale_idLabel1.Location = new System.Drawing.Point(337, 69);
            this.sale_idLabel1.Name = "sale_idLabel1";
            this.sale_idLabel1.Size = new System.Drawing.Size(100, 23);
            this.sale_idLabel1.TabIndex = 38;
            this.sale_idLabel1.Text = "label1";
            // 
            // sale_dateLabel1
            // 
            this.sale_dateLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.salesBindingSource, "sale_date", true));
            this.sale_dateLabel1.Location = new System.Drawing.Point(337, 96);
            this.sale_dateLabel1.Name = "sale_dateLabel1";
            this.sale_dateLabel1.Size = new System.Drawing.Size(100, 23);
            this.sale_dateLabel1.TabIndex = 39;
            this.sale_dateLabel1.Text = "label1";
            // 
            // total_amountLabel1
            // 
            this.total_amountLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.salesBindingSource, "total_amount", true));
            this.total_amountLabel1.Location = new System.Drawing.Point(337, 195);
            this.total_amountLabel1.Name = "total_amountLabel1";
            this.total_amountLabel1.Size = new System.Drawing.Size(100, 23);
            this.total_amountLabel1.TabIndex = 40;
            this.total_amountLabel1.Text = "label1";
            // 
            // payment_typeListBox
            // 
            this.payment_typeListBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.salesBindingSource, "payment_type", true));
            this.payment_typeListBox.FormattingEnabled = true;
            this.payment_typeListBox.ItemHeight = 16;
            this.payment_typeListBox.Items.AddRange(new object[] {
            "наличные",
            "карта"});
            this.payment_typeListBox.Location = new System.Drawing.Point(340, 226);
            this.payment_typeListBox.Name = "payment_typeListBox";
            this.payment_typeListBox.Size = new System.Drawing.Size(120, 20);
            this.payment_typeListBox.TabIndex = 41;
            // 
            // addService
            // 
            this.addService.Location = new System.Drawing.Point(353, 394);
            this.addService.Name = "addService";
            this.addService.Size = new System.Drawing.Size(156, 33);
            this.addService.TabIndex = 42;
            this.addService.Text = "Добавить услугу";
            this.addService.UseVisualStyleBackColor = true;
            this.addService.Click += new System.EventHandler(this.addService_Click);
            // 
            // editSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 458);
            this.Controls.Add(this.addService);
            this.Controls.Add(payment_typeLabel);
            this.Controls.Add(this.payment_typeListBox);
            this.Controls.Add(total_amountLabel);
            this.Controls.Add(this.total_amountLabel1);
            this.Controls.Add(sale_dateLabel);
            this.Controls.Add(this.sale_dateLabel1);
            this.Controls.Add(sale_idLabel);
            this.Controls.Add(this.sale_idLabel1);
            this.Controls.Add(this.employee_idLabel);
            this.Controls.Add(this.employee_idComboBox);
            this.Controls.Add(this.client_idLabel);
            this.Controls.Add(this.client_idComboBox);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.addProd);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.btnFinalize);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevios);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "editSales";
            this.Text = "Редактирование данных";
            this.Load += new System.EventHandler(this.editSales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.shopDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private shopDataSet shopDataSet;
        private System.Windows.Forms.Button btnPrevios;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnFinalize;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button addProd;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnBack;
        private shopDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox client_idComboBox;
        private System.Windows.Forms.BindingSource clientsBindingSource;
        private shopDataSetTableAdapters.clientsTableAdapter clientsTableAdapter;
        private System.Windows.Forms.ComboBox employee_idComboBox;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private shopDataSetTableAdapters.employeesTableAdapter employeesTableAdapter;
        private System.Windows.Forms.Label client_idLabel;
        private System.Windows.Forms.Label employee_idLabel;
        private System.Windows.Forms.BindingSource salesBindingSource;
        private shopDataSetTableAdapters.salesTableAdapter salesTableAdapter;
        private System.Windows.Forms.Label sale_idLabel1;
        private System.Windows.Forms.Label sale_dateLabel1;
        private System.Windows.Forms.Label total_amountLabel1;
        private System.Windows.Forms.ListBox payment_typeListBox;
        private System.Windows.Forms.Button addService;
    }
}