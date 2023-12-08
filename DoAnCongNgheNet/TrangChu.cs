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
    public partial class TrangChu : Form
    {
        public TrangChu()
        {
            InitializeComponent();
        }

        private void thôngTinKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
          khachhang frmKH = new khachhang();
            frmKH.Show();
            Hide();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dangnhap frmLogin = new dangnhap();
            frmLogin.Show();
            Hide();
        }

        private void đặtPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DatSancs frmDatSan = new DatSancs();
            frmDatSan.Show();
            Hide();
        }

        private void quảnLýPhòngToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            quanlyloaisan frmQLSan = new quanlyloaisan();
            frmQLSan.Show();
            Hide();
        }


        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
           Doimatkhau frmDoiMatKhau = new Doimatkhau();
            frmDoiMatKhau.Show();
            Hide();
        }

        private void hToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HoaDon frmHoaDon = new HoaDon();
            frmHoaDon.Show();
            Hide();
        }

        private void FormMAIN_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TrangChu_FormClosing(object sender, FormClosingEventArgs e)
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
    }
}
