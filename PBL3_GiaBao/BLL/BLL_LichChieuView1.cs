using PBL3_GiaBao.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PBL3_GiaBao.BLL
{
    class BLL_LichChieuView1
    {
        #region Design Pattern
        private static BLL_LichChieuView1 _Instance = null;
        public static BLL_LichChieuView1 Instance
        {
            get
            {
                if (_Instance == null) _Instance = new BLL_LichChieuView1();
                return _Instance;
            }
            private set
            {
                _Instance = value;
            }
        }
        #endregion
        #region Constructor
        private BLL_LichChieuView1()
        {

        }
        #endregion
        #region Function
        public List<LichChieuView1> getAllLichChieuViewNoExpriedByBLL()
        {
            return DAL.DAL_LichChieuView1.Instance.GetLichChieuViewNoExpried();
        }
        #endregion
    }
}
