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
    public partial class frm_main : Form
    {
        public frm_main()
        {
            InitializeComponent();
            dataGridView1.AllowUserToAddRows = false;

        }

        private void splitter1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Xoa_btn_Click(object sender, EventArgs e)
        {

        }

        private void Exit2_btn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
           
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           QuanLyLop f = new QuanLyLop();
            f.Show();
            this.Close();
        }

        private void Sua_btn_Click(object sender, EventArgs e)
        {
           
        }

        private void Lammoi_btn_Click(object sender, EventArgs e)
        {
            MSSV_tbx.Clear();
            Name_tbx.Clear();
            Class_tbx.Clear();
            dateTimePicker1.Value = DateTime.Now;
        }

        private void Tim_btn_Click(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
    }

    }

