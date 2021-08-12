using PBL3_GiaBao.DTO;
using PBL3_GiaBao.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3_GiaBao.DAL
{
    class DAL_PhongChieuView
    {
        private static QLRP7Entities db = new QLRP7Entities();

        #region Design Pattern
        private static DAL_PhongChieuView _Instance;
        public static DAL_PhongChieuView Instance
        {
            get
            {
                if (_Instance == null) _Instance = new DAL_PhongChieuView();
                return _Instance;
            }
            private set
            {
                _Instance = value;
            }
        }
        #endregion

        #region Constructor
        private DAL_PhongChieuView()
        {

        }
        #endregion

        #region getData
        public List<PhongChieuView> GetAllPhongChieuViews()
        {
            List<PhongChieuView> phongChieuViews = new List<PhongChieuView>();

            var data = db.PhongChieu.Where(pc => pc.idManHinh == pc.LoaiManHinh.id)
                .Select(pc => new PhongChieuView
                {
                    MaPhong = pc.id,
                    TenPhong = pc.TenPhong,
                    TenMH = pc.LoaiManHinh.TenMH,
                    SoChoNgoi = pc.SoChoNgoi,
                    TinhTrang = pc.TinhTrang,
                    SoHangGhe = pc.SoHangGhe,
                    SoGheMotHang = pc.SoGheMotHang
                });
            return data.ToList();
        }
        #endregion
    }
}
