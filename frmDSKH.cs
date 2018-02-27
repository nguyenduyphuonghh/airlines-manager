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
    public partial class frmDSKH : Form
    {
        //String cnn = @"Data Source=DESKTOP-EFCIJCU\SQLEXPRESS;Initial Catalog=QUANLYVEMAYBAY2;Integrated Security=True";
        string cnn = ConfigurationManager.ConnectionStrings["connect"].ToString();
        public frmDSKH()
        {
            InitializeComponent();
            LoadInfor();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmMainForm mainForm = new frmMainForm();
            mainForm.Show();
            this.Close();
        }
        public void LoadInfor()
        {
            String query = "sp_getDSKH";
            try
            {
                using (SqlConnection conn = new SqlConnection(cnn))
                {
                    using (SqlCommand cm = new SqlCommand(query, conn))
                    {
                        cm.CommandType = CommandType.StoredProcedure;
                        DataTable table = new DataTable();
                        SqlDataAdapter adapter = new SqlDataAdapter(cm);
                        adapter.Fill(table);
                        dtgvDSKH.DataSource = table;
                        dtgvDSKH.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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
