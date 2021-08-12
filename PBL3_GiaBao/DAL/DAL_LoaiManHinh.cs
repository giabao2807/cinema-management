using PBL3_GiaBao.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3_GiaBao.DAL
{
    class DAL_LoaiManHinh
    {
        private static QLRP7Entities db = new QLRP7Entities();

        // Design Pattern
        #region Design Pattern
        private static DAL_LoaiManHinh _Instance;

        public static DAL_LoaiManHinh Instance
        {
            get
            {
                if (_Instance == null) _Instance = new DAL_LoaiManHinh();
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
        private DAL_LoaiManHinh()
        {

        }
        #endregion

        // Function
        #region Function
        public List<LoaiManHinh> getAllLoaiManHinh()
        {
            return db.LoaiManHinhs.Select(lmh => lmh).ToList();
        }
        public LoaiManHinh getLoaiManHinhByTenMH(string tenMH)
        {
            LoaiManHinh loaiManHinh = null;
            var data = db.LoaiManHinhs.Where(lmh => lmh.TenMH.Equals(tenMH));
            if (data.Count() > 0) loaiManHinh = data.FirstOrDefault();
            return loaiManHinh;
        }
        public LoaiManHinh getLoaiManHinhByIdMH(string idMH)
        {
            LoaiManHinh data = db.LoaiManHinhs.Find(idMH); //Find yêu cầu thuộc tính khóa chính, return về null nếu không có record tương ứng với id đưa vào
            return data;
        }
        public string getIdLMH(string s)
        {
            //LoaiManHinh data = db.LoaiManHinh.Where(p => p.TenMH.CompareTo(s) == 0).FirstOrDefault();
            //return data.id;
            foreach (LoaiManHinh lmh in db.LoaiManHinhs)
            {
                if (lmh.TenMH.CompareTo(s.Trim()) == 0)
                {
                    return lmh.id;
                }
            }
            return null;
        }


        #endregion
    }
}
