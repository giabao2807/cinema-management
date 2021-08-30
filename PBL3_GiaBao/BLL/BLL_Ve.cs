using PBL3_GiaBao.DAL;
using PBL3_GiaBao.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3_GiaBao.BLL
{
    class BLL_Ve
    {
        // Design Pattern
        #region Design Pattern
        private static BLL_Ve _Instance = null;
        public static BLL_Ve Instance
        {
            get
            {
                if (_Instance == null) _Instance = new BLL_Ve();
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
        private BLL_Ve()
        {

        }
        #endregion

        // Hàm lấy dữ liệu
        #region Get Data
        public List<Ve> GetListTicketsBoughtByShowTimes(string showTimesID)
        {
            return DAL_Ve.Instance.GetListTicketsBoughtByShowTimes_DAL(showTimesID);
        }
        public List<Ve> GetListTicketsByShowTimes(string showTimesID)
        {
            return DAL_Ve.Instance.GetListTicketsByShowTimes_DAL(showTimesID);
        }
        #endregion

        // Mua vé, Đếm vé
        #region BuyTicket, CountTicket
        public bool BuyTicket(int ticketID, float TienBanVe)
        {
            return DAL_Ve.Instance.BuyTicket_DAL(ticketID,TienBanVe);
        }
        public int CountTheNumberOfTicketsSoldByShowTime(string showTimesID)
        {
            return DAL_Ve.Instance.CountTheNumberOfTicketsSoldByShowTime_DAL(showTimesID);
        }
        public string CountToltalTicketByShowTime(string showTimesID)
        {
            return DAL_Ve.Instance.CountToltalTicketByShowTime_DAL(showTimesID);
        }
        #endregion

        // Thêm , xóa
        #region Add, Delete
        public bool InsertTicketByShowTimes(string showTimesID, string seatName)
        {
            return DAL_Ve.Instance.InsertTicketByShowTimes_DAL(showTimesID, seatName); 
        }
        public bool DeleteTicketsByShowTimes(string showTimesID)
        {
            return DAL_Ve.Instance.DeleteTicketsByShowTimes_DAL(showTimesID);
        }
        #endregion

        public bool IsExitLichChieu(string maLichChieu)
        {
            return DAL_Ve.Instance.IsExitLichChieu(maLichChieu);
        }

    }
}
