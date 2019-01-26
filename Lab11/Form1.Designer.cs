namespace Lab11
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.northwindDataSetCustomers = new Lab11.NorthwindDataSetCustomers();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.orderIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RequiredDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShippedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShipVia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Freight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShipName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShipAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShipCity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShipRegion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShipPostalCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShipCountry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.northwindDataSetOrders = new Lab11.NorthwindDataSetOrders();
            this.orderDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.northwindDataSetOrdersD = new Lab11.NorthwindDataSetOrdersD();
            this.customersTableAdapter = new Lab11.NorthwindDataSetCustomersTableAdapters.CustomersTableAdapter();
            this.northwindDataSetCustomersAllData = new Lab11.NorthwindDataSetCustomersAllData();
            this.customersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.customersTableAdapter1 = new Lab11.NorthwindDataSetCustomersAllDataTableAdapters.CustomersTableAdapter();
            this.ordersTableAdapter = new Lab11.NorthwindDataSetOrdersTableAdapters.OrdersTableAdapter();
            this.order_DetailsTableAdapter = new Lab11.NorthwindDataSetOrdersDTableAdapters.Order_DetailsTableAdapter();
            this.companyNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSetCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSetOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSetOrdersD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSetCustomersAllData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripTextBox1,
            this.toolStripLabel1,
            this.toolStripLabel2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(75, 22);
            this.toolStripButton1.Text = "show orders";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripLabel1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripLabel1.Image")));
            this.toolStripLabel1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(41, 22);
            this.toolStripLabel1.Text = "Filtrer";
            this.toolStripLabel1.Click += new System.EventHandler(this.toolStripLabel1_Click);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(40, 22);
            this.toolStripLabel2.Text = "Delete";
            this.toolStripLabel2.Click += new System.EventHandler(this.toolStripLabel2_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 25);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dataGridView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView2);
            this.splitContainer1.Size = new System.Drawing.Size(800, 425);
            this.splitContainer1.SplitterDistance = 266;
            this.splitContainer1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.companyNameDataGridViewTextBoxColumn,
            this.countryDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.customersBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(266, 425);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataMember = "Customers";
            this.customersBindingSource.DataSource = this.northwindDataSetCustomers;
            // 
            // northwindDataSetCustomers
            // 
            this.northwindDataSetCustomers.DataSetName = "NorthwindDataSetCustomers";
            this.northwindDataSetCustomers.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderIDDataGridViewTextBoxColumn,
            this.CustomerID,
            this.EmployeeID,
            this.OrderDate,
            this.RequiredDate,
            this.ShippedDate,
            this.ShipVia,
            this.Freight,
            this.ShipName,
            this.ShipAddress,
            this.ShipCity,
            this.ShipRegion,
            this.ShipPostalCode,
            this.ShipCountry});
            this.dataGridView2.DataSource = this.ordersBindingSource;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(530, 425);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.Visible = false;
            // 
            // orderIDDataGridViewTextBoxColumn
            // 
            this.orderIDDataGridViewTextBoxColumn.DataPropertyName = "OrderID";
            this.orderIDDataGridViewTextBoxColumn.HeaderText = "OrderID";
            this.orderIDDataGridViewTextBoxColumn.Name = "orderIDDataGridViewTextBoxColumn";
            // 
            // CustomerID
            // 
            this.CustomerID.DataPropertyName = "CustomerID";
            this.CustomerID.HeaderText = "CustomerID";
            this.CustomerID.Name = "CustomerID";
            // 
            // EmployeeID
            // 
            this.EmployeeID.DataPropertyName = "EmployeeID";
            this.EmployeeID.HeaderText = "EmployeeID";
            this.EmployeeID.Name = "EmployeeID";
            // 
            // OrderDate
            // 
            this.OrderDate.DataPropertyName = "OrderDate";
            this.OrderDate.HeaderText = "OrderDate";
            this.OrderDate.Name = "OrderDate";
            // 
            // RequiredDate
            // 
            this.RequiredDate.DataPropertyName = "RequiredDate";
            this.RequiredDate.HeaderText = "RequiredDate";
            this.RequiredDate.Name = "RequiredDate";
            // 
            // ShippedDate
            // 
            this.ShippedDate.DataPropertyName = "ShippedDate";
            this.ShippedDate.HeaderText = "ShippedDate";
            this.ShippedDate.Name = "ShippedDate";
            // 
            // ShipVia
            // 
            this.ShipVia.DataPropertyName = "ShipVia";
            this.ShipVia.HeaderText = "ShipVia";
            this.ShipVia.Name = "ShipVia";
            // 
            // Freight
            // 
            this.Freight.DataPropertyName = "Freight";
            this.Freight.HeaderText = "Freight";
            this.Freight.Name = "Freight";
            // 
            // ShipName
            // 
            this.ShipName.DataPropertyName = "ShipName";
            this.ShipName.HeaderText = "ShipName";
            this.ShipName.Name = "ShipName";
            // 
            // ShipAddress
            // 
            this.ShipAddress.DataPropertyName = "ShipAddress";
            this.ShipAddress.HeaderText = "ShipAddress";
            this.ShipAddress.Name = "ShipAddress";
            // 
            // ShipCity
            // 
            this.ShipCity.DataPropertyName = "ShipCity";
            this.ShipCity.HeaderText = "ShipCity";
            this.ShipCity.Name = "ShipCity";
            // 
            // ShipRegion
            // 
            this.ShipRegion.DataPropertyName = "ShipRegion";
            this.ShipRegion.HeaderText = "ShipRegion";
            this.ShipRegion.Name = "ShipRegion";
            // 
            // ShipPostalCode
            // 
            this.ShipPostalCode.DataPropertyName = "ShipPostalCode";
            this.ShipPostalCode.HeaderText = "ShipPostalCode";
            this.ShipPostalCode.Name = "ShipPostalCode";
            // 
            // ShipCountry
            // 
            this.ShipCountry.DataPropertyName = "ShipCountry";
            this.ShipCountry.HeaderText = "ShipCountry";
            this.ShipCountry.Name = "ShipCountry";
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "Orders";
            this.ordersBindingSource.DataSource = this.northwindDataSetOrders;
            // 
            // northwindDataSetOrders
            // 
            this.northwindDataSetOrders.DataSetName = "NorthwindDataSetOrders";
            this.northwindDataSetOrders.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // orderDetailsBindingSource
            // 
            this.orderDetailsBindingSource.DataMember = "Order Details";
            this.orderDetailsBindingSource.DataSource = this.northwindDataSetOrdersD;
            // 
            // northwindDataSetOrdersD
            // 
            this.northwindDataSetOrdersD.DataSetName = "NorthwindDataSetOrdersD";
            this.northwindDataSetOrdersD.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
            // 
            // northwindDataSetCustomersAllData
            // 
            this.northwindDataSetCustomersAllData.DataSetName = "NorthwindDataSetCustomersAllData";
            this.northwindDataSetCustomersAllData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customersBindingSource1
            // 
            this.customersBindingSource1.DataMember = "Customers";
            this.customersBindingSource1.DataSource = this.northwindDataSetCustomersAllData;
            // 
            // customersTableAdapter1
            // 
            this.customersTableAdapter1.ClearBeforeFill = true;
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // order_DetailsTableAdapter
            // 
            this.order_DetailsTableAdapter.ClearBeforeFill = true;
            // 
            // companyNameDataGridViewTextBoxColumn
            // 
            this.companyNameDataGridViewTextBoxColumn.DataPropertyName = "CompanyName";
            this.companyNameDataGridViewTextBoxColumn.HeaderText = "CompanyName";
            this.companyNameDataGridViewTextBoxColumn.Name = "companyNameDataGridViewTextBoxColumn";
            this.companyNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // countryDataGridViewTextBoxColumn
            // 
            this.countryDataGridViewTextBoxColumn.DataPropertyName = "Country";
            this.countryDataGridViewTextBoxColumn.HeaderText = "Country";
            this.countryDataGridViewTextBoxColumn.Name = "countryDataGridViewTextBoxColumn";
            this.countryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSetCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSetOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSetOrdersD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSetCustomersAllData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private NorthwindDataSetCustomers northwindDataSetCustomers;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private NorthwindDataSetCustomersTableAdapters.CustomersTableAdapter customersTableAdapter;
        private NorthwindDataSetCustomersAllData northwindDataSetCustomersAllData;
        private System.Windows.Forms.BindingSource customersBindingSource1;
        private NorthwindDataSetCustomersAllDataTableAdapters.CustomersTableAdapter customersTableAdapter1;
        private NorthwindDataSetOrders northwindDataSetOrders;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private NorthwindDataSetOrdersTableAdapters.OrdersTableAdapter ordersTableAdapter;
        private NorthwindDataSetOrdersD northwindDataSetOrdersD;
        private System.Windows.Forms.BindingSource orderDetailsBindingSource;
        private NorthwindDataSetOrdersDTableAdapters.Order_DetailsTableAdapter order_DetailsTableAdapter;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn RequiredDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShippedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShipVia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Freight;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShipName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShipAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShipCity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShipRegion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShipPostalCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShipCountry;
        private System.Windows.Forms.ToolStripButton toolStripLabel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countryDataGridViewTextBoxColumn;
    }
}

