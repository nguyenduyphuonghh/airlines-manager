namespace QLVMB
{
    partial class frmThongKe
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
            this.btnback = new System.Windows.Forms.Button();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.dtgvThongKe = new System.Windows.Forms.DataGridView();
            this.mnThongke = new System.Windows.Forms.MenuStrip();
            this.mnDoanhThu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnKH = new System.Windows.Forms.ToolStripMenuItem();
            this.mn1TheoNgay = new System.Windows.Forms.ToolStripMenuItem();
            this.mn1LoaiVe = new System.Windows.Forms.ToolStripMenuItem();
            this.mn2HangNhat = new System.Windows.Forms.ToolStripMenuItem();
            this.mn2Thuonggia = new System.Windows.Forms.ToolStripMenuItem();
            this.mn1Nuoc = new System.Windows.Forms.ToolStripMenuItem();
            this.gbTheoNgay = new System.Windows.Forms.GroupBox();
            this.lblTu = new System.Windows.Forms.Label();
            this.dtpkTu = new System.Windows.Forms.DateTimePicker();
            this.lblDen = new System.Windows.Forms.Label();
            this.dtpkDen = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvThongKe)).BeginInit();
            this.mnThongke.SuspendLayout();
            this.gbTheoNgay.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnback
            // 
            this.btnback.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnback.Location = new System.Drawing.Point(448, 294);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(75, 23);
            this.btnback.TabIndex = 0;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // btnThongKe
            // 
            this.btnThongKe.Location = new System.Drawing.Point(367, 294);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(75, 23);
            this.btnThongKe.TabIndex = 1;
            this.btnThongKe.Text = "Thống Kê";
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Visible = false;
            // 
            // dtgvThongKe
            // 
            this.dtgvThongKe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvThongKe.Location = new System.Drawing.Point(13, 95);
            this.dtgvThongKe.Name = "dtgvThongKe";
            this.dtgvThongKe.Size = new System.Drawing.Size(510, 193);
            this.dtgvThongKe.TabIndex = 2;
            // 
            // mnThongke
            // 
            this.mnThongke.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnDoanhThu,
            this.mnKH});
            this.mnThongke.Location = new System.Drawing.Point(0, 0);
            this.mnThongke.Name = "mnThongke";
            this.mnThongke.Size = new System.Drawing.Size(535, 24);
            this.mnThongke.TabIndex = 3;
            this.mnThongke.Text = "menuStrip1";
            // 
            // mnDoanhThu
            // 
            this.mnDoanhThu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mn1TheoNgay,
            this.mn1LoaiVe});
            this.mnDoanhThu.Name = "mnDoanhThu";
            this.mnDoanhThu.Size = new System.Drawing.Size(75, 20);
            this.mnDoanhThu.Text = "Doanh thu";
            // 
            // mnKH
            // 
            this.mnKH.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mn1Nuoc});
            this.mnKH.Name = "mnKH";
            this.mnKH.Size = new System.Drawing.Size(82, 20);
            this.mnKH.Text = "Khách hàng";
            // 
            // mn1TheoNgay
            // 
            this.mn1TheoNgay.Name = "mn1TheoNgay";
            this.mn1TheoNgay.Size = new System.Drawing.Size(152, 22);
            this.mn1TheoNgay.Text = "Theo Ngày";
            this.mn1TheoNgay.Click += new System.EventHandler(this.mn1TheoNgay_Click);
            // 
            // mn1LoaiVe
            // 
            this.mn1LoaiVe.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mn2HangNhat,
            this.mn2Thuonggia});
            this.mn1LoaiVe.Name = "mn1LoaiVe";
            this.mn1LoaiVe.Size = new System.Drawing.Size(152, 22);
            this.mn1LoaiVe.Text = "Theo Loại Vé";
            // 
            // mn2HangNhat
            // 
            this.mn2HangNhat.Name = "mn2HangNhat";
            this.mn2HangNhat.Size = new System.Drawing.Size(152, 22);
            this.mn2HangNhat.Text = "Hạng nhất";
            // 
            // mn2Thuonggia
            // 
            this.mn2Thuonggia.Name = "mn2Thuonggia";
            this.mn2Thuonggia.Size = new System.Drawing.Size(152, 22);
            this.mn2Thuonggia.Text = "Thương gia";
            // 
            // mn1Nuoc
            // 
            this.mn1Nuoc.Name = "mn1Nuoc";
            this.mn1Nuoc.Size = new System.Drawing.Size(178, 22);
            this.mn1Nuoc.Text = "Trong - Ngoài nước";
            // 
            // gbTheoNgay
            // 
            this.gbTheoNgay.Controls.Add(this.dtpkDen);
            this.gbTheoNgay.Controls.Add(this.lblDen);
            this.gbTheoNgay.Controls.Add(this.dtpkTu);
            this.gbTheoNgay.Controls.Add(this.lblTu);
            this.gbTheoNgay.Location = new System.Drawing.Point(13, 28);
            this.gbTheoNgay.Name = "gbTheoNgay";
            this.gbTheoNgay.Size = new System.Drawing.Size(510, 61);
            this.gbTheoNgay.TabIndex = 4;
            this.gbTheoNgay.TabStop = false;
            this.gbTheoNgay.Text = "Thống kê doanh thu theo ngày";
            this.gbTheoNgay.Visible = false;
            // 
            // lblTu
            // 
            this.lblTu.AutoSize = true;
            this.lblTu.Location = new System.Drawing.Point(6, 26);
            this.lblTu.Name = "lblTu";
            this.lblTu.Size = new System.Drawing.Size(26, 13);
            this.lblTu.TabIndex = 0;
            this.lblTu.Text = "Từ :";
            // 
            // dtpkTu
            // 
            this.dtpkTu.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpkTu.Location = new System.Drawing.Point(78, 20);
            this.dtpkTu.Name = "dtpkTu";
            this.dtpkTu.Size = new System.Drawing.Size(157, 20);
            this.dtpkTu.TabIndex = 1;
            // 
            // lblDen
            // 
            this.lblDen.AutoSize = true;
            this.lblDen.Location = new System.Drawing.Point(263, 26);
            this.lblDen.Name = "lblDen";
            this.lblDen.Size = new System.Drawing.Size(33, 13);
            this.lblDen.TabIndex = 2;
            this.lblDen.Text = "Đến :";
            // 
            // dtpkDen
            // 
            this.dtpkDen.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpkDen.Location = new System.Drawing.Point(347, 20);
            this.dtpkDen.Name = "dtpkDen";
            this.dtpkDen.Size = new System.Drawing.Size(157, 20);
            this.dtpkDen.TabIndex = 3;
            // 
            // frmThongKe
            // 
            this.AcceptButton = this.btnThongKe;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnback;
            this.ClientSize = new System.Drawing.Size(535, 329);
            this.ControlBox = false;
            this.Controls.Add(this.gbTheoNgay);
            this.Controls.Add(this.dtgvThongKe);
            this.Controls.Add(this.btnThongKe);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.mnThongke);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.mnThongke;
            this.Name = "frmThongKe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmThongKe";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvThongKe)).EndInit();
            this.mnThongke.ResumeLayout(false);
            this.mnThongke.PerformLayout();
            this.gbTheoNgay.ResumeLayout(false);
            this.gbTheoNgay.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.DataGridView dtgvThongKe;
        private System.Windows.Forms.MenuStrip mnThongke;
        private System.Windows.Forms.ToolStripMenuItem mnDoanhThu;
        private System.Windows.Forms.ToolStripMenuItem mn1TheoNgay;
        private System.Windows.Forms.ToolStripMenuItem mn1LoaiVe;
        private System.Windows.Forms.ToolStripMenuItem mn2HangNhat;
        private System.Windows.Forms.ToolStripMenuItem mn2Thuonggia;
        private System.Windows.Forms.ToolStripMenuItem mnKH;
        private System.Windows.Forms.ToolStripMenuItem mn1Nuoc;
        private System.Windows.Forms.GroupBox gbTheoNgay;
        private System.Windows.Forms.DateTimePicker dtpkDen;
        private System.Windows.Forms.Label lblDen;
        private System.Windows.Forms.DateTimePicker dtpkTu;
        private System.Windows.Forms.Label lblTu;
    }
}