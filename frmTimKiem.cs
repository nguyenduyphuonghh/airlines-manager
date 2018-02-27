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
    public partial class frmTimKiem : Form
    {
        string cnn = ConfigurationManager.ConnectionStrings["connect"].ToString();
        //String cnn = @"Data Source=DESKTOP-EFCIJCU\SQLEXPRESS;Initial Catalog=QUANLYVEMAYBAY2;Integrated Security=True";
        bool isNgayBay = false, isHanhTrinh = false, isTenKH = false, isHoChieu = false;
        frmMainForm frmMainForm = new frmMainForm();
        
        public frmTimKiem()
        {
            InitializeComponent();
            LoadInfor();
        }

        

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmMainForm.Show();
            this.Close();
        }
        private void mn1NgayBay_Click(object sender, EventArgs e)
        {
            gbNgayBay.Visible = true;
            gbHanhTrinh.Visible = false;
            gbTenKH.Visible = false;
            gbHoChieu.Visible = false;
            btnTimKiem.Visible = true;
            isNgayBay = true;
            isHanhTrinh = false;
            isTenKH = false;
            isHoChieu = false;
        }
        private void mn1HanhTrinh_Click(object sender, EventArgs e)
        {
            gbHanhTrinh.Visible = true;
            gbNgayBay.Visible = false;
            gbTenKH.Visible = false;
            gbHoChieu.Visible = false;
            btnTimKiem.Visible = true;
            isHanhTrinh = true;
            isTenKH = false;
            isHoChieu = false;
            isNgayBay = false;
        }
        private void mn1tenKH_Click(object sender, EventArgs e)
        {
            gbTenKH.Visible = true;
            gbNgayBay.Visible = false;
            gbHanhTrinh.Visible = false;
            gbHoChieu.Visible = false;
            btnTimKiem.Visible = true;
            isTenKH = true;
            isHoChieu = false;
            isNgayBay = false;
            isHanhTrinh = false;
        }
        private void mn1HoChieuKH_Click(object sender, EventArgs e)
        {
            gbHoChieu.Visible = true;
            gbTenKH.Visible = false;
            gbNgayBay.Visible = false;
            gbHanhTrinh.Visible = false;
            btnTimKiem.Visible = true;
            isHoChieu = true;
            isNgayBay = false;
            isHanhTrinh = false;
            isTenKH = false;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            TimKiem();
        }

        public void LoadInfor() {
            try
            {
                using (SqlConnection conn = new SqlConnection(cnn))
                {
                    String query = "sp_getDiemDi";
                    String query2 = "sp_getDiemDen";
                    using (SqlCommand cm = new SqlCommand(query, conn))
                    {
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("noiDi", "");
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cm))
                        {
                            DataTable table = new DataTable();
                            adapter.Fill(table);
                            if (table.Rows.Count > 0)
                            {
                                cboTu.DataSource = table;
                                cboTu.DisplayMember = "noiDi";
                            }
                        }
                    }
                    using (SqlCommand cm = new SqlCommand(query2, conn))
                    {
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("noiDen", "");
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cm))
                        {
                            DataTable table = new DataTable();
                            adapter.Fill(table);
                            if (table.Rows.Count > 0)
                            {
                                cboDen.DataSource = table;
                                cboDen.DisplayMember = "noiDen";
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
        
        public void TimKiem()
        {
            String query = "";
            if (isNgayBay)
            {
                query = "sp_tkNgayBay";
            }
            if (isHanhTrinh)
            {
                query = "sp_tkHanhTrinh";
            }
            if (isTenKH)
            {
                query = "sp_tkTenKH";
            }
            if (isHoChieu)
            {
                query = "sp_tkHoChieu";
            }
            try
            {
                using (SqlConnection conn = new SqlConnection(cnn))
                {
                    using (SqlCommand cm = new SqlCommand(query, conn))
                    {
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("@tenKH", tbxTenKH.Text);
                        cm.Parameters.AddWithValue("@soHoChieu", tbxHoChieu.Text);
                        cm.Parameters.AddWithValue("@noiDi", cboTu.Text);
                        cm.Parameters.AddWithValue("@noiDen", cboDen.Text);
                        cm.Parameters.AddWithValue("@ngayTu", dtpkTu.Value.ToString("yyyy/MM/dd"));
                        cm.Parameters.AddWithValue("@ngayDen", dtpkDen.Value.ToString("yyyy/MM/dd"));
                        DataTable table = new DataTable();
                        SqlDataAdapter adapter = new SqlDataAdapter(cm);
                        adapter.Fill(table);
                        dtgvTimKiem.DataSource = table;
                        dtgvTimKiem.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        if (table.Rows.Count <= 0)
                        {
                            MessageBox.Show("Không tìm được kết quả theo yêu cầu !");
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
