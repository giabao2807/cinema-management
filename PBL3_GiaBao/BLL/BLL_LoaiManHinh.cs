using PBL3_GiaBao.DAL;
using PBL3_GiaBao.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3_GiaBao.BLL
{
    class BLL_LoaiManHinh
    {
        // Design Pattern
        #region Design Pattern
        private static BLL_LoaiManHinh _Instance = null;
        public static BLL_LoaiManHinh Instance
        {
            get
            {
                if (_Instance == null) _Instance = new BLL_LoaiManHinh();
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
        private BLL_LoaiManHinh()
        {

        }
        #endregion

        // Lấy dữ liệu
        #region Get Data
        public List<LoaiManHinh> getAllLoaiManHinhByBLL()
        {
            return DAL_LoaiManHinh.Instance.getAllLoaiManHinh();
        }
        public LoaiManHinh GetLoaiManHinhByTenMH(string tenMH)
        {
            return DAL_LoaiManHinh.Instance.getLoaiManHinhByTenMH(tenMH);
        }
        public LoaiManHinh GetLoaiManHinhByIdMH(string IdMH)
        {
            return DAL_LoaiManHinh.Instance.getLoaiManHinhByIdMH(IdMH);
        }
        public string getIdLMH(string s)
        {
            return DAL_LoaiManHinh.Instance.getIdLMH(s);
        }
        #endregion
    }
}
