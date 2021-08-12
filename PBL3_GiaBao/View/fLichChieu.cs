using PBL3_GiaBao.BLL;
using PBL3_GiaBao.DTO;
using PBL3_GiaBao.EF;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3_GiaBao.View
{
    public partial class fLichChieu : Form
    {
        public fLichChieu()
        {
            InitializeComponent();
            checkLichChieuExpired(); // Xóa lịch chiếu hết hạn
            LoadShowtime(); // Load dữ liệu lên datagridview
            loadData(); // Load dữ liệu từ row đầu tiên datagridview lên các textfield tương ứng
        }

        #region LoadData
        void LoadShowtime()
        {
            List<LichChieuView1> lichChieuViews = BLL_LichChieuView1.Instance.getAllLichChieuViewByBLL();
            dtgvShowTime.DataSource = lichChieuViews.ToList();
        }
        void loadData()
        {
            if (dtgvShowTime.Rows.Count != 0)
            {
                string maPhong = null;
                txtShowtimeID.Text = dtgvShowTime.Rows[0].Cells["MaLichChieu"].Value.ToString().Trim();
                txtMovieName_Showtime.Text = dtgvShowTime.Rows[0].Cells["TenPhim"].Value.ToString().Trim();
                txtScreenTypeName_Showtime.Text = dtgvShowTime.Rows[0].Cells["ManHinh"].Value.ToString().Trim();
                maPhong = dtgvShowTime.Rows[0].Cells["MaPhong"].Value.ToString().Trim();
                txtCinemaRoom.Text = BLL_PhongChieu.Instance.GetPhongChieuByMaPhong(maPhong).TenPhong;
                dtmShowtimeDate.Text = dtgvShowTime.Rows[0].Cells["ThoiGianChieu"].Value.ToString().Trim();
                dtmShowtimeTime.Text = dtgvShowTime.Rows[0].Cells["ThoiGianChieu"].Value.ToString().Trim();
            }
        }
        #endregion

        #region Button
        private void btnAdd_Click(object sender, EventArgs e)
        {
            fFunctionLichChieu f = new fFunctionLichChieu(null);
            f.d += new fFunctionLichChieu.Show_del(LoadShowtime);
            f.ShowDialog();
        }
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (dtgvShowTime.SelectedRows.Count == 1)
            {
                string maLichChieu = txtShowtimeID.Text;
                fFunctionLichChieu f = new fFunctionLichChieu(maLichChieu);
                f.d += new fFunctionLichChieu.Show_del(LoadShowtime);
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("Hãy chọn một lịch chiếu", "Thông baó");
            }
        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            List<string> maLichChieus = new List<string>();
            DataGridViewSelectedRowCollection rows = dtgvShowTime.SelectedRows;
            if (rows.Count < 1)
            {
                MessageBox.Show("Vui lòng chọn tối thiểu 1 lịch chiếu để xóa", "Thông báo");
            }
            else
            {
                try
                {
                    for (int i = 0; i < rows.Count; i++)
                    {
                        string s = rows[i].Cells["MaLichChieu"].Value.ToString().Trim();
                        if (BLL_Ve.Instance.IsExitLichChieu(s))
                        {
                            MessageBox.Show("Lịch chiếu " + s + " đã có vé được bán, không thể xóa");
                        }
                        else
                        {
                            maLichChieus.Add(s);
                        }
                    }
                    if (BLL_LichChieu.Instance.deleteListLichChieu(maLichChieus))
                    {
                        MessageBox.Show("Xóa thành công", "Thông báo");
                        LoadShowtime();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Xóa thất bại", "Thông báo");
                }
            }
        }
        private void btnSearchShowtime_Click(object sender, EventArgs e)
        {
            string tenPhim = txtSearchShowtime.Text;
            var data = from LichChieu in BLL_LichChieu.Instance.getAllLichChieu()
                       from Phim in BLL_Phim.Instance.getAllPhimByBLL()
                       from DinhDangPhim in BLL_DinhDangPhim.Instance.GetAllDinhDangPhim()
                       from LoaiManHinh in BLL_LoaiManHinh.Instance.getAllLoaiManHinhByBLL()
                       from PhongChieu in BLL_PhongChieu.Instance.getAllPhongChieuByBLL()
                       where LichChieu.idDinhDang == DinhDangPhim.id
                       && Phim.id == DinhDangPhim.idPhim
                       && PhongChieu.id == DinhDangPhim.idPhongChieu
                       && LoaiManHinh.id == PhongChieu.idManHinh
                       && convertToUnSign3(Phim.TenPhim).Contains(convertToUnSign3(tenPhim))
                       select new
                       {
                           MaLichChieu = LichChieu.id,
                           MaPhong = PhongChieu.id,
                           TenPhim = Phim.TenPhim,
                           ManHinh = LoaiManHinh.TenMH,
                           ThoiGianChieu = LichChieu.ThoiGianChieu
                       };
            dtgvShowTime.DataSource = data.ToList();
        }
        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Function
        public static string convertToUnSign3(string s)
        {
            Regex regex = new Regex("\\p{IsCombiningDiacriticalMarks}+");
            string temp = s.Normalize(NormalizationForm.FormD);
            return regex.Replace(temp, String.Empty).Replace('\u0111', 'd').Replace('\u0110', 'D');
        } // Hàm chuyển đổi chuỗi có dấu sang không dấu

        public void checkLichChieuExpired()
        {
            BLL_LichChieu.Instance.CheckLichChieuExpired();
        }
        #endregion

        #region Event
        private void txtSearchShowtime_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearchShowtime.PerformClick();
                e.SuppressKeyPress = true;//Tắt tiếng *ting của windows
            }
        } // Khi nhập tên phim cần tìm, có thể bấm Enter thay cho nút tìm kiếm
        private void txtSearchShowtime_MouseClick(object sender, MouseEventArgs e)
        {
            txtSearchShowtime.Text = "";
        }
        private void dtgvShowTime_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                string maPhong = null;
                txtShowtimeID.Text = dtgvShowTime.Rows[e.RowIndex].Cells["MaLichChieu"].Value.ToString().Trim();
                txtMovieName_Showtime.Text = dtgvShowTime.Rows[e.RowIndex].Cells["TenPhim"].Value.ToString().Trim();
                txtScreenTypeName_Showtime.Text = dtgvShowTime.Rows[e.RowIndex].Cells["ManHinh"].Value.ToString().Trim();
                maPhong = dtgvShowTime.Rows[e.RowIndex].Cells["MaPhong"].Value.ToString().Trim();
                txtCinemaRoom.Text = BLL_PhongChieu.Instance.GetPhongChieuByMaPhong(maPhong).TenPhong;
                dtmShowtimeDate.Text = dtgvShowTime.Rows[e.RowIndex].Cells["ThoiGianChieu"].Value.ToString().Trim();
                dtmShowtimeTime.Text = dtgvShowTime.Rows[e.RowIndex].Cells["ThoiGianChieu"].Value.ToString().Trim();
            }
        }
        #endregion
    }
}
