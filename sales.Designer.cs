namespace sellular_shop
{
    partial class contracts
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.shopDataSet = new sellular_shop.shopDataSet();
            this.btnBack = new System.Windows.Forms.Button();
            this.edit = new System.Windows.Forms.Button();
            this.filter = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.contractsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contractsTableAdapter = new sellular_shop.shopDataSetTableAdapters.contractsTableAdapter();
            this.contractidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phonenumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contractdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.contractidDataGridViewTextBoxColumn,
            this.clientidDataGridViewTextBoxColumn,
            this.serviceidDataGridViewTextBoxColumn,
            this.employeeidDataGridViewTextBoxColumn,
            this.phonenumberDataGridViewTextBoxColumn,
            this.contractdateDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.contractsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(276, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(512, 384);
            this.dataGridView1.TabIndex = 0;
            // 
            // shopDataSet
            // 
            this.shopDataSet.DataSetName = "shopDataSet";
            this.shopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(41, 33);
            this.btnBack.TabIndex = 13;
            this.btnBack.Text = "←";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // edit
            // 
            this.edit.Location = new System.Drawing.Point(12, 286);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(220, 50);
            this.edit.TabIndex = 14;
            this.edit.Text = "Изменить";
            this.edit.UseVisualStyleBackColor = true;
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // filter
            // 
            this.filter.Location = new System.Drawing.Point(12, 226);
            this.filter.Name = "filter";
            this.filter.Size = new System.Drawing.Size(220, 50);
            this.filter.TabIndex = 15;
            this.filter.Text = "Фильтр";
            this.filter.UseVisualStyleBackColor = true;
            this.filter.Click += new System.EventHandler(this.filter_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 346);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(220, 50);
            this.button1.TabIndex = 16;
            this.button1.Text = "Показать все";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            // contractidDataGridViewTextBoxColumn
            // 
            this.contractidDataGridViewTextBoxColumn.DataPropertyName = "contract_id";
            this.contractidDataGridViewTextBoxColumn.HeaderText = "id_Договора";
            this.contractidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.contractidDataGridViewTextBoxColumn.Name = "contractidDataGridViewTextBoxColumn";
            this.contractidDataGridViewTextBoxColumn.ReadOnly = true;
            this.contractidDataGridViewTextBoxColumn.Width = 125;
            // 
            // clientidDataGridViewTextBoxColumn
            // 
            this.clientidDataGridViewTextBoxColumn.DataPropertyName = "client_id";
            this.clientidDataGridViewTextBoxColumn.HeaderText = "id_Клиента";
            this.clientidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.clientidDataGridViewTextBoxColumn.Name = "clientidDataGridViewTextBoxColumn";
            this.clientidDataGridViewTextBoxColumn.ReadOnly = true;
            this.clientidDataGridViewTextBoxColumn.Width = 125;
            // 
            // serviceidDataGridViewTextBoxColumn
            // 
            this.serviceidDataGridViewTextBoxColumn.DataPropertyName = "service_id";
            this.serviceidDataGridViewTextBoxColumn.HeaderText = "id_Услуги";
            this.serviceidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.serviceidDataGridViewTextBoxColumn.Name = "serviceidDataGridViewTextBoxColumn";
            this.serviceidDataGridViewTextBoxColumn.ReadOnly = true;
            this.serviceidDataGridViewTextBoxColumn.Width = 125;
            // 
            // employeeidDataGridViewTextBoxColumn
            // 
            this.employeeidDataGridViewTextBoxColumn.DataPropertyName = "employee_id";
            this.employeeidDataGridViewTextBoxColumn.HeaderText = "id_Сотрудника";
            this.employeeidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.employeeidDataGridViewTextBoxColumn.Name = "employeeidDataGridViewTextBoxColumn";
            this.employeeidDataGridViewTextBoxColumn.ReadOnly = true;
            this.employeeidDataGridViewTextBoxColumn.Width = 125;
            // 
            // phonenumberDataGridViewTextBoxColumn
            // 
            this.phonenumberDataGridViewTextBoxColumn.DataPropertyName = "phone_number";
            this.phonenumberDataGridViewTextBoxColumn.HeaderText = "Номер_телефона";
            this.phonenumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.phonenumberDataGridViewTextBoxColumn.Name = "phonenumberDataGridViewTextBoxColumn";
            this.phonenumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.phonenumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // contractdateDataGridViewTextBoxColumn
            // 
            this.contractdateDataGridViewTextBoxColumn.DataPropertyName = "contract_date";
            this.contractdateDataGridViewTextBoxColumn.HeaderText = "Дата заключения";
            this.contractdateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.contractdateDataGridViewTextBoxColumn.Name = "contractdateDataGridViewTextBoxColumn";
            this.contractdateDataGridViewTextBoxColumn.ReadOnly = true;
            this.contractdateDataGridViewTextBoxColumn.Width = 125;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Статус";
            this.statusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            this.statusDataGridViewTextBoxColumn.Width = 125;
            // 
            // contracts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 408);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.filter);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "contracts";
            this.Text = "Сотрудники";
            this.Load += new System.EventHandler(this.contracts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private shopDataSet shopDataSet;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.Button filter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource contractsBindingSource;
        private shopDataSetTableAdapters.contractsTableAdapter contractsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn contractidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phonenumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contractdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
    }
}