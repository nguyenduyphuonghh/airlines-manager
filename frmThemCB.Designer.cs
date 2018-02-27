namespace QLVMB
{
    partial class frmThemCB
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
            this.lblMaMB = new System.Windows.Forms.Label();
            this.btnback = new System.Windows.Forms.Button();
            this.cboMaMB = new System.Windows.Forms.ComboBox();
            this.dtpkNgayBay = new System.Windows.Forms.DateTimePicker();
            this.tbxNoiDi = new System.Windows.Forms.TextBox();
            this.dtpkGioBay = new System.Windows.Forms.DateTimePicker();
            this.tbxNoiDen = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.lblGayBay = new System.Windows.Forms.Label();
            this.lblGioBay = new System.Windows.Forms.Label();
            this.lblNoiDi = new System.Windows.Forms.Label();
            this.lblNoiDen = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMaMB
            // 
            this.lblMaMB.AutoSize = true;
            this.lblMaMB.Location = new System.Drawing.Point(13, 13);
            this.lblMaMB.Name = "lblMaMB";
            this.lblMaMB.Size = new System.Drawing.Size(70, 13);
            this.lblMaMB.TabIndex = 0;
            this.lblMaMB.Text = "Mã máy bay :";
            // 
            // btnback
            // 
            this.btnback.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnback.Location = new System.Drawing.Point(279, 259);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(75, 23);
            this.btnback.TabIndex = 1;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // cboMaMB
            // 
            this.cboMaMB.FormattingEnabled = true;
            this.cboMaMB.Location = new System.Drawing.Point(153, 13);
            this.cboMaMB.Name = "cboMaMB";
            this.cboMaMB.Size = new System.Drawing.Size(201, 21);
            this.cboMaMB.TabIndex = 2;
            // 
            // dtpkNgayBay
            // 
            this.dtpkNgayBay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpkNgayBay.Location = new System.Drawing.Point(153, 61);
            this.dtpkNgayBay.Name = "dtpkNgayBay";
            this.dtpkNgayBay.Size = new System.Drawing.Size(200, 20);
            this.dtpkNgayBay.TabIndex = 3;
            // 
            // tbxNoiDi
            // 
            this.tbxNoiDi.Location = new System.Drawing.Point(153, 159);
            this.tbxNoiDi.Name = "tbxNoiDi";
            this.tbxNoiDi.Size = new System.Drawing.Size(201, 20);
            this.tbxNoiDi.TabIndex = 4;
            // 
            // dtpkGioBay
            // 
            this.dtpkGioBay.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpkGioBay.Location = new System.Drawing.Point(153, 108);
            this.dtpkGioBay.Name = "dtpkGioBay";
            this.dtpkGioBay.Size = new System.Drawing.Size(200, 20);
            this.dtpkGioBay.TabIndex = 5;
            // 
            // tbxNoiDen
            // 
            this.tbxNoiDen.Location = new System.Drawing.Point(153, 204);
            this.tbxNoiDen.Name = "tbxNoiDen";
            this.tbxNoiDen.Size = new System.Drawing.Size(201, 20);
            this.tbxNoiDen.TabIndex = 6;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(198, 259);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 7;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // lblGayBay
            // 
            this.lblGayBay.AutoSize = true;
            this.lblGayBay.Location = new System.Drawing.Point(13, 68);
            this.lblGayBay.Name = "lblGayBay";
            this.lblGayBay.Size = new System.Drawing.Size(58, 13);
            this.lblGayBay.TabIndex = 8;
            this.lblGayBay.Text = "Ngày bay :";
            // 
            // lblGioBay
            // 
            this.lblGioBay.AutoSize = true;
            this.lblGioBay.Location = new System.Drawing.Point(13, 115);
            this.lblGioBay.Name = "lblGioBay";
            this.lblGioBay.Size = new System.Drawing.Size(49, 13);
            this.lblGioBay.TabIndex = 9;
            this.lblGioBay.Text = "Giờ bay :";
            // 
            // lblNoiDi
            // 
            this.lblNoiDi.AutoSize = true;
            this.lblNoiDi.Location = new System.Drawing.Point(13, 166);
            this.lblNoiDi.Name = "lblNoiDi";
            this.lblNoiDi.Size = new System.Drawing.Size(42, 13);
            this.lblNoiDi.TabIndex = 10;
            this.lblNoiDi.Text = "Nơi Đi :";
            // 
            // lblNoiDen
            // 
            this.lblNoiDen.AutoSize = true;
            this.lblNoiDen.Location = new System.Drawing.Point(13, 211);
            this.lblNoiDen.Name = "lblNoiDen";
            this.lblNoiDen.Size = new System.Drawing.Size(52, 13);
            this.lblNoiDen.TabIndex = 11;
            this.lblNoiDen.Text = "Nơi Đến :";
            // 
            // frmThemCB
            // 
            this.AcceptButton = this.btnThem;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnback;
            this.ClientSize = new System.Drawing.Size(386, 294);
            this.ControlBox = false;
            this.Controls.Add(this.lblNoiDen);
            this.Controls.Add(this.lblNoiDi);
            this.Controls.Add(this.lblGioBay);
            this.Controls.Add(this.lblGayBay);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.tbxNoiDen);
            this.Controls.Add(this.dtpkGioBay);
            this.Controls.Add(this.tbxNoiDi);
            this.Controls.Add(this.dtpkNgayBay);
            this.Controls.Add(this.cboMaMB);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.lblMaMB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmThemCB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmThemCB";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMaMB;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.ComboBox cboMaMB;
        private System.Windows.Forms.DateTimePicker dtpkNgayBay;
        private System.Windows.Forms.TextBox tbxNoiDi;
        private System.Windows.Forms.DateTimePicker dtpkGioBay;
        private System.Windows.Forms.TextBox tbxNoiDen;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label lblGayBay;
        private System.Windows.Forms.Label lblGioBay;
        private System.Windows.Forms.Label lblNoiDi;
        private System.Windows.Forms.Label lblNoiDen;
    }
}