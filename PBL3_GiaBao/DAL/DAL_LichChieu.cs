using PBL3_GiaBao.EF;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL3_GiaBao.DTO;

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
            return db.LichChieux.Select(lc => lc).ToList();
        }

        public LichChieu GetLichChieuByIdLichChieu(string idLichChieu)
        {
            return db.LichChieux.Find(idLichChieu);
        }
        public int UpdateStatusShowTimes_DAL(string showTimesID, int status)
        {
                db.LichChieux.Find(showTimesID).TrangThai = status;
                db.SaveChanges();
                return 1;
        }

        public List<LichChieu> GetListShowTimesNotCreateTickets_DAL()
        {
                return db.LichChieux.Where(p => p.TrangThai == 0).ToList();
        }

        public bool isExitLichChieu(string maLichChieu)
        {
            return (db.LichChieux.Find(maLichChieu) != null);
        }
        
        public bool isExitDataLichChieu(string MaDinhDang, DateTime time)
        {
            var data = db.LichChieux.Where(lc => lc.idDinhDang == MaDinhDang && lc.ThoiGianChieu == time);
            return data.Count() > 0;
        }

        // laod list lichhieuview 
        public List<LichChieuView> LoadListShowTimeByFilm(string formatMovieID, DateTime date)
        {
            var data = db.LichChieux.Where(p => p.idDinhDang == formatMovieID && p.ThoiGianChieu.Day.CompareTo(date.Day) == 0
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
            db.LichChieux.Add(new LichChieu
            {
                id = maLichChieu,
                idDinhDang = maDinhDang,
                ThoiGianChieu = time,
            });
            return db.SaveChanges() > 0;
        }
        public bool updateLichChieu(string maLichChieu, string maDinhDang, DateTime time)
        {
            var s = db.LichChieux.Find(maLichChieu);
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
                    db.LichChieux.Remove(lc);
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
                    db.LichChieux.Remove(lc);
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
                var l = db.LichChieux.Find(maLichChieu);
                db.LichChieux.Remove(l);
            }
            return db.SaveChanges() > 0;
        } 
        #endregion
    }
}
