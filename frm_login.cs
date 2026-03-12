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
            if (username == "thayHieuLX" && password == "123456")
            {
                //dang nhap thanh cong
                //chuyen den form chinh
                frm_main main = new frm_main(); 
                main.Show(); //hien thi va chinh sua duoc sv va mssv
                this.Hide();
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
