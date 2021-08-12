using PBL3_GiaBao.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3_GiaBao.DAL
{
    class DAL_Phim
    {
        private static QLRP7Entities db = new QLRP7Entities();

        // Design Pattern
        #region Design Pattern
        private static DAL_Phim _Instance;
        public static DAL_Phim Instance
        {
            get
            {
                if (_Instance == null) _Instance = new DAL_Phim();
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
        private DAL_Phim()
        {

        }
        #endregion

        // Function
        #region Function
        public List<Phim> getAllPhim()
        {
            return db.Phims.Select(phim => phim).ToList();
        }
        public Phim getPhimByIdPhim(string idPhim)
        {
            var data = db.Phims.Find(idPhim);
            return data;
        }
        public Phim getPhimByTenPhim(string tenPhim)
        {
            Phim phim = null;
            var data = db.Phims.Where(p => p.TenPhim == tenPhim);
            if (data.Count() > 0) phim = data.FirstOrDefault();
            return phim;
        }
        public List<Phim> getPhimByListDDP(List<DinhDangPhim> list)
        {
            List<Phim> s = new List<Phim>();
            foreach(DinhDangPhim i in list)
            {
                Phim p = getPhimByIdPhim(i.idPhim);
                s.Add(p);
            }
            return s;
        }
        public List<Phim> GetListMovieByDate_DAL(DateTime date)
        {
            var listLC = db.LichChieux.Where(p => p.ThoiGianChieu.Day.CompareTo(date.Day) == 0
                &&  p.ThoiGianChieu.Month.CompareTo(date.Month) == 0 &&  p.ThoiGianChieu.Year.CompareTo(date.Year) == 0);
            List<Phim> s = new List<Phim>();
            foreach(LichChieu i in listLC)
            {
                Phim p = getPhimByIdPhim(i.DinhDangPhim.idPhim);
                bool alreadyExist = s.Contains(p);
                if (alreadyExist == false) s.Add(p);
            }
            return s;
        }
        public List<Phim> getPhimbyidTheLoai(string idTheLoai)
        {
            var l = db.Phims.Where(p => p.idTheLoai.CompareTo(idTheLoai) == 0);
            return l.ToList();
        }
        #endregion
        // check
        #region check

        public bool themPhim(Phim s)
        {
            db.Phims.Add(s);
            return db.SaveChanges() > 0;
        }
        public bool suaphim(Phim p)
        {
            var phim = db.Phims.Where(i => i.id.Equals(p.id)).FirstOrDefault();
            phim.TenPhim = p.TenPhim;
            phim.MoTa = p.MoTa;
            phim.idTheLoai = p.idTheLoai;
            phim.NamSX = p.NamSX;
            phim.DaoDien = p.DaoDien;
            phim.NgayKetThuc = p.NgayKetThuc;
            phim.NgayKhoiChieu = p.NgayKhoiChieu;
            phim.SanXuat = p.SanXuat;
            phim.ThoiLuong = p.ThoiLuong;
            return db.SaveChanges() > 0;
        }
        public bool xoaphim(List<string> maphims)
        {
            foreach(string x in maphims)
            { 
                var p = db.Phims.Where(phim => phim.id.CompareTo(x) == 0).FirstOrDefault();
                db.Phims.Remove(p);
                var s = db.DinhDangPhims.Where(ddp => ddp.idPhim.CompareTo(x) == 0).FirstOrDefault();
                db.DinhDangPhims.Remove(s);
            }
            return db.SaveChanges() > 0;
        }
        #endregion 
    }
}
