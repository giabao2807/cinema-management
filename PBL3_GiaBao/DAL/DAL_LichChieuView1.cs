using PBL3_GiaBao.DTO;
using PBL3_GiaBao.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3_GiaBao.DAL
{
    class DAL_LichChieuView1
    {
        private static QLRP7Entities db = new QLRP7Entities();

        #region Design Pattern
        private static DAL_LichChieuView1 _Instance;
        public static DAL_LichChieuView1 Instance
        {
            get
            {
                if (_Instance == null) _Instance = new DAL_LichChieuView1();
                return _Instance;
            }
            private set
            {
                _Instance = value;
            }
        }
        #endregion

        #region Constructor
        private DAL_LichChieuView1()
        {

        }
        #endregion

        #region GetData
        public List<LichChieuView1> getAllLichChieuView()
        {
            List<LichChieuView1> lichChieuViews = new List<LichChieuView1>();

            var data = db.LichChieu.Where(lc => lc.idDinhDang == lc.DinhDangPhim.id
            && lc.DinhDangPhim.idPhim == lc.DinhDangPhim.Phim.id
            && lc.DinhDangPhim.idPhongChieu == lc.DinhDangPhim.PhongChieu.id
            && lc.DinhDangPhim.PhongChieu.idManHinh == lc.DinhDangPhim.PhongChieu.LoaiManHinh.id)
                .Select(lc => new LichChieuView1
                {
                    MaLichChieu = lc.id,
                    MaPhong = lc.DinhDangPhim.PhongChieu.id,
                    TenPhim = lc.DinhDangPhim.Phim.TenPhim,
                    ManHinh = lc.DinhDangPhim.PhongChieu.LoaiManHinh.TenMH,
                    ThoiGianChieu = lc.ThoiGianChieu
                });
            return data.ToList();
        }
        #endregion
    }
}
