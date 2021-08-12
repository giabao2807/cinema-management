using PBL3_GiaBao.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3_GiaBao.DAL
{
    class DAL_NhanVien
    {
        private static QLRP7Entities db = new QLRP7Entities();

        // Design Pattern
        #region Design Pattern
        private static DAL_NhanVien _Instance;      
        public static DAL_NhanVien Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new DAL_NhanVien();
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
        private DAL_NhanVien()
        {

        }
        #endregion

        //Hàm lấy dữ liệu
        #region Get Data
        public List<NhanVien> GetAllNV()
        {
            return db.NhanViens.Select(nv => nv).ToList(); ;
        }
        public TaiKhoan GetTaiKhoanByUsername(string username)
        {
            return db.TaiKhoans.Where(p => p.UserName.Equals(username)).FirstOrDefault();
        }
        #endregion

        // Thêm, sửa , xóa
        #region Add, Edit, Delete
        public void AddNhanVien(NhanVien nv)
        {
            db.NhanViens.Add(nv);
            db.SaveChanges();
        }
        public void EditNhanVien(NhanVien nv)
        {
            var tmp = db.NhanViens.Find(nv.id);
            tmp.HoTen = nv.HoTen;
            tmp.NgaySinh = nv.NgaySinh;
            tmp.SDT = nv.SDT;
            tmp.DiaChi = nv.DiaChi;
            tmp.CMND = nv.CMND;
            db.SaveChanges();
        }
        public void DeleteNV(string manv)
        {
            NhanVien nv = db.NhanViens.Where(p => p.id.Equals(manv)).FirstOrDefault();
            db.NhanViens.Remove(nv);
            db.SaveChanges();
        }
        #endregion
    }
}
