using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV
{
    public partial class frm_login : Form
    {
        public frm_login()
        {
            InitializeComponent();

        }

        private void Login_btn_Click(object sender, EventArgs e)
        {
            string username = Username_tbx.Text;
            string password = Password_tbx.Text;
            if (username == "" && password == "")
            {
                // Nếu đăng nhập đúng thì chạy đoạn này:
                this.Hide(); // Ẩn form login đi
                frm_TrangChu trangChu = new frm_TrangChu();
                trangChu.ShowDialog(); // Mở form Trang chủ lên
                this.Close(); // Khi đóng form trang chủ thì tắt luôn phần mềm
            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu");
            }
        }

        private void Exit_btn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Username_tbx_TextChanged(object sender, EventArgs e)
        {

        }

        private void frm_login_Load(object sender, EventArgs e)
        {
        
        }

        private void frm_login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
