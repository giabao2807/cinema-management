using PBL3_GiaBao.DAL;
using PBL3_GiaBao.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3_GiaBao.BLL
{
    class BLL_PhongChieu
    {
        // Design Pattern
        #region Design Pattern
        private static BLL_PhongChieu _Instance = null;
        public static BLL_PhongChieu Instance
        {
            get
            {
                if (_Instance == null) _Instance = new BLL_PhongChieu();
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
        private BLL_PhongChieu()
        {

        }
        #endregion

        // Lấy dữ liệu
        #region Get Data
        public List<PhongChieu> getAllPhongChieuByBLL()
        {
            return DAL_PhongChieu.Instance.getAllPhongChieu();
        }
        public List<PhongChieu> GetPhongChieusByIdMH(string idMH)
        {
            return DAL_PhongChieu.Instance.GetPhongChieusByIdMH(idMH);
        }
        public PhongChieu GetPhongChieuByMaPhong(string maPhong)
        {
            return DAL_PhongChieu.Instance.GetPhongChieuByMaPhong(maPhong);
        }
        public PhongChieu GetCinemaByName(string cinemaName)
        {
            return DAL_PhongChieu.Instance.GetCinemaByName(cinemaName);
        }
        #endregion

        // Thêm, sửa, xóa
        #region Add, Update, Delete
        public bool addPhongChieu(string maPhong, string tenPhong, string idMH, int soChoNgoi, int tinhTrang, int soHangGhe, int soGheMoiHang)
        {
            return DAL_PhongChieu.Instance.addPhongChieu(maPhong, tenPhong, idMH, soChoNgoi, tinhTrang, soHangGhe, soGheMoiHang);
        }
        public bool updatePhongChieu(string maPhong, string tenPhong, string idMH, int soChoNgoi, int tinhTrang, int soHangGhe, int soGheMoiHang)
        {
            return DAL_PhongChieu.Instance.updatePhongChieu(maPhong, tenPhong, idMH, soChoNgoi, tinhTrang, soHangGhe, soGheMoiHang);
        }
        public bool deletePhongChieuByMaPhong(string maPhong)
        {
            return DAL_PhongChieu.Instance.deletePhongChieuByMaPhong(maPhong);
        }
        #endregion    

        public bool IsExitPhongChieuByMaPhong(string maPhong)
        {
            return DAL_PhongChieu.Instance.IsExitPhongChieuByMaPhong(maPhong);
        }

        public bool DeleteListPhongChieu(List<string> maPhongs)
        {
            return DAL_PhongChieu.Instance.deleteListPhongChieu(maPhongs);
        }
    }
}
