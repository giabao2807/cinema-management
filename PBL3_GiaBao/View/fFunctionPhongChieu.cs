using PBL3_GiaBao.BLL;
using PBL3_GiaBao.DTO;
using PBL3_GiaBao.EF;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3_GiaBao.View
{
    public partial class fFunctionPhongChieu : Form
    {
        public delegate void My_del();
        public My_del d { get; set; }
        private string form;
        public fFunctionPhongChieu(string id)
        {
            InitializeComponent();
            form = id;
            setData(id);
        }

        private void setData(string id)
        {
            txtSoChoNgoi.Enabled = false;
            setCBBLoaiManHinh();
            setCBBTinhTrang();
            if (id != null)
            {
                PhongChieu pc = BLL_PhongChieu.Instance.GetPhongChieuByMaPhong(id);
                txtMaPhong.Text = id;
                txtMaPhong.Enabled = false;
                txtTenPhong.Text = pc.TenPhong;
                txtSoChoNgoi.Text = pc.SoChoNgoi.ToString();
                txtSoHangGhe.Text = pc.SoHangGhe.ToString();
                txtGheMoiHang.Text = pc.SoGheMotHang.ToString();
                LoaiManHinh lmh = BLL_LoaiManHinh.Instance.GetLoaiManHinhByIdMH(pc.idManHinh);
                cbbTinhTrang.SelectedIndex = pc.TinhTrang;
                cbbManHinh.SelectedItem = lmh;
            }
        }

        private void setCBBTinhTrang()
        {
            cbbTinhTrang.Items.Add(new CBBItem { Value = 0, Text = "0" });
            cbbTinhTrang.Items.Add(new CBBItem { Value = 1, Text = "1" });
            cbbTinhTrang.SelectedIndex = 0;
        }

        private void setCBBLoaiManHinh()
        {
            cbbManHinh.DataSource = BLL_LoaiManHinh.Instance.getAllLoaiManHinhByBLL();
            cbbManHinh.DisplayMember = "TenMH";
        }
        public bool IsNumber(string pText)
        {
            Regex regex = new Regex(@"^[-+]?[0-9]*.?[0-9]+$");
            return regex.IsMatch(pText);
        }
        private bool checkData(string maPhong, string tenPhong, string soHangGhe, string gheMoiHang)
        {
            if (form == null)
            {
                if (BLL_PhongChieu.Instance.IsExitPhongChieuByMaPhong(maPhong))
                {
                    MessageBox.Show("Trùng mã phòng chiếu!", "Thông báo");
                    return false;
                }
                if (BLL_PhongChieu.Instance.GetCinemaByName(tenPhong) != null)
                {
                    MessageBox.Show("Trùng tên phòng chiếu!", "Thông báo");
                    return false;
                }
            }
            else 
            {
                PhongChieu pc = BLL_PhongChieu.Instance.GetPhongChieuByMaPhong(maPhong);
                if (txtTenPhong.Text != pc.TenPhong)
                {
                    if (BLL_PhongChieu.Instance.GetCinemaByName(tenPhong) != null)
                    {
                        MessageBox.Show("Trùng tên phòng chiếu!", "Thông báo");
                        return false;
                    }
                } 
            }
            if (maPhong == "" || tenPhong == "" || soHangGhe == "" || gheMoiHang == "")
            {
                MessageBox.Show("Nhập thiếu thông tin!", "Thông báo");
                return false;
            }
            if (!IsNumber(soHangGhe) || !IsNumber(gheMoiHang))
            {
                MessageBox.Show("Thông tin định dạng sai", "Thông báo");
                return false;
            }
            else if (int.Parse(soHangGhe) <= 0 || int.Parse(gheMoiHang) <= 0)
            {
                MessageBox.Show("Thông tin định dạng sai", "Thông báo");
                return false;
            }
            return true;
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            string maPhong = txtMaPhong.Text.Trim();
            string tenPhong = txtTenPhong.Text.Trim();
            string soHangGhe = txtSoHangGhe.Text.Trim();
            string gheMoiHang = txtGheMoiHang.Text.Trim();
            string idMH = ((LoaiManHinh)(cbbManHinh.SelectedItem)).id;
            int tinhTrang = (int)((CBBItem)(cbbTinhTrang.SelectedItem)).Value; 
            if (checkData(maPhong, tenPhong, soHangGhe, gheMoiHang))
            {
                string soChoNgoi = txtSoChoNgoi.Text.Trim();
                if (form != null)
                {           
                    BLL.BLL_PhongChieu.Instance.updatePhongChieu(maPhong, tenPhong, idMH, int.Parse(soChoNgoi),tinhTrang ,int.Parse(soHangGhe), int.Parse(gheMoiHang));
                    MessageBox.Show("Cập nhật phòng chiếu thành công", "Thông báo");
                }
                else
                {
                    BLL.BLL_PhongChieu.Instance.addPhongChieu(maPhong, tenPhong, idMH, int.Parse(soChoNgoi), tinhTrang, int.Parse(soHangGhe), int.Parse(gheMoiHang));
                    MessageBox.Show("Thêm phòng chiếu thành công", "Thông báo");
                }
                d();
                this.Close();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSoHangGhe_TextChanged(object sender, EventArgs e)
        {
            if (txtGheMoiHang.Text.Trim() == "" || txtSoHangGhe.Text.Trim() == "")
            {
                txtSoChoNgoi.Text = "";
            }
            else if (!IsNumber(txtGheMoiHang.Text.Trim()) || !IsNumber(txtSoHangGhe.Text.Trim()))
            {
                txtSoChoNgoi.Text = "Error";
            }
            else if (int.Parse(txtGheMoiHang.Text.Trim()) <= 0 || int.Parse(txtSoHangGhe.Text.Trim()) <= 0)
            {
                txtSoChoNgoi.Text = "Error";
            }
            else 
            {
                int soChoNgoi = int.Parse(txtSoHangGhe.Text) * int.Parse(txtGheMoiHang.Text);
                txtSoChoNgoi.Text = soChoNgoi.ToString();
            }
        }

        private void txtGheMoiHang_TextChanged(object sender, EventArgs e)
        {
            if (txtGheMoiHang.Text.Trim() == "" || txtSoHangGhe.Text.Trim() == "")
            {
                txtSoChoNgoi.Text = "";
            }
            else if (!IsNumber(txtGheMoiHang.Text.Trim()) || !IsNumber(txtSoHangGhe.Text.Trim()))
            {
                txtSoChoNgoi.Text = "Error";
            }
            else if (int.Parse(txtGheMoiHang.Text.Trim()) <= 0 || int.Parse(txtSoHangGhe.Text.Trim()) <= 0)
            {
                txtSoChoNgoi.Text = "Error";
            }
            else 
            {
                int soChoNgoi = int.Parse(txtSoHangGhe.Text) * int.Parse(txtGheMoiHang.Text);
                txtSoChoNgoi.Text = soChoNgoi.ToString();
            }
        }
    }
}
