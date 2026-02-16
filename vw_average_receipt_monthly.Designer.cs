namespace sellular_shop
{
    partial class vw_average_receipt_monthly
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
            this.filter = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.vwaveragereceiptmonthlyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vw_average_receipt_monthlyTableAdapter = new sellular_shop.shopDataSetTableAdapters.vw_average_receipt_monthlyTableAdapter();
            this.salemonthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.averagereceiptDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwaveragereceiptmonthlyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.salemonthDataGridViewTextBoxColumn,
            this.averagereceiptDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.vwaveragereceiptmonthlyBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(276, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(331, 384);
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
            // vwaveragereceiptmonthlyBindingSource
            // 
            this.vwaveragereceiptmonthlyBindingSource.DataMember = "vw_average_receipt_monthly";
            this.vwaveragereceiptmonthlyBindingSource.DataSource = this.shopDataSet;
            // 
            // vw_average_receipt_monthlyTableAdapter
            // 
            this.vw_average_receipt_monthlyTableAdapter.ClearBeforeFill = true;
            // 
            // salemonthDataGridViewTextBoxColumn
            // 
            this.salemonthDataGridViewTextBoxColumn.DataPropertyName = "sale_month";
            this.salemonthDataGridViewTextBoxColumn.HeaderText = "Месяц";
            this.salemonthDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.salemonthDataGridViewTextBoxColumn.Name = "salemonthDataGridViewTextBoxColumn";
            this.salemonthDataGridViewTextBoxColumn.ReadOnly = true;
            this.salemonthDataGridViewTextBoxColumn.Width = 125;
            // 
            // averagereceiptDataGridViewTextBoxColumn
            // 
            this.averagereceiptDataGridViewTextBoxColumn.DataPropertyName = "average_receipt";
            this.averagereceiptDataGridViewTextBoxColumn.HeaderText = "средняя_сумма_чека";
            this.averagereceiptDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.averagereceiptDataGridViewTextBoxColumn.Name = "averagereceiptDataGridViewTextBoxColumn";
            this.averagereceiptDataGridViewTextBoxColumn.ReadOnly = true;
            this.averagereceiptDataGridViewTextBoxColumn.Width = 150;
            // 
            // vw_average_receipt_monthly
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 408);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.filter);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "vw_average_receipt_monthly";
            this.Text = "Средний ежемесячный чек";
            this.Load += new System.EventHandler(this.vw_average_receipt_monthly_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwaveragereceiptmonthlyBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private shopDataSet shopDataSet;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button filter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource vwaveragereceiptmonthlyBindingSource;
        private shopDataSetTableAdapters.vw_average_receipt_monthlyTableAdapter vw_average_receipt_monthlyTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn salemonthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn averagereceiptDataGridViewTextBoxColumn;
    }
}