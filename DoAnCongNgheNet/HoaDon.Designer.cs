namespace DoAnCongNgheNet
{
    partial class HoaDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HoaDon));
            this.label1 = new System.Windows.Forms.Label();
            this.gbo_PhieuDatPhong = new System.Windows.Forms.GroupBox();
            this.dgv_HoaDon = new System.Windows.Forms.DataGridView();
            this.btn_load = new System.Windows.Forms.Button();
            this.btn_datsan = new System.Windows.Forms.Button();
            this.btn_trangchu = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_timkiem = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_timkiem_idphieu = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv_phieudatsan = new System.Windows.Forms.DataGridView();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_khoitao = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_tongsogio = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_tiensan = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_hotenkhachhang = new System.Windows.Forms.TextBox();
            this.txt_idphieudatsan = new System.Windows.Forms.TextBox();
            this.txt_idkhachhang = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_thanhtoan = new System.Windows.Forms.Button();
            this.txt_tongtienhoadon = new System.Windows.Forms.TextBox();
            this.txt_dongiasan = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_hotennhanvien = new System.Windows.Forms.TextBox();
            this.cbo_idnhanvien = new System.Windows.Forms.ComboBox();
            this.cbo_trangthai = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_ngaylaphoadon = new System.Windows.Forms.DateTimePicker();
            this.txt_idhoadon = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbo_PhieuDatPhong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HoaDon)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_phieudatsan)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1781, 102);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hóa Đơn Thanh Toán";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // gbo_PhieuDatPhong
            // 
            this.gbo_PhieuDatPhong.Controls.Add(this.dgv_HoaDon);
            this.gbo_PhieuDatPhong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbo_PhieuDatPhong.Location = new System.Drawing.Point(3, 106);
            this.gbo_PhieuDatPhong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbo_PhieuDatPhong.Name = "gbo_PhieuDatPhong";
            this.gbo_PhieuDatPhong.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbo_PhieuDatPhong.Size = new System.Drawing.Size(1727, 330);
            this.gbo_PhieuDatPhong.TabIndex = 2;
            this.gbo_PhieuDatPhong.TabStop = false;
            this.gbo_PhieuDatPhong.Text = "Thông Tin Hóa Đơn";
            // 
            // dgv_HoaDon
            // 
            this.dgv_HoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_HoaDon.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgv_HoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_HoaDon.Location = new System.Drawing.Point(8, 23);
            this.dgv_HoaDon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgv_HoaDon.Name = "dgv_HoaDon";
            this.dgv_HoaDon.ReadOnly = true;
            this.dgv_HoaDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_HoaDon.Size = new System.Drawing.Size(1701, 299);
            this.dgv_HoaDon.TabIndex = 0;
            this.dgv_HoaDon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_HoaDon_CellContentClick);
            this.dgv_HoaDon.Click += new System.EventHandler(this.dgv_HoaDon_Click);
            // 
            // btn_load
            // 
            this.btn_load.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_load.Location = new System.Drawing.Point(1547, 754);
            this.btn_load.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(172, 33);
            this.btn_load.TabIndex = 47;
            this.btn_load.Text = "Load Lại";
            this.btn_load.UseVisualStyleBackColor = true;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // btn_datsan
            // 
            this.btn_datsan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_datsan.Location = new System.Drawing.Point(1547, 672);
            this.btn_datsan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_datsan.Name = "btn_datsan";
            this.btn_datsan.Size = new System.Drawing.Size(172, 33);
            this.btn_datsan.TabIndex = 46;
            this.btn_datsan.Text = "Đặt Sân>>";
            this.btn_datsan.UseVisualStyleBackColor = true;
            this.btn_datsan.Click += new System.EventHandler(this.btn_datsan_Click);
            // 
            // btn_trangchu
            // 
            this.btn_trangchu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_trangchu.Location = new System.Drawing.Point(1547, 713);
            this.btn_trangchu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_trangchu.Name = "btn_trangchu";
            this.btn_trangchu.Size = new System.Drawing.Size(172, 33);
            this.btn_trangchu.TabIndex = 45;
            this.btn_trangchu.Text = "Trang Chủ >>";
            this.btn_trangchu.UseVisualStyleBackColor = true;
            this.btn_trangchu.Click += new System.EventHandler(this.btn_trangchu_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_timkiem);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txt_timkiem_idphieu);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(1485, 487);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(297, 160);
            this.groupBox3.TabIndex = 36;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tìm Kiếm";
            // 
            // btn_timkiem
            // 
            this.btn_timkiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_timkiem.Location = new System.Drawing.Point(61, 107);
            this.btn_timkiem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_timkiem.Name = "btn_timkiem";
            this.btn_timkiem.Size = new System.Drawing.Size(172, 33);
            this.btn_timkiem.TabIndex = 31;
            this.btn_timkiem.Text = "Tìm Kiếm";
            this.btn_timkiem.UseVisualStyleBackColor = true;
            this.btn_timkiem.Click += new System.EventHandler(this.btn_timkiem_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(8, 41);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(130, 22);
            this.label9.TabIndex = 31;
            this.label9.Text = "Theo Mã Phiếu";
            // 
            // txt_timkiem_idphieu
            // 
            this.txt_timkiem_idphieu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_timkiem_idphieu.Location = new System.Drawing.Point(8, 68);
            this.txt_timkiem_idphieu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_timkiem_idphieu.Name = "txt_timkiem_idphieu";
            this.txt_timkiem_idphieu.Size = new System.Drawing.Size(281, 30);
            this.txt_timkiem_idphieu.TabIndex = 32;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv_phieudatsan);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(832, 487);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(560, 322);
            this.groupBox2.TabIndex = 44;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông Tin Phiếu Đặt Sân";
            // 
            // dgv_phieudatsan
            // 
            this.dgv_phieudatsan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_phieudatsan.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgv_phieudatsan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_phieudatsan.Location = new System.Drawing.Point(4, 27);
            this.dgv_phieudatsan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgv_phieudatsan.Name = "dgv_phieudatsan";
            this.dgv_phieudatsan.ReadOnly = true;
            this.dgv_phieudatsan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_phieudatsan.Size = new System.Drawing.Size(552, 287);
            this.dgv_phieudatsan.TabIndex = 0;
            this.dgv_phieudatsan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_phieudatsan_CellContentClick);
            this.dgv_phieudatsan.Click += new System.EventHandler(this.dgv_phieudatsan_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit.Location = new System.Drawing.Point(472, 438);
            this.btn_edit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(143, 42);
            this.btn_edit.TabIndex = 43;
            this.btn_edit.Text = "Chỉnh Sửa";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_khoitao
            // 
            this.btn_khoitao.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_khoitao.Location = new System.Drawing.Point(323, 438);
            this.btn_khoitao.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_khoitao.Name = "btn_khoitao";
            this.btn_khoitao.Size = new System.Drawing.Size(143, 42);
            this.btn_khoitao.TabIndex = 42;
            this.btn_khoitao.Text = "Khởi Tạo";
            this.btn_khoitao.UseVisualStyleBackColor = true;
            this.btn_khoitao.Click += new System.EventHandler(this.btn_khoitao_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reset.Location = new System.Drawing.Point(1075, 438);
            this.btn_reset.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(143, 42);
            this.btn_reset.TabIndex = 41;
            this.btn_reset.Text = "Nhập Lại";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sua.Location = new System.Drawing.Point(924, 437);
            this.btn_sua.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(143, 42);
            this.btn_sua.TabIndex = 40;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.Location = new System.Drawing.Point(773, 438);
            this.btn_xoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(143, 42);
            this.btn_xoa.TabIndex = 39;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_them
            // 
            this.btn_them.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.Location = new System.Drawing.Point(623, 438);
            this.btn_them.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(143, 42);
            this.btn_them.TabIndex = 38;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_tongsogio);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txt_tiensan);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txt_hotenkhachhang);
            this.groupBox1.Controls.Add(this.txt_idphieudatsan);
            this.groupBox1.Controls.Add(this.txt_idkhachhang);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btn_thanhtoan);
            this.groupBox1.Controls.Add(this.txt_tongtienhoadon);
            this.groupBox1.Controls.Add(this.txt_dongiasan);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txt_hotennhanvien);
            this.groupBox1.Controls.Add(this.cbo_idnhanvien);
            this.groupBox1.Controls.Add(this.cbo_trangthai);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txt_ngaylaphoadon);
            this.groupBox1.Controls.Add(this.txt_idhoadon);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(-12, 487);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(840, 322);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập Thông Tin";
            // 
            // txt_tongsogio
            // 
            this.txt_tongsogio.Enabled = false;
            this.txt_tongsogio.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tongsogio.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_tongsogio.Location = new System.Drawing.Point(593, 86);
            this.txt_tongsogio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_tongsogio.Name = "txt_tongsogio";
            this.txt_tongsogio.ReadOnly = true;
            this.txt_tongsogio.Size = new System.Drawing.Size(212, 30);
            this.txt_tongsogio.TabIndex = 43;
            this.txt_tongsogio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(455, 90);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 22);
            this.label8.TabIndex = 42;
            this.label8.Text = "Số Giờ Đá";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // txt_tiensan
            // 
            this.txt_tiensan.Enabled = false;
            this.txt_tiensan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tiensan.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_tiensan.Location = new System.Drawing.Point(592, 234);
            this.txt_tiensan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_tiensan.Name = "txt_tiensan";
            this.txt_tiensan.ReadOnly = true;
            this.txt_tiensan.Size = new System.Drawing.Size(212, 30);
            this.txt_tiensan.TabIndex = 41;
            this.txt_tiensan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(455, 238);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(121, 23);
            this.label13.TabIndex = 40;
            this.label13.Text = "TỔNG TIỀN";
            // 
            // txt_hotenkhachhang
            // 
            this.txt_hotenkhachhang.Enabled = false;
            this.txt_hotenkhachhang.Location = new System.Drawing.Point(247, 91);
            this.txt_hotenkhachhang.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_hotenkhachhang.Name = "txt_hotenkhachhang";
            this.txt_hotenkhachhang.ReadOnly = true;
            this.txt_hotenkhachhang.Size = new System.Drawing.Size(177, 29);
            this.txt_hotenkhachhang.TabIndex = 37;
            // 
            // txt_idphieudatsan
            // 
            this.txt_idphieudatsan.Enabled = false;
            this.txt_idphieudatsan.Location = new System.Drawing.Point(205, 135);
            this.txt_idphieudatsan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_idphieudatsan.Name = "txt_idphieudatsan";
            this.txt_idphieudatsan.ReadOnly = true;
            this.txt_idphieudatsan.Size = new System.Drawing.Size(219, 29);
            this.txt_idphieudatsan.TabIndex = 36;
            // 
            // txt_idkhachhang
            // 
            this.txt_idkhachhang.Enabled = false;
            this.txt_idkhachhang.Location = new System.Drawing.Point(171, 91);
            this.txt_idkhachhang.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_idkhachhang.Name = "txt_idkhachhang";
            this.txt_idkhachhang.ReadOnly = true;
            this.txt_idkhachhang.Size = new System.Drawing.Size(67, 29);
            this.txt_idkhachhang.TabIndex = 35;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 90);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 22);
            this.label6.TabIndex = 34;
            this.label6.Text = "ID Khách Hàng";
            // 
            // btn_thanhtoan
            // 
            this.btn_thanhtoan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thanhtoan.Location = new System.Drawing.Point(460, 276);
            this.btn_thanhtoan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_thanhtoan.Name = "btn_thanhtoan";
            this.btn_thanhtoan.Size = new System.Drawing.Size(347, 33);
            this.btn_thanhtoan.TabIndex = 33;
            this.btn_thanhtoan.Text = "Thanh Toán";
            this.btn_thanhtoan.UseVisualStyleBackColor = true;
            this.btn_thanhtoan.Click += new System.EventHandler(this.btn_thanhtoan_Click);
            // 
            // txt_tongtienhoadon
            // 
            this.txt_tongtienhoadon.Enabled = false;
            this.txt_tongtienhoadon.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tongtienhoadon.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_tongtienhoadon.Location = new System.Drawing.Point(593, 128);
            this.txt_tongtienhoadon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_tongtienhoadon.Name = "txt_tongtienhoadon";
            this.txt_tongtienhoadon.ReadOnly = true;
            this.txt_tongtienhoadon.Size = new System.Drawing.Size(212, 30);
            this.txt_tongtienhoadon.TabIndex = 19;
            this.txt_tongtienhoadon.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_dongiasan
            // 
            this.txt_dongiasan.Enabled = false;
            this.txt_dongiasan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_dongiasan.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_dongiasan.Location = new System.Drawing.Point(592, 44);
            this.txt_dongiasan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_dongiasan.Name = "txt_dongiasan";
            this.txt_dongiasan.ReadOnly = true;
            this.txt_dongiasan.Size = new System.Drawing.Size(212, 30);
            this.txt_dongiasan.TabIndex = 18;
            this.txt_dongiasan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(455, 44);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(112, 22);
            this.label11.TabIndex = 16;
            this.label11.Text = "Đơn Giá Sân";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(456, 132);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 22);
            this.label10.TabIndex = 15;
            this.label10.Text = "Tiền Sân";
            // 
            // txt_hotennhanvien
            // 
            this.txt_hotennhanvien.Enabled = false;
            this.txt_hotennhanvien.Location = new System.Drawing.Point(279, 185);
            this.txt_hotennhanvien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_hotennhanvien.Name = "txt_hotennhanvien";
            this.txt_hotennhanvien.ReadOnly = true;
            this.txt_hotennhanvien.Size = new System.Drawing.Size(145, 29);
            this.txt_hotennhanvien.TabIndex = 13;
            // 
            // cbo_idnhanvien
            // 
            this.cbo_idnhanvien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_idnhanvien.FormattingEnabled = true;
            this.cbo_idnhanvien.Location = new System.Drawing.Point(155, 183);
            this.cbo_idnhanvien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbo_idnhanvien.Name = "cbo_idnhanvien";
            this.cbo_idnhanvien.Size = new System.Drawing.Size(113, 30);
            this.cbo_idnhanvien.TabIndex = 12;
            this.cbo_idnhanvien.SelectedIndexChanged += new System.EventHandler(this.cbo_idnhanvien_SelectedIndexChanged);
            // 
            // cbo_trangthai
            // 
            this.cbo_trangthai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_trangthai.FormattingEnabled = true;
            this.cbo_trangthai.Items.AddRange(new object[] {
            "Chưa Thanh Toán",
            "Đã Thanh Toán"});
            this.cbo_trangthai.Location = new System.Drawing.Point(144, 278);
            this.cbo_trangthai.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbo_trangthai.Name = "cbo_trangthai";
            this.cbo_trangthai.Size = new System.Drawing.Size(280, 30);
            this.cbo_trangthai.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(23, 281);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 22);
            this.label7.TabIndex = 9;
            this.label7.Text = "Trạng Thái";
            // 
            // txt_ngaylaphoadon
            // 
            this.txt_ngaylaphoadon.CustomFormat = "dd-mm-yyyy";
            this.txt_ngaylaphoadon.Enabled = false;
            this.txt_ngaylaphoadon.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ngaylaphoadon.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txt_ngaylaphoadon.Location = new System.Drawing.Point(279, 235);
            this.txt_ngaylaphoadon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_ngaylaphoadon.Name = "txt_ngaylaphoadon";
            this.txt_ngaylaphoadon.Size = new System.Drawing.Size(145, 30);
            this.txt_ngaylaphoadon.TabIndex = 7;
            // 
            // txt_idhoadon
            // 
            this.txt_idhoadon.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_idhoadon.Location = new System.Drawing.Point(144, 41);
            this.txt_idhoadon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_idhoadon.Name = "txt_idhoadon";
            this.txt_idhoadon.Size = new System.Drawing.Size(280, 30);
            this.txt_idhoadon.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 238);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(238, 22);
            this.label5.TabIndex = 3;
            this.label5.Text = "Ngày Lập Hóa Đơn Hiện Tại";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 185);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 22);
            this.label4.TabIndex = 2;
            this.label4.Text = "ID Nhân Viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 138);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 22);
            this.label3.TabIndex = 1;
            this.label3.Text = "ID Phiếu Đặt Sân";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 44);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "ID Hóa Đơn";
            // 
            // HoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1781, 825);
            this.Controls.Add(this.btn_load);
            this.Controls.Add(this.btn_datsan);
            this.Controls.Add(this.btn_trangchu);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_khoitao);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbo_PhieuDatPhong);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "HoaDon";
            this.Text = "HoaDon";
            this.Load += new System.EventHandler(this.HoaDon_Load);
            this.gbo_PhieuDatPhong.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HoaDon)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_phieudatsan)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbo_PhieuDatPhong;
        private System.Windows.Forms.DataGridView dgv_HoaDon;
        private System.Windows.Forms.Button btn_load;
        private System.Windows.Forms.Button btn_datsan;
        private System.Windows.Forms.Button btn_trangchu;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_timkiem;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_timkiem_idphieu;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgv_phieudatsan;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_khoitao;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_tiensan;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_hotenkhachhang;
        private System.Windows.Forms.TextBox txt_idphieudatsan;
        private System.Windows.Forms.TextBox txt_idkhachhang;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_thanhtoan;
        private System.Windows.Forms.TextBox txt_tongtienhoadon;
        private System.Windows.Forms.TextBox txt_dongiasan;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_hotennhanvien;
        private System.Windows.Forms.ComboBox cbo_idnhanvien;
        private System.Windows.Forms.ComboBox cbo_trangthai;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker txt_ngaylaphoadon;
        private System.Windows.Forms.TextBox txt_idhoadon;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_tongsogio;
        private System.Windows.Forms.Label label8;
    }
}