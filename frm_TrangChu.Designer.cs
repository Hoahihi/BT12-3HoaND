namespace QLSV
{
    partial class frm_TrangChu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.cbx_Lop = new System.Windows.Forms.ComboBox();
            this.btn_LamMoiSV = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.NgaySinh = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_XoaSV = new System.Windows.Forms.Button();
            this.btn_SuaSV = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_ThemSV = new System.Windows.Forms.Button();
            this.tbx_Name = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.Label();
            this.tbx_MSSV = new System.Windows.Forms.TextBox();
            this.txtMSSV = new System.Windows.Forms.Label();
            this.lbl_SoTrang = new System.Windows.Forms.Label();
            this.btn_TrangSau = new System.Windows.Forms.Button();
            this.btn_TrangTruoc = new System.Windows.Forms.Button();
            this.btn_TimSinhVien = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tbx_TimSinhVien = new System.Windows.Forms.TextBox();
            this.dgv_SinhVien = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.btn_LamMoiLop = new System.Windows.Forms.Button();
            this.btn_XoaLop = new System.Windows.Forms.Button();
            this.btn_SuaLop = new System.Windows.Forms.Button();
            this.btn_XemDanhSach = new System.Windows.Forms.Button();
            this.btn_ThemLop = new System.Windows.Forms.Button();
            this.tbx_Note = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbx_TenLop = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbx_IDLop = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dgv_LopHoc = new System.Windows.Forms.DataGridView();
            this.tbx_TimLop = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_TimLop = new System.Windows.Forms.Button();
            this.btn_DangXuat = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SinhVien)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_LopHoc)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1090, 635);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabControl1_Selecting);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.splitContainer1);
            this.tabPage1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1082, 606);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Quản lý Sinh Viên";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.splitContainer1.Panel1.Controls.Add(this.cbx_Lop);
            this.splitContainer1.Panel1.Controls.Add(this.btn_LamMoiSV);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.NgaySinh);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.btn_XoaSV);
            this.splitContainer1.Panel1.Controls.Add(this.btn_SuaSV);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.btn_ThemSV);
            this.splitContainer1.Panel1.Controls.Add(this.tbx_Name);
            this.splitContainer1.Panel1.Controls.Add(this.txtName);
            this.splitContainer1.Panel1.Controls.Add(this.tbx_MSSV);
            this.splitContainer1.Panel1.Controls.Add(this.txtMSSV);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.splitContainer1.Panel2.Controls.Add(this.btn_DangXuat);
            this.splitContainer1.Panel2.Controls.Add(this.lbl_SoTrang);
            this.splitContainer1.Panel2.Controls.Add(this.btn_TrangSau);
            this.splitContainer1.Panel2.Controls.Add(this.btn_TrangTruoc);
            this.splitContainer1.Panel2.Controls.Add(this.btn_TimSinhVien);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.tbx_TimSinhVien);
            this.splitContainer1.Panel2.Controls.Add(this.dgv_SinhVien);
            this.splitContainer1.Size = new System.Drawing.Size(1076, 600);
            this.splitContainer1.SplitterDistance = 387;
            this.splitContainer1.TabIndex = 2;
            // 
            // cbx_Lop
            // 
            this.cbx_Lop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_Lop.FormattingEnabled = true;
            this.cbx_Lop.Items.AddRange(new object[] {
            "CNTT1 - Lớp CNTT1",
            "CNTT2 - Lớp CNTT2"});
            this.cbx_Lop.Location = new System.Drawing.Point(45, 356);
            this.cbx_Lop.Name = "cbx_Lop";
            this.cbx_Lop.Size = new System.Drawing.Size(307, 33);
            this.cbx_Lop.TabIndex = 8;
            // 
            // btn_LamMoiSV
            // 
            this.btn_LamMoiSV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_LamMoiSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LamMoiSV.Location = new System.Drawing.Point(199, 506);
            this.btn_LamMoiSV.Name = "btn_LamMoiSV";
            this.btn_LamMoiSV.Size = new System.Drawing.Size(153, 49);
            this.btn_LamMoiSV.TabIndex = 7;
            this.btn_LamMoiSV.Text = "Làm mới";
            this.btn_LamMoiSV.UseVisualStyleBackColor = false;
            this.btn_LamMoiSV.Click += new System.EventHandler(this.btn_LamMoiSV_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 324);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Lớp";
            // 
            // NgaySinh
            // 
            this.NgaySinh.Location = new System.Drawing.Point(45, 273);
            this.NgaySinh.Name = "NgaySinh";
            this.NgaySinh.Size = new System.Drawing.Size(307, 31);
            this.NgaySinh.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(77, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Thông tin sinh viên";
            // 
            // btn_XoaSV
            // 
            this.btn_XoaSV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_XoaSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XoaSV.Location = new System.Drawing.Point(34, 506);
            this.btn_XoaSV.Name = "btn_XoaSV";
            this.btn_XoaSV.Size = new System.Drawing.Size(153, 49);
            this.btn_XoaSV.TabIndex = 6;
            this.btn_XoaSV.Text = "Xoá";
            this.btn_XoaSV.UseVisualStyleBackColor = false;
            this.btn_XoaSV.Click += new System.EventHandler(this.btn_XoaSV_Click);
            // 
            // btn_SuaSV
            // 
            this.btn_SuaSV.BackColor = System.Drawing.Color.Fuchsia;
            this.btn_SuaSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SuaSV.Location = new System.Drawing.Point(199, 430);
            this.btn_SuaSV.Name = "btn_SuaSV";
            this.btn_SuaSV.Size = new System.Drawing.Size(153, 49);
            this.btn_SuaSV.TabIndex = 5;
            this.btn_SuaSV.Text = "Sửa";
            this.btn_SuaSV.UseVisualStyleBackColor = false;
            this.btn_SuaSV.Click += new System.EventHandler(this.btn_SuaSV_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ngày sinh";
            // 
            // btn_ThemSV
            // 
            this.btn_ThemSV.BackColor = System.Drawing.Color.Cyan;
            this.btn_ThemSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThemSV.ForeColor = System.Drawing.Color.Black;
            this.btn_ThemSV.Location = new System.Drawing.Point(34, 430);
            this.btn_ThemSV.Name = "btn_ThemSV";
            this.btn_ThemSV.Size = new System.Drawing.Size(153, 49);
            this.btn_ThemSV.TabIndex = 4;
            this.btn_ThemSV.Text = "Thêm";
            this.btn_ThemSV.UseVisualStyleBackColor = false;
            this.btn_ThemSV.Click += new System.EventHandler(this.btn_ThemSV_Click);
            // 
            // tbx_Name
            // 
            this.tbx_Name.Location = new System.Drawing.Point(45, 187);
            this.tbx_Name.Name = "tbx_Name";
            this.tbx_Name.Size = new System.Drawing.Size(307, 31);
            this.tbx_Name.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.AutoSize = true;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(42, 158);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(80, 18);
            this.txtName.TabIndex = 0;
            this.txtName.Text = "Họ và tên";
            // 
            // tbx_MSSV
            // 
            this.tbx_MSSV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbx_MSSV.Location = new System.Drawing.Point(45, 103);
            this.tbx_MSSV.Name = "tbx_MSSV";
            this.tbx_MSSV.Size = new System.Drawing.Size(307, 31);
            this.tbx_MSSV.TabIndex = 0;
            // 
            // txtMSSV
            // 
            this.txtMSSV.AutoSize = true;
            this.txtMSSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMSSV.Location = new System.Drawing.Point(42, 75);
            this.txtMSSV.Name = "txtMSSV";
            this.txtMSSV.Size = new System.Drawing.Size(54, 18);
            this.txtMSSV.TabIndex = 0;
            this.txtMSSV.Text = "MSSV";
            // 
            // lbl_SoTrang
            // 
            this.lbl_SoTrang.AutoSize = true;
            this.lbl_SoTrang.Location = new System.Drawing.Point(284, 548);
            this.lbl_SoTrang.Name = "lbl_SoTrang";
            this.lbl_SoTrang.Size = new System.Drawing.Size(71, 25);
            this.lbl_SoTrang.TabIndex = 102;
            this.lbl_SoTrang.Text = "Trang 1";
            // 
            // btn_TrangSau
            // 
            this.btn_TrangSau.Location = new System.Drawing.Point(379, 541);
            this.btn_TrangSau.Name = "btn_TrangSau";
            this.btn_TrangSau.Size = new System.Drawing.Size(45, 38);
            this.btn_TrangSau.TabIndex = 101;
            this.btn_TrangSau.Text = ">";
            this.btn_TrangSau.UseVisualStyleBackColor = true;
            this.btn_TrangSau.Click += new System.EventHandler(this.btn_TrangSau_Click);
            // 
            // btn_TrangTruoc
            // 
            this.btn_TrangTruoc.Location = new System.Drawing.Point(215, 541);
            this.btn_TrangTruoc.Name = "btn_TrangTruoc";
            this.btn_TrangTruoc.Size = new System.Drawing.Size(45, 38);
            this.btn_TrangTruoc.TabIndex = 101;
            this.btn_TrangTruoc.Text = "<";
            this.btn_TrangTruoc.UseVisualStyleBackColor = true;
            this.btn_TrangTruoc.Click += new System.EventHandler(this.btn_TrangTruoc_Click);
            // 
            // btn_TimSinhVien
            // 
            this.btn_TimSinhVien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_TimSinhVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TimSinhVien.Location = new System.Drawing.Point(352, 12);
            this.btn_TimSinhVien.Name = "btn_TimSinhVien";
            this.btn_TimSinhVien.Size = new System.Drawing.Size(122, 49);
            this.btn_TimSinhVien.TabIndex = 9;
            this.btn_TimSinhVien.Text = "Tìm";
            this.btn_TimSinhVien.UseVisualStyleBackColor = false;
            this.btn_TimSinhVien.Click += new System.EventHandler(this.btn_TimSinhVien_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(199, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Tìm kiếm [Tên/Mã SV/Lớp]:";
            // 
            // tbx_TimSinhVien
            // 
            this.tbx_TimSinhVien.Location = new System.Drawing.Point(24, 28);
            this.tbx_TimSinhVien.Name = "tbx_TimSinhVien";
            this.tbx_TimSinhVien.Size = new System.Drawing.Size(311, 31);
            this.tbx_TimSinhVien.TabIndex = 8;
            this.tbx_TimSinhVien.TextChanged += new System.EventHandler(this.tbx_TimSinhVien_TextChanged);
            this.tbx_TimSinhVien.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbx_TimSinhVien_KeyDown);
            // 
            // dgv_SinhVien
            // 
            this.dgv_SinhVien.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_SinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_SinhVien.Location = new System.Drawing.Point(10, 76);
            this.dgv_SinhVien.Name = "dgv_SinhVien";
            this.dgv_SinhVien.RowHeadersWidth = 51;
            this.dgv_SinhVien.RowTemplate.Height = 24;
            this.dgv_SinhVien.Size = new System.Drawing.Size(663, 442);
            this.dgv_SinhVien.TabIndex = 100;
            this.dgv_SinhVien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_SinhVien_CellContentClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.splitContainer2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1082, 606);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Quản lý Lớp Học";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(3, 3);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.splitContainer2.Panel1.Controls.Add(this.btn_LamMoiLop);
            this.splitContainer2.Panel1.Controls.Add(this.btn_XoaLop);
            this.splitContainer2.Panel1.Controls.Add(this.btn_SuaLop);
            this.splitContainer2.Panel1.Controls.Add(this.btn_XemDanhSach);
            this.splitContainer2.Panel1.Controls.Add(this.btn_ThemLop);
            this.splitContainer2.Panel1.Controls.Add(this.tbx_Note);
            this.splitContainer2.Panel1.Controls.Add(this.label5);
            this.splitContainer2.Panel1.Controls.Add(this.tbx_TenLop);
            this.splitContainer2.Panel1.Controls.Add(this.label6);
            this.splitContainer2.Panel1.Controls.Add(this.tbx_IDLop);
            this.splitContainer2.Panel1.Controls.Add(this.label7);
            this.splitContainer2.Panel1.Controls.Add(this.label8);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.splitContainer2.Panel2.Controls.Add(this.dgv_LopHoc);
            this.splitContainer2.Panel2.Controls.Add(this.tbx_TimLop);
            this.splitContainer2.Panel2.Controls.Add(this.label9);
            this.splitContainer2.Panel2.Controls.Add(this.btn_TimLop);
            this.splitContainer2.Size = new System.Drawing.Size(1076, 600);
            this.splitContainer2.SplitterDistance = 356;
            this.splitContainer2.TabIndex = 1;
            // 
            // btn_LamMoiLop
            // 
            this.btn_LamMoiLop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_LamMoiLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LamMoiLop.Location = new System.Drawing.Point(194, 468);
            this.btn_LamMoiLop.Name = "btn_LamMoiLop";
            this.btn_LamMoiLop.Size = new System.Drawing.Size(140, 49);
            this.btn_LamMoiLop.TabIndex = 8;
            this.btn_LamMoiLop.Text = "Làm mới";
            this.btn_LamMoiLop.UseVisualStyleBackColor = false;
            this.btn_LamMoiLop.Click += new System.EventHandler(this.btn_LamMoiLop_Click);
            // 
            // btn_XoaLop
            // 
            this.btn_XoaLop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_XoaLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XoaLop.Location = new System.Drawing.Point(23, 468);
            this.btn_XoaLop.Name = "btn_XoaLop";
            this.btn_XoaLop.Size = new System.Drawing.Size(137, 49);
            this.btn_XoaLop.TabIndex = 7;
            this.btn_XoaLop.Text = "Xóa";
            this.btn_XoaLop.UseVisualStyleBackColor = false;
            this.btn_XoaLop.Click += new System.EventHandler(this.btn_XoaLop_Click);
            // 
            // btn_SuaLop
            // 
            this.btn_SuaLop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_SuaLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SuaLop.Location = new System.Drawing.Point(194, 395);
            this.btn_SuaLop.Name = "btn_SuaLop";
            this.btn_SuaLop.Size = new System.Drawing.Size(140, 49);
            this.btn_SuaLop.TabIndex = 6;
            this.btn_SuaLop.Text = "Sửa";
            this.btn_SuaLop.UseVisualStyleBackColor = false;
            this.btn_SuaLop.Click += new System.EventHandler(this.btn_SuaLop_Click);
            // 
            // btn_XemDanhSach
            // 
            this.btn_XemDanhSach.BackColor = System.Drawing.Color.White;
            this.btn_XemDanhSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XemDanhSach.Location = new System.Drawing.Point(23, 535);
            this.btn_XemDanhSach.Name = "btn_XemDanhSach";
            this.btn_XemDanhSach.Size = new System.Drawing.Size(311, 49);
            this.btn_XemDanhSach.TabIndex = 5;
            this.btn_XemDanhSach.Text = "Xem Danh Sách Sinh Viên";
            this.btn_XemDanhSach.UseVisualStyleBackColor = false;
            this.btn_XemDanhSach.Click += new System.EventHandler(this.btn_XemDanhSach_Click);
            // 
            // btn_ThemLop
            // 
            this.btn_ThemLop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_ThemLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThemLop.Location = new System.Drawing.Point(23, 395);
            this.btn_ThemLop.Name = "btn_ThemLop";
            this.btn_ThemLop.Size = new System.Drawing.Size(137, 49);
            this.btn_ThemLop.TabIndex = 5;
            this.btn_ThemLop.Text = "Thêm";
            this.btn_ThemLop.UseVisualStyleBackColor = false;
            this.btn_ThemLop.Click += new System.EventHandler(this.btn_ThemLop_Click);
            // 
            // tbx_Note
            // 
            this.tbx_Note.Location = new System.Drawing.Point(96, 211);
            this.tbx_Note.Multiline = true;
            this.tbx_Note.Name = "tbx_Note";
            this.tbx_Note.Size = new System.Drawing.Size(203, 124);
            this.tbx_Note.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(33, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Note";
            // 
            // tbx_TenLop
            // 
            this.tbx_TenLop.Location = new System.Drawing.Point(96, 151);
            this.tbx_TenLop.Name = "tbx_TenLop";
            this.tbx_TenLop.Size = new System.Drawing.Size(203, 22);
            this.tbx_TenLop.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(30, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "Tên lớp";
            // 
            // tbx_IDLop
            // 
            this.tbx_IDLop.Location = new System.Drawing.Point(96, 93);
            this.tbx_IDLop.Name = "tbx_IDLop";
            this.tbx_IDLop.Size = new System.Drawing.Size(203, 22);
            this.tbx_IDLop.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(33, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 16);
            this.label7.TabIndex = 1;
            this.label7.Text = "ID lớp";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(59, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(264, 36);
            this.label8.TabIndex = 0;
            this.label8.Text = "Thông tin lớp học";
            // 
            // dgv_LopHoc
            // 
            this.dgv_LopHoc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_LopHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_LopHoc.Location = new System.Drawing.Point(27, 78);
            this.dgv_LopHoc.Name = "dgv_LopHoc";
            this.dgv_LopHoc.RowHeadersWidth = 51;
            this.dgv_LopHoc.RowTemplate.Height = 24;
            this.dgv_LopHoc.Size = new System.Drawing.Size(650, 446);
            this.dgv_LopHoc.TabIndex = 0;
            this.dgv_LopHoc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_LopHoc_CellContentClick);
            // 
            // tbx_TimLop
            // 
            this.tbx_TimLop.Location = new System.Drawing.Point(27, 31);
            this.tbx_TimLop.Name = "tbx_TimLop";
            this.tbx_TimLop.Size = new System.Drawing.Size(291, 22);
            this.tbx_TimLop.TabIndex = 1;
            this.tbx_TimLop.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbx_TimLop_KeyDown);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(24, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(190, 16);
            this.label9.TabIndex = 1;
            this.label9.Text = "Tìm kiếm [ID lớp/Tên Lớp]";
            // 
            // btn_TimLop
            // 
            this.btn_TimLop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_TimLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TimLop.Location = new System.Drawing.Point(339, 17);
            this.btn_TimLop.Name = "btn_TimLop";
            this.btn_TimLop.Size = new System.Drawing.Size(137, 49);
            this.btn_TimLop.TabIndex = 5;
            this.btn_TimLop.Text = "Tìm";
            this.btn_TimLop.UseVisualStyleBackColor = false;
            this.btn_TimLop.Click += new System.EventHandler(this.btn_TimLop_Click);
            // 
            // btn_DangXuat
            // 
            this.btn_DangXuat.ForeColor = System.Drawing.Color.Red;
            this.btn_DangXuat.Location = new System.Drawing.Point(496, 541);
            this.btn_DangXuat.Name = "btn_DangXuat";
            this.btn_DangXuat.Size = new System.Drawing.Size(177, 46);
            this.btn_DangXuat.TabIndex = 103;
            this.btn_DangXuat.Text = "Đăng Xuất";
            this.btn_DangXuat.UseVisualStyleBackColor = true;
            this.btn_DangXuat.Click += new System.EventHandler(this.btn_DangXuat_Click);
            // 
            // frm_TrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 635);
            this.Controls.Add(this.tabControl1);
            this.Name = "frm_TrangChu";
            this.Text = "frm_TrangChucs";
            this.Load += new System.EventHandler(this.frm_TrangChu_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SinhVien)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_LopHoc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ComboBox cbx_Lop;
        private System.Windows.Forms.Button btn_LamMoiSV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker NgaySinh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_XoaSV;
        private System.Windows.Forms.Button btn_SuaSV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_ThemSV;
        private System.Windows.Forms.TextBox tbx_Name;
        private System.Windows.Forms.Label txtName;
        private System.Windows.Forms.TextBox tbx_MSSV;
        private System.Windows.Forms.Label txtMSSV;
        private System.Windows.Forms.Button btn_TimSinhVien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbx_TimSinhVien;
        private System.Windows.Forms.DataGridView dgv_SinhVien;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button btn_LamMoiLop;
        private System.Windows.Forms.Button btn_XoaLop;
        private System.Windows.Forms.Button btn_SuaLop;
        private System.Windows.Forms.Button btn_ThemLop;
        private System.Windows.Forms.TextBox tbx_Note;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbx_TenLop;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbx_IDLop;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgv_LopHoc;
        private System.Windows.Forms.TextBox tbx_TimLop;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_TimLop;
        private System.Windows.Forms.Button btn_XemDanhSach;
        private System.Windows.Forms.Button btn_TrangTruoc;
        private System.Windows.Forms.Button btn_TrangSau;
        private System.Windows.Forms.Label lbl_SoTrang;
        private System.Windows.Forms.Button btn_DangXuat;
    }
}