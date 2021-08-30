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
    public partial class fDoiMatKhau : Form
    {
        TaiKhoan TKLogin { get; set; }

        public fDoiMatKhau(TaiKhoan tklogin)
        {
            InitializeComponent();
            TKLogin = tklogin;
            txtOldPass.PasswordChar = '*';
            txtNewPass.PasswordChar = '*';
            txtNewPass2.PasswordChar = '*';
        }

        private void cbold_CheckedChanged(object sender, EventArgs e)
        {
            if (cbold.Checked == true)
            {
                txtOldPass.PasswordChar = '\0';
            }
            else
            {
                txtOldPass.PasswordChar = '*';
            }
        }

        private void cbNew_CheckedChanged(object sender, EventArgs e)
        {
            if (cbNew.Checked == true)
            {
                txtNewPass.PasswordChar = '\0';
            }
            else
            {
                txtNewPass.PasswordChar = '*';
            }
        }

        private void cbConfirn_CheckedChanged(object sender, EventArgs e)
        {
            if (cbConfirn.Checked == true)
            {
                txtNewPass2.PasswordChar = '\0';
            }
            else
            {
                txtNewPass2.PasswordChar = '*';
            }
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            if (checktxt(txtOldPass.Text) && checktxt(txtNewPass.Text) && checktxt(txtNewPass2.Text))
            {
                string old = BLL.BLL_TaiKhoan.Instance.PasswordEncryption(txtOldPass.Text);
                string new1 = BLL.BLL_TaiKhoan.Instance.PasswordEncryption(txtNewPass.Text);
                string new2 = BLL.BLL_TaiKhoan.Instance.PasswordEncryption(txtNewPass.Text);
                if (old.Equals(TKLogin.Pass))
                {
                    if (txtNewPass.Text.Equals(txtNewPass2.Text))
                    {
                        TaiKhoan tmp = BLL.BLL_TaiKhoan.Instance.GetTaiKhoanByIDTK_BLL(TKLogin.idTK);
                        tmp.Pass = new1;
                        BLL.BLL_TaiKhoan.Instance.DoiPass_BLL(tmp);
                        MessageBox.Show("Đổi mật khẩu thành công", "Thông báo");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Mật khẩu mới không trùng khớp, mời nhập lại!", "Thông báo");
                        fDoiMK_Load(sender, e);
                    }
                }
                else
                {
                    MessageBox.Show("Bạn nhập sai mật khẩu cũ, mời nhập lại!");
                    fDoiMK_Load(sender, e);
                }
            }
            else
            {
                MessageBox.Show("Mời nhập đủ dữ liệu!", "Thông báo");
            }
        }

        private void btHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fDoiMK_Load(object sender, EventArgs e)
        {
            txtUser.Text = TKLogin.UserName;
            txtUser.Enabled = false;
            clear();
        }
        public void clear()
        {
            txtOldPass.Text = "";
            txtNewPass.Text = "";
            txtNewPass2.Text = "";
        }
        private bool checktxt(string txt)
        {
            return txt != string.Empty;
        }
    }
}
