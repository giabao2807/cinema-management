using PBL3_GiaBao.DAL;
using PBL3_GiaBao.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3_GiaBao.BLL
{
    class BLL_DinhDangPhim
    {
        // Design Pattern
        #region Design Pattern
        private static BLL_DinhDangPhim _Instance = null;
        public static BLL_DinhDangPhim Instance
        {
            get
            {
                if (_Instance == null) _Instance = new BLL_DinhDangPhim();
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
        private BLL_DinhDangPhim()
        {

        }
        #endregion

        // Lấy dữ liệu
        #region Get Data
        public List<DinhDangPhim> GetAllDinhDangPhim()
        {
            return DAL_DinhDangPhim.Instance.getAllDinhDangPhim();
        }
        public DinhDangPhim GetDinhDangPhimByIdPhong(string maPhong)
        {
            return DAL_DinhDangPhim.Instance.GetDinhDangPhimByIdPhong(maPhong);
        }
        public List<DinhDangPhim> GetDinhDangPhimByMaPhong(string maPhong)
        {
            return DAL_DinhDangPhim.Instance.GetDinhDangPhimByMaPhong(maPhong);
        }
        public bool xoaDinhDangPhim(List<string> maPhims)
        {
            return DAL.DAL_DinhDangPhim.Instance.xoaDinhDangPhim(maPhims);
        }
        public List<DinhDangPhim> GetListFormatMovieByMovie(string movieID,DateTime date)
        {
            return DAL_DinhDangPhim.Instance.GetListFormatMovieByMovieAndDate_DAL(movieID,date);
        }
        public DinhDangPhim GetDinhDangPhimByMaDinhDang(string maDinhDang)
        {
            return DAL_DinhDangPhim.Instance.GetDinhDangPhimByMaDinhDang(maDinhDang);
        }
        public bool isExistDDP(DinhDangPhim ddp)
        {
            return GetAllDinhDangPhim().Exists(x => x.id.Equals(ddp.id));
        }
        public string getIDphongChieubyIdDinhDang(string idDinhDang)
        {
            return DAL.DAL_DinhDangPhim.Instance.getIDphongChieubyIdDinhDang(idDinhDang);
        }
        public List<String> getMaDinhDangbyMaPhim(string x)
        {
            return DAL.DAL_DinhDangPhim.Instance.getMaDinhDangbyMaPhim(x);
        }

        public DinhDangPhim GetDinhDangPhimByMaPhongAndMaPhim(string maPhong, string maPhim)
        {
            return DAL_DinhDangPhim.Instance.GetDinhDangPhimByMaPhongAndMaPhim(maPhong, maPhim);
        }

        public bool IsExitDinhDangPhimByMaDinhDang(string maDinhDang)
        {
            return DAL_DinhDangPhim.Instance.IsExitDinhDangPhimByMaDinhDang(maDinhDang);
        }
        public bool IsExitDinhDangPhimByMaPhimAndMaPhongChieu(string maPhim, string maPhongChieu)
        {
            return DAL_DinhDangPhim.Instance.IsExitDinhDangPhimByMaPhimAndMaPhongChieu(maPhim, maPhongChieu);
        }

        public bool addDinhDangPhim(string maDinhDang, string maPhongChieu, string maPhim)
        {
            return DAL_DinhDangPhim.Instance.addDinhDangPhim(maDinhDang, maPhongChieu, maPhim);
        }
        public bool updateDinhDangPhim(string maDinhDang, string maPhongChieu, string maPhim)
        {
            return DAL_DinhDangPhim.Instance.updateDinhDangPhim(maDinhDang, maPhongChieu, maPhim);
        }

        public bool deleteListDinhDangPhim(List<string> maDinhDangs)
        {
            return DAL_DinhDangPhim.Instance.deleteListDinhDangPhim(maDinhDangs);
        }
        #endregion
    }
}
