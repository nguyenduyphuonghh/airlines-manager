using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace QLVMB
{
    public partial class frmThongKe : Form
    {
        string cnn = ConfigurationManager.ConnectionStrings["connect"].ToString();
        //String cnn = @"Data Source=DESKTOP-EFCIJCU\SQLEXPRESS;Initial Catalog=QUANLYVEMAYBAY2;Integrated Security=True";

        public frmThongKe()
        {
            InitializeComponent();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            frmMainForm frmMainForm = new frmMainForm();
            frmMainForm.Show();
            this.Close();
        }

        private void mn1TheoNgay_Click(object sender, EventArgs e)
        {
            gbTheoNgay.Visible = true;
            btnThongKe.Visible = true;
        }
    }
}
