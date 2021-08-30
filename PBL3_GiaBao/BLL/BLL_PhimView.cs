using PBL3_GiaBao.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3_GiaBao.BLL
{
    class BLL_PhimView
    {
        // Design Pattern
        #region Design Pattern
        private static BLL_PhimView _Instance = null;
        public static BLL_PhimView Instance
        {
            get
            {
                if (_Instance == null) _Instance = new BLL_PhimView();
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
        private BLL_PhimView()
        {

        }
        #endregion
        public List<PhimView> getAllPhimViewbyBLL()
        {
            return DAL.DAL_PhimView.Instance.getAllPhimView();
        }
    }
}