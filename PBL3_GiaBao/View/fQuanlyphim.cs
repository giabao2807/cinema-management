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
    public partial class fQuanlyphim : Form
    {
        static string extension = ".jpg";
        public fQuanlyphim()
        {
            InitializeComponent();
            loadData();
            setCBB();
            setFirstFilm();
            SaveBtn.Hide();

        }
        //Funtion
        #region Function
        private void loadData()
        {
            List<PhimView> phimViews = BLL.BLL_PhimView.Instance.getAllPhimViewbyBLL();
            ListPhimDataGridView.DataSource = phimViews.ToList();
        }

        private void setCBB()
        {
            cbbTheLoai.Items.Clear();
            foreach (TheLoai i in BLL.BLL_TheLoai.Instance.getAllTheLoaiByBLL())
            {
                cbbTheLoai.Items.Add(new CBBItem
                {
                    Value = i.id.Trim(),
                    Text = i.TenTheLoai.Trim()
                });
            }


        }

        private void setImage()
        {
            phimImageBox.Visible = true;
            try
            {
                phimImageBox.Image = Image.FromFile("Image Source\\" + txtMaPhim.Text + extension);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " is not found!");
                phimImageBox.Image = null;
            }
            phimImageBox.SizeMode = PictureBoxSizeMode.AutoSize;
        }

        private void disableTools()
        {
            txtMaPhim.ReadOnly = true;
            txtTenPhim.ReadOnly = true;
            txtDaoDien.ReadOnly = true;
            txtMoTa.ReadOnly = true;
            txtQuocGia.ReadOnly = true;
            txtNSX.ReadOnly = true;
            txtThoiLuong.ReadOnly = true;

            pickImageBtn.Enabled = false;
            endDatePicker.Enabled = false;
            startDatePicker.Enabled = false;
            cbbTheLoai.Enabled = false;

        }

        private void enableTools()
        {
            txtTenPhim.ReadOnly = false;
            txtDaoDien.ReadOnly = false;
            txtMoTa.ReadOnly = false;
            txtQuocGia.ReadOnly = false;
            txtNSX.ReadOnly = false;
            txtThoiLuong.ReadOnly = false;
            cbbTheLoai.Enabled = true;
            pickImageBtn.Enabled = true;
            endDatePicker.Enabled = true;
            startDatePicker.Enabled = true;

        }

        private bool enoughInfo()
        {
            if (
            txtMaPhim.Text == "" || txtTenPhim.Text == "" ||
            cbbTheLoai.SelectedIndex == -1 || txtDaoDien.Text == "" ||
            txtQuocGia.Text == "" || txtNSX.Text == "" || txtThoiLuong.Text == ""
            || txtMoTa.Text == ""
            )
            {
                return false;
            }
            else return true;
        }

        private Phim getPhimfromDataView()
        {
            return new Phim
            {
                id = txtMaPhim.Text.Trim(),
                TenPhim = txtTenPhim.Text.Trim(),
                MoTa = txtMoTa.Text.Trim(),
                ThoiLuong = Convert.ToInt32(txtThoiLuong.Text.Trim()),
                NgayKhoiChieu = Convert.ToDateTime(startDatePicker.Value.ToString()),
                NgayKetThuc = Convert.ToDateTime(endDatePicker.Value.ToString()),
                SanXuat = txtQuocGia.Text.Trim(),
                DaoDien = txtDaoDien.Text.Trim(),
                NamSX = Convert.ToInt32(txtNSX.Text.Trim()),
                idTheLoai = Convert.ToString(((CBBItem)cbbTheLoai.SelectedItem).Value).Trim()
            };
        }

        private void setFirstFilm()
        {
            if (ListPhimDataGridView.Rows.Count >= 1)
            {
                SaveBtn.Hide();
                txtMaPhim.Text = ListPhimDataGridView.Rows[0].Cells["id"].Value.ToString().Trim();
                txtTenPhim.Text = ListPhimDataGridView.Rows[0].Cells["TenPhim"].Value.ToString().Trim();
                txtDaoDien.Text = ListPhimDataGridView.Rows[0].Cells["DaoDien"].Value.ToString().Trim();
                if (ListPhimDataGridView.Rows[0].Cells["MoTa"].Value != null)
                {
                    txtMoTa.Text = ListPhimDataGridView.Rows[0].Cells["MoTa"].Value.ToString().Trim();
                }
                else
                {
                    txtMoTa.Text = "";
                }
                txtQuocGia.Text = ListPhimDataGridView.Rows[0].Cells["SanXuat"].Value.ToString().Trim();
                txtNSX.Text = ListPhimDataGridView.Rows[0].Cells["NamSX"].Value.ToString().Trim();
                txtThoiLuong.Text = ListPhimDataGridView.Rows[0].Cells["ThoiLuong"].Value.ToString().Trim();


                startDatePicker.Value = Convert.ToDateTime(ListPhimDataGridView.Rows[0].Cells["NgayKhoiChieu"].Value.ToString().Trim());
                endDatePicker.Value = Convert.ToDateTime(ListPhimDataGridView.Rows[0].Cells["NgayKetThuc"].Value.ToString().Trim());
                foreach (Object j in cbbTheLoai.Items)
                {
                    if (((CBBItem)j).Text.CompareTo(ListPhimDataGridView.Rows[0].Cells["TenTheLoai"].Value.ToString().Trim()) == 0)
                    {
                        cbbTheLoai.SelectedIndex = cbbTheLoai.Items.IndexOf(j);
                    }
                }
                setImage();
                disableTools();
            }
        }

        private void ListPhimDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SaveBtn.Hide();
            txtMaPhim.Text = ListPhimDataGridView.Rows[e.RowIndex].Cells["id"].Value.ToString().Trim();
            txtTenPhim.Text = ListPhimDataGridView.Rows[e.RowIndex].Cells["TenPhim"].Value.ToString().Trim();
            txtDaoDien.Text = ListPhimDataGridView.Rows[e.RowIndex].Cells["DaoDien"].Value.ToString().Trim();
            if (ListPhimDataGridView.Rows[e.RowIndex].Cells["MoTa"].Value != null)
            {
                txtMoTa.Text = ListPhimDataGridView.Rows[e.RowIndex].Cells["MoTa"].Value.ToString().Trim();
            }
            else
            {
                txtMoTa.Text = "";
            }
            txtQuocGia.Text = ListPhimDataGridView.Rows[e.RowIndex].Cells["SanXuat"].Value.ToString().Trim();
            txtNSX.Text = ListPhimDataGridView.Rows[e.RowIndex].Cells["NamSX"].Value.ToString().Trim();
            txtThoiLuong.Text = ListPhimDataGridView.Rows[e.RowIndex].Cells["ThoiLuong"].Value.ToString().Trim();


            startDatePicker.Value = Convert.ToDateTime(ListPhimDataGridView.Rows[e.RowIndex].Cells["NgayKhoiChieu"].Value.ToString().Trim());
            endDatePicker.Value = Convert.ToDateTime(ListPhimDataGridView.Rows[e.RowIndex].Cells["NgayKetThuc"].Value.ToString().Trim());
            foreach (Object j in cbbTheLoai.Items)
            {
                if (((CBBItem)j).Text.CompareTo(ListPhimDataGridView.Rows[e.RowIndex].Cells["TenTheLoai"].Value.ToString().Trim()) == 0)
                {
                    cbbTheLoai.SelectedIndex = cbbTheLoai.Items.IndexOf(j);
                }
            }


            setImage();
            disableTools();
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
        #endregion

        //BUTTON
        #region BUTTON ACTIVATE 
        private void btClear_Click(object sender, EventArgs e)
        {
            enableTools();
            txtMaPhim.ReadOnly = false;

            endDatePicker.Value = DateTime.Now;
            startDatePicker.Value = DateTime.Now;
            txtMaPhim.Text = txtMaPhim.Text = txtTenPhim.Text = txtDaoDien.Text = txtMoTa.Text =
            txtQuocGia.Text = txtNSX.Text = txtThoiLuong.Text = "";
            cbbTheLoai.SelectedIndex = -1;

            phimImageBox.Visible = false;
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btQLLoaiPhim_Click(object sender, EventArgs e)
        {
            fTheloai f = new fTheloai();
            f.d += new fTheloai.load_del(setCBB);
            f.ShowDialog();
        }

        private void pickImageBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string filePathIamge = null;
                OpenFileDialog openFile = new OpenFileDialog();
                openFile.Filter = "Pictures files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png)|*.jpg; *.jpeg; *.jpe; *.jfif; *.png|All files (*.*)|*.*";
                openFile.FilterIndex = 1;
                openFile.RestoreDirectory = true;
                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    filePathIamge = openFile.FileName;
                    phimImageBox.Visible = true;
                    phimImageBox.Image = Image.FromFile(filePathIamge.ToString());
                    phimImageBox.SizeMode = PictureBoxSizeMode.AutoSize;
                    phimImageBox.Visible = true;
                }
            }
            catch (Exception)
            {
                return;
            }
        }

        private void addPhim_Click(object sender, EventArgs e)
        {
            if (!enoughInfo())
            {
                MessageBox.Show("Vui long dien day du thong tin!");
            }
            else
            {
                try
                {
                    Phim p = getPhimfromDataView();

                    if (BLL.BLL_Phim.Instance.isExistPhim(p))
                    {
                        MessageBox.Show("Trung ma phim, hay thay doi!");
                    }

                    else
                    {
                        if (BLL.BLL_Phim.Instance.themPhim(p))
                        {
                            MessageBox.Show("Them thanh cong!");
                            loadData();
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Them that bai!");
                }
            }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (!enoughInfo())
            {
                MessageBox.Show("Vui long dien day du thong tin!");
            }
            else
            {
                try
                {
                    Phim phim = getPhimfromDataView();


                    if (BLL.BLL_Phim.Instance.suaphim(phim))
                    {
                        MessageBox.Show("Sua thanh cong!");
                        loadData();
                        SaveBtn.Hide();
                    }

                }
                catch (Exception)
                {
                    MessageBox.Show("Sua that bai!");
                }
            }
        }

        private void EditPhim_Click(object sender, EventArgs e)
        {
            SaveBtn.Show();
            enableTools();
        }

        private void deletePhim_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection rows = ListPhimDataGridView.SelectedRows;
            if (rows.Count < 1)
            {
                MessageBox.Show("Vui long chon hon 1 row de xoa!");
            }
            else
            {
                try
                {
                    List<string> maPhims = new List<string>();
                    for (int i = 0; i < rows.Count; i++)
                    {
                        string s = rows[i].Cells["id"].Value.ToString().Trim();
                        List<string> mdd = BLL.BLL_DinhDangPhim.Instance.getMaDinhDangbyMaPhim(s);
                        if (!canBeDeleted(mdd))
                        {
                            MessageBox.Show("Phim dang duoc chieu khong the xoa!");
                        }
                        else
                        {
                            maPhims.Add(s);
                        }
                    }
                    if (BLL.BLL_Phim.Instance.xoaphim(maPhims))
                    {
                        MessageBox.Show("Xoa thanh cong!");
                        loadData();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Xoa that bai!");
                }
            }
        }
        #endregion
    }
}


