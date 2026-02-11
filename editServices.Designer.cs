namespace sellular_shop
{
    partial class editServices
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(editServices));
            System.Windows.Forms.Label service_idLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label monthly_feeLabel;
            System.Windows.Forms.Label is_activeLabel;
            System.Windows.Forms.Label connection_feeLabel;
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
            this.servicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.servicesTableAdapter = new sellular_shop.shopDataSetTableAdapters.servicesTableAdapter();
            this.servicesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.servicesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.service_idLabel1 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.is_activeCheckBox = new System.Windows.Forms.CheckBox();
            this.monthly_feeTextBox = new System.Windows.Forms.TextBox();
            this.connection_feeTextBox = new System.Windows.Forms.TextBox();
            service_idLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            monthly_feeLabel = new System.Windows.Forms.Label();
            is_activeLabel = new System.Windows.Forms.Label();
            connection_feeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.shopDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicesBindingNavigator)).BeginInit();
            this.servicesBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // shopDataSet
            // 
            this.shopDataSet.DataSetName = "shopDataSet";
            this.shopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnPrevios
            // 
            this.btnPrevios.Location = new System.Drawing.Point(12, 306);
            this.btnPrevios.Name = "btnPrevios";
            this.btnPrevios.Size = new System.Drawing.Size(156, 33);
            this.btnPrevios.TabIndex = 21;
            this.btnPrevios.Text = "Предыдущая";
            this.btnPrevios.UseVisualStyleBackColor = true;
            this.btnPrevios.Click += new System.EventHandler(this.btnPrevios_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(357, 306);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(156, 33);
            this.btnNext.TabIndex = 22;
            this.btnNext.Text = "Следующая";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(185, 355);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(156, 33);
            this.btnSave.TabIndex = 23;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(12, 355);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(156, 33);
            this.btnFirst.TabIndex = 24;
            this.btnFirst.Text = "Первая";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(185, 405);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(156, 33);
            this.btnDelete.TabIndex = 25;
            this.btnDelete.Text = "Снять";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(357, 355);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(156, 33);
            this.btnLast.TabIndex = 26;
            this.btnLast.Text = "Последняя";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(185, 306);
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
            this.tableAdapterManager.contractsTableAdapter = null;
            this.tableAdapterManager.employeesTableAdapter = null;
            this.tableAdapterManager.productsTableAdapter = null;
            this.tableAdapterManager.sale_itemsTableAdapter = null;
            this.tableAdapterManager.salesTableAdapter = null;
            this.tableAdapterManager.servicesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = sellular_shop.shopDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // servicesBindingSource
            // 
            this.servicesBindingSource.DataMember = "services";
            this.servicesBindingSource.DataSource = this.shopDataSet;
            // 
            // servicesTableAdapter
            // 
            this.servicesTableAdapter.ClearBeforeFill = true;
            // 
            // servicesBindingNavigator
            // 
            this.servicesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.servicesBindingNavigator.BindingSource = this.servicesBindingSource;
            this.servicesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.servicesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.servicesBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.servicesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.servicesBindingNavigatorSaveItem});
            this.servicesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.servicesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.servicesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.servicesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.servicesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.servicesBindingNavigator.Name = "servicesBindingNavigator";
            this.servicesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.servicesBindingNavigator.Size = new System.Drawing.Size(717, 27);
            this.servicesBindingNavigator.TabIndex = 29;
            this.servicesBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(55, 20);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // servicesBindingNavigatorSaveItem
            // 
            this.servicesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.servicesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("servicesBindingNavigatorSaveItem.Image")));
            this.servicesBindingNavigatorSaveItem.Name = "servicesBindingNavigatorSaveItem";
            this.servicesBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.servicesBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.servicesBindingNavigatorSaveItem.Click += new System.EventHandler(this.servicesBindingNavigatorSaveItem_Click);
            // 
            // service_idLabel
            // 
            service_idLabel.AutoSize = true;
            service_idLabel.Location = new System.Drawing.Point(173, 49);
            service_idLabel.Name = "service_idLabel";
            service_idLabel.Size = new System.Drawing.Size(69, 16);
            service_idLabel.TabIndex = 29;
            service_idLabel.Text = "id услуги:";
            // 
            // service_idLabel1
            // 
            this.service_idLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.servicesBindingSource, "service_id", true));
            this.service_idLabel1.Location = new System.Drawing.Point(264, 49);
            this.service_idLabel1.Name = "service_idLabel1";
            this.service_idLabel1.Size = new System.Drawing.Size(100, 23);
            this.service_idLabel1.TabIndex = 30;
            this.service_idLabel1.Text = "label1";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(173, 78);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(76, 16);
            nameLabel.TabIndex = 30;
            nameLabel.Text = "Название:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.servicesBindingSource, "name", true));
            this.nameTextBox.Location = new System.Drawing.Point(267, 75);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(165, 22);
            this.nameTextBox.TabIndex = 31;
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(173, 111);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(75, 16);
            descriptionLabel.TabIndex = 31;
            descriptionLabel.Text = "Описание:";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.servicesBindingSource, "description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(266, 108);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(166, 22);
            this.descriptionTextBox.TabIndex = 32;
            // 
            // monthly_feeLabel
            // 
            monthly_feeLabel.AutoSize = true;
            monthly_feeLabel.Location = new System.Drawing.Point(173, 147);
            monthly_feeLabel.Name = "monthly_feeLabel";
            monthly_feeLabel.Size = new System.Drawing.Size(92, 32);
            monthly_feeLabel.TabIndex = 32;
            monthly_feeLabel.Text = "Абонентская\r\nплата:";
            // 
            // is_activeLabel
            // 
            is_activeLabel.AutoSize = true;
            is_activeLabel.Location = new System.Drawing.Point(173, 249);
            is_activeLabel.Name = "is_activeLabel";
            is_activeLabel.Size = new System.Drawing.Size(126, 16);
            is_activeLabel.TabIndex = 34;
            is_activeLabel.Text = "Предоставляется:";
            // 
            // is_activeCheckBox
            // 
            this.is_activeCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.servicesBindingSource, "is_active", true));
            this.is_activeCheckBox.Location = new System.Drawing.Point(319, 246);
            this.is_activeCheckBox.Name = "is_activeCheckBox";
            this.is_activeCheckBox.Size = new System.Drawing.Size(22, 24);
            this.is_activeCheckBox.TabIndex = 35;
            this.is_activeCheckBox.UseVisualStyleBackColor = true;
            // 
            // connection_feeLabel
            // 
            connection_feeLabel.AutoSize = true;
            connection_feeLabel.Location = new System.Drawing.Point(173, 195);
            connection_feeLabel.Name = "connection_feeLabel";
            connection_feeLabel.Size = new System.Drawing.Size(105, 32);
            connection_feeLabel.TabIndex = 35;
            connection_feeLabel.Text = "Плата за \r\nприобретение:";
            // 
            // monthly_feeTextBox
            // 
            this.monthly_feeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.servicesBindingSource, "monthly_fee", true));
            this.monthly_feeTextBox.Location = new System.Drawing.Point(284, 157);
            this.monthly_feeTextBox.Name = "monthly_feeTextBox";
            this.monthly_feeTextBox.Size = new System.Drawing.Size(100, 22);
            this.monthly_feeTextBox.TabIndex = 37;
            // 
            // connection_feeTextBox
            // 
            this.connection_feeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.servicesBindingSource, "connection_fee", true));
            this.connection_feeTextBox.Location = new System.Drawing.Point(284, 205);
            this.connection_feeTextBox.Name = "connection_feeTextBox";
            this.connection_feeTextBox.Size = new System.Drawing.Size(100, 22);
            this.connection_feeTextBox.TabIndex = 38;
            // 
            // editServices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 458);
            this.Controls.Add(this.connection_feeTextBox);
            this.Controls.Add(this.monthly_feeTextBox);
            this.Controls.Add(connection_feeLabel);
            this.Controls.Add(is_activeLabel);
            this.Controls.Add(this.is_activeCheckBox);
            this.Controls.Add(monthly_feeLabel);
            this.Controls.Add(descriptionLabel);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(service_idLabel);
            this.Controls.Add(this.service_idLabel1);
            this.Controls.Add(this.servicesBindingNavigator);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevios);
            this.Name = "editServices";
            this.Text = "Редактирование данных";
            this.Load += new System.EventHandler(this.editServices_Load);
            ((System.ComponentModel.ISupportInitialize)(this.shopDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicesBindingNavigator)).EndInit();
            this.servicesBindingNavigator.ResumeLayout(false);
            this.servicesBindingNavigator.PerformLayout();
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
        private System.Windows.Forms.BindingSource servicesBindingSource;
        private shopDataSetTableAdapters.servicesTableAdapter servicesTableAdapter;
        private System.Windows.Forms.BindingNavigator servicesBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton servicesBindingNavigatorSaveItem;
        private System.Windows.Forms.Label service_idLabel1;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.CheckBox is_activeCheckBox;
        private System.Windows.Forms.TextBox monthly_feeTextBox;
        private System.Windows.Forms.TextBox connection_feeTextBox;
    }
}