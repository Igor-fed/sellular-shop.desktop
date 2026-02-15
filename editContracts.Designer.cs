namespace sellular_shop
{
    partial class editContracts
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
            System.Windows.Forms.Label contract_idLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(editContracts));
            System.Windows.Forms.Label service_idLabel;
            System.Windows.Forms.Label phone_numberLabel;
            System.Windows.Forms.Label contract_dateLabel;
            System.Windows.Forms.Label statusLabel;
            this.client_idLabel = new System.Windows.Forms.Label();
            this.employee_idLabel = new System.Windows.Forms.Label();
            this.shopDataSet = new sellular_shop.shopDataSet();
            this.btnPrevios = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.tableAdapterManager = new sellular_shop.shopDataSetTableAdapters.TableAdapterManager();
            this.contractsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contractsTableAdapter = new sellular_shop.shopDataSetTableAdapters.contractsTableAdapter();
            this.contractsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.contractsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.contract_idLabel1 = new System.Windows.Forms.Label();
            this.client_idComboBox = new System.Windows.Forms.ComboBox();
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientsTableAdapter = new sellular_shop.shopDataSetTableAdapters.clientsTableAdapter();
            this.employee_idComboBox = new System.Windows.Forms.ComboBox();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeesTableAdapter = new sellular_shop.shopDataSetTableAdapters.employeesTableAdapter();
            this.service_idListBox = new System.Windows.Forms.ListBox();
            this.phone_numberMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.contract_dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.statusListBox = new System.Windows.Forms.ListBox();
            contract_idLabel = new System.Windows.Forms.Label();
            service_idLabel = new System.Windows.Forms.Label();
            phone_numberLabel = new System.Windows.Forms.Label();
            contract_dateLabel = new System.Windows.Forms.Label();
            statusLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.shopDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractsBindingNavigator)).BeginInit();
            this.contractsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // contract_idLabel
            // 
            contract_idLabel.AutoSize = true;
            contract_idLabel.Location = new System.Drawing.Point(264, 74);
            contract_idLabel.Name = "contract_idLabel";
            contract_idLabel.Size = new System.Drawing.Size(87, 16);
            contract_idLabel.TabIndex = 29;
            contract_idLabel.Text = "id Договора:";
            // 
            // client_idLabel
            // 
            this.client_idLabel.AutoSize = true;
            this.client_idLabel.Location = new System.Drawing.Point(257, 103);
            this.client_idLabel.Name = "client_idLabel";
            this.client_idLabel.Size = new System.Drawing.Size(57, 16);
            this.client_idLabel.TabIndex = 30;
            this.client_idLabel.Text = "Клиент:";
            // 
            // employee_idLabel
            // 
            this.employee_idLabel.AutoSize = true;
            this.employee_idLabel.Location = new System.Drawing.Point(257, 159);
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
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(258, 355);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(156, 33);
            this.btnSave.TabIndex = 23;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
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
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(258, 405);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(156, 33);
            this.btnDelete.TabIndex = 25;
            this.btnDelete.Text = "Расторгнуть";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
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
            this.btnAdd.Text = "Добавить";
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
            // contractsBindingSource
            // 
            this.contractsBindingSource.DataMember = "contracts";
            this.contractsBindingSource.DataSource = this.shopDataSet;
            // 
            // contractsTableAdapter
            // 
            this.contractsTableAdapter.ClearBeforeFill = true;
            // 
            // contractsBindingNavigator
            // 
            this.contractsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.contractsBindingNavigator.BindingSource = this.contractsBindingSource;
            this.contractsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.contractsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.contractsBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contractsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.contractsBindingNavigatorSaveItem});
            this.contractsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.contractsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.contractsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.contractsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.contractsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.contractsBindingNavigator.Name = "contractsBindingNavigator";
            this.contractsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.contractsBindingNavigator.Size = new System.Drawing.Size(717, 27);
            this.contractsBindingNavigator.TabIndex = 29;
            this.contractsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(55, 24);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // contractsBindingNavigatorSaveItem
            // 
            this.contractsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.contractsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("contractsBindingNavigatorSaveItem.Image")));
            this.contractsBindingNavigatorSaveItem.Name = "contractsBindingNavigatorSaveItem";
            this.contractsBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.contractsBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.contractsBindingNavigatorSaveItem.Click += new System.EventHandler(this.contractsBindingNavigatorSaveItem_Click);
            // 
            // contract_idLabel1
            // 
            this.contract_idLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contractsBindingSource, "contract_id", true));
            this.contract_idLabel1.Location = new System.Drawing.Point(357, 74);
            this.contract_idLabel1.Name = "contract_idLabel1";
            this.contract_idLabel1.Size = new System.Drawing.Size(100, 23);
            this.contract_idLabel1.TabIndex = 30;
            this.contract_idLabel1.Text = "label1";
            // 
            // client_idComboBox
            // 
            this.client_idComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.contractsBindingSource, "client_id", true));
            this.client_idComboBox.DataSource = this.clientsBindingSource;
            this.client_idComboBox.DisplayMember = "full_name";
            this.client_idComboBox.FormattingEnabled = true;
            this.client_idComboBox.Location = new System.Drawing.Point(344, 100);
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
            this.employee_idComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.contractsBindingSource, "employee_id", true));
            this.employee_idComboBox.DataSource = this.employeesBindingSource;
            this.employee_idComboBox.DisplayMember = "full_name";
            this.employee_idComboBox.FormattingEnabled = true;
            this.employee_idComboBox.Location = new System.Drawing.Point(344, 156);
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
            // service_idLabel
            // 
            service_idLabel.AutoSize = true;
            service_idLabel.Location = new System.Drawing.Point(257, 134);
            service_idLabel.Name = "service_idLabel";
            service_idLabel.Size = new System.Drawing.Size(56, 16);
            service_idLabel.TabIndex = 33;
            service_idLabel.Text = "Услуга:";
            // 
            // service_idListBox
            // 
            this.service_idListBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.contractsBindingSource, "service_id", true));
            this.service_idListBox.FormattingEnabled = true;
            this.service_idListBox.ItemHeight = 16;
            this.service_idListBox.Location = new System.Drawing.Point(344, 130);
            this.service_idListBox.Name = "service_idListBox";
            this.service_idListBox.Size = new System.Drawing.Size(214, 20);
            this.service_idListBox.TabIndex = 34;
            // 
            // phone_numberLabel
            // 
            phone_numberLabel.AutoSize = true;
            phone_numberLabel.Location = new System.Drawing.Point(257, 189);
            phone_numberLabel.Name = "phone_numberLabel";
            phone_numberLabel.Size = new System.Drawing.Size(70, 16);
            phone_numberLabel.TabIndex = 34;
            phone_numberLabel.Text = "Телефон:";
            // 
            // phone_numberMaskedTextBox
            // 
            this.phone_numberMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contractsBindingSource, "phone_number", true));
            this.phone_numberMaskedTextBox.Location = new System.Drawing.Point(344, 186);
            this.phone_numberMaskedTextBox.Mask = "8(999)999-99-99";
            this.phone_numberMaskedTextBox.Name = "phone_numberMaskedTextBox";
            this.phone_numberMaskedTextBox.Size = new System.Drawing.Size(214, 22);
            this.phone_numberMaskedTextBox.TabIndex = 35;
            // 
            // contract_dateLabel
            // 
            contract_dateLabel.AutoSize = true;
            contract_dateLabel.Location = new System.Drawing.Point(251, 218);
            contract_dateLabel.Name = "contract_dateLabel";
            contract_dateLabel.Size = new System.Drawing.Size(125, 16);
            contract_dateLabel.TabIndex = 35;
            contract_dateLabel.Text = "Дата заключения:";
            // 
            // contract_dateDateTimePicker
            // 
            this.contract_dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.contractsBindingSource, "contract_date", true));
            this.contract_dateDateTimePicker.Location = new System.Drawing.Point(382, 214);
            this.contract_dateDateTimePicker.Name = "contract_dateDateTimePicker";
            this.contract_dateDateTimePicker.Size = new System.Drawing.Size(132, 22);
            this.contract_dateDateTimePicker.TabIndex = 36;
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Location = new System.Drawing.Point(257, 246);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new System.Drawing.Size(56, 16);
            statusLabel.TabIndex = 36;
            statusLabel.Text = "Статус:";
            // 
            // statusListBox
            // 
            this.statusListBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.contractsBindingSource, "status", true));
            this.statusListBox.FormattingEnabled = true;
            this.statusListBox.ItemHeight = 16;
            this.statusListBox.Items.AddRange(new object[] {
            "Активен",
            "Закрыт"});
            this.statusListBox.Location = new System.Drawing.Point(344, 242);
            this.statusListBox.Name = "statusListBox";
            this.statusListBox.Size = new System.Drawing.Size(120, 20);
            this.statusListBox.TabIndex = 37;
            // 
            // editContracts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 458);
            this.Controls.Add(statusLabel);
            this.Controls.Add(this.statusListBox);
            this.Controls.Add(contract_dateLabel);
            this.Controls.Add(this.contract_dateDateTimePicker);
            this.Controls.Add(phone_numberLabel);
            this.Controls.Add(this.phone_numberMaskedTextBox);
            this.Controls.Add(service_idLabel);
            this.Controls.Add(this.service_idListBox);
            this.Controls.Add(this.employee_idLabel);
            this.Controls.Add(this.employee_idComboBox);
            this.Controls.Add(this.client_idLabel);
            this.Controls.Add(this.client_idComboBox);
            this.Controls.Add(contract_idLabel);
            this.Controls.Add(this.contract_idLabel1);
            this.Controls.Add(this.contractsBindingNavigator);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevios);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "editContracts";
            this.Text = "Редактирование данных";
            this.Load += new System.EventHandler(this.editServices_Load);
            ((System.ComponentModel.ISupportInitialize)(this.shopDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractsBindingNavigator)).EndInit();
            this.contractsBindingNavigator.ResumeLayout(false);
            this.contractsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private shopDataSet shopDataSet;
        private System.Windows.Forms.Button btnPrevios;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnBack;
        private shopDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource contractsBindingSource;
        private shopDataSetTableAdapters.contractsTableAdapter contractsTableAdapter;
        private System.Windows.Forms.BindingNavigator contractsBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton contractsBindingNavigatorSaveItem;
        private System.Windows.Forms.Label contract_idLabel1;
        private System.Windows.Forms.ComboBox client_idComboBox;
        private System.Windows.Forms.BindingSource clientsBindingSource;
        private shopDataSetTableAdapters.clientsTableAdapter clientsTableAdapter;
        private System.Windows.Forms.ComboBox employee_idComboBox;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private shopDataSetTableAdapters.employeesTableAdapter employeesTableAdapter;
        private System.Windows.Forms.Label client_idLabel;
        private System.Windows.Forms.Label employee_idLabel;
        private System.Windows.Forms.ListBox service_idListBox;
        private System.Windows.Forms.MaskedTextBox phone_numberMaskedTextBox;
        private System.Windows.Forms.DateTimePicker contract_dateDateTimePicker;
        private System.Windows.Forms.ListBox statusListBox;
    }
}