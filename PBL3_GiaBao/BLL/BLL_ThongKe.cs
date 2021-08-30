using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL3_GiaBao.EF;
using PBL3_GiaBao.DAL;
using PBL3_GiaBao.BLL;
using PBL3_GiaBao.DTO;

namespace PBL3_GiaBao.BLL
{
    class BLL_ThongKe
    {
        private static BLL_ThongKe _Instance = null;
        public delegate bool Mydel(object a, object b);
        public static BLL_ThongKe Instance
        {
            get
            {
                if (_Instance == null) _Instance = new BLL_ThongKe();
                return _Instance;
            }
            private set
            {
                _Instance = value;
            }
        }
        private BLL_ThongKe()
        {

        }
        public List<ThongKeView> GetRevenue(string movieId, DateTime fromDate, DateTime toDate)
        {
            return DAL_ThongKe.Instance.GetRevenue(movieId, fromDate, toDate);
        }
        public List<ThongKeView> sort(List<ThongKeView> ltkv, int k)
        {
            switch (k)
            {
                case 0:
                    {
                        selectedSort(ltkv, ThongKeView.CompareNgayChieu);
                    }
                    break;
                case 1:
                    {
                        selectedSort(ltkv, ThongKeView.CompareSoVeBan);
                    }
                    break;
                case 2:
                    {
                        selectedSort(ltkv, ThongKeView.CompareTienBanVe);
                    }
                    break;
            }
            return ltkv;
        }
        public void selectedSort(List<ThongKeView> ltkv, Mydel d)
        {
            for (int i = 0; i < ltkv.Count - 1; i++)
            {
                for (int j = i + 1; j < ltkv.Count; j++)
                {
                    if (d(ltkv[i], ltkv[j]))
                    {
                        ThongKeView tmp = ltkv[i];
                        ltkv[i] = ltkv[j];
                        ltkv[j] = tmp;
                    }
                }
            }
        }
    }
}
