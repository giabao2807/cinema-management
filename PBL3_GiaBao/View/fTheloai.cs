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
    public partial class fTheloai : Form
    {
        public delegate void load_del();

        public load_del d { get; set; }

        public fTheloai()
        {
            InitializeComponent();
            loadData();
        }

        public void loadData()
        {
            LoaiPhimDataGridView.DataSource = BLL.BLL_TheLoai.Instance.getAllTheLoaiByBLL();
            LoaiPhimDataGridView.Columns["Phims"].Visible = false;
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            if (theLoaitxt.Text.Trim() == "" || maLoaiPhimtxt.Text.Trim() == "")
            {
                MessageBox.Show("Vui lien nhap day du thong tin!");
            }

            else
            {
                try
                {
                    TheLoai tl = new TheLoai
                    {
                        id = maLoaiPhimtxt.Text.Trim(),
                        TenTheLoai = theLoaitxt.Text.Trim()
                    };
                    if (!BLL.BLL_TheLoai.Instance.isExistTheLoai(tl))
                    {
                        if (BLL.BLL_TheLoai.Instance.themTheLoai(tl))
                        {
                            MessageBox.Show("Them Thanh Cong!");
                            loadData();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Trung ma loai phim hoac ten loai phim, hay thay doi!");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Them that bai!");
                }
            }
        }

        public bool canBeDeleted(List<string> maDinhDangs)
        {
            foreach (string x in maDinhDangs)
            {
                if (BLL.BLL_LichChieu.Instance.isExistidDinhDang(x))
                {
                    return false;
                }
            }
            return true;
        }
        private bool theLoaiphuhop(string s)
        {
            List<Phim> p = BLL.BLL_Phim.Instance.getPhimbyidTheLoai(s);
            List<string> maphims = p.Select(x => x.id).ToList();
            foreach (string mp in maphims)
            {
                List<string> mdd = BLL.BLL_DinhDangPhim.Instance.getMaDinhDangbyMaPhim(mp);
                if (!canBeDeleted(mdd))
                {
                    return false;
                }
            }
            return true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection rows = LoaiPhimDataGridView.SelectedRows;

            if (rows.Count < 1)
            {
                MessageBox.Show("Vui long chon hon 1 loai phim de xoa!");
            }
            else
            {
                try
                {
                    List<string> maLoaiPhims = new List<string>();
                    for (int i = 0; i < rows.Count; i++)
                    {
                        string s = rows[i].Cells["id"].Value.ToString().Trim();
                        if (!theLoaiphuhop(s))
                        {
                            MessageBox.Show("The loai co ma " + s + " chua phim dang duoc chieu nen khong the xoa!");
                        }
                        else
                        {
                            maLoaiPhims.Add(s);
                        }
                    }
                    //MessageBox.Show()
                    if (BLL.BLL_TheLoai.Instance.xoaTheLoai(maLoaiPhims))
                    {
                        MessageBox.Show("Xoa Thanh Cong!");
                        loadData();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Xoa That Bai!");
                }

            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
            theLoaitxt.ReadOnly = false;
            maLoaiPhimtxt.ReadOnly = false;
            theLoaitxt.Text = maLoaiPhimtxt.Text = "";
        }

        private void LoaiPhimDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            maLoaiPhimtxt.Text = LoaiPhimDataGridView.Rows[e.RowIndex].Cells["id"].Value.ToString().Trim();
            theLoaitxt.Text = LoaiPhimDataGridView.Rows[e.RowIndex].Cells["TenTheLoai"].Value.ToString().Trim();
            maLoaiPhimtxt.ReadOnly = true;
            theLoaitxt.ReadOnly = true;
        }
    }
}
