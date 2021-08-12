using PBL3_GiaBao.EF;
using System;
using System.Collections;
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
    public partial class fNhanVien : Form
    {
        String Idnv { get; set; }
        TaiKhoan TKhoanLogin { get; set; }
        public fNhanVien(TaiKhoan TKLogin)
        {
            InitializeComponent();
            Idnv = TKLogin.idNV;
            TKhoanLogin = TKLogin;
        }
        List<NhanVien> listnv;
        public List<NhanVien> ListNV { get => listnv; set { listnv = value; showNV(); } }
        void showNV()
        {
            ArrayList arr = new ArrayList();
            BLL.BLL_NhanVien.Instance.GetAllNV_BLL().ForEach(p => arr.Add(new { p.id, p.HoTen, p.NgaySinh, p.SDT, p.DiaChi, p.CMND, }));
            dataGridView1.DataSource = arr;
        }
        private void Clear()
        {
            txtCMND.Text = "";
            txtDiachi.Text = "";
            txtMaNV.Text = "";
            txtSDT.Text = "";
            txtTenNV.Text = "";
        }
        private void fNhanVien_Load(object sender, EventArgs e)
        {
            btClear.Hide();
            btSave.Hide();
            txtMaNV.Enabled = true;
            txtCMND.Enabled = true;
            txtDiachi.Enabled = true;
            txtSDT.Enabled = true;
            txtTenNV.Enabled = true;
            Clear();
            ListNV = BLL.BLL_NhanVien.Instance.GetAllNV_BLL();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            List<string> listManv = new List<string>();
            if (dataGridView1.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    listManv.Add(row.Cells["id"].Value.ToString());
                    if (listManv.Exists(p => p.Equals(Idnv)))
                    {
                        listManv.Remove(Idnv);
                        MessageBox.Show("Bạn không thể xóa quản lý!");
                    }
                }
                listManv.ForEach(p => BLL.BLL_NhanVien.Instance.DeleteNV_BLL(p));
                fNhanVien_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn nhân viên để xóa", "Thông báo!!");
            }
        }

        private void btDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool checktxt(string txt)
        {
             return txt != string.Empty;
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            if (checktxt(txtMaNV.Text) && checktxt(txtCMND.Text) && checktxt(txtDiachi.Text) && checktxt(txtTenNV.Text) && checktxt(txtSDT.Text))
            {
                try
                {
                    NhanVien nv = new NhanVien();
                    nv.id = txtMaNV.Text;
                    nv.HoTen = txtTenNV.Text;
                    nv.DiaChi = txtDiachi.Text;
                    nv.CMND = Convert.ToInt32(txtCMND.Text);
                    nv.SDT = txtSDT.Text;
                    nv.NgaySinh = Convert.ToDateTime(dtNS.Value.ToString());
                    if (!BLL.BLL_NhanVien.Instance.isExitsNV(nv))
                    {
                        BLL.BLL_NhanVien.Instance.AddNhanVien_BLL(nv);
                        fNhanVien_Load(sender, e);
                    }
                    else MessageBox.Show("Đã tồn tại mã nhân viên này, mời nhập lại!", "Thông báo");
                }
                catch (Exception)
                {
                    MessageBox.Show("Định dạng thông tin không hợp lệ, vui lòng kiểm tra!", "Thông báo");
                }
            }
            else
            {
                MessageBox.Show("Mời nhập đủ thông tin nhân viên!!");
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                txtTenNV.Enabled = true;
                txtSDT.Enabled = true;
                txtMaNV.Enabled = true;
                txtDiachi.Enabled = true;
                txtCMND.Enabled = true;
                btClear.Hide();
                string idnv = dataGridView1.SelectedRows[0].Cells["id"].Value.ToString();
                NhanVien nv = BLL.BLL_NhanVien.Instance.GetNVByIDNV(idnv);
                txtMaNV.Enabled = false;
                btSave.Show();

                txtMaNV.Text = nv.id;
                txtTenNV.Text = nv.HoTen;
                txtDiachi.Text = nv.DiaChi;
                txtCMND.Text = nv.CMND.ToString();
                txtSDT.Text = nv.SDT;
                dtNS.Value = nv.NgaySinh;
            }
            else
            {
                MessageBox.Show("Vui Lòng chọn 1 nhân viên để sửa thông tin", "Thông báo");
            }
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if (checktxt(txtMaNV.Text) && checktxt(txtCMND.Text) && checktxt(txtDiachi.Text) && checktxt(txtTenNV.Text) && checktxt(txtSDT.Text))
            {
                try
                {
                    NhanVien nv = new NhanVien();
                    nv.id = txtMaNV.Text;
                    nv.HoTen = txtTenNV.Text;
                    nv.DiaChi = txtDiachi.Text;
                    nv.CMND = Convert.ToInt32(txtCMND.Text);
                    nv.SDT = txtSDT.Text;
                    nv.NgaySinh = Convert.ToDateTime(dtNS.Value.ToString());

                    BLL.BLL_NhanVien.Instance.EditNhanVien_BLL(nv);
                    fNhanVien_Load(sender, e);
                }
                catch (Exception)
                {
                    MessageBox.Show("Định dạng thông tin không hợp lệ, vui lòng kiểm tra!", "Thông báo");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin!", "Thông báo");
            }
        }

        private void btClear_Click(object sender, EventArgs e)
        {

            fNhanVien_Load(sender, e);
        }

        private void btQLTK_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count==1)
            {
                string idnv = dataGridView1.SelectedRows[0].Cells["id"].Value.ToString();
                fAccount account = new fAccount(idnv,TKhoanLogin);
                account.Show();
                account.FormClosed += Account_FormClosed;
                this.Hide();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn 1 nhân viên!", "Thông Báo");
            }
        }

        private void Account_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCMND.Enabled = false;
            txtDiachi.Enabled = false;
            txtMaNV.Enabled = false;
            txtSDT.Enabled = false;
            txtTenNV.Enabled = false;
            string idnv = dataGridView1.Rows[e.RowIndex].Cells["id"].Value.ToString();
            NhanVien nv = BLL.BLL_NhanVien.Instance.GetNVByIDNV(idnv);
            txtMaNV.Enabled = false;
            btSave.Hide();
            btClear.Show();

            txtMaNV.Text = nv.id;
            txtTenNV.Text = nv.HoTen;
            txtDiachi.Text = nv.DiaChi;
            txtCMND.Text = nv.CMND.ToString();
            txtSDT.Text = nv.SDT;
            dtNS.Value = nv.NgaySinh;
        }
    }
}
