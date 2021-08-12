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
        private static QLRP7Entities db = new QLRP7Entities();

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
            var l = db.Ves.Where(p => p.idLichChieu == showTimesID && p.TrangThai == 1);
            return l.ToList();
        }
        public List<Ve> GetListTicketsByShowTimes_DAL(string showTimesID)
        {
            var l = db.Ves.Where(p => p.idLichChieu == showTimesID);
            return l.ToList();
        }
        #endregion

        // Mua vé, Đếm vé
        #region BuyTicket, CountTicket
        public int BuyTicket_DAL(int ticketID, float TienBanVe)
        {
            db.Ves.Find(ticketID).TrangThai = 1;
            // more
            db.Ves.Find(ticketID).TienBanVe = TienBanVe;
            db.SaveChanges();
            return 1;
        }
        public int CountTheNumberOfTicketsSoldByShowTime_DAL(string showTimesID)
        {
            int count = 0;
            var l = db.Ves.Where(p => p.idLichChieu == showTimesID && p.TrangThai == 0);
            count = l.ToList().Count;
            return count;
        }
        public int CountToltalTicketByShowTime_DAL(string showTimesID)
        {
            var l = db.Ves.Where(p => p.idLichChieu == showTimesID);
            return l.ToList().Count;
        }
        #endregion

        // Thêm , xóa
        #region Add, Delete
        public int InsertTicketByShowTimes_DAL(string showTimesID, string seatName)
        {
            Ve obj = new Ve();
            obj.idLichChieu = showTimesID;
            obj.MaGheNgoi = seatName;
            db.Ves.Add(obj);
            db.SaveChanges();
            return 1;
        }
        public int DeleteTicketsByShowTimes_DAL(string showTimesID)
        {
            var l = db.Ves.Where(p => p.idLichChieu == showTimesID);
            db.Ves.RemoveRange(l);
            db.SaveChanges();
            LichChieu lichChieu = DAL_LichChieu.Instance.GetLichChieuByIdLichChieu(showTimesID);
            DinhDangPhim dinhDangPhim = DAL_DinhDangPhim.Instance.GetDinhDangPhimByMaDinhDang(lichChieu.idDinhDang);
            PhongChieu phongChieu = DAL_PhongChieu.Instance.GetPhongChieuByMaPhong(dinhDangPhim.idPhongChieu);
            int result = phongChieu.SoChoNgoi;
            return result;
        }

        public bool IsExitLichChieu(string maLichChieu)
        {
            var data = db.Ves.Where(ve => ve.idLichChieu == maLichChieu && ve.TrangThai == 1);
            return data.Count() > 1;
        }
        #endregion
    }
}
