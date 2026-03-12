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
    public partial class QuanLyLop : Form
    {
        public QuanLyLop()
        {
            InitializeComponent();
        }

        private void Quaylai_btn_Click(object sender, EventArgs e)
        {
            frm_main t = new frm_main();
            this.Close();
            t.Show();
        }
    }
}
