using PBL3_GiaBao.DAL;
using PBL3_GiaBao.EF;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL3_GiaBao.DTO;

namespace PBL3_GiaBao.BLL
{
    class BLL_LichChieu
    {
        // Design Pattern
        #region Design Pattern
        private static BLL_LichChieu _Instance = null;
        public static BLL_LichChieu Instance
        {
            get
            {
                if (_Instance == null) _Instance = new BLL_LichChieu();
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
        private BLL_LichChieu()
        {

        }
        #endregion

        // Lấy dữ liệu
        #region Get Data
        public List<LichChieu> getAllLichChieu()
        {
            return DAL_LichChieu.Instance.getAllLichChieu();
        }
        public LichChieu GetLichChieuByIdLichChieu(string idLichChieu)
        {
            return DAL_LichChieu.Instance.GetLichChieuByIdLichChieu(idLichChieu);
        }
        public List<LichChieu> GetListShowTimesNotCreateTickets()
        {
            return DAL_LichChieu.Instance.GetListShowTimesNotCreateTickets_DAL();
        }
        #endregion

        // Thêm, sửa , xóa
        #region Add, Update, Delete
        public bool addLichChieu(string maLichChieu, string maPhong, string maDinhDang, DateTime time)
        {
            return DAL_LichChieu.Instance.addLichChieu(maLichChieu, maDinhDang, time);
        }

        public int UpdateStatusShowTimes(string showTimesID, int status)
        {
            return DAL_LichChieu.Instance.UpdateStatusShowTimes_DAL(showTimesID, status);
        }
        public bool updateLichChieu(string maLichChieu, string maPhong, string maDinhDang, DateTime time)
        {
            return DAL_LichChieu.Instance.updateLichChieu(maLichChieu, maDinhDang, time);
        }
        public bool deleteLichChieu(string maLichChieu)
        {
            return DAL_LichChieu.Instance.deleteLichChieuByMaLichChieu(maLichChieu);
        }
        public bool isExistidDinhDang(string x)
        {
            return getAllidDinhDang().Exists(p => p.CompareTo(x) == 0);
        }
        public List<string> getAllidDinhDang()
        {
            return getAllLichChieu().Select(p => p.idDinhDang).ToList();
        }
        #endregion

        public bool isExitLichChieu(string maLichChieu)
        {
            return DAL_LichChieu.Instance.isExitLichChieu(maLichChieu);
        }

        public bool isExitDataLichChieu(string maDinhDang, DateTime time)
        {
            return DAL_LichChieu.Instance.isExitDataLichChieu(maDinhDang, time);
        } 
        public bool deleteListLichChieu(List<string> maLichChieus)
        {
            return DAL_LichChieu.Instance.deleteListLichChieu(maLichChieus);
        }
        public List<LichChieuView> LoadListShowTimeByFilm(string formatMovieID, DateTime date)
        {
            return DAL_LichChieu.Instance.LoadListShowTimeByFilm( formatMovieID , date);
        }
        public void CheckLichChieuExpired()
        {
            DAL_LichChieu.Instance.CheckLichChieuExpried();
        }
        public bool checkDataLichChieu(string maPhongChieu, string maPhim, DateTime time)
        {
            return DAL_LichChieu.Instance.checkDataLichChieu(maPhongChieu, maPhim, time);
        }
    }
}
