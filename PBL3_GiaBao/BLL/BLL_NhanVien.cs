using PBL3_GiaBao.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3_GiaBao.BLL
{
    class BLL_NhanVien
    {
        // Design Pattern
        #region Design Pattern
        private static BLL_NhanVien _Instance;
        public static BLL_NhanVien Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BLL_NhanVien();
                }
                return _Instance;
            }
            private set
            {

            }
        }
        #endregion

        // Constructor
        #region Constructor
        private BLL_NhanVien()
        {

        }
        #endregion

        //Hàm lấy dữ liệu
        #region Get Data
        public List<NhanVien> GetAllNV_BLL()
        {
            return DAL.DAL_NhanVien.Instance.GetAllNV();
        }
        public NhanVien GetNVByIDNV(string idnv)
        {
            return GetAllNV_BLL().Where(p => p.id.Equals(idnv)).FirstOrDefault();
        }
        #endregion

        // Thêm, sửa, xóa ...
        #region Add, Edit, Delete
        public void AddNhanVien_BLL(NhanVien nv)
        {
            DAL.DAL_NhanVien.Instance.AddNhanVien(nv);
        }
        public void EditNhanVien_BLL(NhanVien nv)
        {
            DAL.DAL_NhanVien.Instance.EditNhanVien(nv);
        }
        public void DeleteNV_BLL(string manv)
        {
            DAL.DAL_NhanVien.Instance.DeleteNV(manv);
        }
        public bool isExitsNV(NhanVien nv)
        {
            return GetAllNV_BLL().Exists(p => p.id.Equals(nv.id));
        }
        #endregion
    }
}
