namespace sellular_shop
{
    partial class ManagerForm
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
            this.client = new System.Windows.Forms.Button();
            this.services = new System.Windows.Forms.Button();
            this.products = new System.Windows.Forms.Button();
            this.contracts = new System.Windows.Forms.Button();
            this.sales = new System.Windows.Forms.Button();
            this.sale_item = new System.Windows.Forms.Button();
            this.report = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // client
            // 
            this.client.Location = new System.Drawing.Point(62, 58);
            this.client.Name = "client";
            this.client.Size = new System.Drawing.Size(200, 70);
            this.client.TabIndex = 0;
            this.client.Text = "Клиенты";
            this.client.UseVisualStyleBackColor = true;
            this.client.Click += new System.EventHandler(this.client_Click);
            // 
            // services
            // 
            this.services.Location = new System.Drawing.Point(308, 58);
            this.services.Name = "services";
            this.services.Size = new System.Drawing.Size(200, 70);
            this.services.TabIndex = 1;
            this.services.Text = "Услуги";
            this.services.UseVisualStyleBackColor = true;
            this.services.Click += new System.EventHandler(this.services_Click);
            // 
            // products
            // 
            this.products.Location = new System.Drawing.Point(561, 58);
            this.products.Name = "products";
            this.products.Size = new System.Drawing.Size(200, 70);
            this.products.TabIndex = 2;
            this.products.Text = "Товары";
            this.products.UseVisualStyleBackColor = true;
            this.products.Click += new System.EventHandler(this.products_Click);
            // 
            // contracts
            // 
            this.contracts.Location = new System.Drawing.Point(62, 164);
            this.contracts.Name = "contracts";
            this.contracts.Size = new System.Drawing.Size(200, 70);
            this.contracts.TabIndex = 3;
            this.contracts.Text = "Договора";
            this.contracts.UseVisualStyleBackColor = true;
            this.contracts.Click += new System.EventHandler(this.contracts_Click);
            // 
            // sales
            // 
            this.sales.Location = new System.Drawing.Point(308, 164);
            this.sales.Name = "sales";
            this.sales.Size = new System.Drawing.Size(200, 70);
            this.sales.TabIndex = 4;
            this.sales.Text = "Продажи";
            this.sales.UseVisualStyleBackColor = true;
            this.sales.Click += new System.EventHandler(this.sales_Click);
            // 
            // sale_item
            // 
            this.sale_item.Location = new System.Drawing.Point(561, 164);
            this.sale_item.Name = "sale_item";
            this.sale_item.Size = new System.Drawing.Size(200, 70);
            this.sale_item.TabIndex = 5;
            this.sale_item.Text = "Детали продаж";
            this.sale_item.UseVisualStyleBackColor = true;
            this.sale_item.Click += new System.EventHandler(this.sale_item_Click);
            // 
            // report
            // 
            this.report.Location = new System.Drawing.Point(308, 281);
            this.report.Name = "report";
            this.report.Size = new System.Drawing.Size(200, 70);
            this.report.TabIndex = 6;
            this.report.Text = "Отчет";
            this.report.UseVisualStyleBackColor = true;
            this.report.Click += new System.EventHandler(this.report_Click);
            // 
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 420);
            this.Controls.Add(this.report);
            this.Controls.Add(this.sale_item);
            this.Controls.Add(this.sales);
            this.Controls.Add(this.contracts);
            this.Controls.Add(this.products);
            this.Controls.Add(this.services);
            this.Controls.Add(this.client);
            this.Name = "ManagerForm";
            this.Text = "Рабочая область";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button client;
        private System.Windows.Forms.Button services;
        private System.Windows.Forms.Button products;
        private System.Windows.Forms.Button contracts;
        private System.Windows.Forms.Button sales;
        private System.Windows.Forms.Button sale_item;
        private System.Windows.Forms.Button report;
    }
}