namespace QLVMB
{
    partial class frmThemMB
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
            this.lblTenMB = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.tbxTenMB = new System.Windows.Forms.TextBox();
            this.btnthem = new System.Windows.Forms.Button();
            this.lblTongGhe = new System.Windows.Forms.Label();
            this.tbxTongGhe = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblTenMB
            // 
            this.lblTenMB.AutoSize = true;
            this.lblTenMB.Location = new System.Drawing.Point(12, 20);
            this.lblTenMB.Name = "lblTenMB";
            this.lblTenMB.Size = new System.Drawing.Size(76, 13);
            this.lblTenMB.TabIndex = 0;
            this.lblTenMB.Text = "Tên Máy Bay :";
            // 
            // btnBack
            // 
            this.btnBack.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnBack.Location = new System.Drawing.Point(225, 148);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // tbxTenMB
            // 
            this.tbxTenMB.Location = new System.Drawing.Point(125, 17);
            this.tbxTenMB.Name = "tbxTenMB";
            this.tbxTenMB.Size = new System.Drawing.Size(175, 20);
            this.tbxTenMB.TabIndex = 2;
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(144, 148);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(75, 23);
            this.btnthem.TabIndex = 3;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // lblTongGhe
            // 
            this.lblTongGhe.AutoSize = true;
            this.lblTongGhe.Location = new System.Drawing.Point(13, 87);
            this.lblTongGhe.Name = "lblTongGhe";
            this.lblTongGhe.Size = new System.Drawing.Size(59, 13);
            this.lblTongGhe.TabIndex = 4;
            this.lblTongGhe.Text = "Tổng ghế :";
            // 
            // tbxTongGhe
            // 
            this.tbxTongGhe.Location = new System.Drawing.Point(125, 84);
            this.tbxTongGhe.Name = "tbxTongGhe";
            this.tbxTongGhe.Size = new System.Drawing.Size(175, 20);
            this.tbxTongGhe.TabIndex = 5;
            // 
            // frmThemMB
            // 
            this.AcceptButton = this.btnthem;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnBack;
            this.ClientSize = new System.Drawing.Size(312, 183);
            this.ControlBox = false;
            this.Controls.Add(this.tbxTongGhe);
            this.Controls.Add(this.lblTongGhe);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.tbxTenMB);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblTenMB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmThemMB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmThemMB";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTenMB;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox tbxTenMB;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Label lblTongGhe;
        private System.Windows.Forms.TextBox tbxTongGhe;
    }
}