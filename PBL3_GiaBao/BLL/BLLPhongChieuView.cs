using PBL3_GiaBao.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3_GiaBao.BLL
{
    class BLLPhongChieuView
    {
        #region Design Pattern
        private static BLLPhongChieuView _Instance = null;
        public static BLLPhongChieuView Instance
        {
            get
            {
                if (_Instance == null) _Instance = new BLLPhongChieuView();
                return _Instance;
            }
            private set
            {
                _Instance = value;
            }
        }
        #endregion
        #region Constructor
        private BLLPhongChieuView()
        {

        }
        #endregion
        #region Function
        public List<PhongChieuView> getAllPhongChieuViewByBLL()
        {
            return DAL.DAL_PhongChieuView.Instance.GetAllPhongChieuViews();
        }
        #endregion
    }
}
