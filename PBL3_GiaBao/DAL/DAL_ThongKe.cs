using PBL3_GiaBao.EF;
using PBL3_GiaBao.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3_GiaBao.DAL
{
    class DAL_ThongKe
    {
        private static QLRP8Entities db = new QLRP8Entities();

        // Design Pattern
        #region Design Pattern
        private static DAL_ThongKe _Instance = null;
        public static DAL_ThongKe Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new DAL_ThongKe();
                }
                return _Instance;
            }
            private set { _Instance = value; }
        }
        #endregion
        // Constructor 
        #region Constructor 
        public DAL_ThongKe()
        {

        }
        #endregion
        public List<ThongKeView> GetRevenue(string movieId, DateTime fromDate, DateTime toDate)
        {
            List<ThongKeView> listTK = new List<ThongKeView>();
            var listLC = db.LichChieu.Where(p => p.ThoiGianChieu.CompareTo(fromDate) >= 0 && p.ThoiGianChieu.CompareTo(toDate) <= 0);
            if( fromDate == toDate && movieId != "0")
            {
                listLC = db.LichChieu.Where(p => p.ThoiGianChieu.Day == fromDate.Day && p.ThoiGianChieu.Month == fromDate.Month &&
                p.ThoiGianChieu.Year == fromDate.Year && p.DinhDangPhim.idPhim == movieId);
            } else if (movieId != "0")
            {
                listLC = db.LichChieu.Where(p => p.ThoiGianChieu.CompareTo(fromDate) >= 0 && p.ThoiGianChieu.CompareTo(toDate) <= 0
                && p.DinhDangPhim.idPhim == movieId);
            }
            foreach (LichChieu i in listLC)
            {
                float sumTienBanVe = 0;
                var listVe = db.Ve.Where(p => p.idLichChieu == i.id && p.TrangThai == 1);
                foreach (Ve j in listVe)
                {
                    sumTienBanVe += (float)j.TienBanVe;
                }
                ThongKeView tkv = new ThongKeView();
                tkv.TenPhim = i.DinhDangPhim.Phim.TenPhim;
                tkv.NgayChieu = i.ThoiGianChieu.Date;
                tkv.GioChieu = i.ThoiGianChieu.TimeOfDay.ToString();
                tkv.SoVeDaBan = DAL_Ve.Instance.CountTheNumberOfTicketsSoldByShowTime_DAL(i.id);
                tkv.TienBanVe = sumTienBanVe;
                listTK.Add(tkv);
            }
            return listTK;
        }
    }
}
