using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL3_GiaBao.BLL;
using PBL3_GiaBao.EF;
using PBL3_GiaBao.DTO;
using System.Globalization;

namespace PBL3_GiaBao
{
    public partial class fThongKe : Form
    {
        public fThongKe()
        {
            InitializeComponent();
            setCBBPhim();
            comboBox1.SelectedIndex = 0;
            setDateTimePicker();
        }

        public void setCBBPhim()
        {
            comboBox1.Items.Add(new CBBItem { Value = 0, Text = "All" });
            List<Phim> phims = BLL_Phim.Instance.getAllPhimByBLL();
            foreach (Phim i in phims)
            {
                comboBox1.Items.Add(new CBBItem
                {
                    Value = i.id,
                    Text = i.TenPhim
                });
            }
        }
        public void setDateTimePicker()
        {
            dateTimePicker1.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dateTimePicker2.Value = dateTimePicker1.Value.AddMonths(1).AddDays(-1);
        }
        // load danh sach doanh thu 
        public void LoadRevenue(string idMovie, DateTime fromDate, DateTime toDate)
        {
            toDate = toDate.AddDays(1);
            dataGridView1.DataSource = BLL_ThongKe.Instance.GetRevenue(idMovie, fromDate, toDate);
            CultureInfo culture = new CultureInfo("vi-VN");
            textBox1.Text = getSumRevenue().ToString("c",culture);
        }
        // tong doanh thu
        public float getSumRevenue()
        {
            float sum = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                sum += (float)row.Cells["TienBanVe"].Value;
            }
            return sum;
        }
        
        // btn thong ke
        private void button1_Click(object sender, EventArgs e)
        {
            LoadRevenue(((CBBItem)comboBox1.SelectedItem).Value.ToString(), dateTimePicker1.Value, dateTimePicker2.Value);
            comboBox2.Text = "";
        }
        // btn sắp xếp
        private void button2_Click(object sender, EventArgs e)
        {
            if(comboBox2.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn kiểu sắp xếp");
            }
            else {
                List<ThongKeView> ltkv = BLL_ThongKe.Instance.GetRevenue(((CBBItem)comboBox1.SelectedItem).Value.ToString(), dateTimePicker1.Value, dateTimePicker2.Value.AddDays(1));
                if (comboBox2.SelectedItem.ToString() == "Ngày Chiếu")
                {
                    dataGridView1.DataSource = BLL_ThongKe.Instance.sort(ltkv,0);
                }
                if (comboBox2.SelectedItem.ToString() == "Số Vé Bán")
                {
                    dataGridView1.DataSource = BLL_ThongKe.Instance.sort(ltkv,1);
                }
                if (comboBox2.SelectedItem.ToString() == "Tiền Bán Vé")
                {
                    dataGridView1.DataSource = BLL_ThongKe.Instance.sort(ltkv, 2);
                }
            } 
        }
    }
}
