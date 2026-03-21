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
    public partial class frm_TrangChu : Form
    {
        string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=QLSV_DB;Integrated Security=True;TrustServerCertificate=True;";
        int trangHienTai_SV = 1;
        int soDongMotTrang_SV = 10;
        public frm_TrangChu()
        {
            InitializeComponent();
        }

        private void frm_TrangChu_Load(object sender, EventArgs e)
        {
            LoadComboBoxLop();
            LoadDataSV_PhanTrang();
            LoadData_LopHoc();

        }
        private void LoadDataSV_PhanTrang()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    int dongBoQua = (trangHienTai_SV - 1) * soDongMotTrang_SV;
                    string query = @"SELECT * FROM SinhVien 
                             ORDER BY MSSV
                             OFFSET @dongBoQua ROWS 
                             FETCH NEXT @soDong ROWS ONLY";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@dongBoQua", dongBoQua);
                    cmd.Parameters.AddWithValue("@soDong", soDongMotTrang_SV);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgv_SinhVien.DataSource = dt;
                    lbl_SoTrang.Text = "Trang " + trangHienTai_SV.ToString();
                    if (dt.Rows.Count == 0 && trangHienTai_SV > 1)
                    {
                        MessageBox.Show("Đã đến trang cuối cùng!");
                        trangHienTai_SV--;
                        LoadDataSV_PhanTrang();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message);
                }
            }
        }
        private void LoadComboBoxLop()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT IdLop, (IdLop + ' - ' + TenLop) AS HienThi FROM Lop";

                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    cbx_Lop.DataSource = dt;
                    cbx_Lop.DisplayMember = "HienThi";
                    cbx_Lop.ValueMember = "IdLop";
                    cbx_Lop.SelectedIndex = -1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi lấy danh sách lớp: " + ex.Message);
                }
            }
        }
        private void LoadData_LopHoc()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT IdLop, TenLop, Note FROM Lop";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgv_LopHoc.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi tải dữ liệu lớp học: " + ex.Message);
                }
            }
        }

        private void btn_TrangTruoc_Click(object sender, EventArgs e)
        {
            if (trangHienTai_SV > 1)
            {
                trangHienTai_SV--;
                LoadDataSV_PhanTrang();
            }
        }

        private void btn_TrangSau_Click(object sender, EventArgs e)
        {
            trangHienTai_SV++;
            LoadDataSV_PhanTrang();
        }

        private void btn_ThemSV_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbx_MSSV.Text) || string.IsNullOrWhiteSpace(tbx_Name.Text))
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
                    cmd.Parameters.AddWithValue("@mssv", tbx_MSSV.Text.Trim());
                    cmd.Parameters.AddWithValue("@ten", tbx_Name.Text.Trim());
                    cmd.Parameters.AddWithValue("@ngay", NgaySinh.Value.Date);
                    cmd.Parameters.AddWithValue("@lop", cbx_Lop.SelectedValue.ToString());

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Thêm sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btn_LamMoiSV_Click(sender, e);
                }
                catch (Exception)
                {
                    MessageBox.Show("Lỗi: Mã sinh viên (MSSV) này đã tồn tại trong CSDL!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_SuaSV_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbx_MSSV.Text))
            {
                MessageBox.Show("Vui lòng chọn 1 sinh viên từ bảng để sửa thông tin!", "Thông báo");
                return;
            }
            DialogResult confirm = MessageBox.Show("Bạn có chắc chắn muốn cập nhật thông tin cho sinh viên: " + tbx_Name.Text + " không?",
                                                  "Xác nhận thay đổi",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        string query = @"UPDATE SinhVien 
                                 SET HoTen = @hoten, 
                                     NgaySinh = @ngaysinh, 
                                     Lop = @malop 
                                 WHERE MSSV = @mssv";

                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@mssv", tbx_MSSV.Text.Trim());
                        cmd.Parameters.AddWithValue("@hoten", tbx_Name.Text.Trim());
                        cmd.Parameters.AddWithValue("@ngaysinh", NgaySinh.Value);
                        if (cbx_Lop.SelectedValue != null)
                        {
                            cmd.Parameters.AddWithValue("@malop", cbx_Lop.SelectedValue.ToString());
                        }
                        else
                        {
                            MessageBox.Show("Vui lòng chọn lớp học!");
                            return;
                        }

                        int kq = cmd.ExecuteNonQuery();

                        if (kq > 0)
                        {
                            MessageBox.Show("Cập nhật thông tin thành công!", "Thành công");
                            LoadDataSV_PhanTrang();
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy sinh viên có mã " + tbx_MSSV.Text + " để sửa.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi sửa dữ liệu: " + ex.Message, "Lỗi kết nối");
                    }
                }
            }

        }

        private void btn_XoaSV_Click(object sender, EventArgs e)
        {
            if (tbx_MSSV.Text == "")
            {
                MessageBox.Show("Vui lòng click chọn 1 sinh viên từ bảng để xóa!");
                return;
            }

            DialogResult thongBao = MessageBox.Show("Bạn có chắc chắn muốn xóa sinh viên " + tbx_Name.Text + " không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (thongBao == DialogResult.Yes)
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        string query = "DELETE FROM SinhVien WHERE MSSV = @mssv";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@mssv", tbx_MSSV.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Xóa sinh viên thành công!");
                        tbx_MSSV.Clear();
                        tbx_Name.Clear();
                        LoadDataSV_PhanTrang();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi xóa dữ liệu: " + ex.Message);
                    }
                }
            }
        }

        private void btn_LamMoiSV_Click(object sender, EventArgs e)
        {
            tbx_MSSV.Clear();
            tbx_Name.Clear();
            cbx_Lop.SelectedIndex = -1; //lệnh này là bỏ chọn
            cbx_Lop.Text = "";          //lệnh này là xóa chữ đang gõ
            NgaySinh.Value = DateTime.Today;
            tbx_TimSinhVien.Clear();

            tbx_MSSV.Enabled = true;
            tbx_MSSV.Focus();

            LoadDataSV_PhanTrang();
        }

        private void btn_ThoatSinhVien_Click(object sender, EventArgs e)
        {
          
        }

        private void dgv_LopHoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_LopHoc.Rows[e.RowIndex];
                tbx_IDLop.Text = row.Cells["IdLop"].Value.ToString();
                tbx_TenLop.Text = row.Cells["TenLop"].Value.ToString();
                tbx_Note.Text = row.Cells["Note"].Value.ToString();
            }

        }

        private void btn_ThemLop_Click(object sender, EventArgs e)
        {
            if (tbx_IDLop.Text == "" || tbx_TenLop.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đủ ID Lớp và Tên Lớp!");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO Lop (IdLop, TenLop, Note) VALUES (@id, @ten, @note)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", tbx_IDLop.Text);
                    cmd.Parameters.AddWithValue("@ten", tbx_TenLop.Text);
                    cmd.Parameters.AddWithValue("@note", tbx_Note.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm lớp học thành công!");
                    LoadData_LopHoc();
                    LoadComboBoxLop();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi thêm lớp (Có thể ID Lớp đã tồn tại): " + ex.Message);
                }
            }
        }

        private void btn_SuaLop_Click(object sender, EventArgs e)
        {
            if (tbx_IDLop.Text == "")
            {
                MessageBox.Show("Vui lòng chọn hoặc nhập ID Lớp cần sửa!");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "UPDATE Lop SET TenLop = @ten, Note = @note WHERE IdLop = @id";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", tbx_IDLop.Text);
                    cmd.Parameters.AddWithValue("@ten", tbx_TenLop.Text);
                    cmd.Parameters.AddWithValue("@note", tbx_Note.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cập nhật thông tin lớp thành công!");
                    LoadData_LopHoc();
                    LoadComboBoxLop();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi sửa dữ liệu: " + ex.Message);
                }
            }
        }

        private void btn_XoaLop_Click(object sender, EventArgs e)
        {
            if (tbx_IDLop.Text == "")
            {
                MessageBox.Show("Vui lòng chọn lớp cần xóa!");
                return;
            }
            DialogResult thongBao = MessageBox.Show("Bạn có chắc chắn muốn xóa lớp " + tbx_IDLop.Text + " không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (thongBao == DialogResult.Yes)
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        string query = "DELETE FROM Lop WHERE IdLop = @id";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@id", tbx_IDLop.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Xóa lớp thành công!");
                        btn_LamMoiLop_Click(sender, e);
                        LoadData_LopHoc();
                        LoadComboBoxLop();
                    }
                    catch (SqlException ex)
                    {
                        if (ex.Number == 547)
                            MessageBox.Show("Không thể xóa lớp này vì đang có sinh viên học lớp này. Hãy chuyển lớp cho sinh viên trước!");
                        else
                            MessageBox.Show("Lỗi xóa dữ liệu: " + ex.Message);
                    }
                }
            }
        }

        private void btn_LamMoiLop_Click(object sender, EventArgs e)
        {
            tbx_IDLop.Clear();
            tbx_TenLop.Clear();
            tbx_Note.Clear();
            tbx_IDLop.Focus();
        }

        private void btn_XemDanhSach_Click(object sender, EventArgs e)
        {
            if (tbx_IDLop.Text == "")
            {
                MessageBox.Show("Vui lòng click chọn một lớp trong bảng trước khi xem danh sách!");
                return;
            }
            string maLopDuocChon = tbx_IDLop.Text;
            frm_DanhSachSV_TheoLop frm = new frm_DanhSachSV_TheoLop(maLopDuocChon);
            frm.ShowDialog();
        }

        private void dgv_SinhVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0 && !dgv_SinhVien.Rows[e.RowIndex].IsNewRow)
            {
                DataGridViewRow row = dgv_SinhVien.Rows[e.RowIndex];
                tbx_MSSV.Text = row.Cells["MSSV"].Value?.ToString();
                tbx_Name.Text = row.Cells["HoTen"].Value?.ToString();
                if (row.Cells["NgaySinh"].Value != DBNull.Value)
                {
                    NgaySinh.Value = Convert.ToDateTime(row.Cells["NgaySinh"].Value);
                }
                cbx_Lop.SelectedValue = row.Cells["Lop"].Value?.ToString();
            }
        }

        private void btn_TimSinhVien_Click(object sender, EventArgs e)
        {
            string tuKhoa = tbx_TimSinhVien.Text.Trim();

            if (tuKhoa == "")
            {
                trangHienTai_SV = 1;
                LoadDataSV_PhanTrang();
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM SinhVien WHERE MSSV LIKE @tk OR HoTen LIKE @tk";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@tk", "%" + tuKhoa + "%");
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgv_SinhVien.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi tìm kiếm: " + ex.Message);
                }
            }
        }

        private void btn_TimLop_Click(object sender, EventArgs e)
        {
            string tuKhoa = tbx_TimLop.Text.Trim();
            if (string.IsNullOrEmpty(tuKhoa))
            {
                LoadData_LopHoc();
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT IdLop, TenLop, Note FROM Lop WHERE IdLop LIKE @tk OR TenLop LIKE @tk";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@tk", "%" + tuKhoa + "%");
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgv_LopHoc.DataSource = dt;
                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("Không tìm thấy lớp học nào khớp với từ khóa: " + tuKhoa);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi tìm kiếm lớp: " + ex.Message);
                }
            }
        }

        private void tbx_TimLop_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_TimLop_Click(sender, e);
                e.SuppressKeyPress = true;
            }
        }

        private void tbx_TimSinhVien_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbx_TimSinhVien_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_TimSinhVien_Click(sender, e);
                e.SuppressKeyPress = true;
            }
        }

        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (e.TabPage.Text == "Đăng xuất")
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất không?",
                                                      "Xác nhận",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    this.Hide();
                    frm_login f = new frm_login(); 
                    f.ShowDialog();
                    this.Close();
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        private void btn_DangXuat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất không?",
                                                  "Xác nhận thoát",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                frm_login fLogin = new frm_login();
                fLogin.ShowDialog();
                this.Close();
            }
        }
    }
}

    