using PBL3_GiaBao.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3_GiaBao.DAL
{
    class DAL_Ve
    {
        private static QLRP8Entities db = new QLRP8Entities();

        // Design Pattern
        #region Design Pattern
        private static DAL_Ve _Instance = null;
        public static DAL_Ve Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new DAL_Ve();
                }
                return _Instance;
            }
            private set { _Instance = value; }
        }
        #endregion

        // Constructor 
        #region Constructor 
        public DAL_Ve()
        {
            
        }
        #endregion

        // Hàm lấy dữ liệu
        #region Get Data
        public List<Ve> GetListTicketsBoughtByShowTimes_DAL(string showTimesID)
        {
            var l = db.Ve.Where(p => p.idLichChieu == showTimesID && p.TrangThai == 1);
            return l.ToList();
        }
        public List<Ve> GetListTicketsByShowTimes_DAL(string showTimesID)
        {
            var l = db.Ve.Where(p => p.idLichChieu == showTimesID);
            return l.ToList();
        }
        #endregion

        // Mua vé, Đếm vé
        #region BuyTicket, CountTicket
        public bool BuyTicket_DAL(int ticketID, float TienBanVe)
        {
            db.Ve.Find(ticketID).TrangThai = 1;
            db.Ve.Find(ticketID).TienBanVe = TienBanVe;
            return db.SaveChanges() > 0;
        }
        public int CountTheNumberOfTicketsSoldByShowTime_DAL(string showTimesID)
        {
            int count = 0;
            var l = db.Ve.Where(p => p.idLichChieu == showTimesID && p.TrangThai == 1);
            count = l.ToList().Count;
            return count;
        }
        public string CountToltalTicketByShowTime_DAL(string showTimesID)
        {
            var l = db.Ve.Where(p => p.idLichChieu == showTimesID);
            return l.ToList().Count.ToString();
        }
        #endregion

        // Thêm , xóa
        #region Add, Delete
        public bool InsertTicketByShowTimes_DAL(string showTimesID, string seatName)
        {
            Ve obj = new Ve();
            obj.idLichChieu = showTimesID;
            obj.MaGheNgoi = seatName;
            db.Ve.Add(obj);
            return db.SaveChanges() > 0;
            
        }
        public bool DeleteTicketsByShowTimes_DAL(string showTimesID)
        {
            var l = db.Ve.Where(p => p.idLichChieu == showTimesID);
            db.Ve.RemoveRange(l);
            return  db.SaveChanges() >0;
        }

        public bool IsExitLichChieu(string maLichChieu)
        {
            var data = db.Ve.Where(ve => ve.idLichChieu == maLichChieu && ve.TrangThai == 1);
            return data.Count() > 1;
        }
        #endregion
    }
}
