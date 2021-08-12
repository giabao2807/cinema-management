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
    public partial class fControl : Form
    {
        TaiKhoan TKLogin { get; set; }
        public fControl(TaiKhoan tklogin)
        {
            InitializeComponent();
            TKLogin = tklogin;
        }

        private void btQuanly_Click(object sender, EventArgs e)
        {
            if (TKLogin.LoaiTK == 1)
            {
                fQuanly quanly = new fQuanly(TKLogin);
                quanly.Show();
                quanly.FormClosed += F_FormClosed;
                this.Hide();
            }
            else
            {
                MessageBox.Show("Bạn không có quyền truy cập chức năng này!", "Thông báo");
            }
        }

        private void btBanVe_Click(object sender, EventArgs e)
        {
            if (TKLogin.LoaiTK == 2)
            {
                fSeller banve = new fSeller();
                banve.Show();
                banve.FormClosed += F_FormClosed;
                this.Hide();
            }
            else
            {
                MessageBox.Show("Bạn không có quyền truy cập chức năng này!", "Thông báo");
            }
        }

        private void btDoiMK_Click(object sender, EventArgs e)
        {
            fDoiMK f = new fDoiMK(TKLogin);
            f.FormClosed += F_FormClosed;
            f.Show();
            this.Hide();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void F_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }
    }
}
