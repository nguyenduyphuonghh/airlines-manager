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
    public partial class frmThemMB : Form
    {
        string cnn = ConfigurationManager.ConnectionStrings["connect"].ToString();
        //String cnn = @"Data Source=DESKTOP-EFCIJCU\SQLEXPRESS;Initial Catalog=QUANLYVEMAYBAY2;Integrated Security=True";

        public frmThemMB()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (tbxTenMB.Text != tbxTenMB.Tag + "" || tbxTongGhe.Text != tbxTongGhe.Tag + "")
            {
                if (MessageBox.Show("Bạn đang thêm dữ liệu, vẫn muốn thoát?", "Thoát", MessageBoxButtons.OKCancel) == DialogResult.OK)
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

        private void btnthem_Click(object sender, EventArgs e)
        {
            themMB();
        }
        public void themMB()
        {
            String query = "sp_themMB";
            if (tbxTenMB.Text != tbxTenMB.Tag + "" && tbxTongGhe.Text != tbxTongGhe.Tag + "")
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(cnn))
                    {
                        conn.Open();
                        using (SqlCommand cm = new SqlCommand(query, conn))
                        {
                            cm.CommandType = CommandType.StoredProcedure;
                            cm.Parameters.AddWithValue("tenMayBay", tbxTenMB.Text);
                            cm.Parameters.AddWithValue("tongGhe", tbxTongGhe.Text);
                            if (cm.ExecuteNonQuery() == 1)
                            {
                                MessageBox.Show("Thêm máy bay thành công !");
                            }
                            else
                            {
                                MessageBox.Show("Máy bay tên " + tbxTenMB.Text + " đã có trong danh sách !");
                            }
                        }
                        conn.Close();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Dữ liệu bị trùng !");
                }
            }
            else
            {
                MessageBox.Show("Kiểm tra lại dữ liệu !");
            }
        }
    }
}
