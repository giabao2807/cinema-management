using PBL3_GiaBao.DTO;
using PBL3_GiaBao.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3_GiaBao.DAL
{
    class DAL_PhimView
    {
        private static QLRP7Entities db = new QLRP7Entities();

        // Design Pattern
        #region Design Pattern
        private static DAL_PhimView _Instance;
        public static DAL_PhimView Instance
        {
            get
            {
                if (_Instance == null) _Instance = new DAL_PhimView();
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
        private DAL_PhimView()
        {

        }
        #endregion
        public List<PhimView> getAllPhimView()
        {
            List<PhimView> phimViews = new List<PhimView>();

            var data = db.Phims.Where(p => p.idTheLoai == p.TheLoai.id)
                                         .Select(p => new PhimView
                                         {
                                             id = p.id,
                                             TenPhim = p.TenPhim,
                                             MoTa = p.MoTa,
                                             ThoiLuong = p.ThoiLuong,
                                             NgayKhoiChieu = p.NgayKhoiChieu,
                                             NgayKetThuc = p.NgayKetThuc,
                                             SanXuat = p.SanXuat,
                                             DaoDien = p.DaoDien,
                                             NamSX = p.NamSX,
                                             TenTheLoai = p.TheLoai.TenTheLoai
                                         });
            return data.ToList();
        }
    }
}

