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
    public partial class a : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        string str = "Data Source=DESKTOP-BRGJGMP\\MSSQLSERVER156;Initial Catalog=QUANLYSANBONG; Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        public a()
        {
            InitializeComponent();
            
        }
        public void LoadData()
        {
            cmd = con.CreateCommand();
            cmd.CommandText = "SELECT * FROM SAN";
            adapter.SelectCommand = cmd;
            table.Clear();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtID.Text == string.Empty)
                    MessageBox.Show("Bạn chưa nhập mã loại sân", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    if (txtTen.Text == string.Empty)
                        MessageBox.Show("Bạn chưa nhập tên loại sân", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        if (txtTrangthai.Text == string.Empty)
                            MessageBox.Show("Bạn chưa nhập đơn giá loại sân", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else
                        {
                            cmd = con.CreateCommand();
                            cmd.CommandText = @"INSERT INTO SAN VALUES(N'" + txtID.Text + @"',N'" + txtTen.Text + @"',N'" + txtTrangthai.Text + "')";
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Thêm Thành Công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadData();
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Lỗi, Không Được Nhập Trùng Mã Loại Phòng", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void a_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(str);
            con.Open();
            LoadData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataGridView1.CurrentRow.Index;
            txtID.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            txtTen.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            txtTrangthai.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
        }

        private void a_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r; r = MessageBox.Show("Bạn có muốn thoát?","Thoát",MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                cmd = con.CreateCommand();
                cmd.CommandText = @"DELETE FROM SAN WHERE IDSAN = '" + txtID.Text + "'";
                cmd.ExecuteNonQuery();
                LoadData();
            }
        }


    }
}

    
