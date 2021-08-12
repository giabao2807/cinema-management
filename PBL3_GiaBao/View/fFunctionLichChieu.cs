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
    public partial class fFunctionLichChieu : Form
    {
        public delegate void Show_del();
        private string form;
        public Show_del d { get; set; }
        public fFunctionLichChieu(string id)
        {
            InitializeComponent();
            form = id;
            setData(id);
        }

        private void setData(string id)
        {
            txtScreenTypeName_Showtime.Enabled = false;
            cbbCinema.DataSource = BLL_PhongChieu.Instance.getAllPhongChieuByBLL();
            cbbCinema.DisplayMember = "TenPhong";
            if (id != null)
            {
                txtShowtimeID.Text = id;
                txtShowtimeID.Enabled = false;
            } 
        } 

        private void setCBBMovie(string MaPhong)
        {
            /*var data = from DinhDangPhim in BLL_DinhDangPhim.Instance.GetAllDinhDangPhim()
                   from Phim in BLL_Phim.Instance.getAllPhimByBLL()
                   where DinhDangPhim.idPhim == Phim.id
                   && DinhDangPhim.idPhongChieu == MaPhong
                   select new Phim(Phim);*/
            List<DinhDangPhim> ddp = BLL_DinhDangPhim.Instance.GetDinhDangPhimByMaPhong(MaPhong);
            List<Phim> lp = BLL_Phim.Instance.getListPhimByListDDP(ddp);
            cbbMovie.DataSource = lp.ToList();
            cbbMovie.DisplayMember = "TenPhim";
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            string maLichChieu = txtShowtimeID.Text;
            string maPhong = ((PhongChieu)(cbbCinema.SelectedItem)).id;
            string maPhim = ((Phim)(cbbMovie.SelectedItem)).id;
            DinhDangPhim ddp = BLL_DinhDangPhim.Instance.GetDinhDangPhimByMaPhongAndMaPhim(maPhong, maPhim);
            string maDinhDang = ddp.id;
            DateTime time = new DateTime(dtmShowtimeDate.Value.Year, dtmShowtimeDate.Value.Month, dtmShowtimeDate.Value.Day, dtmShowtimeTime.Value.Hour, dtmShowtimeTime.Value.Minute, dtmShowtimeTime.Value.Second);
            if (checkData(maLichChieu, maPhim, maDinhDang, time))
            {
                if (form != null)
                {
                    BLL_LichChieu.Instance.updateLichChieu(maLichChieu, maPhong, maDinhDang, time);
                    MessageBox.Show("Cập nhật lịch chiếu thành công", "Thông báo");
                }
                else
                {
                    BLL_LichChieu.Instance.addLichChieu(maLichChieu, maPhong, maDinhDang, time);
                    MessageBox.Show("Thêm lịch chiếu thành công", "Thông báo");
                }
                d();
                this.Close();
            }
        }


        private bool checkData(string maLichChieu, string maPhim, string maDinhDang, DateTime time)
        {
            if (form == null)
            {
                if (maLichChieu.Trim() == "")
                {
                    MessageBox.Show("Chưa nhập mã lịch chiếu!", "Thông báo");
                    return false;
                }
                else if (BLL_LichChieu.Instance.isExitLichChieu(maLichChieu))
                {
                    MessageBox.Show("Trùng mã lịch chiếu", "Thông báo");
                    return false;
                }
            }
            Phim p = BLL_Phim.Instance.getPhimByIdPhim(maPhim);
            if (time < p.NgayKhoiChieu || time > p.NgayKetThuc)
            {
                MessageBox.Show("Thời gian chiếu không hợp lệ", "Thông báo");
                return false;
            }
            if (BLL_LichChieu.Instance.isExitDataLichChieu(maDinhDang, time))
            {
                MessageBox.Show("Trùng dữ liệu lịch chiếu", "Thông báo");
                return false;
            }
            return true;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbbCinema_SelectedIndexChanged(object sender, EventArgs e)
        {
            string maPhong = ((PhongChieu)(cbbCinema.SelectedItem)).id;
            setCBBMovie(maPhong);
            PhongChieu pc = BLL_PhongChieu.Instance.GetPhongChieuByMaPhong(maPhong);
            txtScreenTypeName_Showtime.Text = BLL_LoaiManHinh.Instance.GetLoaiManHinhByIdMH(pc.idManHinh).TenMH;
        }
    }
}
