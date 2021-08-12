using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3_GiaBao.DTO
{
    class LichChieuView
    {
        public string TenPhong { get; set; }
        public string id { get; set; }
        public string TenPhim { get; set; }
        public DateTime ThoiGianChieu { get; set; }
        public int TrangThai { get; set; }

        public LichChieuView()
        {

        }
    }
}
