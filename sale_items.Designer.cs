namespace sellular_shop
{
    partial class sale_items
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
            this.saleitemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sale_itemsTableAdapter = new sellular_shop.shopDataSetTableAdapters.sale_itemsTableAdapter();
            this.saleitemidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saleidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemtypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleitemsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.saleitemidDataGridViewTextBoxColumn,
            this.saleidDataGridViewTextBoxColumn,
            this.itemtypeDataGridViewTextBoxColumn,
            this.productidDataGridViewTextBoxColumn,
            this.serviceidDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.saleitemsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(276, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(429, 384);
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
            // saleitemsBindingSource
            // 
            this.saleitemsBindingSource.DataMember = "sale_items";
            this.saleitemsBindingSource.DataSource = this.shopDataSet;
            // 
            // sale_itemsTableAdapter
            // 
            this.sale_itemsTableAdapter.ClearBeforeFill = true;
            // 
            // saleitemidDataGridViewTextBoxColumn
            // 
            this.saleitemidDataGridViewTextBoxColumn.DataPropertyName = "sale_item_id";
            this.saleitemidDataGridViewTextBoxColumn.HeaderText = "id";
            this.saleitemidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.saleitemidDataGridViewTextBoxColumn.Name = "saleitemidDataGridViewTextBoxColumn";
            this.saleitemidDataGridViewTextBoxColumn.ReadOnly = true;
            this.saleitemidDataGridViewTextBoxColumn.Width = 125;
            // 
            // saleidDataGridViewTextBoxColumn
            // 
            this.saleidDataGridViewTextBoxColumn.DataPropertyName = "sale_id";
            this.saleidDataGridViewTextBoxColumn.HeaderText = "id_продажи";
            this.saleidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.saleidDataGridViewTextBoxColumn.Name = "saleidDataGridViewTextBoxColumn";
            this.saleidDataGridViewTextBoxColumn.ReadOnly = true;
            this.saleidDataGridViewTextBoxColumn.Width = 125;
            // 
            // itemtypeDataGridViewTextBoxColumn
            // 
            this.itemtypeDataGridViewTextBoxColumn.DataPropertyName = "item_type";
            this.itemtypeDataGridViewTextBoxColumn.HeaderText = "тип";
            this.itemtypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.itemtypeDataGridViewTextBoxColumn.Name = "itemtypeDataGridViewTextBoxColumn";
            this.itemtypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.itemtypeDataGridViewTextBoxColumn.Width = 125;
            // 
            // productidDataGridViewTextBoxColumn
            // 
            this.productidDataGridViewTextBoxColumn.DataPropertyName = "product_id";
            this.productidDataGridViewTextBoxColumn.HeaderText = "id_товара";
            this.productidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productidDataGridViewTextBoxColumn.Name = "productidDataGridViewTextBoxColumn";
            this.productidDataGridViewTextBoxColumn.ReadOnly = true;
            this.productidDataGridViewTextBoxColumn.Width = 125;
            // 
            // serviceidDataGridViewTextBoxColumn
            // 
            this.serviceidDataGridViewTextBoxColumn.DataPropertyName = "service_id";
            this.serviceidDataGridViewTextBoxColumn.HeaderText = "id_услуги";
            this.serviceidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.serviceidDataGridViewTextBoxColumn.Name = "serviceidDataGridViewTextBoxColumn";
            this.serviceidDataGridViewTextBoxColumn.ReadOnly = true;
            this.serviceidDataGridViewTextBoxColumn.Width = 125;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "количество";
            this.quantityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.ReadOnly = true;
            this.quantityDataGridViewTextBoxColumn.Width = 125;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "цена";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            this.priceDataGridViewTextBoxColumn.Width = 125;
            // 
            // sale_items
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
            this.Name = "sale_items";
            this.Text = "Ежедневные продажи";
            this.Load += new System.EventHandler(this.sale_items_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleitemsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private shopDataSet shopDataSet;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button filter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource saleitemsBindingSource;
        private shopDataSetTableAdapters.sale_itemsTableAdapter sale_itemsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn saleitemidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn saleidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemtypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
    }
}