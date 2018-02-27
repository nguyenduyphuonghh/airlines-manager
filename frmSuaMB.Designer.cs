namespace QLVMB
{
    partial class frmSuaMB
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
            this.tbxTenMB = new System.Windows.Forms.TextBox();
            this.tbxTongGhe = new System.Windows.Forms.TextBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.lbltenMB = new System.Windows.Forms.Label();
            this.lblTongGhe = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMaMB
            // 
            this.lblMaMB.AutoSize = true;
            this.lblMaMB.Location = new System.Drawing.Point(12, 24);
            this.lblMaMB.Name = "lblMaMB";
            this.lblMaMB.Size = new System.Drawing.Size(70, 13);
            this.lblMaMB.TabIndex = 0;
            this.lblMaMB.Text = "Mã máy bay :";
            // 
            // btnback
            // 
            this.btnback.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnback.Location = new System.Drawing.Point(213, 172);
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
            this.cboMaMB.Location = new System.Drawing.Point(132, 21);
            this.cboMaMB.Name = "cboMaMB";
            this.cboMaMB.Size = new System.Drawing.Size(156, 21);
            this.cboMaMB.TabIndex = 2;
            // 
            // tbxTenMB
            // 
            this.tbxTenMB.Location = new System.Drawing.Point(132, 71);
            this.tbxTenMB.Name = "tbxTenMB";
            this.tbxTenMB.Size = new System.Drawing.Size(156, 20);
            this.tbxTenMB.TabIndex = 3;
            // 
            // tbxTongGhe
            // 
            this.tbxTongGhe.Location = new System.Drawing.Point(132, 118);
            this.tbxTongGhe.Name = "tbxTongGhe";
            this.tbxTongGhe.Size = new System.Drawing.Size(156, 20);
            this.tbxTongGhe.TabIndex = 4;
            this.tbxTongGhe.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxTongGhe_KeyPress);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(132, 172);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 5;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // lbltenMB
            // 
            this.lbltenMB.AutoSize = true;
            this.lbltenMB.Location = new System.Drawing.Point(12, 74);
            this.lbltenMB.Name = "lbltenMB";
            this.lbltenMB.Size = new System.Drawing.Size(74, 13);
            this.lbltenMB.TabIndex = 6;
            this.lbltenMB.Text = "Tên máy bay :";
            // 
            // lblTongGhe
            // 
            this.lblTongGhe.AutoSize = true;
            this.lblTongGhe.Location = new System.Drawing.Point(12, 121);
            this.lblTongGhe.Name = "lblTongGhe";
            this.lblTongGhe.Size = new System.Drawing.Size(73, 13);
            this.lblTongGhe.TabIndex = 7;
            this.lblTongGhe.Text = "Tổng số ghế :";
            // 
            // frmSuaMB
            // 
            this.AcceptButton = this.btnSua;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnback;
            this.ClientSize = new System.Drawing.Size(296, 204);
            this.ControlBox = false;
            this.Controls.Add(this.lblTongGhe);
            this.Controls.Add(this.lbltenMB);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.tbxTongGhe);
            this.Controls.Add(this.tbxTenMB);
            this.Controls.Add(this.cboMaMB);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.lblMaMB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmSuaMB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSuaMB";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMaMB;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.ComboBox cboMaMB;
        private System.Windows.Forms.TextBox tbxTenMB;
        private System.Windows.Forms.TextBox tbxTongGhe;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Label lbltenMB;
        private System.Windows.Forms.Label lblTongGhe;
    }
}