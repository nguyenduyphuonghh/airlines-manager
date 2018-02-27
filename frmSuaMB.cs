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
    public partial class frmSuaMB : Form
    {
        string cnn = ConfigurationManager.ConnectionStrings["connect"].ToString();
        //String cnn = @"Data Source=DESKTOP-EFCIJCU\SQLEXPRESS;Initial Catalog=QUANLYVEMAYBAY2;Integrated Security=True";

        public frmSuaMB()
        {
            InitializeComponent();
            LoadInfor();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            if (tbxTenMB.Text != tbxTenMB.Tag + "" || tbxTongGhe.Text != tbxTongGhe.Tag + "")
            {
                if (MessageBox.Show("Bạn đang chỉnh sửa dữ liệu, vẫn muốn thoát?", "Thoát", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    this.Close();
                }
                else
                {
                    tbxTenMB.Text = tbxTenMB.Text;
                }
            }
            else
            {
                this.Close();
            }
        }

        private void tbxTongGhe_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        public void LoadInfor()
        {
            String query = "sp_getMaMB";
            try
            {
                using (SqlConnection conn = new SqlConnection(cnn))
                {
                    using (SqlCommand cm = new SqlCommand(query, conn))
                    {
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("maMayBay", 0);
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cm))
                        {
                            DataTable table = new DataTable();
                            adapter.Fill(table);
                            if (table.Rows.Count > 0)
                            {
                                cboMaMB.DataSource = table;
                                cboMaMB.DisplayMember = "maMayBay";
                            }
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            SuaMB();
        }
        public void SuaMB()
        {
            String query = "sp_suaMB";
            try
            {
                using (SqlConnection conn = new SqlConnection(cnn))
                {
                    conn.Open();
                    if (tbxTenMB.Text != "" && tbxTongGhe.Text != "")
                    {
                        using (SqlCommand cm = new SqlCommand(query, conn))
                        {
                            cm.CommandType = CommandType.StoredProcedure;
                            cm.Parameters.AddWithValue("maMayBay", cboMaMB.Text);
                            cm.Parameters.AddWithValue("tenMayBay", tbxTenMB.Text);
                            cm.Parameters.AddWithValue("tongGhe", tbxTongGhe.Text);
                            cm.ExecuteNonQuery();
                            MessageBox.Show("Sửa thành công !");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Kiểm tra lại dữ liệu !");
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
