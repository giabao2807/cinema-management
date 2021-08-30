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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3_GiaBao.View
{
    public partial class fPhongChieu : Form
    {
        public fPhongChieu()
        {
            InitializeComponent();
            loadListPhim(); // Load dữ liệu ra datagridview
            loadData(); // Lấy dữ liệu từ row đầu tiền datagirdview đổ vào các textfield
        }

        #region LoadData
        void loadListPhim()
        {
            List<PhongChieuView> phongChieuViews = BLLPhongChieuView.Instance.getAllPhongChieuViewByBLL();
            dtgvCinema.DataSource = phongChieuViews.ToList();
        }
        void loadData()
        {
            if (dtgvCinema.Rows.Count > 0)
            {
                txtCinemaID.Text = dtgvCinema.Rows[0].Cells["MaPhong"].Value.ToString().Trim();
                txtCinemaName.Text = dtgvCinema.Rows[0].Cells["TenPhong"].Value.ToString().Trim();
                txtDisplay.Text = dtgvCinema.Rows[0].Cells["TenMH"].Value.ToString().Trim();
                txtCinemaSeats.Text = dtgvCinema.Rows[0].Cells["SoChoNgoi"].Value.ToString().Trim();
                txtCinemaStatus.Text = dtgvCinema.Rows[0].Cells["TinhTrang"].Value.ToString().Trim();
                txtNumberOfRows.Text = dtgvCinema.Rows[0].Cells["SoHangGhe"].Value.ToString().Trim();
                txtSeatsPerRow.Text = dtgvCinema.Rows[0].Cells["SoGheMotHang"].Value.ToString().Trim();
            }
        }
        #endregion

        #region Button
        private void btnAdd_Click(object sender, EventArgs e)
        {
            fThemPhongChieu f = new fThemPhongChieu(null);
            f.d += new fThemPhongChieu.My_del(loadListPhim);
            f.ShowDialog();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dtgvCinema.SelectedRows.Count == 1)
            {
                string maPhong = txtCinemaID.Text;
                fThemPhongChieu f = new fThemPhongChieu(maPhong);
                f.d += new fThemPhongChieu.My_del(loadListPhim);
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("Hãy chọn một phòng chiếu", "Thông baó");
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection rows = dtgvCinema.SelectedRows;
            if (rows.Count < 1)
            {
                MessageBox.Show("Vui lòng chọn tối thiểu 1 phòng chiếu để xóa", "Thông báo");
            }
            else
            {
                try
                {
                    List<string> maPhongs = new List<string>();
                    for (int i = 0; i < rows.Count; i++)
                    {
                        bool check = true;
                        string s = rows[i].Cells["MaPhong"].Value.ToString().Trim();
                        List<DinhDangPhim> dinhDangPhims = BLL_DinhDangPhim.Instance.GetDinhDangPhimByMaPhong(s);
                        foreach (DinhDangPhim ddp in dinhDangPhims)
                        {
                            if (BLL_LichChieu.Instance.isExistidDinhDang(ddp.id))
                            {
                                MessageBox.Show("Phòng chiếu này đang được sử dụng, không thể xóa");
                                check = false;
                                break;
                            }
                        }
                        if (check) maPhongs.Add(s);
                    }
                    if (BLL_PhongChieu.Instance.DeleteListPhongChieu(maPhongs))
                    {
                        MessageBox.Show("Xóa thành công ");
                        loadListPhim();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Xóa thất bại", "Thông báo");
                }
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Event
        private void dtgvCinema_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                txtCinemaID.Text = dtgvCinema.Rows[e.RowIndex].Cells["MaPhong"].Value.ToString().Trim();
                txtCinemaName.Text = dtgvCinema.Rows[e.RowIndex].Cells["TenPhong"].Value.ToString().Trim();
                txtDisplay.Text = dtgvCinema.Rows[e.RowIndex].Cells["TenMH"].Value.ToString().Trim();
                txtCinemaSeats.Text = dtgvCinema.Rows[e.RowIndex].Cells["SoChoNgoi"].Value.ToString().Trim();
                txtCinemaStatus.Text = dtgvCinema.Rows[e.RowIndex].Cells["TinhTrang"].Value.ToString().Trim();
                txtNumberOfRows.Text = dtgvCinema.Rows[e.RowIndex].Cells["SoHangGhe"].Value.ToString().Trim();
                txtSeatsPerRow.Text = dtgvCinema.Rows[e.RowIndex].Cells["SoGheMotHang"].Value.ToString().Trim();
            }
        }
        #endregion
    }
}
