namespace QLVMB
{
    partial class frmTimKiem
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
            this.btnBack = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.mnStripTimKiem = new System.Windows.Forms.MenuStrip();
            this.mnTKCB = new System.Windows.Forms.ToolStripMenuItem();
            this.mn1NgayBay = new System.Windows.Forms.ToolStripMenuItem();
            this.mn1HanhTrinh = new System.Windows.Forms.ToolStripMenuItem();
            this.mnTKKH = new System.Windows.Forms.ToolStripMenuItem();
            this.mn1tenKH = new System.Windows.Forms.ToolStripMenuItem();
            this.mn1HoChieuKH = new System.Windows.Forms.ToolStripMenuItem();
            this.dtgvTimKiem = new System.Windows.Forms.DataGridView();
            this.gbNgayBay = new System.Windows.Forms.GroupBox();
            this.dtpkDen = new System.Windows.Forms.DateTimePicker();
            this.dtpkTu = new System.Windows.Forms.DateTimePicker();
            this.lblDen = new System.Windows.Forms.Label();
            this.lblTu = new System.Windows.Forms.Label();
            this.gbHanhTrinh = new System.Windows.Forms.GroupBox();
            this.cboDen = new System.Windows.Forms.ComboBox();
            this.cboTu = new System.Windows.Forms.ComboBox();
            this.lblDen1 = new System.Windows.Forms.Label();
            this.lblTu1 = new System.Windows.Forms.Label();
            this.gbTenKH = new System.Windows.Forms.GroupBox();
            this.tbxTenKH = new System.Windows.Forms.TextBox();
            this.lblTenKH = new System.Windows.Forms.Label();
            this.gbHoChieu = new System.Windows.Forms.GroupBox();
            this.tbxHoChieu = new System.Windows.Forms.TextBox();
            this.lblhoChieu = new System.Windows.Forms.Label();
            this.mnStripTimKiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTimKiem)).BeginInit();
            this.gbNgayBay.SuspendLayout();
            this.gbHanhTrinh.SuspendLayout();
            this.gbTenKH.SuspendLayout();
            this.gbHoChieu.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(479, 375);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(395, 375);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(75, 23);
            this.btnTimKiem.TabIndex = 1;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Visible = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // mnStripTimKiem
            // 
            this.mnStripTimKiem.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnTKCB,
            this.mnTKKH});
            this.mnStripTimKiem.Location = new System.Drawing.Point(0, 0);
            this.mnStripTimKiem.Name = "mnStripTimKiem";
            this.mnStripTimKiem.Size = new System.Drawing.Size(566, 24);
            this.mnStripTimKiem.TabIndex = 2;
            this.mnStripTimKiem.Text = "menuStrip1";
            // 
            // mnTKCB
            // 
            this.mnTKCB.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mn1NgayBay,
            this.mn1HanhTrinh});
            this.mnTKCB.Name = "mnTKCB";
            this.mnTKCB.Size = new System.Drawing.Size(133, 20);
            this.mnTKCB.Text = "Tìm kiếm chuyến bay";
            // 
            // mn1NgayBay
            // 
            this.mn1NgayBay.Name = "mn1NgayBay";
            this.mn1NgayBay.Size = new System.Drawing.Size(163, 22);
            this.mn1NgayBay.Text = "Theo Ngày Bay";
            this.mn1NgayBay.Click += new System.EventHandler(this.mn1NgayBay_Click);
            // 
            // mn1HanhTrinh
            // 
            this.mn1HanhTrinh.Name = "mn1HanhTrinh";
            this.mn1HanhTrinh.Size = new System.Drawing.Size(163, 22);
            this.mn1HanhTrinh.Text = "Theo Hành Trình";
            this.mn1HanhTrinh.Click += new System.EventHandler(this.mn1HanhTrinh_Click);
            // 
            // mnTKKH
            // 
            this.mnTKKH.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mn1tenKH,
            this.mn1HoChieuKH});
            this.mnTKKH.Name = "mnTKKH";
            this.mnTKKH.Size = new System.Drawing.Size(134, 20);
            this.mnTKKH.Text = "Tìm kiếm khách hàng";
            // 
            // mn1tenKH
            // 
            this.mn1tenKH.Name = "mn1tenKH";
            this.mn1tenKH.Size = new System.Drawing.Size(154, 22);
            this.mn1tenKH.Text = "Theo tên";
            this.mn1tenKH.Click += new System.EventHandler(this.mn1tenKH_Click);
            // 
            // mn1HoChieuKH
            // 
            this.mn1HoChieuKH.Name = "mn1HoChieuKH";
            this.mn1HoChieuKH.Size = new System.Drawing.Size(154, 22);
            this.mn1HoChieuKH.Text = "Theo Hộ Chiếu";
            this.mn1HoChieuKH.Click += new System.EventHandler(this.mn1HoChieuKH_Click);
            // 
            // dtgvTimKiem
            // 
            this.dtgvTimKiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvTimKiem.Location = new System.Drawing.Point(12, 171);
            this.dtgvTimKiem.Name = "dtgvTimKiem";
            this.dtgvTimKiem.Size = new System.Drawing.Size(542, 198);
            this.dtgvTimKiem.TabIndex = 3;
            // 
            // gbNgayBay
            // 
            this.gbNgayBay.Controls.Add(this.dtpkDen);
            this.gbNgayBay.Controls.Add(this.dtpkTu);
            this.gbNgayBay.Controls.Add(this.lblDen);
            this.gbNgayBay.Controls.Add(this.lblTu);
            this.gbNgayBay.Location = new System.Drawing.Point(13, 28);
            this.gbNgayBay.Name = "gbNgayBay";
            this.gbNgayBay.Size = new System.Drawing.Size(541, 60);
            this.gbNgayBay.TabIndex = 6;
            this.gbNgayBay.TabStop = false;
            this.gbNgayBay.Text = "Tìm kiếm chuyến bay theo ngày bay";
            this.gbNgayBay.Visible = false;
            // 
            // dtpkDen
            // 
            this.dtpkDen.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpkDen.Location = new System.Drawing.Point(336, 20);
            this.dtpkDen.Name = "dtpkDen";
            this.dtpkDen.Size = new System.Drawing.Size(185, 20);
            this.dtpkDen.TabIndex = 3;
            // 
            // dtpkTu
            // 
            this.dtpkTu.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpkTu.Location = new System.Drawing.Point(71, 20);
            this.dtpkTu.Name = "dtpkTu";
            this.dtpkTu.Size = new System.Drawing.Size(188, 20);
            this.dtpkTu.TabIndex = 2;
            // 
            // lblDen
            // 
            this.lblDen.AutoSize = true;
            this.lblDen.Location = new System.Drawing.Point(285, 26);
            this.lblDen.Name = "lblDen";
            this.lblDen.Size = new System.Drawing.Size(33, 13);
            this.lblDen.TabIndex = 1;
            this.lblDen.Text = "Đến :";
            // 
            // lblTu
            // 
            this.lblTu.AutoSize = true;
            this.lblTu.Location = new System.Drawing.Point(16, 26);
            this.lblTu.Name = "lblTu";
            this.lblTu.Size = new System.Drawing.Size(26, 13);
            this.lblTu.TabIndex = 0;
            this.lblTu.Text = "Từ :";
            // 
            // gbHanhTrinh
            // 
            this.gbHanhTrinh.Controls.Add(this.cboDen);
            this.gbHanhTrinh.Controls.Add(this.cboTu);
            this.gbHanhTrinh.Controls.Add(this.lblDen1);
            this.gbHanhTrinh.Controls.Add(this.lblTu1);
            this.gbHanhTrinh.Location = new System.Drawing.Point(13, 95);
            this.gbHanhTrinh.Name = "gbHanhTrinh";
            this.gbHanhTrinh.Size = new System.Drawing.Size(538, 70);
            this.gbHanhTrinh.TabIndex = 7;
            this.gbHanhTrinh.TabStop = false;
            this.gbHanhTrinh.Text = "Tìm kiếm chuyến bay theo hành trình";
            this.gbHanhTrinh.Visible = false;
            // 
            // cboDen
            // 
            this.cboDen.FormattingEnabled = true;
            this.cboDen.Location = new System.Drawing.Point(336, 26);
            this.cboDen.Name = "cboDen";
            this.cboDen.Size = new System.Drawing.Size(185, 21);
            this.cboDen.TabIndex = 4;
            // 
            // cboTu
            // 
            this.cboTu.FormattingEnabled = true;
            this.cboTu.Location = new System.Drawing.Point(71, 26);
            this.cboTu.Name = "cboTu";
            this.cboTu.Size = new System.Drawing.Size(188, 21);
            this.cboTu.TabIndex = 3;
            // 
            // lblDen1
            // 
            this.lblDen1.AutoSize = true;
            this.lblDen1.Location = new System.Drawing.Point(285, 29);
            this.lblDen1.Name = "lblDen1";
            this.lblDen1.Size = new System.Drawing.Size(33, 13);
            this.lblDen1.TabIndex = 2;
            this.lblDen1.Text = "Đến :";
            // 
            // lblTu1
            // 
            this.lblTu1.AutoSize = true;
            this.lblTu1.Location = new System.Drawing.Point(16, 29);
            this.lblTu1.Name = "lblTu1";
            this.lblTu1.Size = new System.Drawing.Size(26, 13);
            this.lblTu1.TabIndex = 1;
            this.lblTu1.Text = "Từ :";
            // 
            // gbTenKH
            // 
            this.gbTenKH.Controls.Add(this.tbxTenKH);
            this.gbTenKH.Controls.Add(this.lblTenKH);
            this.gbTenKH.Location = new System.Drawing.Point(13, 28);
            this.gbTenKH.Name = "gbTenKH";
            this.gbTenKH.Size = new System.Drawing.Size(538, 60);
            this.gbTenKH.TabIndex = 0;
            this.gbTenKH.TabStop = false;
            this.gbTenKH.Text = "Tìm kiếm khách hàng theo tên :";
            this.gbTenKH.Visible = false;
            // 
            // tbxTenKH
            // 
            this.tbxTenKH.Location = new System.Drawing.Point(165, 20);
            this.tbxTenKH.Name = "tbxTenKH";
            this.tbxTenKH.Size = new System.Drawing.Size(373, 20);
            this.tbxTenKH.TabIndex = 1;
            // 
            // lblTenKH
            // 
            this.lblTenKH.AutoSize = true;
            this.lblTenKH.Location = new System.Drawing.Point(19, 20);
            this.lblTenKH.Name = "lblTenKH";
            this.lblTenKH.Size = new System.Drawing.Size(117, 13);
            this.lblTenKH.TabIndex = 0;
            this.lblTenKH.Text = "Nhập tên khách hàng :";
            // 
            // gbHoChieu
            // 
            this.gbHoChieu.Controls.Add(this.tbxHoChieu);
            this.gbHoChieu.Controls.Add(this.lblhoChieu);
            this.gbHoChieu.Location = new System.Drawing.Point(13, 95);
            this.gbHoChieu.Name = "gbHoChieu";
            this.gbHoChieu.Size = new System.Drawing.Size(541, 70);
            this.gbHoChieu.TabIndex = 0;
            this.gbHoChieu.TabStop = false;
            this.gbHoChieu.Text = "Tìm kiếm khách hàng theo hộ chiếu";
            this.gbHoChieu.Visible = false;
            // 
            // tbxHoChieu
            // 
            this.tbxHoChieu.Location = new System.Drawing.Point(168, 23);
            this.tbxHoChieu.Name = "tbxHoChieu";
            this.tbxHoChieu.Size = new System.Drawing.Size(373, 20);
            this.tbxHoChieu.TabIndex = 3;
            // 
            // lblhoChieu
            // 
            this.lblhoChieu.AutoSize = true;
            this.lblhoChieu.Location = new System.Drawing.Point(19, 26);
            this.lblhoChieu.Name = "lblhoChieu";
            this.lblhoChieu.Size = new System.Drawing.Size(83, 13);
            this.lblhoChieu.TabIndex = 2;
            this.lblhoChieu.Text = "Nhập hộ chiếu :";
            // 
            // frmTimKiem
            // 
            this.AcceptButton = this.btnTimKiem;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnBack;
            this.ClientSize = new System.Drawing.Size(566, 411);
            this.ControlBox = false;
            this.Controls.Add(this.gbHoChieu);
            this.Controls.Add(this.gbTenKH);
            this.Controls.Add(this.gbHanhTrinh);
            this.Controls.Add(this.gbNgayBay);
            this.Controls.Add(this.dtgvTimKiem);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.mnStripTimKiem);
            this.MainMenuStrip = this.mnStripTimKiem;
            this.Name = "frmTimKiem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTimKiem";
            this.mnStripTimKiem.ResumeLayout(false);
            this.mnStripTimKiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTimKiem)).EndInit();
            this.gbNgayBay.ResumeLayout(false);
            this.gbNgayBay.PerformLayout();
            this.gbHanhTrinh.ResumeLayout(false);
            this.gbHanhTrinh.PerformLayout();
            this.gbTenKH.ResumeLayout(false);
            this.gbTenKH.PerformLayout();
            this.gbHoChieu.ResumeLayout(false);
            this.gbHoChieu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.MenuStrip mnStripTimKiem;
        private System.Windows.Forms.ToolStripMenuItem mnTKCB;
        private System.Windows.Forms.ToolStripMenuItem mn1NgayBay;
        private System.Windows.Forms.ToolStripMenuItem mn1HanhTrinh;
        private System.Windows.Forms.ToolStripMenuItem mnTKKH;
        private System.Windows.Forms.ToolStripMenuItem mn1tenKH;
        private System.Windows.Forms.ToolStripMenuItem mn1HoChieuKH;
        private System.Windows.Forms.DataGridView dtgvTimKiem;
        private System.Windows.Forms.GroupBox gbNgayBay;
        private System.Windows.Forms.DateTimePicker dtpkDen;
        private System.Windows.Forms.DateTimePicker dtpkTu;
        private System.Windows.Forms.Label lblDen;
        private System.Windows.Forms.Label lblTu;
        private System.Windows.Forms.GroupBox gbHanhTrinh;
        private System.Windows.Forms.ComboBox cboDen;
        private System.Windows.Forms.ComboBox cboTu;
        private System.Windows.Forms.Label lblDen1;
        private System.Windows.Forms.Label lblTu1;
        private System.Windows.Forms.GroupBox gbTenKH;
        private System.Windows.Forms.TextBox tbxTenKH;
        private System.Windows.Forms.Label lblTenKH;
        private System.Windows.Forms.GroupBox gbHoChieu;
        private System.Windows.Forms.TextBox tbxHoChieu;
        private System.Windows.Forms.Label lblhoChieu;
    }
}