namespace DoAnCongNgheNet
{
    partial class quanlyloaisan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(quanlyloaisan));
            this.btn_search = new System.Windows.Forms.Button();
            this.txt_nhapmaloaisan_search = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dgvLoaiSan = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_dongia = new System.Windows.Forms.ComboBox();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_khoitao = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_maloaisan = new System.Windows.Forms.TextBox();
            this.txt_tenloaisan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_thongtinKH = new System.Windows.Forms.Label();
            this.btn_returnfrmMain = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiSan)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_search
            // 
            this.btn_search.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Location = new System.Drawing.Point(835, 406);
            this.btn_search.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(143, 36);
            this.btn_search.TabIndex = 42;
            this.btn_search.Text = "Tìm Kiếm";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // txt_nhapmaloaisan_search
            // 
            this.txt_nhapmaloaisan_search.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nhapmaloaisan_search.Location = new System.Drawing.Point(605, 406);
            this.txt_nhapmaloaisan_search.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_nhapmaloaisan_search.Name = "txt_nhapmaloaisan_search";
            this.txt_nhapmaloaisan_search.Size = new System.Drawing.Size(219, 32);
            this.txt_nhapmaloaisan_search.TabIndex = 40;
            this.txt_nhapmaloaisan_search.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(151, 407);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(393, 26);
            this.label9.TabIndex = 41;
            this.label9.Text = "Tìm Kiếm Khách Hàng Theo Mã Sân";
            // 
            // dgvLoaiSan
            // 
            this.dgvLoaiSan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLoaiSan.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvLoaiSan.Location = new System.Drawing.Point(93, 460);
            this.dgvLoaiSan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvLoaiSan.Name = "dgvLoaiSan";
            this.dgvLoaiSan.ReadOnly = true;
            this.dgvLoaiSan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLoaiSan.Size = new System.Drawing.Size(1341, 316);
            this.dgvLoaiSan.TabIndex = 43;
            this.dgvLoaiSan.Click += new System.EventHandler(this.dgvLoaiSan_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.cb_dongia);
            this.groupBox1.Controls.Add(this.btn_edit);
            this.groupBox1.Controls.Add(this.btn_khoitao);
            this.groupBox1.Controls.Add(this.btn_reset);
            this.groupBox1.Controls.Add(this.btn_sua);
            this.groupBox1.Controls.Add(this.btn_xoa);
            this.groupBox1.Controls.Add(this.btn_them);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txt_maloaisan);
            this.groupBox1.Controls.Add(this.txt_tenloaisan);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(93, 91);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1341, 284);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " Thông Tin";
            // 
            // cb_dongia
            // 
            this.cb_dongia.FormattingEnabled = true;
            this.cb_dongia.Location = new System.Drawing.Point(868, 101);
            this.cb_dongia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cb_dongia.Name = "cb_dongia";
            this.cb_dongia.Size = new System.Drawing.Size(283, 30);
            this.cb_dongia.TabIndex = 24;
            this.cb_dongia.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(407, 219);
            this.btn_edit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(143, 42);
            this.btn_edit.TabIndex = 23;
            this.btn_edit.Text = "Chỉnh Sửa";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_khoitao
            // 
            this.btn_khoitao.Location = new System.Drawing.Point(256, 219);
            this.btn_khoitao.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_khoitao.Name = "btn_khoitao";
            this.btn_khoitao.Size = new System.Drawing.Size(143, 42);
            this.btn_khoitao.TabIndex = 22;
            this.btn_khoitao.Text = "Khởi Tạo";
            this.btn_khoitao.UseVisualStyleBackColor = true;
            this.btn_khoitao.Click += new System.EventHandler(this.btn_khoitao_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(1009, 219);
            this.btn_reset.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(143, 42);
            this.btn_reset.TabIndex = 20;
            this.btn_reset.Text = "Nhập Lại";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(859, 218);
            this.btn_sua.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(143, 42);
            this.btn_sua.TabIndex = 19;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(708, 219);
            this.btn_xoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(143, 42);
            this.btn_xoa.TabIndex = 18;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(557, 219);
            this.btn_them.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(143, 42);
            this.btn_them.TabIndex = 17;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(703, 111);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(153, 22);
            this.label7.TabIndex = 10;
            this.label7.Text = "Đơn Giá Loại Sân";
            // 
            // txt_maloaisan
            // 
            this.txt_maloaisan.Location = new System.Drawing.Point(265, 73);
            this.txt_maloaisan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_maloaisan.Name = "txt_maloaisan";
            this.txt_maloaisan.Size = new System.Drawing.Size(340, 30);
            this.txt_maloaisan.TabIndex = 1;
            // 
            // txt_tenloaisan
            // 
            this.txt_tenloaisan.Location = new System.Drawing.Point(265, 146);
            this.txt_tenloaisan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_tenloaisan.Name = "txt_tenloaisan";
            this.txt_tenloaisan.Size = new System.Drawing.Size(340, 30);
            this.txt_tenloaisan.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 150);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhập Tên Loại Sân";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 76);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập Mã Loại Sân";
            // 
            // lb_thongtinKH
            // 
            this.lb_thongtinKH.AutoSize = true;
            this.lb_thongtinKH.Font = new System.Drawing.Font("Times New Roman", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_thongtinKH.Location = new System.Drawing.Point(451, 23);
            this.lb_thongtinKH.Name = "lb_thongtinKH";
            this.lb_thongtinKH.Padding = new System.Windows.Forms.Padding(0, 18, 0, 0);
            this.lb_thongtinKH.Size = new System.Drawing.Size(543, 73);
            this.lb_thongtinKH.TabIndex = 38;
            this.lb_thongtinKH.Text = "THÔNG TIN LOẠI SÂN";
            this.lb_thongtinKH.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_returnfrmMain
            // 
            this.btn_returnfrmMain.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_returnfrmMain.Location = new System.Drawing.Point(1372, 784);
            this.btn_returnfrmMain.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_returnfrmMain.Name = "btn_returnfrmMain";
            this.btn_returnfrmMain.Size = new System.Drawing.Size(143, 36);
            this.btn_returnfrmMain.TabIndex = 44;
            this.btn_returnfrmMain.Text = "Trang Chủ >>";
            this.btn_returnfrmMain.UseVisualStyleBackColor = true;
            this.btn_returnfrmMain.Click += new System.EventHandler(this.btn_returnfrmMain_Click);
            // 
            // quanlyloaisan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1531, 828);
            this.Controls.Add(this.btn_returnfrmMain);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.txt_nhapmaloaisan_search);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dgvLoaiSan);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lb_thongtinKH);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "quanlyloaisan";
            this.Text = "quanlyloaisan";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.quanlyloaisan_FormClosing);
            this.Load += new System.EventHandler(this.quanlyloaisan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiSan)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox txt_nhapmaloaisan_search;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgvLoaiSan;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_khoitao;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_maloaisan;
        private System.Windows.Forms.TextBox txt_tenloaisan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_thongtinKH;
        private System.Windows.Forms.Button btn_returnfrmMain;
        private System.Windows.Forms.ComboBox cb_dongia;
    }
}