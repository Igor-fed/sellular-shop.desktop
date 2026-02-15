namespace sellular_shop
{
    partial class services
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
            this.serviceidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monthlyfeeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.connectionfeeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isactiveDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.servicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shopDataSet = new sellular_shop.shopDataSet();
            this.btnBack = new System.Windows.Forms.Button();
            this.edit = new System.Windows.Forms.Button();
            this.filter = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.servicesTableAdapter = new sellular_shop.shopDataSetTableAdapters.servicesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.serviceidDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.monthlyfeeDataGridViewTextBoxColumn,
            this.connectionfeeDataGridViewTextBoxColumn,
            this.isactiveDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.servicesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(276, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(512, 384);
            this.dataGridView1.TabIndex = 0;
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
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Название";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Описание";
            this.descriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            this.descriptionDataGridViewTextBoxColumn.Width = 125;
            // 
            // monthlyfeeDataGridViewTextBoxColumn
            // 
            this.monthlyfeeDataGridViewTextBoxColumn.DataPropertyName = "monthly_fee";
            this.monthlyfeeDataGridViewTextBoxColumn.HeaderText = "Абонентская плата";
            this.monthlyfeeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.monthlyfeeDataGridViewTextBoxColumn.Name = "monthlyfeeDataGridViewTextBoxColumn";
            this.monthlyfeeDataGridViewTextBoxColumn.ReadOnly = true;
            this.monthlyfeeDataGridViewTextBoxColumn.Width = 125;
            // 
            // connectionfeeDataGridViewTextBoxColumn
            // 
            this.connectionfeeDataGridViewTextBoxColumn.DataPropertyName = "connection_fee";
            this.connectionfeeDataGridViewTextBoxColumn.HeaderText = "Плата за приобретение";
            this.connectionfeeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.connectionfeeDataGridViewTextBoxColumn.Name = "connectionfeeDataGridViewTextBoxColumn";
            this.connectionfeeDataGridViewTextBoxColumn.ReadOnly = true;
            this.connectionfeeDataGridViewTextBoxColumn.Width = 125;
            // 
            // isactiveDataGridViewCheckBoxColumn
            // 
            this.isactiveDataGridViewCheckBoxColumn.DataPropertyName = "is_active";
            this.isactiveDataGridViewCheckBoxColumn.HeaderText = "Активна";
            this.isactiveDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.isactiveDataGridViewCheckBoxColumn.Name = "isactiveDataGridViewCheckBoxColumn";
            this.isactiveDataGridViewCheckBoxColumn.ReadOnly = true;
            this.isactiveDataGridViewCheckBoxColumn.Width = 125;
            // 
            // servicesBindingSource
            // 
            this.servicesBindingSource.DataMember = "services";
            this.servicesBindingSource.DataSource = this.shopDataSet;
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
            // servicesTableAdapter
            // 
            this.servicesTableAdapter.ClearBeforeFill = true;
            // 
            // services
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
            this.Name = "services";
            this.Text = "Сотрудники";
            this.Load += new System.EventHandler(this.services_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private shopDataSet shopDataSet;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.Button filter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource servicesBindingSource;
        private shopDataSetTableAdapters.servicesTableAdapter servicesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn monthlyfeeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn connectionfeeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isactiveDataGridViewCheckBoxColumn;
    }
}