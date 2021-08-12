using PBL3_GiaBao.EF;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL3_GiaBao.DTO;
using PBL3_GiaBao.BLL;

namespace PBL3_GiaBao.DAL
{
    class DAL_LichChieu
    {
        private static QLRP7Entities db = new QLRP7Entities();

        // Design Pattern
        #region Design Pattern
        private static DAL_LichChieu _Instance;
        public static DAL_LichChieu Instance
        {
            get
            {
                if (_Instance == null) _Instance = new DAL_LichChieu();
                return _Instance;
            }
            private set
            {
                _Instance = value;
            }
        }
        #endregion

        // Constructor 
        #region Constructor
        private DAL_LichChieu()
        {

        }
        #endregion

        // Hàm lấy dữ liệu
        #region Get Data
        public List<LichChieu> getAllLichChieu()
        {
            return db.LichChieu.Select(lc => lc).ToList();
        }

        public LichChieu GetLichChieuByIdLichChieu(string idLichChieu)
        {
            return db.LichChieu.Find(idLichChieu);
        }
        public int UpdateStatusShowTimes_DAL(string showTimesID, int status)
        {
                db.LichChieu.Find(showTimesID).TrangThai = status;
                db.SaveChanges();
                return 1;
        }

        public List<LichChieu> GetListShowTimesNotCreateTickets_DAL()
        {
                return db.LichChieu.Where(p => p.TrangThai == 0).ToList();
        }

        public bool isExitLichChieu(string maLichChieu)
        {
            return (db.LichChieu.Find(maLichChieu) != null);
        }
        
        public bool isExitDataLichChieu(string MaDinhDang, DateTime time)
        {
            var data = db.LichChieu.Where(lc => lc.idDinhDang == MaDinhDang && lc.ThoiGianChieu == time);
            return data.Count() > 0;
        }

        // laod list lichhieuview 
        public List<LichChieuView> LoadListShowTimeByFilm(string formatMovieID, DateTime date)
        {
            var data = db.LichChieu.Where(p => p.idDinhDang == formatMovieID && p.ThoiGianChieu.Day.CompareTo(date.Day) == 0
                && p.ThoiGianChieu.Month.CompareTo(date.Month) == 0 && p.ThoiGianChieu.Year.CompareTo(date.Year) == 0).Select(
                 p => new LichChieuView
                 {
                     TenPhong = p.DinhDangPhim.PhongChieu.TenPhong,
                     id = p.id,
                     TenPhim = p.DinhDangPhim.Phim.TenPhim,
                     ThoiGianChieu = p.ThoiGianChieu,
                     TrangThai = p.TrangThai
                 });
            return data.ToList();
        }
        #endregion

        // Thêm, sửa, xóa
        #region Add, Update, Delete
        public bool addLichChieu(string maLichChieu, string maDinhDang, DateTime time)
        {
            db.LichChieu.Add(new LichChieu
            {
                id = maLichChieu,
                idDinhDang = maDinhDang,
                ThoiGianChieu = time,
            });
            return db.SaveChanges() > 0;
        }
        public bool updateLichChieu(string maLichChieu, string maDinhDang, DateTime time)
        {
            var s = db.LichChieu.Find(maLichChieu);
            s.idDinhDang = maDinhDang;
            s.ThoiGianChieu = time;
            return db.SaveChanges() > 0;
        }
        public bool deleteLichChieuByMaPhong(string maDinhDang)
        {
            foreach (LichChieu lc in getAllLichChieu())
            {
                if (lc.idDinhDang == maDinhDang)
                {
                    db.LichChieu.Remove(lc);
                    break;
                }
            }
            return db.SaveChanges() > 0;
        }
        public bool deleteLichChieuByMaLichChieu(string maLichChieu)
        {
            foreach (LichChieu lc in getAllLichChieu())
            {
                if (lc.id == maLichChieu)
                {
                    db.LichChieu.Remove(lc);
                    break;
                }
            }
            return db.SaveChanges() > 0;
        }

        public bool deleteListLichChieu(List<string> maLichChieus)
        {
            foreach(string maLichChieu in maLichChieus)
            {
                var v = db.Ves.Where(ve => ve.idLichChieu == maLichChieu);
                db.Ves.RemoveRange(v);
                var l = db.LichChieu.Find(maLichChieu);
                db.LichChieu.Remove(l);
            }
            return db.SaveChanges() > 0;
        }
        #endregion
        public void CheckLichChieuExpried()
        {
            DateTime now = DateTime.Now;
            List<LichChieu> lichChieus = getAllLichChieu();
            foreach (LichChieu lc in lichChieus)
            {
                if (lc.ThoiGianChieu < now) deleteLichChieuByMaLichChieu(lc.id);
            }
        }
        public bool checkDataLichChieu(string maPhongChieu, string maPhim, DateTime time)
        {
            List<LichChieu> lichChieus = db.LichChieu.Where
                (lc => lc.idDinhDang == lc.DinhDangPhim.id
                && lc.DinhDangPhim.idPhongChieu == maPhongChieu).ToList();
            Phim p = BLL_Phim.Instance.getPhimByIdPhim(maPhim);
            foreach (LichChieu lc in lichChieus)
            {
                if (time.Date == lc.ThoiGianChieu.Date)
                {
                    if (((Convert.ToDouble(time.Hour) * 60) < ((Convert.ToDouble(lc.ThoiGianChieu.Hour) * 60) + p.ThoiLuong))
                        && ((Convert.ToDouble(time.Hour) * 60) > (Convert.ToDouble(lc.ThoiGianChieu.Hour) * 60) - p.ThoiLuong))
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
