using PBL3_GiaBao.EF;
using PBL3_GiaBao.BLL;
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
    public partial class fDangNhap : Form
    {
        TaiKhoan TaiKhoanlogin { get; set; }
        public fDangNhap()
        {
            InitializeComponent();
            txtMK.PasswordChar = '*';
        }

        private void checkboxMk_CheckedChanged(object sender, EventArgs e)
        {
            if (checkboxMk.Checked == true)
            {
                txtMK.PasswordChar = '\0';
            }
            else
            {
                txtMK.PasswordChar = '*';
            }
        }

        private void btHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void enter()
        {
            string username = txtTentk.Text.Trim();
            string password = BLL.BLL_TaiKhoan.Instance.PasswordEncryption(txtMK.Text);
            int result = Login(username, password);
            if (result == 1)
            {
                TaiKhoanlogin = BLL.BLL_TaiKhoan.Instance.GetTaiKhoanByUserPass_BLL(username, password);
                fControl f = new fControl(TaiKhoanlogin);
                f.Show();
                f.FormClosed += F_FormClosed;
                this.Hide();
            }
            else
            {
                MessageBox.Show("Dang nhap that bai", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTentk.Text = "";
                txtMK.Text = "";
                txtTentk.Focus();
            }
        }
        private void btDNhap_Click(object sender, EventArgs e)
        {
            enter();
        }

        private void F_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private int Login(string username, string password)
        {
            return BLL.BLL_TaiKhoan.Instance.Login(username, password);
            txtTentk.Text = "";
            txtMK.Text = "";
        }

        private void fLogin_Load(object sender, EventArgs e)
        {

        }

        private void txtMK_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
            if (e.KeyChar == 13)
            {
                enter();
            }
        }
    }
}
