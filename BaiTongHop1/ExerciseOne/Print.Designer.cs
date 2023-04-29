namespace ExerciseOne
{
    partial class Print
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
            this.printDialog2 = new System.Windows.Forms.PrintDialog();
            this.printDocument2 = new System.Drawing.Printing.PrintDocument();
            this.btnPrint = new Guna.UI2.WinForms.Guna2Button();
            this.cbOrderID = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnAll3 = new Guna.UI2.WinForms.Guna2Button();
            this.dgvOrderDetail = new System.Windows.Forms.DataGridView();
            this.dgvOrder = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // printDialog2
            // 
            this.printDialog2.UseEXDialog = true;
            // 
            // printDocument2
            // 
            this.printDocument2.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument2_PrintPage);
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
            this.btnPrint.Location = new System.Drawing.Point(662, 12);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.PressedDepth = 50;
            this.btnPrint.Size = new System.Drawing.Size(105, 44);
            this.btnPrint.TabIndex = 58;
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
            this.cbOrderID.Location = new System.Drawing.Point(153, 13);
            this.cbOrderID.Name = "cbOrderID";
            this.cbOrderID.Size = new System.Drawing.Size(277, 36);
            this.cbOrderID.TabIndex = 57;
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
            this.btnAll3.Location = new System.Drawing.Point(531, 13);
            this.btnAll3.Name = "btnAll3";
            this.btnAll3.PressedDepth = 50;
            this.btnAll3.Size = new System.Drawing.Size(105, 44);
            this.btnAll3.TabIndex = 56;
            this.btnAll3.Text = "Tất cả";
            this.btnAll3.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // dgvOrderDetail
            // 
            this.dgvOrderDetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrderDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderDetail.Location = new System.Drawing.Point(404, 61);
            this.dgvOrderDetail.Margin = new System.Windows.Forms.Padding(2);
            this.dgvOrderDetail.Name = "dgvOrderDetail";
            this.dgvOrderDetail.RowHeadersWidth = 51;
            this.dgvOrderDetail.RowTemplate.Height = 24;
            this.dgvOrderDetail.Size = new System.Drawing.Size(367, 379);
            this.dgvOrderDetail.TabIndex = 55;
            // 
            // dgvOrder
            // 
            this.dgvOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrder.Location = new System.Drawing.Point(19, 61);
            this.dgvOrder.Margin = new System.Windows.Forms.Padding(2);
            this.dgvOrder.Name = "dgvOrder";
            this.dgvOrder.RowHeadersWidth = 51;
            this.dgvOrder.RowTemplate.Height = 24;
            this.dgvOrder.Size = new System.Drawing.Size(367, 379);
            this.dgvOrder.TabIndex = 54;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label1.Location = new System.Drawing.Point(15, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 22);
            this.label1.TabIndex = 53;
            this.label1.Text = "OrderID:";
            // 
            // Print
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 480);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.cbOrderID);
            this.Controls.Add(this.btnAll3);
            this.Controls.Add(this.dgvOrderDetail);
            this.Controls.Add(this.dgvOrder);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Print";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrderForm";
            this.Load += new System.EventHandler(this.OrderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PrintDialog printDialog2;
        private System.Drawing.Printing.PrintDocument printDocument2;
        private Guna.UI2.WinForms.Guna2Button btnPrint;
        private Guna.UI2.WinForms.Guna2ComboBox cbOrderID;
        private Guna.UI2.WinForms.Guna2Button btnAll3;
        private System.Windows.Forms.DataGridView dgvOrderDetail;
        private System.Windows.Forms.DataGridView dgvOrder;
        private System.Windows.Forms.Label label1;
    }
}