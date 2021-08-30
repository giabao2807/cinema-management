using PBL3_GiaBao.BLL;
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
    public partial class fThemDinhDangPhim : Form
    {
        private string form;
        public delegate void My_del();
        public My_del d { get; set; }
        public fThemDinhDangPhim(string id)
        {
            InitializeComponent();
            form = id;
            setData(id);
        }
        #region LoadData 
        private void setData(string id)
        {
            setCBBPhim();
            setCBBPhongChieu();
            if (id != null)
            {
                txtMaDinhDang.Text = id;
                txtMaDinhDang.Enabled = false;
                DinhDangPhim ddp = BLL_DinhDangPhim.Instance.GetDinhDangPhimByMaDinhDang(id);
                Phim p = BLL_Phim.Instance.getPhimByIdPhim(ddp.idPhim);
                PhongChieu pc = BLL_PhongChieu.Instance.GetPhongChieuByMaPhong(ddp.idPhongChieu);
                cbbPhim.SelectedItem = p;
                cbbPhongChieu.SelectedItem = pc;
            }

        }
        private void setCBBPhim()
        {
            cbbPhim.DataSource = BLL_Phim.Instance.getAllPhimByBLL();
            cbbPhim.DisplayMember = "TenPhim";
        }
        private void setCBBPhongChieu()
        {
            cbbPhongChieu.DataSource = BLL_PhongChieu.Instance.getAllPhongChieuByBLL();
            cbbPhongChieu.DisplayMember = "TenPhong";
        }
        #endregion

        #region Button
        private void btnOK_Click(object sender, EventArgs e)
        {
            string tenPhong = ((PhongChieu)(cbbPhongChieu.SelectedItem)).TenPhong;
            string maPhong = BLL_PhongChieu.Instance.GetCinemaByName(tenPhong).id;
            string tenPhim = ((Phim)(cbbPhim.SelectedItem)).TenPhim;
            string maPhim = BLL_Phim.Instance.getPhimByTenPhim(tenPhim).id;
            string maDinhDang = txtMaDinhDang.Text;
            if (checkData(maDinhDang, maPhong, maPhim))
            {
                if (form != null)
                {
                    BLL_DinhDangPhim.Instance.updateDinhDangPhim(maDinhDang, maPhong, maPhim);
                    MessageBox.Show("Cập nhật định dạng phim thành công", "Thông báo");
                }
                else
                {
                    BLL_DinhDangPhim.Instance.addDinhDangPhim(maDinhDang, maPhong, maPhim);
                    MessageBox.Show("Thêm định dạng phim thành công", "Thông báo");
                }
                d();
                this.Close();
            }

        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Function
        private bool checkData(string maDinhDang, string maPhong, string maPhim)
        {
            if (BLL_DinhDangPhim.Instance.IsExitDinhDangPhimByMaDinhDang(maDinhDang) && form == null)
            {
                MessageBox.Show("Trùng mã định dạng phim", "Thông báo");
                return false;
            }
            if (BLL_DinhDangPhim.Instance.IsExitDinhDangPhimByMaPhimAndMaPhongChieu(maPhim, maPhong))
            {
                MessageBox.Show("Đã tồn tại mã định dạng có mã phim và mã phòng chiếu này", "Thông báo");
                return false;
            }
            return true;
        }
        #endregion
    }
}
