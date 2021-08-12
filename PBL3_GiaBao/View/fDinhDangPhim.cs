using PBL3_GiaBao.BLL;
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
    public partial class fDinhDangPhim : Form
    {
        public fDinhDangPhim()
        {
            InitializeComponent();
            setData();
        }

        private void setData()
        {
            dtgvDinhDangPhim.DataSource = BLL_DinhDangPhim.Instance.GetAllDinhDangPhim();
            dtgvDinhDangPhim.Columns["Phim"].Visible = false;
            dtgvDinhDangPhim.Columns["PhongChieu"].Visible = false;
            dtgvDinhDangPhim.Columns["LichChieux"].Visible = false;
        }

        private void dtgvDinhDangPhim_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaDinhDang.Text = dtgvDinhDangPhim.Rows[e.RowIndex].Cells["id"].Value.ToString().Trim();
            string maPhong = dtgvDinhDangPhim.Rows[e.RowIndex].Cells["idPhongchieu"].Value.ToString().Trim();
            string maPhim = dtgvDinhDangPhim.Rows[e.RowIndex].Cells["idPhim"].Value.ToString().Trim();
            txtPhongChieu.Text = BLL_PhongChieu.Instance.GetPhongChieuByMaPhong(maPhong).TenPhong;
            txtPhim.Text = BLL_Phim.Instance.getPhimByIdPhim(maPhim).TenPhim;
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            fFunctionDinhDangPhim f = new fFunctionDinhDangPhim(null);
            f.d += new fFunctionDinhDangPhim.My_del(setData);
            f.ShowDialog();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            List<string> maDinhDangs = new List<string>();
            DataGridViewSelectedRowCollection rows = dtgvDinhDangPhim.SelectedRows;
            if (rows.Count < 1)
            {
                MessageBox.Show("Vui lòng chọn tối thiểu 1 định dạng phim để xóa", "Thông báo");
            }
            else
            {
                try
                {
                    for (int i = 0; i < rows.Count; i++)
                    {
                        string s = rows[i].Cells["id"].Value.ToString().Trim();
                        if (BLL_LichChieu.Instance.isExistidDinhDang(s))
                        {
                            MessageBox.Show("Định dạng phim có mã " + s + " đang có lịch chiếu, không thể xóa");
                        }
                        else
                        {
                            maDinhDangs.Add(s);
                        }
                    }
                    if (BLL_DinhDangPhim.Instance.deleteListDinhDangPhim(maDinhDangs))
                    {
                        MessageBox.Show("Xóa thành công");
                        setData();
                    }
                }
                catch(Exception)
                {
                    MessageBox.Show("Xóa thất bại");
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dtgvDinhDangPhim.SelectedRows.Count == 1)
            {
                string maDinhDang = txtMaDinhDang.Text;
                fFunctionDinhDangPhim f = new fFunctionDinhDangPhim(maDinhDang);
                f.d += new fFunctionDinhDangPhim.My_del(setData);
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("Hãy chọn một định dạng phim", "Thông báo");
            }
        }

        private void btDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
