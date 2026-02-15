namespace sellular_shop
{
    partial class editProducts
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
            System.Windows.Forms.Label product_idLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label id_categoryLabel;
            System.Windows.Forms.Label brandLabel;
            System.Windows.Forms.Label priceLabel;
            System.Windows.Forms.Label quantityLabel;
            System.Windows.Forms.Label imeiLabel;
            System.Windows.Forms.Label is_activeLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(editProducts));
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
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productsTableAdapter = new sellular_shop.shopDataSetTableAdapters.productsTableAdapter();
            this.productsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.productsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.product_idLabel1 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.brandTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.imeiTextBox = new System.Windows.Forms.TextBox();
            this.is_activeCheckBox = new System.Windows.Forms.CheckBox();
            this.quantityNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoryTableAdapter = new sellular_shop.shopDataSetTableAdapters.categoryTableAdapter();
            this.id_categoryListBox = new System.Windows.Forms.ListBox();
            this.categoryBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.id_categoryLabel2 = new System.Windows.Forms.Label();
            product_idLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            id_categoryLabel = new System.Windows.Forms.Label();
            brandLabel = new System.Windows.Forms.Label();
            priceLabel = new System.Windows.Forms.Label();
            quantityLabel = new System.Windows.Forms.Label();
            imeiLabel = new System.Windows.Forms.Label();
            is_activeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.shopDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingNavigator)).BeginInit();
            this.productsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantityNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // product_idLabel
            // 
            product_idLabel.AutoSize = true;
            product_idLabel.Location = new System.Drawing.Point(210, 50);
            product_idLabel.Name = "product_idLabel";
            product_idLabel.Size = new System.Drawing.Size(73, 16);
            product_idLabel.TabIndex = 29;
            product_idLabel.Text = "id Товара:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(210, 79);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(76, 16);
            nameLabel.TabIndex = 30;
            nameLabel.Text = "Название:";
            // 
            // id_categoryLabel
            // 
            id_categoryLabel.AutoSize = true;
            id_categoryLabel.Location = new System.Drawing.Point(210, 105);
            id_categoryLabel.Name = "id_categoryLabel";
            id_categoryLabel.Size = new System.Drawing.Size(93, 16);
            id_categoryLabel.TabIndex = 31;
            id_categoryLabel.Text = "id Категории:";
            // 
            // brandLabel
            // 
            brandLabel.AutoSize = true;
            brandLabel.Location = new System.Drawing.Point(210, 132);
            brandLabel.Name = "brandLabel";
            brandLabel.Size = new System.Drawing.Size(51, 16);
            brandLabel.TabIndex = 32;
            brandLabel.Text = "Бренд:";
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Location = new System.Drawing.Point(210, 157);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new System.Drawing.Size(42, 16);
            priceLabel.TabIndex = 33;
            priceLabel.Text = "цена:";
            // 
            // quantityLabel
            // 
            quantityLabel.AutoSize = true;
            quantityLabel.Location = new System.Drawing.Point(210, 184);
            quantityLabel.Name = "quantityLabel";
            quantityLabel.Size = new System.Drawing.Size(88, 16);
            quantityLabel.TabIndex = 34;
            quantityLabel.Text = "Количество:";
            // 
            // imeiLabel
            // 
            imeiLabel.AutoSize = true;
            imeiLabel.Location = new System.Drawing.Point(210, 212);
            imeiLabel.Name = "imeiLabel";
            imeiLabel.Size = new System.Drawing.Size(35, 16);
            imeiLabel.TabIndex = 35;
            imeiLabel.Text = "imei:";
            // 
            // is_activeLabel
            // 
            is_activeLabel.AutoSize = true;
            is_activeLabel.Location = new System.Drawing.Point(210, 241);
            is_activeLabel.Name = "is_activeLabel";
            is_activeLabel.Size = new System.Drawing.Size(65, 16);
            is_activeLabel.TabIndex = 36;
            is_activeLabel.Text = "Активна:";
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
            this.btnDelete.Text = "Снять";
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
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "products";
            this.productsBindingSource.DataSource = this.shopDataSet;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // productsBindingNavigator
            // 
            this.productsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.productsBindingNavigator.BindingSource = this.productsBindingSource;
            this.productsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.productsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.productsBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.productsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.productsBindingNavigatorSaveItem});
            this.productsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.productsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.productsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.productsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.productsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.productsBindingNavigator.Name = "productsBindingNavigator";
            this.productsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.productsBindingNavigator.Size = new System.Drawing.Size(899, 27);
            this.productsBindingNavigator.TabIndex = 29;
            this.productsBindingNavigator.Text = "bindingNavigator1";
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
            // productsBindingNavigatorSaveItem
            // 
            this.productsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.productsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("productsBindingNavigatorSaveItem.Image")));
            this.productsBindingNavigatorSaveItem.Name = "productsBindingNavigatorSaveItem";
            this.productsBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.productsBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.productsBindingNavigatorSaveItem.Click += new System.EventHandler(this.productsBindingNavigatorSaveItem_Click);
            // 
            // product_idLabel1
            // 
            this.product_idLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "product_id", true));
            this.product_idLabel1.Location = new System.Drawing.Point(310, 50);
            this.product_idLabel1.Name = "product_idLabel1";
            this.product_idLabel1.Size = new System.Drawing.Size(100, 23);
            this.product_idLabel1.TabIndex = 30;
            this.product_idLabel1.Text = "label1";
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "name", true));
            this.nameTextBox.Location = new System.Drawing.Point(313, 76);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(207, 22);
            this.nameTextBox.TabIndex = 31;
            // 
            // brandTextBox
            // 
            this.brandTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "brand", true));
            this.brandTextBox.Location = new System.Drawing.Point(313, 126);
            this.brandTextBox.Name = "brandTextBox";
            this.brandTextBox.Size = new System.Drawing.Size(207, 22);
            this.brandTextBox.TabIndex = 33;
            // 
            // priceTextBox
            // 
            this.priceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "price", true));
            this.priceTextBox.Location = new System.Drawing.Point(313, 154);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(146, 22);
            this.priceTextBox.TabIndex = 34;
            // 
            // imeiTextBox
            // 
            this.imeiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "imei", true));
            this.imeiTextBox.Location = new System.Drawing.Point(313, 209);
            this.imeiTextBox.Name = "imeiTextBox";
            this.imeiTextBox.Size = new System.Drawing.Size(207, 22);
            this.imeiTextBox.TabIndex = 36;
            // 
            // is_activeCheckBox
            // 
            this.is_activeCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.productsBindingSource, "is_active", true));
            this.is_activeCheckBox.Location = new System.Drawing.Point(313, 241);
            this.is_activeCheckBox.Name = "is_activeCheckBox";
            this.is_activeCheckBox.Size = new System.Drawing.Size(26, 24);
            this.is_activeCheckBox.TabIndex = 37;
            this.is_activeCheckBox.UseVisualStyleBackColor = true;
            // 
            // quantityNumericUpDown
            // 
            this.quantityNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.productsBindingSource, "quantity", true));
            this.quantityNumericUpDown.Location = new System.Drawing.Point(314, 182);
            this.quantityNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.quantityNumericUpDown.Name = "quantityNumericUpDown";
            this.quantityNumericUpDown.Size = new System.Drawing.Size(70, 22);
            this.quantityNumericUpDown.TabIndex = 39;
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataMember = "category";
            this.categoryBindingSource.DataSource = this.shopDataSet;
            // 
            // categoryTableAdapter
            // 
            this.categoryTableAdapter.ClearBeforeFill = true;
            // 
            // id_categoryListBox
            // 
            this.id_categoryListBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.categoryBindingSource, "id", true));
            this.id_categoryListBox.DataSource = this.categoryBindingSource;
            this.id_categoryListBox.DisplayMember = "name";
            this.id_categoryListBox.FormattingEnabled = true;
            this.id_categoryListBox.ItemHeight = 16;
            this.id_categoryListBox.Location = new System.Drawing.Point(420, 105);
            this.id_categoryListBox.Name = "id_categoryListBox";
            this.id_categoryListBox.Size = new System.Drawing.Size(120, 20);
            this.id_categoryListBox.TabIndex = 41;
            this.id_categoryListBox.ValueMember = "id";
            // 
            // categoryBindingSource1
            // 
            this.categoryBindingSource1.DataMember = "category";
            this.categoryBindingSource1.DataSource = this.shopDataSet;
            // 
            // id_categoryLabel2
            // 
            this.id_categoryLabel2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "id_category", true));
            this.id_categoryLabel2.Location = new System.Drawing.Point(314, 105);
            this.id_categoryLabel2.Name = "id_categoryLabel2";
            this.id_categoryLabel2.Size = new System.Drawing.Size(100, 23);
            this.id_categoryLabel2.TabIndex = 42;
            this.id_categoryLabel2.Text = "label1";
            // 
            // editProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 458);
            this.Controls.Add(this.id_categoryLabel2);
            this.Controls.Add(this.id_categoryListBox);
            this.Controls.Add(this.quantityNumericUpDown);
            this.Controls.Add(is_activeLabel);
            this.Controls.Add(this.is_activeCheckBox);
            this.Controls.Add(imeiLabel);
            this.Controls.Add(this.imeiTextBox);
            this.Controls.Add(quantityLabel);
            this.Controls.Add(priceLabel);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(brandLabel);
            this.Controls.Add(this.brandTextBox);
            this.Controls.Add(id_categoryLabel);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(product_idLabel);
            this.Controls.Add(this.product_idLabel1);
            this.Controls.Add(this.productsBindingNavigator);
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
            this.Name = "editProducts";
            this.Text = "Редактирование данных";
            this.Load += new System.EventHandler(this.editProducts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.shopDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingNavigator)).EndInit();
            this.productsBindingNavigator.ResumeLayout(false);
            this.productsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantityNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource1)).EndInit();
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
        private System.Windows.Forms.BindingSource productsBindingSource;
        private shopDataSetTableAdapters.productsTableAdapter productsTableAdapter;
        private System.Windows.Forms.BindingNavigator productsBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton productsBindingNavigatorSaveItem;
        private System.Windows.Forms.Label product_idLabel1;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox brandTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.TextBox imeiTextBox;
        private System.Windows.Forms.CheckBox is_activeCheckBox;
        private System.Windows.Forms.NumericUpDown quantityNumericUpDown;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private shopDataSetTableAdapters.categoryTableAdapter categoryTableAdapter;
        private System.Windows.Forms.ListBox id_categoryListBox;
        private System.Windows.Forms.BindingSource categoryBindingSource1;
        private System.Windows.Forms.Label id_categoryLabel2;
    }
}