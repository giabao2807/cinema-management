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
    public partial class fBanVe : Form
    {
        public fBanVe()
        {
            InitializeComponent();
            dateTimePicker1.Value = DateTime.Now;
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            comboBox1.Text = "";
            comboBox1.Items.Clear();
            comboBox2.Text = "";
            comboBox2.Items.Clear();
            setCBBPhim();
            if (comboBox1.Items.Count >= 1) comboBox1.SelectedIndex = 0;
            else
            {
                comboBox1.Text = "";
                dataGridView1.DataSource = "";
            }
        }
        public void setCBBPhim()
        {
            List<Phim> phims = BLL_Phim.Instance.GetListMovieByDate(dateTimePicker1.Value);
            foreach (Phim i in phims)
            {
                comboBox1.Items.Add(new CBBItem
                {
                    Value = i.id,
                    Text = i.TenPhim
                });
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            setCBBLoaiManHinh();
            if (comboBox2.Items.Count >= 1) comboBox2.SelectedIndex = 0;
            else
            {
                comboBox2.Text = "";
                dataGridView1.DataSource = "";
            }
        }
        public void setCBBLoaiManHinh()
        {
            if (comboBox1.Items.Count >= 1)
            {
                string idphim = ((CBBItem)comboBox1.SelectedItem).Value.ToString();
                List<DinhDangPhim> ddphim = BLL_DinhDangPhim.Instance.GetListFormatMovieByMovie(idphim,dateTimePicker1.Value);
                foreach (DinhDangPhim i in ddphim)
                {
                    PhongChieu pc = BLL_PhongChieu.Instance.GetPhongChieuByMaPhong(i.idPhongChieu);
                    comboBox2.Items.Add(new CBBItem
                    {
                        Value = i.id,
                        Text = pc.LoaiManHinh.TenMH
                    });
                }
            }
        }

        public void LoadListShowTimeByFilm(string formatMovieID)
        {
            List<LichChieuView> data = BLL_LichChieu.Instance.LoadListShowTimeByFilm( formatMovieID,dateTimePicker1.Value);
            dataGridView1.DataSource = data.ToList();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadListShowTimeByFilm(((CBBItem)comboBox2.SelectedItem).Value.ToString());
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                LichChieu lc = BLL_LichChieu.Instance.GetLichChieuByIdLichChieu(dataGridView1.SelectedRows[0].Cells["id"].Value.ToString());
                Phim phim = BLL_Phim.Instance.getPhimByIdPhim(((CBBItem)comboBox1.SelectedItem).Value.ToString());
                if(dataGridView1.SelectedRows[0].Cells["TrangThai"].Value.ToString() == "1")
                {
                    fRapChieuPhim tt = new fRapChieuPhim(lc, phim);
                    tt.Show();
                } else
                {
                    MessageBox.Show("Lịch chiếu này chưa được tạo vé");
                }
            }
        }
    }
}
