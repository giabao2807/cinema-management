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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3_GiaBao.View
{
    public partial class fThemPhongChieu : Form
    {
        public delegate void My_del();
        public My_del d { get; set; }
        private string form;
        public fThemPhongChieu(string id)
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

        private bool checkData(string maPhong, string tenPhong, string strSoHangGhe, string strGheMoiHang, ref int soHangGhe, ref int gheMoiHang)
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
            if (!(int.TryParse(strSoHangGhe, out soHangGhe)) || !(int.TryParse(strGheMoiHang, out gheMoiHang)))
            {
                MessageBox.Show("Nhập sai định dạng", "Thông báo");
                return false;
            }
            else if (soHangGhe * gheMoiHang > 160)
            {
                MessageBox.Show("Vượt quá số ghế tối đa của một phòng");
                return false;
            }
            return true;
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            int soHangGhe = 0, gheMoiHang = 0;
            string maPhong = txtMaPhong.Text.Trim();
            string tenPhong = txtTenPhong.Text.Trim();
            string strSoHangGhe = txtSoHangGhe.Text.Trim();
            string strGheMoiHang = txtGheMoiHang.Text.Trim();
            string idMH = ((LoaiManHinh)(cbbManHinh.SelectedItem)).id;
            int tinhTrang = (int)((CBBItem)(cbbTinhTrang.SelectedItem)).Value;
            if (checkData(maPhong, tenPhong, strSoHangGhe, strGheMoiHang, ref soHangGhe, ref gheMoiHang))
            {
                string soChoNgoistr = txtSoChoNgoi.Text.Trim();
                if (form != null )
                {
                    BLL.BLL_PhongChieu.Instance.updatePhongChieu(maPhong, tenPhong, idMH, int.Parse(soChoNgoistr), tinhTrang, soHangGhe, gheMoiHang);
                    MessageBox.Show("Cập nhật phòng chiếu thành công", "Thông báo");
                }
                else
                {
                    BLL.BLL_PhongChieu.Instance.addPhongChieu(maPhong, tenPhong, idMH, int.Parse(soChoNgoistr), tinhTrang, soHangGhe, gheMoiHang);
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
            int soHangGhe;
            int gheMoiHang;
            if (txtGheMoiHang.Text.Trim() == "" || txtSoHangGhe.Text.Trim() == "")
            {
                txtSoChoNgoi.Text = "";
            }
            else if (!(int.TryParse(txtSoHangGhe.Text, out soHangGhe)) || !(int.TryParse(txtGheMoiHang.Text, out gheMoiHang)))
            {
                txtSoChoNgoi.Text = "Error";
            }
            else
            {
                int soChoNgoi = soHangGhe * gheMoiHang;
                txtSoChoNgoi.Text = soChoNgoi.ToString();
            }
        }

        private void txtGheMoiHang_TextChanged(object sender, EventArgs e)
        {
            int soHangGhe;
            int gheMoiHang;
            if (txtGheMoiHang.Text.Trim() == "" || txtSoHangGhe.Text.Trim() == "")
            {
                txtSoChoNgoi.Text = "";
            }
            else if (!(int.TryParse(txtGheMoiHang.Text, out gheMoiHang)) || !(int.TryParse(txtSoHangGhe.Text, out soHangGhe)))
            {
                txtSoChoNgoi.Text = "Error";
            }
            else
            {
                int soChoNgoi = soHangGhe * gheMoiHang;
                txtSoChoNgoi.Text = soChoNgoi.ToString();
            }
        }
    }
}
