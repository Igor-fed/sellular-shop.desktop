namespace sellular_shop
{
    partial class AdminPanel
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
            this.changePass = new System.Windows.Forms.Button();
            this.btnEmployees = new System.Windows.Forms.Button();
            this.btnClients = new System.Windows.Forms.Button();
            this.btnServices = new System.Windows.Forms.Button();
            this.sales = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.category = new System.Windows.Forms.Button();
            this.vw_average_receipt_monthly = new System.Windows.Forms.Button();
            this.vw_daily_sales = new System.Windows.Forms.Button();
            this.vw_product_revenue = new System.Windows.Forms.Button();
            this.vw_service_revenue = new System.Windows.Forms.Button();
            this.vw_sales_by_employee = new System.Windows.Forms.Button();
            this.vw_sales_services = new System.Windows.Forms.Button();
            this.vw_sales_products = new System.Windows.Forms.Button();
            this.vwreport = new System.Windows.Forms.Button();
            this.products = new System.Windows.Forms.Button();
            this.contracts = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // changePass
            // 
            this.changePass.Location = new System.Drawing.Point(423, 391);
            this.changePass.Name = "changePass";
            this.changePass.Size = new System.Drawing.Size(186, 60);
            this.changePass.TabIndex = 0;
            this.changePass.Text = "Изменение пароля";
            this.changePass.UseVisualStyleBackColor = true;
            this.changePass.Click += new System.EventHandler(this.btnChangePass_Click);
            // 
            // btnEmployees
            // 
            this.btnEmployees.Location = new System.Drawing.Point(60, 61);
            this.btnEmployees.Name = "btnEmployees";
            this.btnEmployees.Size = new System.Drawing.Size(186, 60);
            this.btnEmployees.TabIndex = 1;
            this.btnEmployees.Text = "Сотрудники";
            this.btnEmployees.UseVisualStyleBackColor = true;
            this.btnEmployees.Click += new System.EventHandler(this.btnEmployees_Click);
            // 
            // btnClients
            // 
            this.btnClients.Location = new System.Drawing.Point(60, 127);
            this.btnClients.Name = "btnClients";
            this.btnClients.Size = new System.Drawing.Size(186, 60);
            this.btnClients.TabIndex = 2;
            this.btnClients.Text = "Клиенты";
            this.btnClients.UseVisualStyleBackColor = true;
            this.btnClients.Click += new System.EventHandler(this.btnClients_Click);
            // 
            // btnServices
            // 
            this.btnServices.Location = new System.Drawing.Point(60, 193);
            this.btnServices.Name = "btnServices";
            this.btnServices.Size = new System.Drawing.Size(186, 60);
            this.btnServices.TabIndex = 3;
            this.btnServices.Text = "Услуги";
            this.btnServices.UseVisualStyleBackColor = true;
            this.btnServices.Click += new System.EventHandler(this.btnServices_Click);
            // 
            // sales
            // 
            this.sales.Location = new System.Drawing.Point(300, 127);
            this.sales.Name = "sales";
            this.sales.Size = new System.Drawing.Size(186, 60);
            this.sales.TabIndex = 4;
            this.sales.Text = "Продажи";
            this.sales.UseVisualStyleBackColor = true;
            this.sales.Click += new System.EventHandler(this.sales_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(300, 193);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(186, 60);
            this.button2.TabIndex = 5;
            this.button2.Text = "Детали продаж";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            // 
            // category
            // 
            this.category.Location = new System.Drawing.Point(60, 259);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(186, 60);
            this.category.TabIndex = 6;
            this.category.Text = "Категории товаров";
            this.category.UseVisualStyleBackColor = true;
            this.category.Click += new System.EventHandler(this.category_Click);
            // 
            // vw_average_receipt_monthly
            // 
            this.vw_average_receipt_monthly.Location = new System.Drawing.Point(300, 259);
            this.vw_average_receipt_monthly.Name = "vw_average_receipt_monthly";
            this.vw_average_receipt_monthly.Size = new System.Drawing.Size(186, 60);
            this.vw_average_receipt_monthly.TabIndex = 7;
            this.vw_average_receipt_monthly.Text = "Средний ежемесячный чек";
            this.vw_average_receipt_monthly.UseVisualStyleBackColor = true;
            this.vw_average_receipt_monthly.Click += new System.EventHandler(this.vw_average_receipt_monthly_Click);
            // 
            // vw_daily_sales
            // 
            this.vw_daily_sales.Location = new System.Drawing.Point(300, 325);
            this.vw_daily_sales.Name = "vw_daily_sales";
            this.vw_daily_sales.Size = new System.Drawing.Size(186, 60);
            this.vw_daily_sales.TabIndex = 8;
            this.vw_daily_sales.Text = "Ежедневные продажи";
            this.vw_daily_sales.UseVisualStyleBackColor = true;
            this.vw_daily_sales.Click += new System.EventHandler(this.vw_daily_sales_Click);
            // 
            // vw_product_revenue
            // 
            this.vw_product_revenue.Location = new System.Drawing.Point(539, 61);
            this.vw_product_revenue.Name = "vw_product_revenue";
            this.vw_product_revenue.Size = new System.Drawing.Size(186, 60);
            this.vw_product_revenue.TabIndex = 9;
            this.vw_product_revenue.Text = "Выручка с реализации товаров";
            this.vw_product_revenue.UseVisualStyleBackColor = true;
            this.vw_product_revenue.Click += new System.EventHandler(this.vw_product_revenue_Click);
            // 
            // vw_service_revenue
            // 
            this.vw_service_revenue.Location = new System.Drawing.Point(539, 127);
            this.vw_service_revenue.Name = "vw_service_revenue";
            this.vw_service_revenue.Size = new System.Drawing.Size(186, 60);
            this.vw_service_revenue.TabIndex = 10;
            this.vw_service_revenue.Text = "Выручка с реализации услуг";
            this.vw_service_revenue.UseVisualStyleBackColor = true;
            this.vw_service_revenue.Click += new System.EventHandler(this.vw_service_revenue_Click);
            // 
            // vw_sales_by_employee
            // 
            this.vw_sales_by_employee.Location = new System.Drawing.Point(539, 193);
            this.vw_sales_by_employee.Name = "vw_sales_by_employee";
            this.vw_sales_by_employee.Size = new System.Drawing.Size(186, 60);
            this.vw_sales_by_employee.TabIndex = 11;
            this.vw_sales_by_employee.Text = "KPI сотрудников";
            this.vw_sales_by_employee.UseVisualStyleBackColor = true;
            this.vw_sales_by_employee.Click += new System.EventHandler(this.vw_sales_by_employee_Click);
            // 
            // vw_sales_services
            // 
            this.vw_sales_services.Location = new System.Drawing.Point(539, 259);
            this.vw_sales_services.Name = "vw_sales_services";
            this.vw_sales_services.Size = new System.Drawing.Size(186, 60);
            this.vw_sales_services.TabIndex = 12;
            this.vw_sales_services.Text = "Продажи услуг";
            this.vw_sales_services.UseVisualStyleBackColor = true;
            this.vw_sales_services.Click += new System.EventHandler(this.vw_sales_services_Click);
            // 
            // vw_sales_products
            // 
            this.vw_sales_products.Location = new System.Drawing.Point(539, 325);
            this.vw_sales_products.Name = "vw_sales_products";
            this.vw_sales_products.Size = new System.Drawing.Size(186, 60);
            this.vw_sales_products.TabIndex = 13;
            this.vw_sales_products.Text = "Продажи товаров";
            this.vw_sales_products.UseVisualStyleBackColor = true;
            this.vw_sales_products.Click += new System.EventHandler(this.vw_sales_products_Click);
            // 
            // vwreport
            // 
            this.vwreport.Location = new System.Drawing.Point(175, 391);
            this.vwreport.Name = "vwreport";
            this.vwreport.Size = new System.Drawing.Size(186, 60);
            this.vwreport.TabIndex = 14;
            this.vwreport.Text = "Отчет";
            this.vwreport.UseVisualStyleBackColor = true;
            this.vwreport.Click += new System.EventHandler(this.vwreport_Click);
            // 
            // products
            // 
            this.products.Location = new System.Drawing.Point(60, 325);
            this.products.Name = "products";
            this.products.Size = new System.Drawing.Size(186, 60);
            this.products.TabIndex = 15;
            this.products.Text = "Товары";
            this.products.UseVisualStyleBackColor = true;
            this.products.Click += new System.EventHandler(this.products_Click);
            // 
            // contracts
            // 
            this.contracts.Location = new System.Drawing.Point(300, 61);
            this.contracts.Name = "contracts";
            this.contracts.Size = new System.Drawing.Size(186, 60);
            this.contracts.TabIndex = 16;
            this.contracts.Text = "Договора";
            this.contracts.UseVisualStyleBackColor = true;
            this.contracts.Click += new System.EventHandler(this.contracts_Click);
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 503);
            this.Controls.Add(this.contracts);
            this.Controls.Add(this.products);
            this.Controls.Add(this.vwreport);
            this.Controls.Add(this.vw_sales_products);
            this.Controls.Add(this.vw_sales_services);
            this.Controls.Add(this.vw_sales_by_employee);
            this.Controls.Add(this.vw_service_revenue);
            this.Controls.Add(this.vw_product_revenue);
            this.Controls.Add(this.vw_daily_sales);
            this.Controls.Add(this.vw_average_receipt_monthly);
            this.Controls.Add(this.category);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.sales);
            this.Controls.Add(this.btnServices);
            this.Controls.Add(this.btnClients);
            this.Controls.Add(this.btnEmployees);
            this.Controls.Add(this.changePass);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdminPanel";
            this.Text = "Панель администратора";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button changePass;
        private System.Windows.Forms.Button btnEmployees;
        private System.Windows.Forms.Button btnClients;
        private System.Windows.Forms.Button btnServices;
        private System.Windows.Forms.Button sales;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button category;
        private System.Windows.Forms.Button vw_average_receipt_monthly;
        private System.Windows.Forms.Button vw_daily_sales;
        private System.Windows.Forms.Button vw_product_revenue;
        private System.Windows.Forms.Button vw_service_revenue;
        private System.Windows.Forms.Button vw_sales_by_employee;
        private System.Windows.Forms.Button vw_sales_services;
        private System.Windows.Forms.Button vw_sales_products;
        private System.Windows.Forms.Button vwreport;
        private System.Windows.Forms.Button products;
        private System.Windows.Forms.Button contracts;
    }
}