using PBL3_GiaBao.EF;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3_GiaBao.View
{
    public partial class fQuanly : Form
    {
        TaiKhoan TKLogin { get; set; }
        public fQuanly(TaiKhoan TaiKhoanLogin)
        {
            InitializeComponent();
            TKLogin = TaiKhoanLogin;
        }
        private void btQLLoaiPhim_Click(object sender, EventArgs e)
        {
            fTheloai f = new fTheloai();
            f.Show();
            f.FormClosed += F_FormClosed;
            this.Hide();
        }

        private void btQLPhim_Click(object sender, EventArgs e)
        {
            fQuanlyphim f = new fQuanlyphim();
            f.Show();
            f.FormClosed += F_FormClosed;
            this.Hide();
        }

        private void btQLPhongChieu_Click(object sender, EventArgs e)
        {
            fPhongChieu f = new fPhongChieu();
            f.Show();
            f.FormClosed += F_FormClosed;
            this.Hide();
        }

        private void btQLNVien_Click(object sender, EventArgs e)
        {
            fNhanVien f = new fNhanVien(TKLogin);
            f.Show();
            f.FormClosed += F_FormClosed;
            this.Hide();

        }

        private void F_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void btQLLChieu_Click(object sender, EventArgs e)
        {
            fLichChieu f = new fLichChieu();
            f.Show();
            f.FormClosed += F_FormClosed;
            this.Hide();
        }

        private void btDXuat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btQLVe_Click(object sender, EventArgs e)
        {
            fQuanLyVe f = new fQuanLyVe();
            f.Show();
            f.FormClosed += F_FormClosed;
            this.Hide();
        }

        private void btQLVe_MouseHover(object sender, EventArgs e)
        {
            Button p = (Button)sender;
            p.BackColor = Color.Brown;
            p.Font = new Font(p.Font,FontStyle.Bold);
           

        }

        private void btQLVe_MouseLeave(object sender, EventArgs e)
        {
            Button p = (Button)sender;
            p.BackColor = Color.OldLace;
            p.Font = new Font(p.Font,FontStyle.Regular);
            
        }

        private void btDXuat_MouseHover(object sender, EventArgs e)
        {
            Button p = (Button)sender;
            p.BackColor = Color.Brown;
        }

        private void btDXuat_MouseLeave(object sender, EventArgs e)
        {
            Button p = (Button)sender;
            p.BackColor = Color.OldLace;
        }

        private void btnQLDinhDangPhim_Click(object sender, EventArgs e)
        {
            fDinhDangPhim f = new fDinhDangPhim();
            f.Show();
            f.FormClosed += F_FormClosed;
            this.Hide();
        }

        private void btnQLDinhDangPhim_MouseHover(object sender, EventArgs e)
        {
            Button p = (Button)sender;
            p.BackColor = Color.Brown;
            p.Font = new Font(p.Font, FontStyle.Bold);
        }

        private void btnQLDinhDangPhim_MouseLeave(object sender, EventArgs e)
        {
            Button p = (Button)sender;
            p.BackColor = Color.OldLace;
            p.Font = new Font(p.Font, FontStyle.Regular);
        }
    }
}
