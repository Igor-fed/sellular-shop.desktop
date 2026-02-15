namespace sellular_shop
{
    partial class editClients
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
            System.Windows.Forms.Label client_idLabel;
            System.Windows.Forms.Label last_nameLabel;
            System.Windows.Forms.Label first_nameLabel;
            System.Windows.Forms.Label patronymicLabel;
            System.Windows.Forms.Label birth_dateLabel;
            System.Windows.Forms.Label phoneLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label is_activeLabel;
            this.shopDataSet = new sellular_shop.shopDataSet();
            this.btnPrevios = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientsTableAdapter = new sellular_shop.shopDataSetTableAdapters.clientsTableAdapter();
            this.client_idLabel1 = new System.Windows.Forms.Label();
            this.last_nameTextBox = new System.Windows.Forms.TextBox();
            this.first_nameTextBox = new System.Windows.Forms.TextBox();
            this.patronymicTextBox = new System.Windows.Forms.TextBox();
            this.birth_dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.is_activeCheckBox = new System.Windows.Forms.CheckBox();
            this.tableAdapterManager = new sellular_shop.shopDataSetTableAdapters.TableAdapterManager();
            client_idLabel = new System.Windows.Forms.Label();
            last_nameLabel = new System.Windows.Forms.Label();
            first_nameLabel = new System.Windows.Forms.Label();
            patronymicLabel = new System.Windows.Forms.Label();
            birth_dateLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            is_activeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.shopDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // client_idLabel
            // 
            client_idLabel.AutoSize = true;
            client_idLabel.Location = new System.Drawing.Point(154, 60);
            client_idLabel.Name = "client_idLabel";
            client_idLabel.Size = new System.Drawing.Size(79, 16);
            client_idLabel.TabIndex = 28;
            client_idLabel.Text = "id Клиента:";
            // 
            // last_nameLabel
            // 
            last_nameLabel.AutoSize = true;
            last_nameLabel.Location = new System.Drawing.Point(156, 89);
            last_nameLabel.Name = "last_nameLabel";
            last_nameLabel.Size = new System.Drawing.Size(69, 16);
            last_nameLabel.TabIndex = 29;
            last_nameLabel.Text = "Фамилия:";
            // 
            // first_nameLabel
            // 
            first_nameLabel.AutoSize = true;
            first_nameLabel.Location = new System.Drawing.Point(154, 117);
            first_nameLabel.Name = "first_nameLabel";
            first_nameLabel.Size = new System.Drawing.Size(36, 16);
            first_nameLabel.TabIndex = 30;
            first_nameLabel.Text = "Имя:";
            // 
            // patronymicLabel
            // 
            patronymicLabel.AutoSize = true;
            patronymicLabel.Location = new System.Drawing.Point(156, 145);
            patronymicLabel.Name = "patronymicLabel";
            patronymicLabel.Size = new System.Drawing.Size(73, 16);
            patronymicLabel.TabIndex = 31;
            patronymicLabel.Text = "Отчество:";
            // 
            // birth_dateLabel
            // 
            birth_dateLabel.AutoSize = true;
            birth_dateLabel.Location = new System.Drawing.Point(154, 175);
            birth_dateLabel.Name = "birth_dateLabel";
            birth_dateLabel.Size = new System.Drawing.Size(109, 16);
            birth_dateLabel.TabIndex = 32;
            birth_dateLabel.Text = "Дата рождения:";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new System.Drawing.Point(156, 201);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(70, 16);
            phoneLabel.TabIndex = 33;
            phoneLabel.Text = "Телефон:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(156, 229);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(51, 16);
            emailLabel.TabIndex = 34;
            emailLabel.Text = "Почта:";
            // 
            // is_activeLabel
            // 
            is_activeLabel.AutoSize = true;
            is_activeLabel.Location = new System.Drawing.Point(154, 256);
            is_activeLabel.Name = "is_activeLabel";
            is_activeLabel.Size = new System.Drawing.Size(107, 16);
            is_activeLabel.TabIndex = 35;
            is_activeLabel.Text = "Сотрудничаем:";
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
            this.btnDelete.Text = "Отключить";
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
            // clientsBindingSource
            // 
            this.clientsBindingSource.DataMember = "clients";
            this.clientsBindingSource.DataSource = this.shopDataSet;
            // 
            // clientsTableAdapter
            // 
            this.clientsTableAdapter.ClearBeforeFill = true;
            // 
            // client_idLabel1
            // 
            this.client_idLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientsBindingSource, "client_id", true));
            this.client_idLabel1.Location = new System.Drawing.Point(267, 60);
            this.client_idLabel1.Name = "client_idLabel1";
            this.client_idLabel1.Size = new System.Drawing.Size(100, 23);
            this.client_idLabel1.TabIndex = 29;
            this.client_idLabel1.Text = "label1";
            // 
            // last_nameTextBox
            // 
            this.last_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientsBindingSource, "last_name", true));
            this.last_nameTextBox.Location = new System.Drawing.Point(270, 86);
            this.last_nameTextBox.Name = "last_nameTextBox";
            this.last_nameTextBox.Size = new System.Drawing.Size(143, 22);
            this.last_nameTextBox.TabIndex = 30;
            // 
            // first_nameTextBox
            // 
            this.first_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientsBindingSource, "first_name", true));
            this.first_nameTextBox.Location = new System.Drawing.Point(270, 114);
            this.first_nameTextBox.Name = "first_nameTextBox";
            this.first_nameTextBox.Size = new System.Drawing.Size(143, 22);
            this.first_nameTextBox.TabIndex = 31;
            // 
            // patronymicTextBox
            // 
            this.patronymicTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientsBindingSource, "patronymic", true));
            this.patronymicTextBox.Location = new System.Drawing.Point(270, 142);
            this.patronymicTextBox.Name = "patronymicTextBox";
            this.patronymicTextBox.Size = new System.Drawing.Size(143, 22);
            this.patronymicTextBox.TabIndex = 32;
            // 
            // birth_dateDateTimePicker
            // 
            this.birth_dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.clientsBindingSource, "birth_date", true));
            this.birth_dateDateTimePicker.Location = new System.Drawing.Point(270, 170);
            this.birth_dateDateTimePicker.Name = "birth_dateDateTimePicker";
            this.birth_dateDateTimePicker.Size = new System.Drawing.Size(143, 22);
            this.birth_dateDateTimePicker.TabIndex = 33;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientsBindingSource, "phone", true));
            this.phoneTextBox.Location = new System.Drawing.Point(270, 198);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(143, 22);
            this.phoneTextBox.TabIndex = 34;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientsBindingSource, "email", true));
            this.emailTextBox.Location = new System.Drawing.Point(267, 226);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(146, 22);
            this.emailTextBox.TabIndex = 35;
            // 
            // is_activeCheckBox
            // 
            this.is_activeCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.clientsBindingSource, "is_active", true));
            this.is_activeCheckBox.Location = new System.Drawing.Point(267, 253);
            this.is_activeCheckBox.Name = "is_activeCheckBox";
            this.is_activeCheckBox.Size = new System.Drawing.Size(27, 24);
            this.is_activeCheckBox.TabIndex = 36;
            this.is_activeCheckBox.UseVisualStyleBackColor = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.categoryTableAdapter = null;
            this.tableAdapterManager.clientsTableAdapter = this.clientsTableAdapter;
            this.tableAdapterManager.contractsTableAdapter = null;
            this.tableAdapterManager.employeesTableAdapter = null;
            this.tableAdapterManager.productsTableAdapter = null;
            this.tableAdapterManager.sale_itemsTableAdapter = null;
            this.tableAdapterManager.salesTableAdapter = null;
            this.tableAdapterManager.servicesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = sellular_shop.shopDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // editClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 458);
            this.Controls.Add(is_activeLabel);
            this.Controls.Add(this.is_activeCheckBox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(phoneLabel);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(birth_dateLabel);
            this.Controls.Add(this.birth_dateDateTimePicker);
            this.Controls.Add(patronymicLabel);
            this.Controls.Add(this.patronymicTextBox);
            this.Controls.Add(first_nameLabel);
            this.Controls.Add(this.first_nameTextBox);
            this.Controls.Add(last_nameLabel);
            this.Controls.Add(this.last_nameTextBox);
            this.Controls.Add(client_idLabel);
            this.Controls.Add(this.client_idLabel1);
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
            this.Name = "editClients";
            this.Text = "Редактирование данных";
            this.Load += new System.EventHandler(this.editEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.shopDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
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
        private System.Windows.Forms.BindingSource clientsBindingSource;
        private shopDataSetTableAdapters.clientsTableAdapter clientsTableAdapter;
        private System.Windows.Forms.Label client_idLabel1;
        private System.Windows.Forms.TextBox last_nameTextBox;
        private System.Windows.Forms.TextBox first_nameTextBox;
        private System.Windows.Forms.TextBox patronymicTextBox;
        private System.Windows.Forms.DateTimePicker birth_dateDateTimePicker;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.CheckBox is_activeCheckBox;
        private shopDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}