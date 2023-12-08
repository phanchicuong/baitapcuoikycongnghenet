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
    public partial class DatSancs : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        string str = "Data Source=DESKTOP-BRGJGMP\\MSSQLSERVER156;Initial Catalog=QUANLYSANBONG; Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
         public DatSancs()
        {
            InitializeComponent();
        }
        public void LoadData()
        {
            cmd = con.CreateCommand();
            cmd.CommandText = "SELECT * PHIEUDATSAN";
            adapter.SelectCommand = cmd;
            table.Clear();
            adapter.Fill(table);
            dgv_phieudatsan.DataSource = table;
        }
        public void LoadCbo_KhachHang()
        {
            SqlCommand sqlCmd = new SqlCommand("SELECT * FROM KHACHHANG", con);
            con = new SqlConnection(str);
            con.Open();
            SqlDataReader sqlReader = sqlCmd.ExecuteReader();

            while (sqlReader.Read())
            {
                cbo_tenkh.Items.Add(sqlReader["HOTENKHACHHANG"].ToString());
                cbo_tenkh.SelectedIndex = 0;
            }
            sqlReader.Close();
        }
        public void LoadCbo_Phong_Maphong()
        {
            SqlCommand sqlCmd = new SqlCommand("SELECT * FROM PHONG", con);
            con = new SqlConnection(str);
            con.Open();
            SqlDataReader sqlReader = sqlCmd.ExecuteReader();

            while (sqlReader.Read())
            {
                cbo_masan.Items.Add(sqlReader["IDPHONG"].ToString());
            }
            sqlReader.Close();
        }
        public void LoadCbo_LoaiPhong()
        {
            SqlCommand sqlCmd = new SqlCommand("SELECT * FROM LOAIPHONG", con);
            con = new SqlConnection(str);
            con.Open();
            SqlDataReader sqlReader = sqlCmd.ExecuteReader();

            while (sqlReader.Read())
            {
                cbo_loaisan.Items.Add(sqlReader["TENLOAIPHONG"].ToString());
            }

            sqlReader.Close();
        }

        private void dgv_phieudatphong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgv_phieudatsan.CurrentRow.Index;
            txt_maphieu.Text = dgv_phieudatsan.Rows[i].Cells[0].Value.ToString();
            cbo_makh.Text = dgv_phieudatsan.Rows[i].Cells[1].Value.ToString();
            cbo_masan.Text = dgv_phieudatsan.Rows[i].Cells[2].Value.ToString();
            dtp_checkin.Text = dgv_phieudatsan.Rows[i].Cells[3].Value.ToString();
            dtp_checkout.Text = dgv_phieudatsan.Rows[i].Cells[4].Value.ToString();

            
            try
            {
                SqlCommand sqlCmd = new SqlCommand("SELECT * FROM KHACHHANG WHERE IDKHACHHANG = N'" + cbo_makh.Text + "'", con);
                con = new SqlConnection(str);
                con.Open();
                SqlDataReader sqlReader = sqlCmd.ExecuteReader();

                while (sqlReader.Read())
                {
                    cbo_tenkh.Text = sqlReader["HOTENKHACHHANG"].ToString();
                }
                sqlReader.Close();
            }
            catch
            {
                MessageBox.Show("Lỗi !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

            //------------------------------

            SqlCommand sqlCmd1 = new SqlCommand("SELECT * FROM SAN WHERE IDSAN = '" + cbo_masan.Text + "'", con);
            con = new SqlConnection(str);
            con.Open();
            SqlDataReader sqlReader1 = sqlCmd1.ExecuteReader();

            while (sqlReader1.Read())
            {
                txt_maloaisan.Text = sqlReader1["IDLOAISAN"].ToString();
            }

            //--------------------------------------


            SqlCommand sqlCmd2 = new SqlCommand("SELECT * FROM LOAISAN WHERE IDLOAISAN = '" + txt_maloaisan.Text + "'", con);
            con = new SqlConnection(str);
            con.Open();
            SqlDataReader sqlReader2 = sqlCmd2.ExecuteReader();

            while (sqlReader2.Read())
            {
                cbo_loaisan.Text = sqlReader2["TENLOAISAN"].ToString();
            }

            //--------------------------------------


            SqlCommand sqlCmd3 = new SqlCommand("SELECT * FROM SAN WHERE IDSAN = '" + cbo_masan.Text + "'", con);
            con = new SqlConnection(str);
            con.Open();
            SqlDataReader sqlReader3 = sqlCmd3.ExecuteReader();

            while (sqlReader3.Read())
            {
                txt_tensan.Text = sqlReader3["TENSAN"].ToString();
            }


        }

        private void cbo_tenkh_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand sqlCmd = new SqlCommand("SELECT * FROM KHACHHANG WHERE HOTENKHACHHANG = N'" + cbo_tenkh.Text + "'", con);
            con = new SqlConnection(str);
            con.Open();
            SqlDataReader sqlReader = sqlCmd.ExecuteReader();

            while (sqlReader.Read())
            {
                cbo_makh.Text = sqlReader["IDKHACHHANG"].ToString();
            }
            sqlReader.Close();
        }

        private void cbo_loaiphong_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand sqlCmd = new SqlCommand("SELECT * FROM LOAISAN WHERE TENLOAISAN = N'" + cbo_loaisan.Text + "'", con);
            con = new SqlConnection(str);
            con.Open();
            SqlDataReader sqlReader = sqlCmd.ExecuteReader();

            while (sqlReader.Read())
            {
                txt_maloaisan.Text = sqlReader["IDLOAISAN"].ToString();
            }
            sqlReader.Close();

            SqlCommand sqlCmd1 = new SqlCommand("SELECT IDPHONG FROM PHONG WHERE IDLOAIPHONG = '" + txt_maloaisan.Text + "'", con);
            con = new SqlConnection(str);
            con.Open();
            SqlDataReader sqlReader1 = sqlCmd1.ExecuteReader();
            cbo_masan.Items.Clear();
            while (sqlReader1.Read())
            {
                cbo_masan.Items.Add(sqlReader1["IDPHONG"].ToString());
            }

            sqlReader1.Close();
        }

        private void cbo_masan_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand sqlCmd = new SqlCommand("SELECT TENSAN, TRANGTHAI FROM SAN WHERE IDSAN = '" + cbo_masan.Text + "'", con);
            con = new SqlConnection(str);
            con.Open();
            SqlDataReader sqlReader = sqlCmd.ExecuteReader();

            while (sqlReader.Read())
            {
                txt_tensan.Text = sqlReader["TENSAN"].ToString();
            }
            sqlReader.Close();
        }

        private void btn_themkh_Click(object sender, EventArgs e)
        {
            khachhang frmKH = new khachhang();
            frmKH.Show();
        }

        private void btn_nhaplai_Click(object sender, EventArgs e)
        {
            cbo_tenkh.SelectedIndex = 0;
            cbo_makh.SelectedIndex = 0;
            cbo_loaisan.SelectedIndex = 0;
            txt_maloaisan.Text = string.Empty;
            dtp_checkin.Text = string.Empty;
            dtp_checkout.Text = string.Empty;
            txt_maphieu.Text = string.Empty;
            cbo_makh.Text = string.Empty;
            cbo_masan.Text = string.Empty;
            txt_tensan.Text = string.Empty;
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                try
                {
                    cmd = con.CreateCommand();
                    cmd.CommandText = @"DELETE FROM PHIEUDATSAN WHERE IDPHIEUDATSAN = '" + txt_maphieu.Text + "'";
                    cmd.ExecuteNonQuery();
                    LoadData();
                    cmd = con.CreateCommand();
                    cmd.CommandText = @"UPDATE SAN SET TRANGTHAI = N'Trống' WHERE (IDSAN = N'" + cbo_masan.Text + @"')";
                    cmd.ExecuteNonQuery();

                    cbo_tenkh.SelectedIndex = 0;
                    cbo_makh.SelectedIndex = 0;
                    cbo_loaisan.SelectedIndex = 0;
                    txt_maloaisan.Text = string.Empty;
                    dtp_checkin.Text = string.Empty;
                    dtp_checkout.Text = string.Empty;
                    txt_maphieu.Text = string.Empty;
                    cbo_makh.Text = string.Empty;
                    cbo_masan.Text = string.Empty;
                    txt_tensan.Text = string.Empty;

                }
                catch
                {
                    MessageBox.Show("Lỗi !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void DatSancs_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r; r = MessageBox.Show(
                "Bạn có muốn thoát?",
                "Thoát",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }

        private void btn_trangchu_Click(object sender, EventArgs e)
        {
            TrangChu frm = new TrangChu();
            frm.Show();
            Hide();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_maphieu_search.Text == string.Empty)
                {
                    LoadData();
                    MessageBox.Show("Chưa Nhập Thông Tin");
                }
                else
                {
                    cmd = con.CreateCommand();
                    cmd.CommandText = @"EXEC TimKiemPhieuDatSan @idphieu = '" + txt_maphieu_search.Text.ToUpper().Trim() + @"'";
                    adapter.SelectCommand = cmd;
                    table.Clear();
                    adapter.Fill(table);
                    dgv_phieudatsan.DataSource = table;
                }
            }
            catch
            {
                MessageBox.Show("Lỗi");
            }
        }

        private void btn_taohoadon_Click(object sender, EventArgs e)
        {
            //HoaDon.TimKiemTheoMaPhieu = txt_maphieu.Text.Trim();
            //HoaDon frmHoaDon = new HoaDon();
            //frmHoaDon.Show();
            //Hide();
        }

        private void btn_xemhd_Click(object sender, EventArgs e)
        {
            HoaDon frmHoaDon = new HoaDon();
            frmHoaDon.Show();
            Hide();
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            DatSancs frm = new DatSancs();
            frm.Show();
            this.Dispose(false);
        }

        private void btn_traphong_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = con.CreateCommand();
                cmd.CommandText =
                    @"EXEC CapNhatTinhTrangSan @idsan = '" + cbo_masan.Text + "'" +
                    @"SET DATEFORMAT DMY EXEC TraSan @IdPhieuDatSan = '" + txt_maphieu.Text + "', @CheckOut = '" + dtp_checkout.Text + "'";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Trả sân thành công");
                LoadData();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message.Substring(err.Message.IndexOf('\n')), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        


        public bool IsNumber(string pValue)
        {
            foreach (Char c in pValue)
            {
                if (!Char.IsDigit(c))
                    return false;
            }
            return true;
        }
        public bool IsChar(string pValue)
        {
            foreach (Char c in pValue)
            {
                if (Char.IsDigit(c))
                    return false;
            }
            return true;
        }

        private void btn_dat_Click(object sender, EventArgs e)
        {
            quanlyloaisan frm = new quanlyloaisan();
            frm.Show();
            Hide();
        }

        private void btn_DatSan_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (cbo_loaisan.Text == "")
                    MessageBox.Show("Bắt Buộc Chọn Loại Sân", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                        if (dtp_checkin.Text == "")
                            MessageBox.Show("Bắt Buộc Chọn Check-In", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else
                        {
                            if (txt_maphieu.Text.Trim() == "")
                                MessageBox.Show("Bắt Buộc Nhập Mã Phiếu", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            else
                            {
                                if (cbo_masan.Text == "")
                                    MessageBox.Show("Bắt Buộc Chọn Mã Sân", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                else
                                {
                                    SqlCommand sqlCmd = new SqlCommand(@"SELECT TRANGTHAI FROM SAN WHERE TENSAN = N'" + txt_tensan.Text.Trim() + @"'", con);
                                    con = new SqlConnection(str);
                                    con.Open();
                                    SqlDataReader sqlReader = sqlCmd.ExecuteReader();

                                    while (sqlReader.Read())
                                    {
                                        if (txt_maphieu.Text == string.Empty)
                                            MessageBox.Show("Chưa Nhập Mã Phiếu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        if (sqlReader[0].ToString() == "Có Khách")
                                            MessageBox.Show("Sân Đã Có Khách", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        if (sqlReader[0].ToString() == "Trống")
                                        {
                                            cmd = con.CreateCommand();
                                            cmd.CommandText = @"SET DATEFORMAT DMY INSERT INTO PHIEUDATSAN(IDPHIEUDATSAN,IDKHACHHANG,IDPHONG,CHECKIN,CHECkOUT)
                                                              VALUES('" + txt_maphieu.Text.ToUpper().Trim() + @"','"
                                                              + cbo_makh.Text + @"','" + cbo_masan.Text + @"','"
                                                              + dtp_checkin.Text + @"'," + dtp_checkout.Text + ")";
                                            cmd.ExecuteNonQuery();
                                            cmd = con.CreateCommand();
                                            cmd.CommandText = @"EXEC CapNhatSanDaDat @idsan = '" + cbo_masan.Text + "'";
                                            cmd.ExecuteNonQuery();
                                            MessageBox.Show("Thêm thành công");
                                            LoadData();
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            catch
            {
                MessageBox.Show("Lỗi, Không Được Trùng Mã Phiếu Đặt Sân", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DatSancs_Load(object sender, EventArgs e)
        {

        }

        }



}

