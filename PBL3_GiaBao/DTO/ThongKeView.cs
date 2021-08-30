using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3_GiaBao.DTO
{
    class ThongKeView
    {
        public string TenPhim { get; set; }
        public DateTime NgayChieu { get; set; }
        public string GioChieu { get; set; }
        public int SoVeDaBan { get; set; }
        public float TienBanVe { get; set; }

        public ThongKeView()
        {

        }
        public ThongKeView(string TenPhim, DateTime NgayChieu,string GioChieu,int SoVeDaBan, float TienBanVe)
        {
            this.TenPhim = TenPhim;
            this.NgayChieu = NgayChieu;
            this.GioChieu = GioChieu;
            this.SoVeDaBan = SoVeDaBan;
            this.TienBanVe = TienBanVe;
        }
        public static bool CompareSoVeBan(Object a, Object b)
        {
            return ((ThongKeView)a).SoVeDaBan < ((ThongKeView)b).SoVeDaBan;
        }
        public static bool CompareNgayChieu(Object a, Object b)
        {
            return (((ThongKeView)a).NgayChieu < ((ThongKeView)b).NgayChieu);
        }
        public static bool CompareTienBanVe(Object a, Object b)
        {
            return ((ThongKeView)a).TienBanVe < ((ThongKeView)b).TienBanVe;
        }
    }
}
