namespace sellular_shop
{
    partial class vw_sales_services
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
            this.vwsalesservicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shopDataSet = new sellular_shop.shopDataSet();
            this.btnBack = new System.Windows.Forms.Button();
            this.filter = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.vw_sales_servicesTableAdapter = new sellular_shop.shopDataSetTableAdapters.vw_sales_servicesTableAdapter();
            this.sale_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sale_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sale_day = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sale_month = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.service_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.service_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity_sold = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vwsalesservicesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.saleidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saledateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saledayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salemonthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.servicenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantitysoldDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalamountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwsalesservicesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwsalesservicesBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sale_id,
            this.sale_date,
            this.sale_day,
            this.sale_month,
            this.service_id,
            this.service_name,
            this.quantity_sold,
            this.price,
            this.saleidDataGridViewTextBoxColumn,
            this.saledateDataGridViewTextBoxColumn,
            this.saledayDataGridViewTextBoxColumn,
            this.salemonthDataGridViewTextBoxColumn,
            this.serviceidDataGridViewTextBoxColumn,
            this.servicenameDataGridViewTextBoxColumn,
            this.quantitysoldDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.totalamountDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.vwsalesservicesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(276, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(403, 455);
            this.dataGridView1.TabIndex = 0;
            // 
            // vwsalesservicesBindingSource
            // 
            this.vwsalesservicesBindingSource.DataMember = "vw_sales_services";
            this.vwsalesservicesBindingSource.DataSource = this.shopDataSet;
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
            this.filter.Location = new System.Drawing.Point(12, 361);
            this.filter.Name = "filter";
            this.filter.Size = new System.Drawing.Size(220, 50);
            this.filter.TabIndex = 15;
            this.filter.Text = "Фильтр";
            this.filter.UseVisualStyleBackColor = true;
            this.filter.Click += new System.EventHandler(this.filter_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 417);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(220, 50);
            this.button1.TabIndex = 16;
            this.button1.Text = "Показать все";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // vw_sales_servicesTableAdapter
            // 
            this.vw_sales_servicesTableAdapter.ClearBeforeFill = true;
            // 
            // sale_id
            // 
            this.sale_id.DataPropertyName = "sale_id";
            this.sale_id.HeaderText = "id";
            this.sale_id.MinimumWidth = 6;
            this.sale_id.Name = "sale_id";
            this.sale_id.ReadOnly = true;
            this.sale_id.Width = 125;
            // 
            // sale_date
            // 
            this.sale_date.DataPropertyName = "sale_date";
            this.sale_date.HeaderText = "Дата";
            this.sale_date.MinimumWidth = 6;
            this.sale_date.Name = "sale_date";
            this.sale_date.ReadOnly = true;
            this.sale_date.Width = 125;
            // 
            // sale_day
            // 
            this.sale_day.DataPropertyName = "sale_day";
            this.sale_day.HeaderText = "День";
            this.sale_day.MinimumWidth = 6;
            this.sale_day.Name = "sale_day";
            this.sale_day.ReadOnly = true;
            this.sale_day.Width = 125;
            // 
            // sale_month
            // 
            this.sale_month.DataPropertyName = "sale_month";
            this.sale_month.HeaderText = "Месяц";
            this.sale_month.MinimumWidth = 6;
            this.sale_month.Name = "sale_month";
            this.sale_month.ReadOnly = true;
            this.sale_month.Width = 125;
            // 
            // service_id
            // 
            this.service_id.DataPropertyName = "service_id";
            this.service_id.HeaderText = "id_Услуги";
            this.service_id.MinimumWidth = 6;
            this.service_id.Name = "service_id";
            this.service_id.ReadOnly = true;
            this.service_id.Width = 125;
            // 
            // service_name
            // 
            this.service_name.DataPropertyName = "service_name";
            this.service_name.HeaderText = "Название";
            this.service_name.MinimumWidth = 6;
            this.service_name.Name = "service_name";
            this.service_name.ReadOnly = true;
            this.service_name.Width = 125;
            // 
            // quantity_sold
            // 
            this.quantity_sold.DataPropertyName = "quantity_sold";
            this.quantity_sold.HeaderText = "количество";
            this.quantity_sold.MinimumWidth = 6;
            this.quantity_sold.Name = "quantity_sold";
            this.quantity_sold.ReadOnly = true;
            this.quantity_sold.Width = 125;
            // 
            // price
            // 
            this.price.DataPropertyName = "price";
            this.price.HeaderText = "цена";
            this.price.MinimumWidth = 6;
            this.price.Name = "price";
            this.price.ReadOnly = true;
            this.price.Width = 125;
            // 
            // vwsalesservicesBindingSource1
            // 
            this.vwsalesservicesBindingSource1.DataMember = "vw_sales_services";
            this.vwsalesservicesBindingSource1.DataSource = this.shopDataSet;
            // 
            // saleidDataGridViewTextBoxColumn
            // 
            this.saleidDataGridViewTextBoxColumn.DataPropertyName = "sale_id";
            this.saleidDataGridViewTextBoxColumn.HeaderText = "sale_id";
            this.saleidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.saleidDataGridViewTextBoxColumn.Name = "saleidDataGridViewTextBoxColumn";
            this.saleidDataGridViewTextBoxColumn.ReadOnly = true;
            this.saleidDataGridViewTextBoxColumn.Width = 125;
            // 
            // saledateDataGridViewTextBoxColumn
            // 
            this.saledateDataGridViewTextBoxColumn.DataPropertyName = "sale_date";
            this.saledateDataGridViewTextBoxColumn.HeaderText = "sale_date";
            this.saledateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.saledateDataGridViewTextBoxColumn.Name = "saledateDataGridViewTextBoxColumn";
            this.saledateDataGridViewTextBoxColumn.ReadOnly = true;
            this.saledateDataGridViewTextBoxColumn.Width = 125;
            // 
            // saledayDataGridViewTextBoxColumn
            // 
            this.saledayDataGridViewTextBoxColumn.DataPropertyName = "sale_day";
            this.saledayDataGridViewTextBoxColumn.HeaderText = "sale_day";
            this.saledayDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.saledayDataGridViewTextBoxColumn.Name = "saledayDataGridViewTextBoxColumn";
            this.saledayDataGridViewTextBoxColumn.ReadOnly = true;
            this.saledayDataGridViewTextBoxColumn.Width = 125;
            // 
            // salemonthDataGridViewTextBoxColumn
            // 
            this.salemonthDataGridViewTextBoxColumn.DataPropertyName = "sale_month";
            this.salemonthDataGridViewTextBoxColumn.HeaderText = "sale_month";
            this.salemonthDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.salemonthDataGridViewTextBoxColumn.Name = "salemonthDataGridViewTextBoxColumn";
            this.salemonthDataGridViewTextBoxColumn.ReadOnly = true;
            this.salemonthDataGridViewTextBoxColumn.Width = 125;
            // 
            // serviceidDataGridViewTextBoxColumn
            // 
            this.serviceidDataGridViewTextBoxColumn.DataPropertyName = "service_id";
            this.serviceidDataGridViewTextBoxColumn.HeaderText = "service_id";
            this.serviceidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.serviceidDataGridViewTextBoxColumn.Name = "serviceidDataGridViewTextBoxColumn";
            this.serviceidDataGridViewTextBoxColumn.ReadOnly = true;
            this.serviceidDataGridViewTextBoxColumn.Width = 125;
            // 
            // servicenameDataGridViewTextBoxColumn
            // 
            this.servicenameDataGridViewTextBoxColumn.DataPropertyName = "service_name";
            this.servicenameDataGridViewTextBoxColumn.HeaderText = "service_name";
            this.servicenameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.servicenameDataGridViewTextBoxColumn.Name = "servicenameDataGridViewTextBoxColumn";
            this.servicenameDataGridViewTextBoxColumn.ReadOnly = true;
            this.servicenameDataGridViewTextBoxColumn.Width = 125;
            // 
            // quantitysoldDataGridViewTextBoxColumn
            // 
            this.quantitysoldDataGridViewTextBoxColumn.DataPropertyName = "quantity_sold";
            this.quantitysoldDataGridViewTextBoxColumn.HeaderText = "quantity_sold";
            this.quantitysoldDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.quantitysoldDataGridViewTextBoxColumn.Name = "quantitysoldDataGridViewTextBoxColumn";
            this.quantitysoldDataGridViewTextBoxColumn.ReadOnly = true;
            this.quantitysoldDataGridViewTextBoxColumn.Width = 125;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "price";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            this.priceDataGridViewTextBoxColumn.Width = 125;
            // 
            // totalamountDataGridViewTextBoxColumn
            // 
            this.totalamountDataGridViewTextBoxColumn.DataPropertyName = "total_amount";
            this.totalamountDataGridViewTextBoxColumn.HeaderText = "total_amount";
            this.totalamountDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.totalamountDataGridViewTextBoxColumn.Name = "totalamountDataGridViewTextBoxColumn";
            this.totalamountDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalamountDataGridViewTextBoxColumn.Width = 125;
            // 
            // vw_sales_services
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 479);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.filter);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "vw_sales_services";
            this.Text = "Продажи услуг";
            this.Load += new System.EventHandler(this.vw_sales_services_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwsalesservicesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwsalesservicesBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private shopDataSet shopDataSet;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button filter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource vwsalesservicesBindingSource;
        private shopDataSetTableAdapters.vw_sales_servicesTableAdapter vw_sales_servicesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn sale_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn sale_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn sale_day;
        private System.Windows.Forms.DataGridViewTextBoxColumn sale_month;
        private System.Windows.Forms.DataGridViewTextBoxColumn service_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn service_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity_sold;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn saleidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn saledateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn saledayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salemonthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn servicenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantitysoldDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalamountDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource vwsalesservicesBindingSource1;
    }
}