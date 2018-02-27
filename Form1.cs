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
    public partial class FormDatVe : Form
    {
        string cnn = ConfigurationManager.ConnectionStrings["connect"].ToString();
        //String cnn = @"Data Source=DESKTOP-EFCIJCU\SQLEXPRESS;Initial Catalog=QUANLYVEMAYBAY2;Integrated Security=True";
        frmMainForm frmMainForm = new frmMainForm();
        public FormDatVe()
        {
            InitializeComponent();
        }
        private bool addKH(string tenkh, string sohochieu, DateTime ngaysinh, Int16 gioitinh, string diachi, string sdt, string quoctich)
        {
            bool Authen = true;
            try
            {
                using (SqlConnection cn = new SqlConnection(cnn))
                {
                    cn.Open();
                    using (SqlCommand cm = new SqlCommand("spKH_AddKH", cn))
                    {
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("@tenKH",tenkh);
                        cm.Parameters.AddWithValue("@soHoChieu", sohochieu);
                        cm.Parameters.AddWithValue("@ngaySinh", ngaysinh);
                        cm.Parameters.AddWithValue("@gioiTinh", gioitinh);
                        cm.Parameters.AddWithValue("@diaChi", diachi);
                        cm.Parameters.AddWithValue("@sdt", sdt);
                        cm.Parameters.AddWithValue("@quocTich", quoctich);
                        SqlDataReader dr;
                        dr = cm.ExecuteReader();
                        Authen = dr.HasRows ? true : false;
                        if (dr.HasRows)
                        {
                            dr.Read();
                            txtMaKH.Text = dr[0] + "";
                        }
                        else
                        {
                            //MessageBox.Show("Lỗi k thêm được khách hàng");
                        }
                        dr.Close();
                    }
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Xem lại định dạng ngày tháng đi, bảo rồi mà!");
                return false;
            }
            return Authen;
        }
        private void loadDiaDiem()
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(cnn))
                {
                    cn.Open();
                    using (SqlCommand cm = new SqlCommand("spCB_getDiaDiem", cn))
                    {
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("@maChuyenBay",0);
                        cm.Parameters.AddWithValue("@noiDi", cbNoiDi.Text);
                        cm.Parameters.AddWithValue("@noiDen", cbNoiDen.Text);                        
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cm))
                        {
                                DataTable dt = new DataTable();
                                adapter.Fill(dt);
                                if (dt.Rows.Count > 0)
                                {
                                    cbNgayBay.DataSource = dt;
                                    cbNgayBay.DisplayMember = "ngayBay";
                                    cbNgayBay.ValueMember = "maChuyenBay";

                                    cbGioBay.DataSource = dt;
                                    cbGioBay.DisplayMember = "gioBay";
                                    cbGioBay.ValueMember = "maChuyenBay";

                                    cbMaChuyenBay.DataSource = dt;
                                    cbMaChuyenBay.DisplayMember = "maChuyenBay";
                                    cbMaChuyenBay.ValueMember = "maChuyenBay";

                                    cbMaMayBay.DataSource = dt;
                                    cbMaMayBay.DisplayMember = "maMayBay";
                                    cbMaMayBay.ValueMember = "maMayBay";
                                }
                                else
                                {
                                    MessageBox.Show("Không thể thực hiện!");

                                }

                        }//adapter
                    }//command
                    

                }//connecttion         
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Application.Exit();
            }
        }//load Diem di
        private bool addVe(Int16 maloaive, int makh, int macb, int idghe, DateTime ngayban, DateTime gioban )
        {
            bool Authen = true;
            try
            {
                using (SqlConnection cn = new SqlConnection(cnn))
                {
                    cn.Open();
                    using (SqlCommand cm = new SqlCommand("spVe_AddVe", cn))
                    {
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("@maLoaiVe", maloaive);
                        cm.Parameters.AddWithValue("@maKhachHang", makh);
                        cm.Parameters.AddWithValue("@maChuyenBay", macb);
                        cm.Parameters.AddWithValue("@IDghe", idghe);
                        cm.Parameters.AddWithValue("@ngayBan", ngayban);
                        cm.Parameters.AddWithValue("@gioBan", gioban);

                        SqlDataReader dr;
                        dr = cm.ExecuteReader();
                        Authen = dr.HasRows ? true : false;
                        if (dr.HasRows)
                        {
                            dr.Read();
                            txtMaVe.Text = dr[0] + "";
                        }
                        else
                        {
                            //MessageBox.Show("Lỗi k thêm được vé");
                        }
                        dr.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return Authen;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            cbNoiDi.Items.Add("Hanoi");
            cbNoiDi.Items.Add("HoChiMinh");
            cbNoiDi.Items.Add("DaNang");
            cbNoiDi.Items.Add("HaiPhong"); cbNoiDi.SelectedIndex = 1;
            cbNoiDen.Items.Add("Hanoi");
            cbNoiDen.Items.Add("HoChiMinh");
            cbNoiDen.Items.Add("DaNang");
            cbNoiDen.Items.Add("HaiPhong"); cbNoiDen.SelectedIndex = 0;
            cbMaMayBay.Items.Add("5"); cbMaMayBay.SelectedIndex = 0;
            cbMaMayBay.Tag = cbMaMayBay.Text;
            cbSoGhe.Tag = cbSoGhe.Text;
            cbMaChuyenBay.Tag = cbMaChuyenBay.Text;
            cbGioBay.Tag = cbGioBay.Text;
            cbNgayBay.Tag = cbNgayBay.Text;
            rdoNam.Checked = true;
            rdoNam.Tag = rdoNam.Checked;
            rdoThuongGia.Checked = true;
            rdoThuongGia.Tag = rdoThuongGia.Checked;
            txtGioBan.Text = DateTime.Now.ToString("hh:mm:ss");
            txtNgayBan.Text = DateTime.Now.ToString("MM/dd/yyyy");
            
            txtTenKH.Tag = txtTenKH.Text;
            txtTenKH.Focus();
            txtNgaySinh.Text = "MM/dd/yyyy";
            txtNgaySinh.ForeColor = Color.Gray;
            txtNgaySinh.Tag = txtNgaySinh.Text;
            txtHoChieu.Tag = txtHoChieu.Text;
            txtDiaChi.Tag = txtDiaChi.Text;
            txtSdt.Tag = txtSdt.Text;
            txtQuocTich.Tag = txtQuocTich.Text;

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (txtTenKH.Text != txtTenKH.Tag + "" || txtNgaySinh.Text != txtNgaySinh.Tag + "" || txtHoChieu.Text != txtHoChieu.Tag + ""
                || txtDiaChi.Text != txtDiaChi.Tag + "" || txtSdt.Text != txtSdt.Tag + "" || txtQuocTich.Text != txtQuocTich.Tag + "" || rdoNam.Checked != (bool)rdoNam.Tag)
            {
                if (MessageBox.Show("Bạn đang có dữ liệu được chỉnh sửa, vẫn muốn thoát?", "Cảnh báo!", MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.OK)
                {
                    this.Hide();
                    frmMainForm form = new frmMainForm();
                    form.ShowDialog();
                    this.Close();
                }

            }
            else
            {
                this.Hide();
                frmMainForm form = new frmMainForm();
                form.ShowDialog();
                this.Close();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime dt;
                dt = Convert.ToDateTime(txtNgaySinh.Text);
                Int16 gtnam = Convert.ToByte(rdoNam.Checked);
                if (addKH(txtTenKH.Text, txtHoChieu.Text, dt, gtnam, txtDiaChi.Text, txtSdt.Text, txtQuocTich.Text))
                {

                    //MessageBox.Show("Thêm kh thành công mỹ mãn");
                    Int16 thuonggia = Convert.ToByte(rdoThuongGia.Checked);
                    Int16 phothong = Convert.ToByte(rdoPhoThong.Checked);
                    int makh = int.Parse(txtMaKH.Text);
                    int macb = int.Parse(cbMaChuyenBay.Text.ToString());
                    int idghe = int.Parse(cbSoGhe.SelectedValue.ToString());
                    DateTime nb = Convert.ToDateTime(txtNgayBan.Text);
                    DateTime gb = Convert.ToDateTime(txtGioBan.Text);
                    if (addVe(thuonggia, makh, macb, idghe,nb,gb))
                    {
                        MessageBox.Show("Thêm vé thành công");
                    }
                    else
                    {
                        MessageBox.Show("Ghế này đã có người đặt rồi!");
                    }
                }
                else
                {
                    //MessageBox.Show("khách hàng đã tồn tại trong hệ thống");
                    Int16 thuonggia = Convert.ToByte(rdoThuongGia.Checked);
                    //Int16 phothong = Convert.ToByte(rdoPhoThong.Checked);
                    int makh = int.Parse(txtMaKH.Text);
                    int macb = int.Parse(cbMaChuyenBay.Text.ToString());
                    int idghe = int.Parse(cbSoGhe.SelectedValue.ToString());
                    DateTime nb = Convert.ToDateTime(txtNgayBan.Text);
                    DateTime gb = Convert.ToDateTime(txtGioBan.Text);
                    if (addVe(thuonggia, makh, macb, idghe,gb,nb))
                    {
                        MessageBox.Show("Thêm vé thành công");
                    }
                    else
                    {
                        MessageBox.Show("Ghế này đã có người đặt rồi!");
                    }
                }
                
            }
            catch (Exception)
            {
                MessageBox.Show("Ngày sinh chưa đúng! Xem lại!");
            }
        }

        private void btnKiemTra_Click(object sender, EventArgs e)
        {
            loadDiaDiem();
        }

        private void cbMaMayBay_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(cnn))
                {
                    using (SqlCommand cm = new SqlCommand("spGheNgoi_getByMaMayBay", cn))
                    {
                        cm.CommandType = CommandType.StoredProcedure;
                        int kq = int.Parse(cbMaMayBay.Text.ToString());
                        cm.Parameters.AddWithValue("@maMayBay", kq);
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cm))
                        {
                            DataTable dt = new DataTable();

                            adapter.Fill(dt);

                            cbSoGhe.DataSource = dt;
                            cbSoGhe.DisplayMember = "soGhe";
                            cbSoGhe.ValueMember = "IDghe";
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            rdoNam.Checked = (bool)rdoNam.Tag;
            rdoThuongGia.Checked = (bool)rdoThuongGia.Tag;
            txtTenKH.Text = txtTenKH.Tag.ToString();
            txtNgaySinh.Text = txtNgaySinh.Tag.ToString();
            txtNgaySinh.ForeColor = Color.Gray;
            txtHoChieu.Text = txtHoChieu.Tag.ToString();
            txtDiaChi.Text = txtDiaChi.Tag.ToString();
            txtSdt.Text = txtSdt.Tag.ToString();
            txtQuocTich.Text = txtQuocTich.Tag.ToString();
            cbMaChuyenBay.Text = cbMaChuyenBay.Tag.ToString();
            cbGioBay.Text = cbGioBay.Tag.ToString();
            cbNgayBay.Text = cbNgayBay.Tag.ToString();
            cbMaMayBay.Text = cbMaMayBay.Tag.ToString();
            cbSoGhe.Text = cbSoGhe.Tag.ToString();
        }

        private void txtTenKH_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenKH.Text))
            {
                e.Cancel = true;
                txtTenKH.Focus();
                epTenKH.SetError(txtTenKH, "Không được để trống");
            }
            else
            {
                e.Cancel = false;
                epTenKH.SetError(txtTenKH, null);
            }
        }

        private void txtNgaySinh_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtNgaySinh.Text))
            {
                e.Cancel = true;
                txtNgaySinh.Focus();
                epNgaySinh.SetError(txtNgaySinh, "Không được để trống");
            }
            else
            {
                e.Cancel = false;
                epNgaySinh.SetError(txtNgaySinh, null);
            }
        }

        private void txtHoChieu_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtHoChieu.Text))
            {
                e.Cancel = true;
                txtHoChieu.Focus();
                epHoChieu.SetError(txtHoChieu, "Không được để trống");
            }
            else
            {
                e.Cancel = false;
                epHoChieu.SetError(txtHoChieu, null);
            }
        }

        private void txtDiaChi_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtDiaChi.Text))
            {
                e.Cancel = true;
                txtDiaChi.Focus();
                epDiaChi.SetError(txtDiaChi, "Không được để trống");
            }
            else
            {
                e.Cancel = false;
                epDiaChi.SetError(txtDiaChi, null);
            }
        }

        private void txtSdt_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtSdt.Text))
            {
                e.Cancel = true;
                txtSdt.Focus();
                epSdt.SetError(txtSdt, "Không được để trống");
            }
            else
            {
                e.Cancel = false;
                epSdt.SetError(txtSdt, null);
            }
        }

        private void txtQuocTich_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtQuocTich.Text))
            {
                e.Cancel = true;
                txtQuocTich.Focus();
                epQuocTich.SetError(txtQuocTich, "Không được để trống");
            }
            else
            {
                e.Cancel = false;
                epQuocTich.SetError(txtQuocTich, null);
            }
        }

        private void txtGioBan_Click(object sender, EventArgs e)
        {
            txtGioBan.Text = DateTime.Now.ToString("hh:mm:ss");
        }

        private void txtNgaySinh_TextChanged(object sender, EventArgs e)
        {
            txtNgaySinh.ForeColor = Color.Black;
        }

        private void txtNgaySinh_Click(object sender, EventArgs e)
        {
            txtNgaySinh.Text = "";
            txtNgaySinh.Focus();
        }

        private void txtNgaySinh_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= 48 && e.KeyChar <= 57) && !(e.KeyChar == 47) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                epNgaySinh.SetError(txtNgaySinh,"Chỉ các ký tự số và / (MM/dd/yyyy)");
            }
            if (e.KeyChar == (char)Keys.Return)
            {
                txtHoChieu.Focus();
            }
        }

        private void txtTenKH_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (!(e.KeyChar >= 65 && e.KeyChar <= 90) || !(e.KeyChar >= 97 && e.KeyChar <= 122) && !(e.KeyChar == 32) && !Char.IsControl(e.KeyChar))
            if(!char.IsControl(e.KeyChar) && char.IsDigit(e.KeyChar)) 
            {
                e.Handled = true;
                epTenKH.SetError(txtTenKH,"Không được nhập số đâu!");
            }
            if (e.KeyChar == (char)Keys.Return)
            {
                txtNgaySinh.Text = "";
                txtNgaySinh.Focus();
            }
        }

        private void txtHoChieu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= 65 && e.KeyChar <= 90) && !Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                epHoChieu.SetError(txtHoChieu,"Chỉ các ký tự in hoa và số");
            }
            if (e.KeyChar == (char)Keys.Return)
            {
                rdoNam.Focus();
            }
        }

        private void rdoNam_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                txtDiaChi.Focus();
            }
            if (e.KeyChar == (char)Keys.Right)
            {
                rdoNu.Focus();
            } 
        }

        private void rdoNu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                txtDiaChi.Focus();
            }
        }

        private void txtDiaChi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                txtSdt.Focus();
            }
        }

        private void txtSdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar==43) && !Char.IsControl(e.KeyChar) && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                epSdt.SetError(txtSdt, "Chỉ dấu + và số thôi)");
            }
            if (e.KeyChar == (char)Keys.Return)
            {
                txtQuocTich.Focus();
            }
        }

        private void txtQuocTich_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (!(e.KeyChar >= 65 && e.KeyChar <= 90) || !(e.KeyChar >= 97 && e.KeyChar <= 122) && !(e.KeyChar == 32) && !Char.IsControl(e.KeyChar))
            if (!char.IsControl(e.KeyChar) && char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                epQuocTich.SetError(txtQuocTich, "Không được nhập số !");
            }
            if (e.KeyChar == (char)Keys.Return)
            {
                btnKiemTra.Visible = true;
                btnLuu.Visible = true;
                cbNoiDi.Focus();
            }
        }

        private void cbNoiDi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                cbNoiDen.Focus();
            }
        }

        private void cbNoiDen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                btnKiemTra.Focus();
            }
        }

        private void btnKiemTra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Right)
            {
                cbGioBay.Focus();
            }
        }

        private void cbGioBay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                cbNgayBay.Focus();
            }
        }

        private void cbNgayBay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                cbSoGhe.Focus();
            }
        }
    }
}
