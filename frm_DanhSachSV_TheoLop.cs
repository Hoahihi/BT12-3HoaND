using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV
{
    public partial class frm_DanhSachSV_TheoLop : Form
    {

        string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=QLSV_DB;Integrated Security=True;TrustServerCertificate=True;";
        string maLopDangXem = "";
        public frm_DanhSachSV_TheoLop(string maLop)
        {
            InitializeComponent();
            maLopDangXem = maLop; 
        }
        public frm_DanhSachSV_TheoLop()
        {
            InitializeComponent();
        }

        private void frm_DanhSachSV_TheoLop_Load(object sender, EventArgs e)
        {
            this.Text = "Danh sách sinh viên của lớp: " + maLopDangXem;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM SinhVien WHERE Lop = @ml";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ml", maLopDangXem);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgv_DanhSach.DataSource = dt;
                    dgv_DanhSach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("Lớp này hiện tại chưa có sinh viên nào!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi lấy danh sách: " + ex.Message);
                }
            }
        }
    }
}