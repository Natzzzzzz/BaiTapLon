namespace ExerciseOne
{
    partial class Main
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
            this.guna2TabControl1 = new Guna.UI2.WinForms.Guna2TabControl();
            this.Products = new System.Windows.Forms.TabPage();
            this.lblName = new System.Windows.Forms.Label();
            this.cbItemID = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtSize = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtItemName = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.btnAll = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.btnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.Agents = new System.Windows.Forms.TabPage();
            this.lblAgentName = new System.Windows.Forms.Label();
            this.cbAgentID = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtAddress = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtAgentName = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblAgentID = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.btnAll2 = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdate2 = new Guna.UI2.WinForms.Guna2Button();
            this.btnDelete2 = new Guna.UI2.WinForms.Guna2Button();
            this.btnAdd2 = new Guna.UI2.WinForms.Guna2Button();
            this.dgvAgents = new System.Windows.Forms.DataGridView();
            this.Orders = new System.Windows.Forms.TabPage();
            this.btnPrint = new Guna.UI2.WinForms.Guna2Button();
            this.cbOrderID = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnAll3 = new Guna.UI2.WinForms.Guna2Button();
            this.dgvOrderDetail = new System.Windows.Forms.DataGridView();
            this.dgvOrder = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.Statics = new System.Windows.Forms.TabPage();
            this.btnBestSeller = new Guna.UI2.WinForms.Guna2Button();
            this.btnBestCustomer = new Guna.UI2.WinForms.Guna2Button();
            this.dgvShowOutput = new System.Windows.Forms.DataGridView();
            this.printDialog2 = new System.Windows.Forms.PrintDialog();
            this.printDocument2 = new System.Drawing.Printing.PrintDocument();
            this.guna2TabControl1.SuspendLayout();
            this.Products.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.Agents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgents)).BeginInit();
            this.Orders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).BeginInit();
            this.Statics.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowOutput)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2TabControl1
            // 
            this.guna2TabControl1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.guna2TabControl1.Controls.Add(this.Products);
            this.guna2TabControl1.Controls.Add(this.Agents);
            this.guna2TabControl1.Controls.Add(this.Orders);
            this.guna2TabControl1.Controls.Add(this.Statics);
            this.guna2TabControl1.ItemSize = new System.Drawing.Size(180, 40);
            this.guna2TabControl1.Location = new System.Drawing.Point(-3, 1);
            this.guna2TabControl1.Name = "guna2TabControl1";
            this.guna2TabControl1.SelectedIndex = 0;
            this.guna2TabControl1.Size = new System.Drawing.Size(950, 447);
            this.guna2TabControl1.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.guna2TabControl1.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.guna2TabControl1.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.guna2TabControl1.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.guna2TabControl1.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.guna2TabControl1.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.guna2TabControl1.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.guna2TabControl1.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.guna2TabControl1.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.guna2TabControl1.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.guna2TabControl1.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.guna2TabControl1.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.guna2TabControl1.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.guna2TabControl1.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.guna2TabControl1.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.guna2TabControl1.TabButtonSize = new System.Drawing.Size(180, 40);
            this.guna2TabControl1.TabIndex = 0;
            this.guna2TabControl1.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(1)))), ((int)(((byte)(203)))));
            // 
            // Products
            // 
            this.Products.BackColor = System.Drawing.Color.White;
            this.Products.Controls.Add(this.lblName);
            this.Products.Controls.Add(this.cbItemID);
            this.Products.Controls.Add(this.txtSize);
            this.Products.Controls.Add(this.txtItemName);
            this.Products.Controls.Add(this.lblID);
            this.Products.Controls.Add(this.lblSize);
            this.Products.Controls.Add(this.btnAll);
            this.Products.Controls.Add(this.btnUpdate);
            this.Products.Controls.Add(this.btnDelete);
            this.Products.Controls.Add(this.btnAdd);
            this.Products.Controls.Add(this.dgvProducts);
            this.Products.Location = new System.Drawing.Point(184, 4);
            this.Products.Margin = new System.Windows.Forms.Padding(10);
            this.Products.Name = "Products";
            this.Products.Padding = new System.Windows.Forms.Padding(10);
            this.Products.Size = new System.Drawing.Size(762, 439);
            this.Products.TabIndex = 0;
            this.Products.Text = "Products";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblName.Location = new System.Drawing.Point(13, 9);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(62, 22);
            this.lblName.TabIndex = 61;
            this.lblName.Text = "Name:";
            // 
            // cbItemID
            // 
            this.cbItemID.BackColor = System.Drawing.Color.Transparent;
            this.cbItemID.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbItemID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbItemID.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbItemID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbItemID.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbItemID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbItemID.ItemHeight = 30;
            this.cbItemID.Location = new System.Drawing.Point(80, 108);
            this.cbItemID.Name = "cbItemID";
            this.cbItemID.Size = new System.Drawing.Size(326, 36);
            this.cbItemID.TabIndex = 60;
            this.cbItemID.SelectedIndexChanged += new System.EventHandler(this.cbItemID_SelectedIndexChanged);
            // 
            // txtSize
            // 
            this.txtSize.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSize.DefaultText = "";
            this.txtSize.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSize.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSize.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSize.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSize.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSize.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSize.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSize.Location = new System.Drawing.Point(80, 59);
            this.txtSize.Name = "txtSize";
            this.txtSize.PasswordChar = '\0';
            this.txtSize.PlaceholderText = "";
            this.txtSize.SelectedText = "";
            this.txtSize.Size = new System.Drawing.Size(326, 34);
            this.txtSize.TabIndex = 59;
            this.txtSize.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSize_KeyPress);
            // 
            // txtItemName
            // 
            this.txtItemName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtItemName.DefaultText = "";
            this.txtItemName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtItemName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtItemName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtItemName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtItemName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtItemName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtItemName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtItemName.Location = new System.Drawing.Point(80, 9);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.PasswordChar = '\0';
            this.txtItemName.PlaceholderText = "";
            this.txtItemName.SelectedText = "";
            this.txtItemName.Size = new System.Drawing.Size(326, 34);
            this.txtItemName.TabIndex = 58;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblID.Location = new System.Drawing.Point(10, 114);
            this.lblID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(65, 22);
            this.lblID.TabIndex = 57;
            this.lblID.Text = "ItemID:";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblSize.Location = new System.Drawing.Point(14, 62);
            this.lblSize.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(49, 22);
            this.lblSize.TabIndex = 56;
            this.lblSize.Text = "Size:";
            // 
            // btnAll
            // 
            this.btnAll.BorderRadius = 20;
            this.btnAll.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAll.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAll.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAll.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAll.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(1)))), ((int)(((byte)(203)))));
            this.btnAll.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.btnAll.ForeColor = System.Drawing.Color.White;
            this.btnAll.Location = new System.Drawing.Point(608, 76);
            this.btnAll.Name = "btnAll";
            this.btnAll.PressedDepth = 50;
            this.btnAll.Size = new System.Drawing.Size(144, 68);
            this.btnAll.TabIndex = 55;
            this.btnAll.Text = "Tất cả";
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BorderRadius = 20;
            this.btnUpdate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpdate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUpdate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(1)))), ((int)(((byte)(203)))));
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(435, 76);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.PressedDepth = 50;
            this.btnUpdate.Size = new System.Drawing.Size(144, 68);
            this.btnUpdate.TabIndex = 54;
            this.btnUpdate.Text = "Sửa";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BorderRadius = 20;
            this.btnDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDelete.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(1)))), ((int)(((byte)(203)))));
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(608, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.PressedDepth = 50;
            this.btnDelete.Size = new System.Drawing.Size(144, 67);
            this.btnDelete.TabIndex = 53;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BorderRadius = 20;
            this.btnAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAdd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(1)))), ((int)(((byte)(203)))));
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(435, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.PressedDepth = 50;
            this.btnAdd.Size = new System.Drawing.Size(144, 67);
            this.btnAdd.TabIndex = 52;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvProducts
            // 
            this.dgvProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Location = new System.Drawing.Point(1, 149);
            this.dgvProducts.Margin = new System.Windows.Forms.Padding(2);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.RowHeadersWidth = 51;
            this.dgvProducts.RowTemplate.Height = 24;
            this.dgvProducts.Size = new System.Drawing.Size(760, 287);
            this.dgvProducts.TabIndex = 51;
            // 
            // Agents
            // 
            this.Agents.Controls.Add(this.lblAgentName);
            this.Agents.Controls.Add(this.cbAgentID);
            this.Agents.Controls.Add(this.txtAddress);
            this.Agents.Controls.Add(this.txtAgentName);
            this.Agents.Controls.Add(this.lblAgentID);
            this.Agents.Controls.Add(this.lblAddress);
            this.Agents.Controls.Add(this.btnAll2);
            this.Agents.Controls.Add(this.btnUpdate2);
            this.Agents.Controls.Add(this.btnDelete2);
            this.Agents.Controls.Add(this.btnAdd2);
            this.Agents.Controls.Add(this.dgvAgents);
            this.Agents.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Agents.Location = new System.Drawing.Point(184, 4);
            this.Agents.Name = "Agents";
            this.Agents.Padding = new System.Windows.Forms.Padding(3);
            this.Agents.Size = new System.Drawing.Size(762, 439);
            this.Agents.TabIndex = 1;
            this.Agents.Text = "Agents";
            this.Agents.UseVisualStyleBackColor = true;
            // 
            // lblAgentName
            // 
            this.lblAgentName.AutoSize = true;
            this.lblAgentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblAgentName.Location = new System.Drawing.Point(2, 10);
            this.lblAgentName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAgentName.Name = "lblAgentName";
            this.lblAgentName.Size = new System.Drawing.Size(127, 22);
            this.lblAgentName.TabIndex = 51;
            this.lblAgentName.Text = "Agent\'s Name:";
            // 
            // cbAgentID
            // 
            this.cbAgentID.BackColor = System.Drawing.Color.Transparent;
            this.cbAgentID.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbAgentID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAgentID.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbAgentID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbAgentID.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbAgentID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbAgentID.ItemHeight = 30;
            this.cbAgentID.Location = new System.Drawing.Point(130, 106);
            this.cbAgentID.Name = "cbAgentID";
            this.cbAgentID.Size = new System.Drawing.Size(277, 36);
            this.cbAgentID.TabIndex = 50;
            this.cbAgentID.SelectedIndexChanged += new System.EventHandler(this.cbAgentID_SelectedIndexChanged);
            // 
            // txtAddress
            // 
            this.txtAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAddress.DefaultText = "";
            this.txtAddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAddress.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtAddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAddress.Location = new System.Drawing.Point(130, 64);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.PasswordChar = '\0';
            this.txtAddress.PlaceholderText = "";
            this.txtAddress.SelectedText = "";
            this.txtAddress.Size = new System.Drawing.Size(277, 34);
            this.txtAddress.TabIndex = 49;
            // 
            // txtAgentName
            // 
            this.txtAgentName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAgentName.DefaultText = "";
            this.txtAgentName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAgentName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAgentName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAgentName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAgentName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAgentName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtAgentName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAgentName.Location = new System.Drawing.Point(130, 7);
            this.txtAgentName.Name = "txtAgentName";
            this.txtAgentName.PasswordChar = '\0';
            this.txtAgentName.PlaceholderText = "";
            this.txtAgentName.SelectedText = "";
            this.txtAgentName.Size = new System.Drawing.Size(277, 34);
            this.txtAgentName.TabIndex = 48;
            // 
            // lblAgentID
            // 
            this.lblAgentID.AutoSize = true;
            this.lblAgentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblAgentID.Location = new System.Drawing.Point(2, 114);
            this.lblAgentID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAgentID.Name = "lblAgentID";
            this.lblAgentID.Size = new System.Drawing.Size(84, 22);
            this.lblAgentID.TabIndex = 47;
            this.lblAgentID.Text = "Agent ID:";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblAddress.Location = new System.Drawing.Point(2, 64);
            this.lblAddress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(81, 22);
            this.lblAddress.TabIndex = 46;
            this.lblAddress.Text = "Address:";
            // 
            // btnAll2
            // 
            this.btnAll2.BorderRadius = 20;
            this.btnAll2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAll2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAll2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAll2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAll2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(1)))), ((int)(((byte)(203)))));
            this.btnAll2.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.btnAll2.ForeColor = System.Drawing.Color.White;
            this.btnAll2.Location = new System.Drawing.Point(609, 74);
            this.btnAll2.Name = "btnAll2";
            this.btnAll2.PressedDepth = 50;
            this.btnAll2.Size = new System.Drawing.Size(144, 68);
            this.btnAll2.TabIndex = 45;
            this.btnAll2.Text = "Tất cả";
            this.btnAll2.Click += new System.EventHandler(this.btnAll2_Click);
            // 
            // btnUpdate2
            // 
            this.btnUpdate2.BorderRadius = 20;
            this.btnUpdate2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdate2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdate2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpdate2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUpdate2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(1)))), ((int)(((byte)(203)))));
            this.btnUpdate2.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.btnUpdate2.ForeColor = System.Drawing.Color.White;
            this.btnUpdate2.Location = new System.Drawing.Point(436, 74);
            this.btnUpdate2.Name = "btnUpdate2";
            this.btnUpdate2.PressedDepth = 50;
            this.btnUpdate2.Size = new System.Drawing.Size(144, 68);
            this.btnUpdate2.TabIndex = 44;
            this.btnUpdate2.Text = "Sửa";
            this.btnUpdate2.Click += new System.EventHandler(this.btnUpdate2_Click);
            // 
            // btnDelete2
            // 
            this.btnDelete2.BorderRadius = 20;
            this.btnDelete2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDelete2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDelete2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(1)))), ((int)(((byte)(203)))));
            this.btnDelete2.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.btnDelete2.ForeColor = System.Drawing.Color.White;
            this.btnDelete2.Location = new System.Drawing.Point(609, 1);
            this.btnDelete2.Name = "btnDelete2";
            this.btnDelete2.PressedDepth = 50;
            this.btnDelete2.Size = new System.Drawing.Size(144, 67);
            this.btnDelete2.TabIndex = 43;
            this.btnDelete2.Text = "Xóa";
            this.btnDelete2.Click += new System.EventHandler(this.btnDelete2_Click);
            // 
            // btnAdd2
            // 
            this.btnAdd2.BorderRadius = 20;
            this.btnAdd2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdd2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAdd2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(1)))), ((int)(((byte)(203)))));
            this.btnAdd2.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.btnAdd2.ForeColor = System.Drawing.Color.White;
            this.btnAdd2.Location = new System.Drawing.Point(436, 1);
            this.btnAdd2.Name = "btnAdd2";
            this.btnAdd2.PressedDepth = 50;
            this.btnAdd2.Size = new System.Drawing.Size(144, 67);
            this.btnAdd2.TabIndex = 42;
            this.btnAdd2.Text = "Thêm";
            this.btnAdd2.Click += new System.EventHandler(this.btnAdd2_Click);
            // 
            // dgvAgents
            // 
            this.dgvAgents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAgents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAgents.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(1)))), ((int)(((byte)(203)))));
            this.dgvAgents.Location = new System.Drawing.Point(2, 151);
            this.dgvAgents.Margin = new System.Windows.Forms.Padding(2);
            this.dgvAgents.Name = "dgvAgents";
            this.dgvAgents.RowHeadersWidth = 51;
            this.dgvAgents.RowTemplate.Height = 24;
            this.dgvAgents.Size = new System.Drawing.Size(758, 286);
            this.dgvAgents.TabIndex = 41;
            // 
            // Orders
            // 
            this.Orders.Controls.Add(this.btnPrint);
            this.Orders.Controls.Add(this.cbOrderID);
            this.Orders.Controls.Add(this.btnAll3);
            this.Orders.Controls.Add(this.dgvOrderDetail);
            this.Orders.Controls.Add(this.dgvOrder);
            this.Orders.Controls.Add(this.label1);
            this.Orders.Location = new System.Drawing.Point(184, 4);
            this.Orders.Name = "Orders";
            this.Orders.Padding = new System.Windows.Forms.Padding(3);
            this.Orders.Size = new System.Drawing.Size(762, 439);
            this.Orders.TabIndex = 2;
            this.Orders.Text = "Orders";
            this.Orders.UseVisualStyleBackColor = true;
            // 
            // btnPrint
            // 
            this.btnPrint.BorderRadius = 20;
            this.btnPrint.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPrint.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPrint.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPrint.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPrint.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(1)))), ((int)(((byte)(203)))));
            this.btnPrint.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Location = new System.Drawing.Point(648, 6);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.PressedDepth = 50;
            this.btnPrint.Size = new System.Drawing.Size(105, 44);
            this.btnPrint.TabIndex = 52;
            this.btnPrint.Text = "In";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // cbOrderID
            // 
            this.cbOrderID.BackColor = System.Drawing.Color.Transparent;
            this.cbOrderID.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbOrderID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOrderID.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbOrderID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbOrderID.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbOrderID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbOrderID.ItemHeight = 30;
            this.cbOrderID.Location = new System.Drawing.Point(139, 7);
            this.cbOrderID.Name = "cbOrderID";
            this.cbOrderID.Size = new System.Drawing.Size(277, 36);
            this.cbOrderID.TabIndex = 51;
            this.cbOrderID.SelectedIndexChanged += new System.EventHandler(this.cbOrderID_SelectedIndexChanged);
            // 
            // btnAll3
            // 
            this.btnAll3.BorderRadius = 20;
            this.btnAll3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAll3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAll3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAll3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAll3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(1)))), ((int)(((byte)(203)))));
            this.btnAll3.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.btnAll3.ForeColor = System.Drawing.Color.White;
            this.btnAll3.Location = new System.Drawing.Point(517, 7);
            this.btnAll3.Name = "btnAll3";
            this.btnAll3.PressedDepth = 50;
            this.btnAll3.Size = new System.Drawing.Size(105, 44);
            this.btnAll3.TabIndex = 46;
            this.btnAll3.Text = "Tất cả";
            this.btnAll3.Click += new System.EventHandler(this.btnAll3_Click);
            // 
            // dgvOrderDetail
            // 
            this.dgvOrderDetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrderDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderDetail.Location = new System.Drawing.Point(390, 55);
            this.dgvOrderDetail.Margin = new System.Windows.Forms.Padding(2);
            this.dgvOrderDetail.Name = "dgvOrderDetail";
            this.dgvOrderDetail.RowHeadersWidth = 51;
            this.dgvOrderDetail.RowTemplate.Height = 24;
            this.dgvOrderDetail.Size = new System.Drawing.Size(367, 379);
            this.dgvOrderDetail.TabIndex = 10;
            // 
            // dgvOrder
            // 
            this.dgvOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrder.Location = new System.Drawing.Point(5, 55);
            this.dgvOrder.Margin = new System.Windows.Forms.Padding(2);
            this.dgvOrder.Name = "dgvOrder";
            this.dgvOrder.RowHeadersWidth = 51;
            this.dgvOrder.RowTemplate.Height = 24;
            this.dgvOrder.Size = new System.Drawing.Size(367, 379);
            this.dgvOrder.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label1.Location = new System.Drawing.Point(29, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 22);
            this.label1.TabIndex = 7;
            this.label1.Text = "OrderID:";
            // 
            // Statics
            // 
            this.Statics.Controls.Add(this.btnBestSeller);
            this.Statics.Controls.Add(this.btnBestCustomer);
            this.Statics.Controls.Add(this.dgvShowOutput);
            this.Statics.Location = new System.Drawing.Point(184, 4);
            this.Statics.Name = "Statics";
            this.Statics.Padding = new System.Windows.Forms.Padding(3);
            this.Statics.Size = new System.Drawing.Size(762, 439);
            this.Statics.TabIndex = 3;
            this.Statics.Text = "Statics";
            this.Statics.UseVisualStyleBackColor = true;
            // 
            // btnBestSeller
            // 
            this.btnBestSeller.BorderRadius = 20;
            this.btnBestSeller.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBestSeller.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBestSeller.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBestSeller.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBestSeller.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(1)))), ((int)(((byte)(203)))));
            this.btnBestSeller.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.btnBestSeller.ForeColor = System.Drawing.Color.White;
            this.btnBestSeller.Location = new System.Drawing.Point(418, 7);
            this.btnBestSeller.Name = "btnBestSeller";
            this.btnBestSeller.PressedDepth = 50;
            this.btnBestSeller.Size = new System.Drawing.Size(267, 123);
            this.btnBestSeller.TabIndex = 44;
            this.btnBestSeller.Text = "Mặt hàng được mua nhiều nhất";
            this.btnBestSeller.Click += new System.EventHandler(this.btnBestSeller_Click);
            // 
            // btnBestCustomer
            // 
            this.btnBestCustomer.BorderRadius = 20;
            this.btnBestCustomer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBestCustomer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBestCustomer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBestCustomer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBestCustomer.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(1)))), ((int)(((byte)(203)))));
            this.btnBestCustomer.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.btnBestCustomer.ForeColor = System.Drawing.Color.White;
            this.btnBestCustomer.Location = new System.Drawing.Point(94, 7);
            this.btnBestCustomer.Name = "btnBestCustomer";
            this.btnBestCustomer.PressedDepth = 50;
            this.btnBestCustomer.Size = new System.Drawing.Size(267, 123);
            this.btnBestCustomer.TabIndex = 43;
            this.btnBestCustomer.Text = "Khách hàng mua nhiều nhất";
            this.btnBestCustomer.Click += new System.EventHandler(this.btnBestCustomer_Click);
            // 
            // dgvShowOutput
            // 
            this.dgvShowOutput.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvShowOutput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShowOutput.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(1)))), ((int)(((byte)(203)))));
            this.dgvShowOutput.Location = new System.Drawing.Point(2, 151);
            this.dgvShowOutput.Margin = new System.Windows.Forms.Padding(2);
            this.dgvShowOutput.Name = "dgvShowOutput";
            this.dgvShowOutput.RowHeadersWidth = 51;
            this.dgvShowOutput.RowTemplate.Height = 24;
            this.dgvShowOutput.Size = new System.Drawing.Size(758, 286);
            this.dgvShowOutput.TabIndex = 42;
            // 
            // printDocument2
            // 
            this.printDocument2.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument2_PrintPage);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 451);
            this.Controls.Add(this.guna2TabControl1);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.guna2TabControl1.ResumeLayout(false);
            this.Products.ResumeLayout(false);
            this.Products.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.Agents.ResumeLayout(false);
            this.Agents.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgents)).EndInit();
            this.Orders.ResumeLayout(false);
            this.Orders.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).EndInit();
            this.Statics.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowOutput)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TabControl guna2TabControl1;
        private System.Windows.Forms.TabPage Products;
        private System.Windows.Forms.TabPage Agents;
        private System.Windows.Forms.TabPage Orders;
        private System.Windows.Forms.TabPage Statics;
        private System.Windows.Forms.Label lblName;
        private Guna.UI2.WinForms.Guna2ComboBox cbItemID;
        private Guna.UI2.WinForms.Guna2TextBox txtSize;
        private Guna.UI2.WinForms.Guna2TextBox txtItemName;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblSize;
        private Guna.UI2.WinForms.Guna2Button btnAll;
        private Guna.UI2.WinForms.Guna2Button btnUpdate;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.Label lblAgentName;
        private Guna.UI2.WinForms.Guna2ComboBox cbAgentID;
        private Guna.UI2.WinForms.Guna2TextBox txtAddress;
        private Guna.UI2.WinForms.Guna2TextBox txtAgentName;
        private System.Windows.Forms.Label lblAgentID;
        private System.Windows.Forms.Label lblAddress;
        private Guna.UI2.WinForms.Guna2Button btnAll2;
        private Guna.UI2.WinForms.Guna2Button btnUpdate2;
        private Guna.UI2.WinForms.Guna2Button btnDelete2;
        private Guna.UI2.WinForms.Guna2Button btnAdd2;
        private System.Windows.Forms.DataGridView dgvAgents;
        private Guna.UI2.WinForms.Guna2ComboBox cbOrderID;
        private Guna.UI2.WinForms.Guna2Button btnAll3;
        private System.Windows.Forms.DataGridView dgvOrderDetail;
        private System.Windows.Forms.DataGridView dgvOrder;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnPrint;
        private System.Windows.Forms.PrintDialog printDialog2;
        private System.Drawing.Printing.PrintDocument printDocument2;
        private Guna.UI2.WinForms.Guna2Button btnBestSeller;
        private Guna.UI2.WinForms.Guna2Button btnBestCustomer;
        private System.Windows.Forms.DataGridView dgvShowOutput;
    }
}