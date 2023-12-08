using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DoAnCongNgheNet
{
    public partial class HoaDon : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        string str = "Data Source=DESKTOP-BRGJGMP\\MSSQLSERVER156;Initial Catalog=QUANLYSANBONG; Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        //-----------------------

        SqlConnection con1;
        SqlCommand cmd1;
        string str1 = "Data Source=DESKTOP-BRGJGMP\\MSSQLSERVER156;Initial Catalog=QUANLYSANBONG; Integrated Security=True";
        SqlDataAdapter adapter1 = new SqlDataAdapter();
        DataTable table1 = new DataTable();

        public HoaDon()
        {
            InitializeComponent();
        }

        public static string TimKiemTheoMaPhieu;

        private void LoadData_HoaDon()
        {
            cmd = con.CreateCommand();
            cmd.CommandText = "SELECT * FROM HOADON";
            adapter.SelectCommand = cmd;
            table.Clear();
            adapter.Fill(table);
            dgv_HoaDon.DataSource = table;
        }

        private void LoadData_PhieuDatSan()
        {
            cmd1 = con1.CreateCommand();
            cmd1.CommandText = "SELECT * FROM PHIEUDATSAN";
            adapter1.SelectCommand = cmd1;
            table1.Clear();
            adapter1.Fill(table1);
            dgv_phieudatsan.DataSource = table1;
        }

        private void LoadData_CboIDNhanVien()
        {
            SqlCommand sqlCmd = new SqlCommand("SELECT * FROM NHANVIEN", con);
            con = new SqlConnection(str);
            con.Open();
            SqlDataReader sqlReader = sqlCmd.ExecuteReader();

            while (sqlReader.Read())
            {
                cbo_idnhanvien.Items.Add(sqlReader["IDNHANVIEN"].ToString());
            }

            sqlReader.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void HoaDon_Load(object sender, EventArgs e)
        {
            foreach (Control item in groupBox1.Controls)
            {
                if (item is TextBox)
                {
                    item.Enabled = false;
                    cbo_trangthai.Enabled = false;
                    cbo_idnhanvien.Enabled = false;
                    txt_idphieudatsan.Enabled = false;
                }
            }
           
            btn_them.Enabled = false;
            btn_xoa.Enabled = false;
            btn_sua.Enabled = false;

            //-------------------------------

            con = new SqlConnection(str);
            con.Open();
            LoadData_HoaDon();
            LoadData_CboIDNhanVien();
            txt_timkiem_idphieu.Text = TimKiemTheoMaPhieu;
           

            //--------------------------------

            con1 = new SqlConnection(str1);
            con1.Open();
            LoadData_PhieuDatSan();
            con1.Close();
        }

        private void dgv_HoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv_HoaDon_Click(object sender, EventArgs e)
        {
            int i;
            i = dgv_HoaDon.CurrentRow.Index;
            txt_idhoadon.Text = dgv_HoaDon.Rows[i].Cells[0].Value.ToString();
            txt_idkhachhang.Text = dgv_HoaDon.Rows[i].Cells[1].Value.ToString();
            txt_idphieudatsan.Text = dgv_HoaDon.Rows[i].Cells[2].Value.ToString();
            cbo_idnhanvien.Text = dgv_HoaDon.Rows[i].Cells[3].Value.ToString();
            txt_ngaylaphoadon.Text = dgv_HoaDon.Rows[i].Cells[4].Value.ToString();
            cbo_trangthai.Text = dgv_HoaDon.Rows[i].Cells[5].Value.ToString();
            txt_tiensan.Text = dgv_HoaDon.Rows[i].Cells[6].Value.ToString();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_idhoadon.Text == string.Empty)
                    MessageBox.Show("Chưa Nhập Mã Phiếu", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    cmd = con.CreateCommand();
                    cmd.CommandText = @"INSERT INTO HOADON VALUES(N'" + txt_idhoadon.Text.ToUpper().Trim() + @"','" + txt_idkhachhang.Text + @"','" + txt_idphieudatsan.Text + @"','" + cbo_idnhanvien.Text + @"','" + DateTime.Now.ToString() + @"','" + cbo_trangthai.Text + @"'," + float.Parse(txt_tiensan.Text) + ")";
                    cmd.ExecuteNonQuery();
                    LoadData_HoaDon();
                }
            }
            catch
            {
                MessageBox.Show("Lỗi", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {

            DialogResult dr = MessageBox.Show("Bạn có muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                cmd = con.CreateCommand();
                cmd.CommandText = @"DELETE FROM HOADON WHERE IDHOADON = '" + txt_idhoadon.Text + "'";
                cmd.ExecuteNonQuery();
                LoadData_HoaDon();
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = con.CreateCommand();
                cmd.CommandText = @"UPDATE HOADON SET TRANGTHAIHD = N'" + cbo_trangthai.Text + @"' WHERE (IDHOADON = N'" + txt_idhoadon.Text + @"')";
                cmd.ExecuteNonQuery();
                cmd = con.CreateCommand();
                LoadData_HoaDon();
            }
            catch
            {
                MessageBox.Show("Lỗi", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_khoitao_Click(object sender, EventArgs e)
        {
            foreach (Control item in groupBox1.Controls)
            {
                if (item is TextBox)
                {
                    cbo_trangthai.Text = string.Empty;
                    item.Enabled = true;
                    cbo_trangthai.Enabled = true;
                    cbo_trangthai.Text = string.Empty;
                    txt_idphieudatsan.Enabled = true;
                    txt_idphieudatsan.Text = string.Empty;
                    cbo_idnhanvien.Enabled = true;
                    cbo_idnhanvien.Text = string.Empty;
                    txt_idhoadon.Focus();
                }
            }
            btn_them.Enabled = true;
            btn_xoa.Enabled = false;
            btn_sua.Enabled = false;
            dgv_HoaDon.Enabled = false;
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {

            btn_sua.Enabled = true;
            btn_xoa.Enabled = true;
            btn_them.Enabled = false;
            dgv_HoaDon.Enabled = true;

            foreach (Control item in groupBox1.Controls)
            {
                if (item is TextBox)
                {
                    item.Enabled = true;
                    cbo_trangthai.Enabled = true;
                    txt_idphieudatsan.Enabled = true;
                }
            }
            txt_idhoadon.Enabled = false;
            txt_idphieudatsan.Enabled = false;
            cbo_idnhanvien.Enabled = false;
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            foreach (Control item in groupBox1.Controls)
            {
                if (item is TextBox)
                {
                    item.Enabled = true;
                    item.Text = string.Empty;
                    cbo_trangthai.Enabled = true;
                    txt_idphieudatsan.Enabled = true;
                    cbo_trangthai.Text = string.Empty;
                    txt_idphieudatsan.Text = string.Empty;
                    cbo_idnhanvien.Enabled = true;
                    cbo_idnhanvien.Text = string.Empty;
                }
            }
            txt_idhoadon.Focus();
        }

        private void cbo_idnhanvien_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand sqlCmd = new SqlCommand("SELECT HOTENNHANVIEN FROM NHANVIEN WHERE IDNHANVIEN = '" + cbo_idnhanvien.Text + "'", con);
            con = new SqlConnection(str);
            con.Open();
            SqlDataReader sqlReader = sqlCmd.ExecuteReader();

            while (sqlReader.Read())
            {
                txt_hotennhanvien.Text = sqlReader["HOTENNHANVIEN"].ToString();
            }
            sqlReader.Close();
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_timkiem_idphieu.Text == string.Empty)
                {
                    LoadData_PhieuDatSan();
                    MessageBox.Show("Chưa Nhập Thông Tin");
                }
                else
                {
                    cmd1 = con1.CreateCommand();
                    cmd1.CommandText = @"SELECT * FROM PHIEUDATSAN WHERE IDPHIEUDATSAN = '" + txt_timkiem_idphieu.Text + "'";
                    adapter.SelectCommand = cmd1;
                    table1.Clear();
                    adapter.Fill(table1);
                    dgv_phieudatsan.DataSource = table1;
                }
            }
            catch
            {
                MessageBox.Show("Lỗi");
            }
        }

        string masan = string.Empty;

        private void dgv_phieudatsan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv_phieudatsan_Click(object sender, EventArgs e)
        {
            int i;
            i = dgv_phieudatsan.CurrentRow.Index;
            txt_idphieudatsan.Text = dgv_phieudatsan.Rows[i].Cells[0].Value.ToString();
            txt_idkhachhang.Text = dgv_phieudatsan.Rows[i].Cells[1].Value.ToString();
            masan = dgv_phieudatsan.Rows[i].Cells[2].Value.ToString();

            string maloaisan = string.Empty;
            //--------------------------------

            SqlCommand sqlCmd1 =
                    new SqlCommand(@"SELECT SAN.IDLOAISAN FROM SAN WHERE IDSAN = '" + masan + "'", con);
            con = new SqlConnection(str);
            con.Open();
            SqlDataReader sqlReader1 = sqlCmd1.ExecuteReader();

            while (sqlReader1.Read())
            {
                maloaisan = sqlReader1[0].ToString();
            }

            sqlReader1.Close();

            //--------------------------------

            SqlCommand sqlCmd2 =
                    new SqlCommand(@"SELECT LOAISAN.DONGIA FROM LOAISAN WHERE IDLOAISAN='" + maloaisan + "'", con);
            con = new SqlConnection(str);
            con.Open();
            SqlDataReader sqlReader2 = sqlCmd2.ExecuteReader();

            while (sqlReader2.Read())
            {
                txt_dongiasan.Text = sqlReader2[0].ToString();
            }

            sqlReader2.Close();

            //--------------------------------

            SqlCommand sqlCmd =
                    new SqlCommand(@"SELECT DATEDIFF(DAY,PHIEUDATSAN.CHECKIN, PHIEUDATSAN.CHECKOUT)
                                    FROM PHIEUDATSAN
                                    WHERE(PHIEUDATSAN.IDPHIEUDATSAN = '" + txt_idphieudatsan.Text + "')", con);
            con = new SqlConnection(str);
            con.Open();
            SqlDataReader sqlReader = sqlCmd.ExecuteReader();

           

            sqlReader.Close();

            //--------------------------------

            SqlCommand sqlCmd3 =
                    new SqlCommand(@"SELECT * FROM KHACHHANG WHERE IDKHACHHANG = '" + txt_idkhachhang.Text.Trim().ToUpper() + "'", con);
            con = new SqlConnection(str);
            con.Open();
            SqlDataReader sqlReader3 = sqlCmd3.ExecuteReader();

            while (sqlReader3.Read())
            {
                txt_hotenkhachhang.Text = sqlReader3["HOTENKHACHHANG"].ToString();
            }

            sqlReader3.Close();
        }

        double dongialoaisan;

        private void btn_thanhtoan_Click(object sender, EventArgs e)
        {
            try
            {
                string maloaisan = string.Empty;
                //--------------------------------

                SqlCommand sqlCmd1 =
                        new SqlCommand(@"SELECT SAN.IDLOAISAN FROM SAN WHERE IDSAN = '" + masan + "'", con);
                con = new SqlConnection(str);
                con.Open();
                SqlDataReader sqlReader1 = sqlCmd1.ExecuteReader();

                while (sqlReader1.Read())
                {
                    maloaisan = sqlReader1[0].ToString();
                }

                sqlReader1.Close();

                //--------------------------------

                SqlCommand sqlCmd2 =
                        new SqlCommand(@"SELECT LOAISAN.DONGIA FROM LOAISAN WHERE IDLOAISAN='" + maloaisan + "'", con);
                con = new SqlConnection(str);
                con.Open();
                SqlDataReader sqlReader2 = sqlCmd2.ExecuteReader();

                while (sqlReader2.Read())
                {
                    dongialoaisan = double.Parse(sqlReader2[0].ToString());
                }

                sqlReader2.Close();

                double tongtiensan;
                tongtiensan = dongialoaisan * double.Parse(txt_tongsogio.Text);
                txt_tongtienhoadon.Text = tongtiensan.ToString();
            }
            catch
            {
                MessageBox.Show("Lỗi");
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btn_trangchu_Click(object sender, EventArgs e)
        {
            TrangChu tc = new TrangChu();
            tc.Show();
            Hide();
        }

        private void btn_datsan_Click(object sender, EventArgs e)
        {
            DatSancs dp = new DatSancs();
            dp.Show();
            Hide();
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            HoaDon hd = new HoaDon();
            hd.Show();
            this.Dispose(false);
        }

    }
}
