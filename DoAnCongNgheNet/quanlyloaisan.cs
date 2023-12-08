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
    public partial class quanlyloaisan : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        string str = "Data Source=DESKTOP-BRGJGMP\\MSSQLSERVER156;Initial Catalog=QUANLYSANBONG; Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        public quanlyloaisan()
        {
            InitializeComponent();
        }

        public void LoadData()
        {
            cmd = con.CreateCommand();
            cmd.CommandText = "SELECT * FROM LOAISAN";
            adapter.SelectCommand = cmd;
            table.Clear();
            adapter.Fill(table);
            dgvLoaiSan.DataSource = table;
        }

        private void quanlyloaisan_Load(object sender, EventArgs e)
        {
            foreach (Control item in groupBox1.Controls)
            {
                if (item is TextBox)
                {
                    item.Enabled = false;
                }
            }
            btn_them.Enabled = false;
            btn_xoa.Enabled = false;
            btn_sua.Enabled = false;
            con = new SqlConnection(str);
            con.Open();
            LoadData();
        }

        private void btn_khoitao_Click(object sender, EventArgs e)
        {
            foreach (Control item in groupBox1.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = string.Empty;
                    item.Enabled = true;
                    txt_maloaisan.Focus();
                }
            }
            btn_them.Enabled = true;
            btn_xoa.Enabled = false;
            btn_sua.Enabled = false;
            dgvLoaiSan.Enabled = false;
        }

       

        private void dgvLoaiSan_Click(object sender, EventArgs e)
        {
            int i;
            i = dgvLoaiSan.CurrentRow.Index;
            txt_maloaisan.Text = dgvLoaiSan.Rows[i].Cells[0].Value.ToString();
            txt_tenloaisan.Text = dgvLoaiSan.Rows[i].Cells[1].Value.ToString();
            cb_dongia.Text = dgvLoaiSan.Rows[i].Cells[2].Value.ToString();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
             foreach (Control item in groupBox1.Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = string.Empty;
                    }
                }
                txt_tenloaisan.Focus();
        }

        private void quanlyloaisan_FormClosing(object sender, FormClosingEventArgs e)
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

        private void btn_returnfrmMain_Click(object sender, EventArgs e)
        {
            TrangChu frmMain = new TrangChu();
            frmMain.Show();
            Hide();
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

        private void btn_them_Click(object sender, EventArgs e)
        {

            try
            {
                if (txt_maloaisan.Text == string.Empty)
                    MessageBox.Show("Bạn chưa nhập mã loại sân", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    if (txt_tenloaisan.Text == string.Empty)
                        MessageBox.Show("Bạn chưa nhập tên loại sân", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        if (cb_dongia.Text == string.Empty)
                            MessageBox.Show("Bạn chưa nhập đơn giá loại sân", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else
                        {
                            if (IsChar(cb_dongia.Text) == true)
                                MessageBox.Show("Đơn Giá Phải Là Số", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            else
                            {
                                cmd = con.CreateCommand();
                                cmd.CommandText = @"INSERT INTO LOAISAN VALUES(N'" + txt_maloaisan.Text + @"',N'" + txt_tenloaisan.Text + @"',N'" + cb_dongia.Text + "')";
                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Thêm Thành Công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LoadData();
                            }
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Lỗi, Không Được Nhập Trùng Mã Loại Sân", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                cmd = con.CreateCommand();
                cmd.CommandText = @"DELETE FROM LOAISAN WHERE IDLOAISAN = '" + txt_maloaisan.Text + "'";
                cmd.ExecuteNonQuery();
                LoadData();
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            txt_maloaisan.Enabled = false;
            cmd = con.CreateCommand();
            cmd.CommandText = @"UPDATE LOAISAN SET IDLOAISAN = N'" + txt_maloaisan.Text + @"', TENLOAISAN = N'" + txt_tenloaisan.Text + @"', DONGIA = N'" + cb_dongia.Text + "' WHERE (IDLOAISAN = N'" + txt_maloaisan.Text + @"')";
            cmd.ExecuteNonQuery();
            LoadData();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            btn_sua.Enabled = true;
            btn_xoa.Enabled = true;
            btn_them.Enabled = false;
            dgvLoaiSan.Enabled = true;

            foreach (Control item in groupBox1.Controls)
            {
                if (item is TextBox)
                {
                    item.Enabled = true;
                }
            }
            txt_maloaisan.Enabled = false;
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_nhapmaloaisan_search.Text == string.Empty)
                {
                    LoadData();
                    MessageBox.Show("Chưa Nhập Thông Tin");
                }
                else
                {
                    cmd = con.CreateCommand();
                    cmd.CommandText = @"SELECT * FROM LOAISAN WHERE IDLOAISAN = '" + txt_nhapmaloaisan_search.Text + "'";
                    adapter.SelectCommand = cmd;
                    table.Clear();
                    adapter.Fill(table);
                    dgvLoaiSan.DataSource = table;
                }
            }
            catch
            {
                MessageBox.Show("Lỗi");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Load_cb();
        }
        
        public void Load_cb()
        {
            string[] Gia = { "150000", "200000", "400000" };

            cb_dongia.Items.AddRange(Gia);
            cb_dongia.SelectedIndex = 0;
        }
    





    }
}
