namespace NorthwndEntityApp
{
    partial class Default
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Default));
            this.dgv_list = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.seçeneklerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menüToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_categories = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_products = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_suppliers = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_customers = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_employees = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_orders = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_regions = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_shippers = new System.Windows.Forms.ToolStripMenuItem();
            this.tSS_categories = new System.Windows.Forms.ToolStripSeparator();
            this.tSS_products = new System.Windows.Forms.ToolStripSeparator();
            this.tSS_suppliers = new System.Windows.Forms.ToolStripSeparator();
            this.tSS_customers = new System.Windows.Forms.ToolStripSeparator();
            this.tSS_employees = new System.Windows.Forms.ToolStripSeparator();
            this.tSS_orders = new System.Windows.Forms.ToolStripSeparator();
            this.tSS_regions = new System.Windows.Forms.ToolStripSeparator();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_list)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_list
            // 
            this.dgv_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_list.Location = new System.Drawing.Point(2, 31);
            this.dgv_list.Name = "dgv_list";
            this.dgv_list.RowHeadersWidth = 51;
            this.dgv_list.RowTemplate.Height = 24;
            this.dgv_list.Size = new System.Drawing.Size(1318, 578);
            this.dgv_list.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.seçeneklerToolStripMenuItem,
            this.menüToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1323, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // seçeneklerToolStripMenuItem
            // 
            this.seçeneklerToolStripMenuItem.Name = "seçeneklerToolStripMenuItem";
            this.seçeneklerToolStripMenuItem.Size = new System.Drawing.Size(94, 24);
            this.seçeneklerToolStripMenuItem.Text = "Seçenekler";
            // 
            // menüToolStripMenuItem
            // 
            this.menüToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_categories,
            this.tSS_categories,
            this.TSMI_products,
            this.tSS_products,
            this.TSMI_suppliers,
            this.tSS_suppliers,
            this.TSMI_customers,
            this.tSS_customers,
            this.TSMI_employees,
            this.tSS_employees,
            this.TSMI_orders,
            this.tSS_orders,
            this.TSMI_regions,
            this.tSS_regions,
            this.TSMI_shippers});
            this.menüToolStripMenuItem.Name = "menüToolStripMenuItem";
            this.menüToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.menüToolStripMenuItem.Text = "Menü";
            // 
            // TSMI_categories
            // 
            this.TSMI_categories.Image = ((System.Drawing.Image)(resources.GetObject("TSMI_categories.Image")));
            this.TSMI_categories.Name = "TSMI_categories";
            this.TSMI_categories.Size = new System.Drawing.Size(224, 26);
            this.TSMI_categories.Text = "Kategoriler";
            this.TSMI_categories.Click += new System.EventHandler(this.TSMI_categories_Click);
            // 
            // TSMI_products
            // 
            this.TSMI_products.Image = ((System.Drawing.Image)(resources.GetObject("TSMI_products.Image")));
            this.TSMI_products.Name = "TSMI_products";
            this.TSMI_products.Size = new System.Drawing.Size(224, 26);
            this.TSMI_products.Text = "Ürünler";
            this.TSMI_products.Click += new System.EventHandler(this.TSMI_products_Click);
            // 
            // TSMI_suppliers
            // 
            this.TSMI_suppliers.Image = ((System.Drawing.Image)(resources.GetObject("TSMI_suppliers.Image")));
            this.TSMI_suppliers.Name = "TSMI_suppliers";
            this.TSMI_suppliers.Size = new System.Drawing.Size(224, 26);
            this.TSMI_suppliers.Text = "Tedarikçiler";
            this.TSMI_suppliers.Click += new System.EventHandler(this.TSMI_suppliers_Click);
            // 
            // TSMI_customers
            // 
            this.TSMI_customers.Image = ((System.Drawing.Image)(resources.GetObject("TSMI_customers.Image")));
            this.TSMI_customers.Name = "TSMI_customers";
            this.TSMI_customers.Size = new System.Drawing.Size(224, 26);
            this.TSMI_customers.Text = "Müşteriler";
            this.TSMI_customers.Click += new System.EventHandler(this.TSMI_customers_Click);
            // 
            // TSMI_employees
            // 
            this.TSMI_employees.Image = ((System.Drawing.Image)(resources.GetObject("TSMI_employees.Image")));
            this.TSMI_employees.Name = "TSMI_employees";
            this.TSMI_employees.Size = new System.Drawing.Size(224, 26);
            this.TSMI_employees.Text = "Çalışanlar";
            this.TSMI_employees.Click += new System.EventHandler(this.TSMI_employees_Click);
            // 
            // TSMI_orders
            // 
            this.TSMI_orders.Image = ((System.Drawing.Image)(resources.GetObject("TSMI_orders.Image")));
            this.TSMI_orders.Name = "TSMI_orders";
            this.TSMI_orders.Size = new System.Drawing.Size(224, 26);
            this.TSMI_orders.Text = "Siparişler";
            this.TSMI_orders.Click += new System.EventHandler(this.TSMI_orders_Click);
            // 
            // TSMI_regions
            // 
            this.TSMI_regions.Image = ((System.Drawing.Image)(resources.GetObject("TSMI_regions.Image")));
            this.TSMI_regions.Name = "TSMI_regions";
            this.TSMI_regions.Size = new System.Drawing.Size(224, 26);
            this.TSMI_regions.Text = "Bölgeler";
            this.TSMI_regions.Click += new System.EventHandler(this.TSMI_regions_Click);
            // 
            // TSMI_shippers
            // 
            this.TSMI_shippers.Image = ((System.Drawing.Image)(resources.GetObject("TSMI_shippers.Image")));
            this.TSMI_shippers.Name = "TSMI_shippers";
            this.TSMI_shippers.Size = new System.Drawing.Size(224, 26);
            this.TSMI_shippers.Text = "Nakliyatçılar";
            this.TSMI_shippers.Click += new System.EventHandler(this.TSMI_shippers_Click);
            // 
            // tSS_categories
            // 
            this.tSS_categories.Name = "tSS_categories";
            this.tSS_categories.Size = new System.Drawing.Size(221, 6);
            // 
            // tSS_products
            // 
            this.tSS_products.Name = "tSS_products";
            this.tSS_products.Size = new System.Drawing.Size(221, 6);
            // 
            // tSS_suppliers
            // 
            this.tSS_suppliers.Name = "tSS_suppliers";
            this.tSS_suppliers.Size = new System.Drawing.Size(221, 6);
            // 
            // tSS_customers
            // 
            this.tSS_customers.Name = "tSS_customers";
            this.tSS_customers.Size = new System.Drawing.Size(221, 6);
            // 
            // tSS_employees
            // 
            this.tSS_employees.Name = "tSS_employees";
            this.tSS_employees.Size = new System.Drawing.Size(221, 6);
            // 
            // tSS_orders
            // 
            this.tSS_orders.Name = "tSS_orders";
            this.tSS_orders.Size = new System.Drawing.Size(221, 6);
            // 
            // tSS_regions
            // 
            this.tSS_regions.Name = "tSS_regions";
            this.tSS_regions.Size = new System.Drawing.Size(221, 6);
            // 
            // Default
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1323, 636);
            this.Controls.Add(this.dgv_list);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(1341, 683);
            this.MinimumSize = new System.Drawing.Size(1341, 683);
            this.Name = "Default";
            this.Text = "NORTHWND";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_list)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_list;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem seçeneklerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menüToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TSMI_categories;
        private System.Windows.Forms.ToolStripSeparator tSS_categories;
        private System.Windows.Forms.ToolStripMenuItem TSMI_products;
        private System.Windows.Forms.ToolStripSeparator tSS_products;
        private System.Windows.Forms.ToolStripMenuItem TSMI_suppliers;
        private System.Windows.Forms.ToolStripSeparator tSS_suppliers;
        private System.Windows.Forms.ToolStripMenuItem TSMI_customers;
        private System.Windows.Forms.ToolStripSeparator tSS_customers;
        private System.Windows.Forms.ToolStripMenuItem TSMI_employees;
        private System.Windows.Forms.ToolStripSeparator tSS_employees;
        private System.Windows.Forms.ToolStripMenuItem TSMI_orders;
        private System.Windows.Forms.ToolStripSeparator tSS_orders;
        private System.Windows.Forms.ToolStripMenuItem TSMI_regions;
        private System.Windows.Forms.ToolStripSeparator tSS_regions;
        private System.Windows.Forms.ToolStripMenuItem TSMI_shippers;
    }
}