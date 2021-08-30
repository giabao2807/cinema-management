using PBL3_GiaBao.DAL;
using PBL3_GiaBao.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3_GiaBao.BLL
{
    class BLL_Phim
    {
        // Design Pattern
        #region Design Pattern
        private static BLL_Phim _Instance = null;
        public static BLL_Phim Instance
        {
            get
            {
                if (_Instance == null) _Instance = new BLL_Phim();
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
        private BLL_Phim()
        {

        }
        #endregion

        // Lấy dữ liệu
        #region Get Data
        public List<Phim> getAllPhimByBLL()
        {
            return DAL_Phim.Instance.getAllPhim();
        }
        public Phim getPhimByIdPhim(string idPhim)
        {
            return DAL_Phim.Instance.getPhimByIdPhim(idPhim);
        }
        public Phim getPhimByTenPhim(string tenPhim)
        {
            return DAL_Phim.Instance.getPhimByTenPhim(tenPhim);
        }
        public List<Phim> GetListMovieByDate(DateTime date)
        {
            return DAL_Phim.Instance.GetListMovieByDate_DAL(date);
        }
        public List<Phim> getPhimbyidTheLoai(string idTheLoai)
        {
            return DAL.DAL_Phim.Instance.getPhimbyidTheLoai(idTheLoai);
        }
        public List<Phim> getListPhimByListDDP(List<DinhDangPhim> ddp)
        {
            return DAL.DAL_Phim.Instance.getPhimByListDDP(ddp);
        }
        #endregion
        // check
        #region Check
        public bool isExistPhim(Phim p)
        {
            return getAllPhimByBLL().Exists(phim => (phim.id.Trim().CompareTo(p.id) == 0));
        }
        public bool themPhim(Phim p)
        {
            return DAL.DAL_Phim.Instance.themPhim(p);
        }

        public bool suaphim(Phim p)
        {
            return DAL.DAL_Phim.Instance.suaphim(p);
        }
        public bool xoaphim(List<string> maphims)
        {
            return DAL.DAL_Phim.Instance.xoaphim(maphims);
        }
        #endregion
    }
}
