using PBL3_GiaBao.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3_GiaBao.DAL
{
    class DAL_TheLoai
    {
        private static QLRP7Entities db = new QLRP7Entities();

        // Design Pattern
        #region Design Pattern
        private static DAL_TheLoai _Instance;
        public static DAL_TheLoai Instance
        {
            get
            {
                if (_Instance == null) _Instance = new DAL_TheLoai();
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
        private DAL_TheLoai()
        {

        }
        #endregion

        // Function
        #region Function
        public List<TheLoai> getAllTheLoai()
        {
            return db.TheLoais.Select(theloai => theloai).ToList();
        }
        #endregion
        //check
        #region check
        public bool themTheLoai(TheLoai tl)
        {
            db.TheLoais.Add(tl);
            return db.SaveChanges() > 0;
        }
        #endregion
        public bool xoaTheLoai(List<string> maLoaiPhims)
        {
            foreach (string x in maLoaiPhims)
            {         
                if(DAL.DAL_Phim.Instance.getPhimbyidTheLoai(x).Count > 0)
                {
                    List<string> maphims = DAL.DAL_Phim.Instance.getPhimbyidTheLoai(x).Select(p => p.id).ToList();
                    DAL.DAL_Phim.Instance.xoaphim(maphims);
                }
                var l = db.TheLoais.Where(tl => tl.id.Equals(x)).FirstOrDefault();
                db.TheLoais.Remove(l);
            }
            return db.SaveChanges() > 0;
        }
    }
}
