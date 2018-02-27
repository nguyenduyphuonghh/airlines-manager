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
    public partial class frmThemCB : Form
    {
        string cnn = ConfigurationManager.ConnectionStrings["connect"].ToString();
        //String cnn = @"Data Source=DESKTOP-EFCIJCU\SQLEXPRESS;Initial Catalog=QUANLYVEMAYBAY2;Integrated Security=True";

        public frmThemCB()
        {
            InitializeComponent();
            getMaMB();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            if (dtpkNgayBay.Text != "" || dtpkGioBay.Text != "" || tbxNoiDi.Text != tbxNoiDi.Tag + "" || tbxNoiDen.Text != tbxNoiDen.Tag + "")
            {
                if (MessageBox.Show("Bạn đang thêm dữ liệu, vẫn muốn thoát?", "Thoát", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    this.Close();
                }
                else
                {

                }
            }
            else
            {
                this.Close();
            }
        }
        public void getMaMB()
        {
            String query = "sp_getMaMB";
            try
            {
                using (SqlConnection conn = new SqlConnection(cnn))
                {
                    conn.Open();
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
                    conn.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            themCB();
        }
        public void themCB()
        {
            String query = "sp_themCB";
            if (tbxNoiDi.Text != tbxNoiDi.Tag + "" && tbxNoiDen.Text != tbxNoiDen.Tag + "")
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(cnn))
                    {
                        conn.Open();
                        using (SqlCommand cm = new SqlCommand(query, conn))
                        {
                            cm.CommandType = CommandType.StoredProcedure;
                            cm.Parameters.AddWithValue("maMayBay", cboMaMB.Text.ToString());
                            cm.Parameters.AddWithValue("ngayBay", dtpkNgayBay.Value.ToString("dd/MM/yyyy"));
                            cm.Parameters.AddWithValue("gioBay", dtpkGioBay.Value.ToString("HH:mm:ss"));
                            cm.Parameters.AddWithValue("noiDi", tbxNoiDi.Text.ToString());
                            cm.Parameters.AddWithValue("noiDen", tbxNoiDen.Text.ToString());
                            if (cm.ExecuteNonQuery() == 1)
                            {
                                MessageBox.Show("Thêm chuyến bay thành công !");
                            }
                            else
                            {
                                MessageBox.Show("Dữ liệu bị trùng !");
                            }
                        }
                        conn.Close();

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Kiểm tra lại dữ liệu !");
            }
        }
    }
}
