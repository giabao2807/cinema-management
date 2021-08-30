using PBL3_GiaBao.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PBL3_GiaBao.BLL
{
    class BLL_TaiKhoan
    {
        // Design Pattern
        #region Design Pattern
        private static BLL_TaiKhoan _Instance;
        public static BLL_TaiKhoan Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BLL_TaiKhoan();
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
        private BLL_TaiKhoan()
        {

        }
        #endregion

        // Hàm lấy dữ liệu
        #region Get Data
        public TaiKhoan GetTaiKhoanByUserName(string username)
        {
            return DAL.DAL_TaiKhoan.Instance.GetTaiKhoanByUsername(username);
        }
        public List<TaiKhoan> GetTKByIDNV_BLL(string idnv)
        {
            return DAL.DAL_TaiKhoan.Instance.GetTKByIDNV(idnv);
        }
        public TaiKhoan GetTaiKhoanByIDTK_BLL(string idtk)
        {
            return DAL.DAL_TaiKhoan.Instance.GetTaiKhoanByIDTK(idtk);
        }
        public TaiKhoan GetTaiKhoanByUserPass_BLL(string user, string pass)
        {
            return DAL.DAL_TaiKhoan.Instance.GetTaiKhoanByUserPass(user, pass);
        }
        #endregion
        
        // Login
        #region Login
        public int Login(string username, string password)
        {
            return DAL.DAL_TaiKhoan.Instance.Login(username, password);
        }
        #endregion
        //Mã hóa mật khẩu
        #region Mã hóa 
        public string PasswordEncryption(string password)
        {
            //tính năng bảo mật cho việc đăng nhập
            byte[] temp = ASCIIEncoding.ASCII.GetBytes(password);//chuyển qua mảng kiểu byte từ một chuỗi
            byte[] hasData = new MD5CryptoServiceProvider().ComputeHash(temp);
            //tạo ra bảng has(bảng băm) chứa các mảng byte
            //từ mật khẩu được mã hóa thành mảng băm

            string hasPass = "";

            foreach (byte item in hasData)
            {
                hasPass += item;
            }

            //tính năng mã hóa nâng cao bằng việc đảo ngược mật khẩu
            char[] arr = hasPass.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }
        #endregion

        //Hàm kiểm tra
        #region Check
        public bool isExitsTK_BLL(string user, string pass)
        {
            return DAL.DAL_TaiKhoan.Instance.isExitTK(user, pass);
        }
        public bool isExitsTK_BLL(string idtk)
        {
            return DAL.DAL_TaiKhoan.Instance.isExitTK(idtk);
        }
        #endregion

        // Thêm, sửa, xóa
        #region Add, Edit, Delete
        public void AddTKhoan_BLL(TaiKhoan tk)
        {
            DAL.DAL_TaiKhoan.Instance.AddTKhoan(tk);
        }
        public void DoiPass_BLL(TaiKhoan tk)
        {
            DAL.DAL_TaiKhoan.Instance.DoiMK(tk);
        }
        public void SuaThongTin_BLL(TaiKhoan tk)
        {
            DAL.DAL_TaiKhoan.Instance.EditTK(tk);
        }
        public void DeleteTK_BLL(string idtk)
        {
            DAL.DAL_TaiKhoan.Instance.DeleteTK(idtk);
        }
        #endregion
    }
}
