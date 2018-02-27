using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLVMB
{
    public partial class frmMainForm : Form
    {
        public frmMainForm()
        {
            InitializeComponent();
        }

        private void btnBanVe_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDatVe formDatVe = new FormDatVe();
            formDatVe.ShowDialog();
            this.Close();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát ứng dụng ?","Thoát",MessageBoxButtons.OKCancel,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2)== DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            frmTimKiem frmTimKiem = new frmTimKiem();
            frmTimKiem.Show();
            this.Hide();
        }

        private void btnMayBay_Click(object sender, EventArgs e)
        {
            frmMayBay frmMayBay = new frmMayBay();
            frmMayBay.Show();
            this.Hide();
        }

        private void btnKH_Click(object sender, EventArgs e)
        {
            frmDSKH frmDSKH = new frmDSKH();
            frmDSKH.Show();
            this.Hide();
        }

        private void btnDSVe_Click(object sender, EventArgs e)
        {
            frmDSVe frmDSVe = new frmDSVe();
            frmDSVe.Show();
            this.Hide();
        }

        private void btnDSCB_Click(object sender, EventArgs e)
        {
            frmDSCB frmDSCB = new frmDSCB();
            frmDSCB.Show();
            this.Hide();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            frmThongKe frmThongKe = new frmThongKe();
            frmThongKe.Show();
            this.Hide();
        }
    }
}
