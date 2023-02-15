
namespace new_supermarket
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1side = new System.Windows.Forms.Panel();
            this.panelsubsetting = new System.Windows.Forms.Panel();
            this.btnStore = new System.Windows.Forms.Button();
            this.btnUser = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnSetting = new System.Windows.Forms.Button();
            this.panelsubrecord = new System.Windows.Forms.Panel();
            this.button11 = new System.Windows.Forms.Button();
            this.btnPOSRecord = new System.Windows.Forms.Button();
            this.btnSale_History = new System.Windows.Forms.Button();
            this.btnRecord = new System.Windows.Forms.Button();
            this.btnSupplier = new System.Windows.Forms.Button();
            this.panelsubstock = new System.Windows.Forms.Panel();
            this.btnStock_Adjustment = new System.Windows.Forms.Button();
            this.btnStock_Entry = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnInStock = new System.Windows.Forms.Button();
            this.panel1subproduct = new System.Windows.Forms.Panel();
            this.btnBrand = new System.Windows.Forms.Button();
            this.btnCategory = new System.Windows.Forms.Button();
            this.btnProductList = new System.Windows.Forms.Button();
            this.btnProduct = new System.Windows.Forms.Button();
            this.btnDashboaed = new System.Windows.Forms.Button();
            this.panellogo = new System.Windows.Forms.Panel();
            this.lbname = new System.Windows.Forms.Label();
            this.UserName = new System.Windows.Forms.Label();
            this.Admin = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1tital = new System.Windows.Forms.Panel();
            this.lbtitle = new System.Windows.Forms.Label();
            this.panel1main = new System.Windows.Forms.Panel();
            this.panel1side.SuspendLayout();
            this.panelsubsetting.SuspendLayout();
            this.panelsubrecord.SuspendLayout();
            this.panelsubstock.SuspendLayout();
            this.panel1subproduct.SuspendLayout();
            this.panellogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1tital.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1side
            // 
            this.panel1side.AutoScroll = true;
            this.panel1side.Controls.Add(this.panelsubsetting);
            this.panel1side.Controls.Add(this.btnLogout);
            this.panel1side.Controls.Add(this.btnSetting);
            this.panel1side.Controls.Add(this.panelsubrecord);
            this.panel1side.Controls.Add(this.btnRecord);
            this.panel1side.Controls.Add(this.btnSupplier);
            this.panel1side.Controls.Add(this.panelsubstock);
            this.panel1side.Controls.Add(this.flowLayoutPanel1);
            this.panel1side.Controls.Add(this.btnInStock);
            this.panel1side.Controls.Add(this.panel1subproduct);
            this.panel1side.Controls.Add(this.btnProduct);
            this.panel1side.Controls.Add(this.btnDashboaed);
            this.panel1side.Controls.Add(this.panellogo);
            this.panel1side.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1side.Location = new System.Drawing.Point(0, 0);
            this.panel1side.Name = "panel1side";
            this.panel1side.Size = new System.Drawing.Size(200, 605);
            this.panel1side.TabIndex = 0;
            this.panel1side.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1logo_Paint);
            // 
            // panelsubsetting
            // 
            this.panelsubsetting.Controls.Add(this.btnStore);
            this.panelsubsetting.Controls.Add(this.btnUser);
            this.panelsubsetting.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelsubsetting.Location = new System.Drawing.Point(0, 796);
            this.panelsubsetting.Name = "panelsubsetting";
            this.panelsubsetting.Size = new System.Drawing.Size(200, 82);
            this.panelsubsetting.TabIndex = 15;
            // 
            // btnStore
            // 
            this.btnStore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(70)))), ((int)(((byte)(200)))));
            this.btnStore.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStore.FlatAppearance.BorderSize = 0;
            this.btnStore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStore.ForeColor = System.Drawing.Color.White;
            this.btnStore.Location = new System.Drawing.Point(0, 45);
            this.btnStore.Name = "btnStore";
            this.btnStore.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnStore.Size = new System.Drawing.Size(200, 36);
            this.btnStore.TabIndex = 6;
            this.btnStore.Text = "Store";
            this.btnStore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStore.UseVisualStyleBackColor = false;
            this.btnStore.Click += new System.EventHandler(this.btnStore_Click);
            // 
            // btnUser
            // 
            this.btnUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(70)))), ((int)(((byte)(200)))));
            this.btnUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUser.FlatAppearance.BorderSize = 0;
            this.btnUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUser.ForeColor = System.Drawing.Color.White;
            this.btnUser.Location = new System.Drawing.Point(0, 0);
            this.btnUser.Name = "btnUser";
            this.btnUser.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnUser.Size = new System.Drawing.Size(200, 45);
            this.btnUser.TabIndex = 5;
            this.btnUser.Text = "User";
            this.btnUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUser.UseVisualStyleBackColor = false;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(70)))), ((int)(((byte)(160)))));
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(0, 878);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnLogout.Size = new System.Drawing.Size(200, 50);
            this.btnLogout.TabIndex = 14;
            this.btnLogout.Text = "Logout";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnSetting
            // 
            this.btnSetting.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSetting.FlatAppearance.BorderSize = 0;
            this.btnSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetting.ForeColor = System.Drawing.Color.White;
            this.btnSetting.Location = new System.Drawing.Point(0, 737);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnSetting.Size = new System.Drawing.Size(200, 59);
            this.btnSetting.TabIndex = 10;
            this.btnSetting.Text = "Setting";
            this.btnSetting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSetting.UseVisualStyleBackColor = true;
            this.btnSetting.Click += new System.EventHandler(this.button12_Click);
            // 
            // panelsubrecord
            // 
            this.panelsubrecord.Controls.Add(this.button11);
            this.panelsubrecord.Controls.Add(this.btnPOSRecord);
            this.panelsubrecord.Controls.Add(this.btnSale_History);
            this.panelsubrecord.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelsubrecord.Location = new System.Drawing.Point(0, 647);
            this.panelsubrecord.Name = "panelsubrecord";
            this.panelsubrecord.Size = new System.Drawing.Size(200, 90);
            this.panelsubrecord.TabIndex = 9;
            // 
            // button11
            // 
            this.button11.Dock = System.Windows.Forms.DockStyle.Top;
            this.button11.FlatAppearance.BorderSize = 0;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.ForeColor = System.Drawing.Color.White;
            this.button11.Location = new System.Drawing.Point(0, 90);
            this.button11.Name = "button11";
            this.button11.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.button11.Size = new System.Drawing.Size(200, 45);
            this.button11.TabIndex = 9;
            this.button11.Text = "Record";
            this.button11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button11.UseVisualStyleBackColor = true;
            // 
            // btnPOSRecord
            // 
            this.btnPOSRecord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(70)))), ((int)(((byte)(200)))));
            this.btnPOSRecord.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPOSRecord.FlatAppearance.BorderSize = 0;
            this.btnPOSRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPOSRecord.ForeColor = System.Drawing.Color.White;
            this.btnPOSRecord.Location = new System.Drawing.Point(0, 45);
            this.btnPOSRecord.Name = "btnPOSRecord";
            this.btnPOSRecord.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnPOSRecord.Size = new System.Drawing.Size(200, 45);
            this.btnPOSRecord.TabIndex = 6;
            this.btnPOSRecord.Text = "POS Record";
            this.btnPOSRecord.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPOSRecord.UseVisualStyleBackColor = false;
            this.btnPOSRecord.Click += new System.EventHandler(this.button9_Click);
            // 
            // btnSale_History
            // 
            this.btnSale_History.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(70)))), ((int)(((byte)(200)))));
            this.btnSale_History.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSale_History.FlatAppearance.BorderSize = 0;
            this.btnSale_History.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSale_History.ForeColor = System.Drawing.Color.White;
            this.btnSale_History.Location = new System.Drawing.Point(0, 0);
            this.btnSale_History.Name = "btnSale_History";
            this.btnSale_History.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnSale_History.Size = new System.Drawing.Size(200, 45);
            this.btnSale_History.TabIndex = 5;
            this.btnSale_History.Text = "Sale History";
            this.btnSale_History.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSale_History.UseVisualStyleBackColor = false;
            this.btnSale_History.Click += new System.EventHandler(this.button10_Click);
            // 
            // btnRecord
            // 
            this.btnRecord.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRecord.FlatAppearance.BorderSize = 0;
            this.btnRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecord.ForeColor = System.Drawing.Color.White;
            this.btnRecord.Location = new System.Drawing.Point(0, 602);
            this.btnRecord.Name = "btnRecord";
            this.btnRecord.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnRecord.Size = new System.Drawing.Size(200, 45);
            this.btnRecord.TabIndex = 8;
            this.btnRecord.Text = "Record";
            this.btnRecord.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRecord.UseVisualStyleBackColor = true;
            this.btnRecord.Click += new System.EventHandler(this.button8_Click);
            // 
            // btnSupplier
            // 
            this.btnSupplier.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSupplier.FlatAppearance.BorderSize = 0;
            this.btnSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupplier.ForeColor = System.Drawing.Color.White;
            this.btnSupplier.Location = new System.Drawing.Point(0, 557);
            this.btnSupplier.Name = "btnSupplier";
            this.btnSupplier.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnSupplier.Size = new System.Drawing.Size(200, 45);
            this.btnSupplier.TabIndex = 7;
            this.btnSupplier.Text = "Supplier";
            this.btnSupplier.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSupplier.UseVisualStyleBackColor = true;
            this.btnSupplier.Click += new System.EventHandler(this.button7_Click);
            // 
            // panelsubstock
            // 
            this.panelsubstock.Controls.Add(this.btnStock_Adjustment);
            this.panelsubstock.Controls.Add(this.btnStock_Entry);
            this.panelsubstock.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelsubstock.Location = new System.Drawing.Point(0, 467);
            this.panelsubstock.Name = "panelsubstock";
            this.panelsubstock.Size = new System.Drawing.Size(200, 90);
            this.panelsubstock.TabIndex = 6;
            // 
            // btnStock_Adjustment
            // 
            this.btnStock_Adjustment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(70)))), ((int)(((byte)(200)))));
            this.btnStock_Adjustment.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStock_Adjustment.FlatAppearance.BorderSize = 0;
            this.btnStock_Adjustment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStock_Adjustment.ForeColor = System.Drawing.Color.White;
            this.btnStock_Adjustment.Location = new System.Drawing.Point(0, 45);
            this.btnStock_Adjustment.Name = "btnStock_Adjustment";
            this.btnStock_Adjustment.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnStock_Adjustment.Size = new System.Drawing.Size(200, 45);
            this.btnStock_Adjustment.TabIndex = 6;
            this.btnStock_Adjustment.Text = "Stock Ajustment";
            this.btnStock_Adjustment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStock_Adjustment.UseVisualStyleBackColor = false;
            this.btnStock_Adjustment.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnStock_Entry
            // 
            this.btnStock_Entry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(70)))), ((int)(((byte)(200)))));
            this.btnStock_Entry.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStock_Entry.FlatAppearance.BorderSize = 0;
            this.btnStock_Entry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStock_Entry.ForeColor = System.Drawing.Color.White;
            this.btnStock_Entry.Location = new System.Drawing.Point(0, 0);
            this.btnStock_Entry.Name = "btnStock_Entry";
            this.btnStock_Entry.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnStock_Entry.Size = new System.Drawing.Size(200, 45);
            this.btnStock_Entry.TabIndex = 5;
            this.btnStock_Entry.Text = " Stock Entry";
            this.btnStock_Entry.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStock_Entry.UseVisualStyleBackColor = false;
            this.btnStock_Entry.Click += new System.EventHandler(this.btnStock_Entry_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 15);
            this.flowLayoutPanel1.TabIndex = 5;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // btnInStock
            // 
            this.btnInStock.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInStock.FlatAppearance.BorderSize = 0;
            this.btnInStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInStock.ForeColor = System.Drawing.Color.White;
            this.btnInStock.Location = new System.Drawing.Point(0, 422);
            this.btnInStock.Name = "btnInStock";
            this.btnInStock.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnInStock.Size = new System.Drawing.Size(200, 45);
            this.btnInStock.TabIndex = 4;
            this.btnInStock.Text = "In Stock";
            this.btnInStock.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInStock.UseVisualStyleBackColor = true;
            this.btnInStock.Click += new System.EventHandler(this.btnIn_Stock_Click);
            // 
            // panel1subproduct
            // 
            this.panel1subproduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(70)))), ((int)(((byte)(200)))));
            this.panel1subproduct.Controls.Add(this.btnBrand);
            this.panel1subproduct.Controls.Add(this.btnCategory);
            this.panel1subproduct.Controls.Add(this.btnProductList);
            this.panel1subproduct.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1subproduct.Location = new System.Drawing.Point(0, 287);
            this.panel1subproduct.Name = "panel1subproduct";
            this.panel1subproduct.Size = new System.Drawing.Size(200, 135);
            this.panel1subproduct.TabIndex = 3;
            // 
            // btnBrand
            // 
            this.btnBrand.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBrand.FlatAppearance.BorderSize = 0;
            this.btnBrand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrand.ForeColor = System.Drawing.Color.White;
            this.btnBrand.Location = new System.Drawing.Point(0, 90);
            this.btnBrand.Name = "btnBrand";
            this.btnBrand.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnBrand.Size = new System.Drawing.Size(200, 45);
            this.btnBrand.TabIndex = 5;
            this.btnBrand.Text = "Brand";
            this.btnBrand.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBrand.UseVisualStyleBackColor = true;
            this.btnBrand.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnCategory
            // 
            this.btnCategory.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCategory.FlatAppearance.BorderSize = 0;
            this.btnCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategory.ForeColor = System.Drawing.Color.White;
            this.btnCategory.Location = new System.Drawing.Point(0, 45);
            this.btnCategory.Name = "btnCategory";
            this.btnCategory.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnCategory.Size = new System.Drawing.Size(200, 45);
            this.btnCategory.TabIndex = 4;
            this.btnCategory.Text = "Category";
            this.btnCategory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCategory.UseVisualStyleBackColor = true;
            this.btnCategory.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnProductList
            // 
            this.btnProductList.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProductList.FlatAppearance.BorderSize = 0;
            this.btnProductList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductList.ForeColor = System.Drawing.Color.White;
            this.btnProductList.Location = new System.Drawing.Point(0, 0);
            this.btnProductList.Name = "btnProductList";
            this.btnProductList.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnProductList.Size = new System.Drawing.Size(200, 45);
            this.btnProductList.TabIndex = 3;
            this.btnProductList.Text = "Product List";
            this.btnProductList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProductList.UseVisualStyleBackColor = true;
            this.btnProductList.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnProduct
            // 
            this.btnProduct.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProduct.FlatAppearance.BorderSize = 0;
            this.btnProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProduct.ForeColor = System.Drawing.Color.White;
            this.btnProduct.Location = new System.Drawing.Point(0, 242);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnProduct.Size = new System.Drawing.Size(200, 45);
            this.btnProduct.TabIndex = 2;
            this.btnProduct.Text = "Product";
            this.btnProduct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProduct.UseVisualStyleBackColor = true;
            this.btnProduct.Click += new System.EventHandler(this.btnproduct_Click);
            // 
            // btnDashboaed
            // 
            this.btnDashboaed.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboaed.FlatAppearance.BorderSize = 0;
            this.btnDashboaed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboaed.ForeColor = System.Drawing.Color.White;
            this.btnDashboaed.Location = new System.Drawing.Point(0, 197);
            this.btnDashboaed.Name = "btnDashboaed";
            this.btnDashboaed.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnDashboaed.Size = new System.Drawing.Size(200, 45);
            this.btnDashboaed.TabIndex = 1;
            this.btnDashboaed.Text = "Dashboard";
            this.btnDashboaed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboaed.UseVisualStyleBackColor = true;
            this.btnDashboaed.Click += new System.EventHandler(this.btndashboaed_Click);
            // 
            // panellogo
            // 
            this.panellogo.Controls.Add(this.lbname);
            this.panellogo.Controls.Add(this.UserName);
            this.panellogo.Controls.Add(this.Admin);
            this.panellogo.Controls.Add(this.pictureBox1);
            this.panellogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panellogo.Location = new System.Drawing.Point(0, 0);
            this.panellogo.Name = "panellogo";
            this.panellogo.Size = new System.Drawing.Size(200, 197);
            this.panellogo.TabIndex = 0;
            this.panellogo.Paint += new System.Windows.Forms.PaintEventHandler(this.panellogo_Paint);
            // 
            // lbname
            // 
            this.lbname.AutoSize = true;
            this.lbname.ForeColor = System.Drawing.Color.White;
            this.lbname.Location = new System.Drawing.Point(3, 99);
            this.lbname.Name = "lbname";
            this.lbname.Size = new System.Drawing.Size(27, 20);
            this.lbname.TabIndex = 3;
            this.lbname.Text = "LN";
            this.lbname.Visible = false;
            // 
            // UserName
            // 
            this.UserName.AutoSize = true;
            this.UserName.ForeColor = System.Drawing.Color.White;
            this.UserName.Location = new System.Drawing.Point(55, 123);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(85, 20);
            this.UserName.TabIndex = 2;
            this.UserName.Text = "UserName";
            // 
            // Admin
            // 
            this.Admin.AutoSize = true;
            this.Admin.ForeColor = System.Drawing.Color.White;
            this.Admin.Location = new System.Drawing.Point(45, 163);
            this.Admin.Name = "Admin";
            this.Admin.Size = new System.Drawing.Size(104, 20);
            this.Admin.TabIndex = 1;
            this.Admin.Text = "Administrator";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(59, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 75);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1tital
            // 
            this.panel1tital.Controls.Add(this.lbtitle);
            this.panel1tital.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1tital.Location = new System.Drawing.Point(200, 0);
            this.panel1tital.Name = "panel1tital";
            this.panel1tital.Size = new System.Drawing.Size(984, 40);
            this.panel1tital.TabIndex = 1;
            this.panel1tital.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1tital_Paint);
            // 
            // lbtitle
            // 
            this.lbtitle.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtitle.ForeColor = System.Drawing.Color.White;
            this.lbtitle.Location = new System.Drawing.Point(199, 10);
            this.lbtitle.Name = "lbtitle";
            this.lbtitle.Size = new System.Drawing.Size(512, 20);
            this.lbtitle.TabIndex = 3;
            this.lbtitle.Text = "GOOD CHOICE";
            this.lbtitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbtitle.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel1main
            // 
            this.panel1main.BackColor = System.Drawing.Color.White;
            this.panel1main.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1main.BackgroundImage")));
            this.panel1main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1main.Location = new System.Drawing.Point(200, 40);
            this.panel1main.Name = "panel1main";
            this.panel1main.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.panel1main.Size = new System.Drawing.Size(984, 565);
            this.panel1main.TabIndex = 2;
            this.panel1main.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1main_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(70)))), ((int)(((byte)(160)))));
            this.ClientSize = new System.Drawing.Size(1184, 605);
            this.Controls.Add(this.panel1main);
            this.Controls.Add(this.panel1tital);
            this.Controls.Add(this.panel1side);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "point of sale";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1side.ResumeLayout(false);
            this.panelsubsetting.ResumeLayout(false);
            this.panelsubrecord.ResumeLayout(false);
            this.panelsubstock.ResumeLayout(false);
            this.panel1subproduct.ResumeLayout(false);
            this.panellogo.ResumeLayout(false);
            this.panellogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1tital.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1side;
        private System.Windows.Forms.Panel panellogo;
        private System.Windows.Forms.Panel panel1tital;
        private System.Windows.Forms.Panel panel1main;
        private System.Windows.Forms.Button btnDashboaed;
        private System.Windows.Forms.Panel panel1subproduct;
        private System.Windows.Forms.Button btnBrand;
        private System.Windows.Forms.Button btnCategory;
        private System.Windows.Forms.Button btnProductList;
        private System.Windows.Forms.Button btnProduct;
        private System.Windows.Forms.Panel panelsubstock;
        private System.Windows.Forms.Button btnStock_Adjustment;
        private System.Windows.Forms.Button btnStock_Entry;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnInStock;
        private System.Windows.Forms.Button btnRecord;
        private System.Windows.Forms.Button btnSupplier;
        private System.Windows.Forms.Panel panelsubrecord;
        private System.Windows.Forms.Button btnPOSRecord;
        private System.Windows.Forms.Button btnSale_History;
        private System.Windows.Forms.Button btnSetting;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Label UserName;
        private System.Windows.Forms.Label Admin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbname;
        private System.Windows.Forms.Label lbtitle;
        private System.Windows.Forms.Panel panelsubsetting;
        private System.Windows.Forms.Button btnStore;
        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.Button btnLogout;
    }
}

