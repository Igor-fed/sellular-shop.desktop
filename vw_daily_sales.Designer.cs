namespace sellular_shop
{
    partial class vw_daily_sales
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
            this.vwdailysalesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shopDataSet = new sellular_shop.shopDataSet();
            this.btnBack = new System.Windows.Forms.Button();
            this.filter = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.vw_daily_salesTableAdapter = new sellular_shop.shopDataSetTableAdapters.vw_daily_salesTableAdapter();
            this.saledayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salescountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalamountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwdailysalesBindingSource)).BeginInit();
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
            this.saledayDataGridViewTextBoxColumn,
            this.salescountDataGridViewTextBoxColumn,
            this.totalamountDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.vwdailysalesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(276, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(429, 384);
            this.dataGridView1.TabIndex = 0;
            // 
            // vwdailysalesBindingSource
            // 
            this.vwdailysalesBindingSource.DataMember = "vw_daily_sales";
            this.vwdailysalesBindingSource.DataSource = this.shopDataSet;
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
            // filter
            // 
            this.filter.Location = new System.Drawing.Point(12, 290);
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
            // vw_daily_salesTableAdapter
            // 
            this.vw_daily_salesTableAdapter.ClearBeforeFill = true;
            // 
            // saledayDataGridViewTextBoxColumn
            // 
            this.saledayDataGridViewTextBoxColumn.DataPropertyName = "sale_day";
            this.saledayDataGridViewTextBoxColumn.HeaderText = "День";
            this.saledayDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.saledayDataGridViewTextBoxColumn.Name = "saledayDataGridViewTextBoxColumn";
            this.saledayDataGridViewTextBoxColumn.ReadOnly = true;
            this.saledayDataGridViewTextBoxColumn.Width = 125;
            // 
            // salescountDataGridViewTextBoxColumn
            // 
            this.salescountDataGridViewTextBoxColumn.DataPropertyName = "sales_count";
            this.salescountDataGridViewTextBoxColumn.HeaderText = "количество продаж";
            this.salescountDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.salescountDataGridViewTextBoxColumn.Name = "salescountDataGridViewTextBoxColumn";
            this.salescountDataGridViewTextBoxColumn.ReadOnly = true;
            this.salescountDataGridViewTextBoxColumn.Width = 125;
            // 
            // totalamountDataGridViewTextBoxColumn
            // 
            this.totalamountDataGridViewTextBoxColumn.DataPropertyName = "total_amount";
            this.totalamountDataGridViewTextBoxColumn.HeaderText = "сумма";
            this.totalamountDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.totalamountDataGridViewTextBoxColumn.Name = "totalamountDataGridViewTextBoxColumn";
            this.totalamountDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalamountDataGridViewTextBoxColumn.Width = 125;
            // 
            // vw_daily_sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 408);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.filter);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "vw_daily_sales";
            this.Text = "Ежедневные продажи";
            this.Load += new System.EventHandler(this.vw_daily_sales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwdailysalesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private shopDataSet shopDataSet;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button filter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource vwdailysalesBindingSource;
        private shopDataSetTableAdapters.vw_daily_salesTableAdapter vw_daily_salesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn saledayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salescountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalamountDataGridViewTextBoxColumn;
    }
}