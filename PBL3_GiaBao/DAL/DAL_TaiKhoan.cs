using PBL3_GiaBao.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3_GiaBao.DAL
{
    class DAL_TaiKhoan
    {
        private static QLRP8Entities db = new QLRP8Entities();

        // Design Pattern
        #region Design Pattern
        private static DAL_TaiKhoan _Instance;
        public static DAL_TaiKhoan Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new DAL_TaiKhoan();
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
        private DAL_TaiKhoan()
        {

        }
        #endregion

        // Login, Change Password
        #region Login, Change Password
        public int Login(string username, string password)
        {
            if (db.TaiKhoan.ToList().Exists(p => p.UserName.Equals(username) && p.Pass.Equals(password)))
            {
                return 1;
            }
            return 0;
        }
        public void DoiMK(TaiKhoan tk)
        {

                var tmp = db.TaiKhoan.Find(tk.idTK);
                tmp.Pass = tk.Pass;
                db.SaveChanges();

        }
        #endregion


        //Hàm lấy dữ liệu
        #region Get Data
        public TaiKhoan GetTaiKhoanByUsername(string username)
        {
            return db.TaiKhoan.Where(p => p.UserName.Equals(username)).FirstOrDefault();
        }
        public List<TaiKhoan> GetTKByIDNV(string idnv)
        {
            return db.TaiKhoan.Where(tk => tk.idNV.Equals(idnv)).ToList();
        }
        public TaiKhoan GetTaiKhoanByIDTK(string idtk)
        {
            return db.TaiKhoan.Where(tk => tk.idTK.Equals(idtk)).FirstOrDefault();
        }
        public TaiKhoan GetTaiKhoanByUserPass(string user, string pass)
        {
            return db.TaiKhoan.Where(p => p.UserName.Equals(user) && p.Pass.Equals(pass)).FirstOrDefault();
        }
        #endregion

        // Thêm , xóa, surwa
        #region Add, Delete
        public void AddTKhoan(TaiKhoan tk)
        {
                db.TaiKhoan.Add(tk);
                db.SaveChanges();
        }
        public void EditTK(TaiKhoan tk)
        {
            var tmp = db.TaiKhoan.Find(tk.idTK);
            tmp.UserName = tk.UserName;
            tmp.LoaiTK = tk.LoaiTK;
            db.SaveChanges();
        }
        public void DeleteTK(string idtk)
        {

                TaiKhoan tmp = db.TaiKhoan.Where(p => p.idTK.Equals(idtk)).FirstOrDefault();
                db.TaiKhoan.Remove(tmp);
                db.SaveChanges();
        }
        #endregion
        
        // Hàm kiểm tra
        #region Check
        public bool isExitTK(string user, string pass)
        {
            return db.TaiKhoan.ToList().Exists(p => p.UserName.Equals(user) && p.Pass.Equals(pass));
        }
        public bool isExitTK(string idtk)
        {
            return db.TaiKhoan.ToList().Exists(p => p.idTK.Equals(idtk));
        }
        #endregion
    }
}
