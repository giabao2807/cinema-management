﻿using PBL3_GiaBao.BLL;
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
    public partial class fThemLichChieu : Form
    {
        public delegate void Show_del();
        private string form;
        public Show_del d { get; set; }
        public fThemLichChieu(string id)
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
                LichChieu lc = BLL_LichChieu.Instance.GetLichChieuByIdLichChieu(id);
                dtmShowtimeDate.Text = lc.ThoiGianChieu.ToString().Trim();
                dtmShowtimeTime.Text = lc.ThoiGianChieu.ToString().Trim();
                txtShowtimeID.Text = id;
                txtTicketFee.Text = lc.GiaVe.ToString();
                txtShowtimeID.Enabled = false;
            }
        }

        private void setCBBMovie(string MaPhong)
        {
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
            string strGiaVe = txtTicketFee.Text;
            int giaVe = 0;
            DinhDangPhim ddp = BLL_DinhDangPhim.Instance.GetDinhDangPhimByMaPhongAndMaPhim(maPhong, maPhim);
            string maDinhDang = ddp.id;
            DateTime time = new DateTime(dtmShowtimeDate.Value.Year, dtmShowtimeDate.Value.Month, dtmShowtimeDate.Value.Day, dtmShowtimeTime.Value.Hour, dtmShowtimeTime.Value.Minute, dtmShowtimeTime.Value.Second);
            if (checkData(maLichChieu, maPhim, maDinhDang, strGiaVe, ref giaVe ,time))
            {
                if (form != null)
                {
                    BLL_LichChieu.Instance.updateLichChieu(maLichChieu, maDinhDang, giaVe, time);
                    MessageBox.Show("Cập nhật lịch chiếu thành công", "Thông báo");
                }
                else
                {
                    BLL_LichChieu.Instance.addLichChieu(maLichChieu, maDinhDang, giaVe, time);
                    MessageBox.Show("Thêm lịch chiếu thành công", "Thông báo");
                }
                d();
                this.Close();
            }
        }

        private bool checkData(string maLichChieu, string maPhim, string maDinhDang, string strGiaVe, ref int giaVe, DateTime time)
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
            if (!(int.TryParse(strGiaVe, out giaVe)))
            {
                MessageBox.Show("Nhập sai giá vé", "Thông báo");
                return false;
            }
            string maPhongChieu = BLL_DinhDangPhim.Instance.getIDphongChieubyIdDinhDang(maDinhDang);
            Phim p = BLL_Phim.Instance.getPhimByIdPhim(maPhim);
            if ((time < p.NgayKhoiChieu || time > p.NgayKetThuc)
                || !(BLL_LichChieu.Instance.checkDataLichChieu(maPhongChieu, maPhim, time)))
            {
                MessageBox.Show("Thời gian chiếu không hợp lệ", "Thông báo");
                return false;
            }
            return true;
        }

      
        private void checkDateTime(string maDinhDang, DateTime time)
        {
            string maPhongChieu = BLL_DinhDangPhim.Instance.getIDphongChieubyIdDinhDang(maDinhDang);

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
