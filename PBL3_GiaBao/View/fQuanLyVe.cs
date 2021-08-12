using PBL3_GiaBao.BLL;
using PBL3_GiaBao.EF;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3_GiaBao.View
{
    public partial class fQuanLyVe : Form
    {
        public fQuanLyVe()
        {
            InitializeComponent();
            LoadAllListShowTimes();

        }

        void LoadAllListShowTimes()
        {
            dtgrLichChieu.DataSource = "";
            List<LichChieu> allListShowTime = BLL_LichChieu.Instance.getAllLichChieu(); LichChieu l = new LichChieu();
            dtgrLichChieu.DataSource = allListShowTime;
            this.dtgrLichChieu.Columns["DinhDangPhim"].Visible = false;
            //this.dtgrLichChieu.Columns["PhongChieu"].Visible = false;
            this.dtgrLichChieu.Columns["Ves"].Visible = false;
        }

        void LoadTicketsByShowTimes(string showTimesID)
        {
            List<Ve> listTicket = BLL_Ve.Instance.GetListTicketsByShowTimes(showTimesID);
            dtgvVe.DataSource = listTicket;
            this.dtgvVe.Columns["LichChieu"].Visible = false;
        }

        private void btnAddVe_Click(object sender, EventArgs e)
        {
            if (dtgrLichChieu.SelectedRows.Count > 0)
            {
                LichChieu showTimes = BLL_LichChieu.Instance.GetLichChieuByIdLichChieu(dtgrLichChieu.SelectedRows[0].Cells["id"].Value.ToString());
                if (showTimes.TrangThai == 1)
                {
                    MessageBox.Show("LỊCH CHIẾU NÀY ĐÃ ĐƯỢC TẠO VÉ!!!", "THÔNG BÁO");
                    return;
                }
                AutoCreateTicketsByShowTimes(showTimes);
                LoadAllListShowTimes();
                LoadTicketsByShowTimes(showTimes.id);
            }
            else
            {
                MessageBox.Show("BẠN CHƯA CHỌN LỊCH CHIẾU ĐỂ TẠO!!!", "THÔNG BÁO");
            }
        }

        void AutoCreateTicketsByShowTimes(LichChieu showTimes)
        {
            int result = 0;
            DinhDangPhim dinhDangPhim = BLL_DinhDangPhim.Instance.GetDinhDangPhimByMaDinhDang(showTimes.idDinhDang);
            PhongChieu cinema = BLL_PhongChieu.Instance.GetPhongChieuByMaPhong(dinhDangPhim.idPhongChieu);
            int Row = cinema.SoHangGhe;
            int Column = cinema.SoGheMotHang;
            for (int i = 0; i < Row; i++)
            {
                int temp = i + 65;
                char nameRow = (char)(temp);
                for (int j = 1; j <= Column; j++)
                {
                    string seatName = nameRow.ToString() + j;
                    result += BLL_Ve.Instance.InsertTicketByShowTimes(showTimes.id, seatName);
                }
            }
            if (result == Row * Column)
            {
                int ret = BLL_LichChieu.Instance.UpdateStatusShowTimes(showTimes.id, 1);
                if (ret > 0)
                    MessageBox.Show("TẠO VÉ TỰ ĐỘNG THÀNH CÔNG!", "THÔNG BÁO");
            }
            else
                MessageBox.Show("TẠO VÉ TỰ ĐỘNG THẤT BẠI!", "THÔNG BÁO");
        }

        private void btnRemoveVe_Click(object sender, EventArgs e)
        {
            if (dtgrLichChieu.SelectedRows.Count > 0)
            {
                LichChieu showTimes = BLL_LichChieu.Instance.GetLichChieuByIdLichChieu(dtgrLichChieu.SelectedRows[0].Cells["id"].Value.ToString());
                if (showTimes.TrangThai == 0)
                {
                    MessageBox.Show("LỊCH CHIẾU NÀY CHƯA ĐƯỢC TẠO VÉ!!!", "THÔNG BÁO");
                    return;
                }
                DeleteTicketsByShowTimes(showTimes);
                LoadAllListShowTimes();
                LoadTicketsByShowTimes(showTimes.id);
            }
            else
            {
                MessageBox.Show("BẠN CHƯA CHỌN LỊCH CHIẾU ĐỂ XÓA!!!", "THÔNG BÁO");
            }
        }

        private void DeleteTicketsByShowTimes(LichChieu showTimes)
        {
            DinhDangPhim dinhDangPhim = BLL_DinhDangPhim.Instance.GetDinhDangPhimByMaDinhDang(showTimes.idDinhDang);
            PhongChieu cinema = BLL_PhongChieu.Instance.GetPhongChieuByMaPhong(dinhDangPhim.idPhongChieu);
            int Row = cinema.SoHangGhe;
            int Column = cinema.SoGheMotHang;
            int result = BLL_Ve.Instance.DeleteTicketsByShowTimes(showTimes.id);
            if (result == Row * Column)
            {
                int ret = BLL_LichChieu.Instance.UpdateStatusShowTimes(showTimes.id, 0);
                if (ret > 0)
                    MessageBox.Show("XÓA TẤT CẢ CÁC VÉ CỦA LỊCH CHIẾU ID=" + showTimes.id + " THÀNH CÔNG!", "THÔNG BÁO");
            }
            else
                MessageBox.Show("XÓA TẤT CẢ CÁC VÉ CỦA LỊCH CHIẾU ID=" + showTimes.id + " THẤT BẠI!", "THÔNG BÁO");
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            LoadAllListShowTimes();
        }

        private void btnShowLichChieuChuatao_Click(object sender, EventArgs e)
        {
            LoadListShowTimesNotCreateTickets();
        }

        private void LoadListShowTimesNotCreateTickets()
        {
            dtgrLichChieu.DataSource = "";
            List<LichChieu> allListShowTime = BLL_LichChieu.Instance.GetListShowTimesNotCreateTickets();
            dtgrLichChieu.DataSource = allListShowTime;
            this.dtgrLichChieu.Columns["DinhDangPhim"].Visible = false;
            //this.dtgrLichChieu.Columns["PhongChieu"].Visible = false;
            this.dtgrLichChieu.Columns["Ves"].Visible = false;
        }

        private void btnShowTicketBought_Click(object sender, EventArgs e)
        {
            if (dtgrLichChieu.SelectedRows.Count > 0)
            {
                LichChieu showTimes = BLL_LichChieu.Instance.GetLichChieuByIdLichChieu(dtgrLichChieu.SelectedRows[0].Cells["id"].Value.ToString());
                LoadTicketsBoughtByShowTimes(showTimes.id);
            }
            else
            {
                MessageBox.Show("BẠN CHƯA CHỌN LỊCH CHIẾU ĐỂ XEM!!!", "THÔNG BÁO");
            }
        }

        void LoadTicketsBoughtByShowTimes(string showTimesID)
        {
            List<Ve> listTicket = BLL_Ve.Instance.GetListTicketsBoughtByShowTimes(showTimesID);
            dtgvVe.DataSource = listTicket;
            this.dtgvVe.Columns["LichChieu"].Visible = false;
        }

        private void btnShowAllTicketByLichChieu_Click(object sender, EventArgs e)
        {
            if (dtgrLichChieu.SelectedRows.Count > 0)
            {
                LichChieu showTimes = BLL_LichChieu.Instance.GetLichChieuByIdLichChieu(dtgrLichChieu.SelectedRows[0].Cells["id"].Value.ToString());
                LoadTicketsByShowTimes(showTimes.id);
            }
            else
            {
                MessageBox.Show("BẠN CHƯA CHỌN LỊCH CHIẾU ĐỂ XEM!!!", "THÔNG BÁO");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
