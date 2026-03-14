using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLSV
{
    public partial class frm_main : Form
    {
        string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=QLSV_DB;Integrated Security=True;TrustServerCertificate=True;";

        public frm_main()
        {
            InitializeComponent();
            dataGridView1.AllowUserToAddRows = false; 
            dataGridView1.ReadOnly = true;            
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void frm_main_Load(object sender, EventArgs e)
        {
            LoadData("");
        }

        private void LoadData(string searchKey)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT MSSV AS 'MSSV', HoTen AS 'Họ và tên', NgaySinh AS 'Ngày sinh', Lop AS 'Lớp' FROM SinhVien";

                    if (!string.IsNullOrEmpty(searchKey))
                    {
                        query += " WHERE MSSV LIKE @key OR HoTen LIKE @key OR Lop LIKE @key";
                    }

                    SqlCommand cmd = new SqlCommand(query, conn);
                    if (!string.IsNullOrEmpty(searchKey))
                    {
                        cmd.Parameters.AddWithValue("@key", "%" + searchKey + "%");
                    }

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dt.Columns.Add("STT", typeof(int)).SetOrdinal(0);
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        dt.Rows[i]["STT"] = i + 1;
                    }

                    dataGridView1.DataSource = dt;
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi kết nối CSDL: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                MSSV_tbx.Text = row.Cells["MSSV"].Value.ToString();
                Name_tbx.Text = row.Cells["Họ và tên"].Value.ToString();

                DateTime dt;
                if (DateTime.TryParse(row.Cells["Ngày sinh"].Value.ToString(), out dt))
                {
                    dateTimePicker1.Value = dt;
                }

                Class_tbx.Text = row.Cells["Lớp"].Value.ToString();

                MSSV_tbx.Enabled = false;
            }
        }

        private void Lammoi_btn_Click(object sender, EventArgs e)
        {
            MSSV_tbx.Clear();
            Name_tbx.Clear();
            Class_tbx.Clear();
            dateTimePicker1.Value = DateTime.Today;
            Tim_tbx.Clear();

            MSSV_tbx.Enabled = true; 
            MSSV_tbx.Focus();

            LoadData(""); 
        }

        
        private void Add_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(MSSV_tbx.Text) || string.IsNullOrWhiteSpace(Name_tbx.Text))
            {
                MessageBox.Show("Vui lòng nhập ít nhất MSSV và Họ tên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO SinhVien (MSSV, HoTen, NgaySinh, Lop) VALUES (@mssv, @ten, @ngay, @lop)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@mssv", MSSV_tbx.Text.Trim());
                    cmd.Parameters.AddWithValue("@ten", Name_tbx.Text.Trim());
                    cmd.Parameters.AddWithValue("@ngay", dateTimePicker1.Value.Date);
                    cmd.Parameters.AddWithValue("@lop", Class_tbx.Text.Trim());

                    cmd.ExecuteNonQuery(); 

                    MessageBox.Show("Thêm sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Lammoi_btn_Click(sender, e); 
                }
                catch (Exception)
                {
                    MessageBox.Show("Lỗi: Mã sinh viên (MSSV) này đã tồn tại trong CSDL!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

      
        private void Sua_btn_Click(object sender, EventArgs e)
        {
            if (MSSV_tbx.Enabled == true)
            {
                MessageBox.Show("Vui lòng chọn 1 sinh viên từ bảng bên phải để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult dr = MessageBox.Show("Bạn có chắc chắn với sửa đổi này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        string query = "UPDATE SinhVien SET HoTen = @ten, NgaySinh = @ngay, Lop = @lop WHERE MSSV = @mssv";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@mssv", MSSV_tbx.Text.Trim());
                        cmd.Parameters.AddWithValue("@ten", Name_tbx.Text.Trim());
                        cmd.Parameters.AddWithValue("@ngay", dateTimePicker1.Value.Date);
                        cmd.Parameters.AddWithValue("@lop", Class_tbx.Text.Trim());

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Lammoi_btn_Click(sender, e);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi sửa: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }


        private void Xoa_btn_Click(object sender, EventArgs e)
        {
            if (MSSV_tbx.Enabled == true)
            {
                MessageBox.Show("Vui lòng chọn 1 sinh viên từ bảng bên phải để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa sinh viên này khỏi Database không?", "Cảnh báo Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        string query = "DELETE FROM SinhVien WHERE MSSV = @mssv";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@mssv", MSSV_tbx.Text.Trim());

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Đã xóa sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Lammoi_btn_Click(sender, e);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi xóa: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

 
        private void Tim_btn_Click(object sender, EventArgs e)
        {
            string keyword = Tim_tbx.Text.Trim();
            if (string.IsNullOrEmpty(keyword))
            {
                MessageBox.Show("Vui lòng nhập nội dung cần tìm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            LoadData(keyword); 
        }

    
        private void button1_Click(object sender, EventArgs e) 
        {
            QuanLyLop f = new QuanLyLop();
            f.Show();
            this.Hide();
        }

        private void Exit2_btn_Click(object sender, EventArgs e) 
        {
            Application.Exit();
        }
    }
}