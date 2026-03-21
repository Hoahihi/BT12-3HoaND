using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QLSV
{
    public partial class frm_QuanLyLopBACKUP : Form
    {

        string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=QLSV_DB;Integrated Security=True;";
        public frm_QuanLyLopBACKUP()
        {
            InitializeComponent();  
            dataGridView1.AllowUserToAddRows = false;
        }
        private void LoadData()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    // Lấy 4 cột từ bảng Lop trong SQL
                    string query = "SELECT L.IdLop,L.TenLop, L.Note FROM Lop as L";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dataGridView1.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message);
                }
            }
        }
        private void Quaylai_btn_Click(object sender, EventArgs e)
        {
            frm_main t = new frm_main();
            this.Close();
            t.Show();
        }

        private void Them1_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(IDLop_tbx.Text) || string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Vui lòng nhập ít nhất ID Lớp và Tên Lớp!");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    // Đã xóa SoSV khỏi câu lệnh INSERT
                    string query = "INSERT INTO Lop (IdLop, TenLop, Note) VALUES (@id, @ten, @note)";
                    SqlCommand cmd = new SqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@id", IDLop_tbx.Text.Trim());
                    cmd.Parameters.AddWithValue("@ten", textBox1.Text.Trim());
                    cmd.Parameters.AddWithValue("@note", Note_tbx.Text.Trim());

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm lớp thành công!");
                    LoadData();
                    Lammoi1_btn_Click(sender, e);
                }
                catch (Exception)
                {
                    MessageBox.Show("Lỗi: ID Lớp này đã tồn tại!");
                }
            }
        }

        private void Sua2_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(IDLop_tbx.Text))
            {
                MessageBox.Show("Vui lòng chọn một lớp dưới bảng để sửa!");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "UPDATE Lop SET TenLop = @ten, Note = @note WHERE IdLop = @id";
                    SqlCommand cmd = new SqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@id", IDLop_tbx.Text.Trim());
                    cmd.Parameters.AddWithValue("@ten", textBox1.Text.Trim());
                    cmd.Parameters.AddWithValue("@note", Note_tbx.Text.Trim());

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cập nhật thành công!");
                    LoadData();
                    Lammoi1_btn_Click(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        private void Xoa1_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(IDLop_tbx.Text))
            {
                MessageBox.Show("Vui lòng chọn lớp cần xóa!");
                return;
            }

            if (MessageBox.Show("Bạn có chắc muốn xóa lớp này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        string query = "DELETE FROM Lop WHERE IdLop = @id";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@id", IDLop_tbx.Text.Trim());

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Xóa thành công!");
                        LoadData();
                        Lammoi1_btn_Click(sender, e);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Lỗi: Không thể xóa lớp này (Có thể đang có sinh viên tham chiếu đến).");
                    }
                }
            }
        }

        private void Lammoi1_btn_Click(object sender, EventArgs e)
        {
            IDLop_tbx.Clear();
            textBox1.Clear();
            Note_tbx.Clear();

            IDLop_tbx.Enabled = true;
            IDLop_tbx.Focus();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dataGridView1.Rows[e.RowIndex].Cells[0].Value != null)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                IDLop_tbx.Text = row.Cells[0].Value.ToString();
                textBox1.Text = row.Cells[1].Value.ToString();

                Note_tbx.Text = row.Cells[2].Value.ToString();

                IDLop_tbx.Enabled = false;
            }
        }

        private void QuanLyLop_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
