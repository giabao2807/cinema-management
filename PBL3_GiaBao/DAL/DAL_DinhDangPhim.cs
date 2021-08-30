using PBL3_GiaBao.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3_GiaBao.DAL
{
    class DAL_DinhDangPhim
    {
        private static QLRP8Entities db = new QLRP8Entities();

        // Design Pattern
        #region Design Pattern
        private static DAL_DinhDangPhim _Instance;
        public static DAL_DinhDangPhim Instance
        {
            get
            {
                if (_Instance == null) _Instance = new DAL_DinhDangPhim();
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
        private DAL_DinhDangPhim()
        {

        }
        #endregion

        // Function
        #region Function
        public List<DinhDangPhim> getAllDinhDangPhim()
        {
            return db.DinhDangPhim.Select(ddp => ddp).ToList();
        }
        public DinhDangPhim GetDinhDangPhimByIdPhong(string maPhong)
        {
            DinhDangPhim dinhDangPhim = null;
            var data = db.DinhDangPhim.Where(ddp => ddp.idPhongChieu == maPhong);
            if (data.Count() > 0) dinhDangPhim = data.FirstOrDefault();
            return dinhDangPhim;
        }
        public List<DinhDangPhim> GetDinhDangPhimByMaPhong(string maPhong)
        {
            var data = db.DinhDangPhim.Where(ddp => ddp.idPhongChieu == maPhong);
            return data.ToList();
        }
        public DinhDangPhim GetDinhDangPhimByMaDinhDang(string maDinhDang)
        {
            return db.DinhDangPhim.Find(maDinhDang);
        }

        public List<DinhDangPhim> GetListFormatMovieByMovie_DAL(string movieID)
        {
            var l = db.DinhDangPhim.Where(p => p.idPhim == movieID);
            return l.ToList();
        }
        public List<DinhDangPhim> GetListFormatMovieByMovieAndDate_DAL(string movieID, DateTime date)
        {
            var listLC = db.LichChieu.Where(p => p.ThoiGianChieu.Day.CompareTo(date.Day) == 0
                && p.ThoiGianChieu.Month.CompareTo(date.Month) == 0 && p.ThoiGianChieu.Year.CompareTo(date.Year) == 0);
            List<DinhDangPhim> s = new List<DinhDangPhim>();
            foreach (LichChieu i in listLC)
            {
                DinhDangPhim p = GetDinhDangPhimByMaDinhDang(i.idDinhDang);
                bool alreadyExist = s.Contains(p);
                if (alreadyExist == false && p.idPhim == movieID) s.Add(p);
            }
            return s;
        }

        public List<String> getMaDinhDangbyMaPhim(string x)
        {
            var l = db.DinhDangPhim.Where(p => p.idPhim.CompareTo(x) == 0).Select(p => p.id).ToList();
            return l;
        }
        public string getIDphongChieubyIdDinhDang(string idDinhDang)
        {
            var l = db.DinhDangPhim.Find(idDinhDang);
            return l.idPhongChieu;
        }
        public DinhDangPhim GetDinhDangPhimByMaPhongAndMaPhim(string maPhong, string maPhim)
        {
            DinhDangPhim dinhDangPhim = null;
            var data = db.DinhDangPhim.Where(ddp => ddp.idPhim == maPhim && ddp.idPhongChieu == maPhong);
            if (data.Count() > 0) dinhDangPhim = data.FirstOrDefault();
            return dinhDangPhim;
        }
        #endregion 
        //check
        #region check
        public bool xoaDinhDangPhim(List<string> maPhims)
        {
            foreach (string mp in maPhims)
            {
                var l = db.DinhDangPhim.Where(p => p.idPhim.CompareTo(mp) == 0).FirstOrDefault();
                db.DinhDangPhim.Remove(l);
            }
            return db.SaveChanges() > 0;
        }


        public bool IsExitDinhDangPhimByMaDinhDang(string maDinhDang)
        {
            return db.DinhDangPhim.Find(maDinhDang) != null;
        }
        public bool IsExitDinhDangPhimByMaPhimAndMaPhongChieu(string maPhim, string maPhongChieu)
        {
            var data = db.DinhDangPhim.Where(ddp => ddp.idPhim == maPhim && ddp.idPhongChieu == maPhongChieu);
            return data.Count() > 0;
        }
        public bool addDinhDangPhim(string maDinhDang, string maPhongChieu, string maPhim)
        {
            db.DinhDangPhim.Add(new DinhDangPhim
            {
                id = maDinhDang,
                idPhongChieu = maPhongChieu,
                idPhim = maPhim
            });
            return db.SaveChanges() > 0;
        }
        public bool updateDinhDangPhim(string maDinhDang, string maPhongChieu, string maPhim)
        {
            DinhDangPhim ddp = db.DinhDangPhim.Find(maDinhDang);
            ddp.id = maDinhDang;
            ddp.idPhim = maPhim;
            ddp.idPhongChieu = maPhongChieu;
            return db.SaveChanges() > 0;
        }
        public bool deleteListDinhDangPhim(List<string> maDinhDangs)
        {
            foreach (string maDinhDang in maDinhDangs)
            {
                var data = db.DinhDangPhim.Find(maDinhDang);
                db.DinhDangPhim.Remove(data);
            }
            return db.SaveChanges() > 0;
        }
        #endregion
    }
}
