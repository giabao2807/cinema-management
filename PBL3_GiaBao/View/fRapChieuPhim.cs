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
    public partial class fRapChieuPhim : Form
    {
        int SIZE = 30;//Size của ghế
        int GAP = 7;//Khoảng cách giữa các ghế
        List<Ve> listSeat = new List<Ve>(); // dùng lưu ds vé của lịch chiếu
        List<Button> listSeatSelected = new List<Button>();  //dùng lưu vết các Ghế đang chọn
        int countTicket = 0; //đếm số lượng vé mua
        int displayPrice = 0;//Hiện thị giá vé
        int ticketPrice = 0;//Lưu giá vé gốc
        float discount = 0;//Tiền được giảm
        int total = 0;//Tổng giá tiền
        float payment = 0;//Tiền phải trả

        LichChieu Times;
        Phim Movie;

        public fRapChieuPhim(LichChieu lichchieu, Phim phim)
        {
            InitializeComponent();
            Times = lichchieu;
            Movie = phim;
        }

        public fRapChieuPhim()
        {
        }
        // thông tin phòng chiếu
        private void LoadDataCinema(string cinemaName)
        {
            PhongChieu cinema = BLL_PhongChieu.Instance.GetCinemaByName(cinemaName);
            int Row = cinema.SoHangGhe;
            int Column = cinema.SoGheMotHang;
            flowLayoutPanel1.Size = new Size((SIZE + 20 + GAP) * Column, (SIZE + GAP) * Row);
        }

        // load form theatre
        private void theatre_Load(object sender, EventArgs e)
        {
            ticketPrice = (int)Times.GiaVe;
            DinhDangPhim dinhDangPhim = BLL_DinhDangPhim.Instance.GetDinhDangPhimByMaDinhDang(Times.idDinhDang);
            PhongChieu pc = BLL_PhongChieu.Instance.GetPhongChieuByMaPhong(dinhDangPhim.idPhongChieu);
            lbinformation.Text = "CGV Hung Vuong | " + pc.TenPhong + " | " + Movie.TenPhim;
            lbtime.Text = Times.ThoiGianChieu.ToShortDateString() + " | "
                + Times.ThoiGianChieu.ToShortTimeString() + " - "
                + Times.ThoiGianChieu.AddMinutes(Movie.ThoiLuong).ToShortTimeString();
            string apphich = Movie.id;
            pictureBox1.BackgroundImage = Image.FromFile("Image Source\\" + apphich + ".jpg");
            LoadDataCinema(pc.TenPhong);
            listSeat = BLL_Ve.Instance.GetListTicketsByShowTimes(Times.id);
            LoadSeats(listSeat);
        }

        //thông tin thanh toán
        private void LoadBill()
        {
            lbTicketPrice.Text = displayPrice.ToString();
            lbTotal.Text = total.ToString();
            lbDisCount.Text = discount.ToString();
            lbPayment.Text = payment.ToString();
        }

        // load ghế
        private void LoadSeats(List<Ve> list)
        {
            flowLayoutPanel1.Controls.Clear();
            for (int i = 0; i < list.Count; i++)
            {
                Button btnSeat = new Button() { Width = SIZE + 20, Height = SIZE };
                btnSeat.Text = list[i].MaGheNgoi;
                if (list[i].TrangThai == 1)
                    btnSeat.BackColor = Color.Red;
                else
                    btnSeat.BackColor = Color.White;
                btnSeat.Click += BtnSeat_Click;
                flowLayoutPanel1.Controls.Add(btnSeat);
                btnSeat.Tag = list[i];
            }
        }

        //click cho từng ghế
        private void BtnSeat_Click(object sender, EventArgs e)
        {
            Button btnSeat = sender as Button;
            if (btnSeat.BackColor == Color.White)
            {
                btnSeat.BackColor = Color.Yellow;
                countTicket++;
                displayPrice = ticketPrice;
                total += ticketPrice;
                if (countTicket >= 3) discount = total / 100 * 10;
                if (countTicket >= 5) discount = total / 100 * 20;
                payment = total - discount;
                listSeatSelected.Add(btnSeat);

            }
            else if (btnSeat.BackColor == Color.Yellow)
            {
                btnSeat.BackColor = Color.White;
                countTicket--;
                total -= ticketPrice;
                if (countTicket >= 3 && countTicket < 5) discount = total / 100 * 10;
                if (countTicket < 3) discount = 0;
                payment = total - discount;
                displayPrice = ticketPrice;
                listSeatSelected.Remove(btnSeat);
            }
            else if (btnSeat.BackColor == Color.Red)
            {
                //MessageBox.Show("Ghế số [" + btnSeat.Text + "] đã có người mua");
            }
            LoadBill();
        }
        // btn huy
        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn hủy tất cả những vé đã chọn ko?",
                "Hủy Mua Vé", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No) return;
            foreach (Button btn in listSeatSelected)
            {
                btn.BackColor = Color.White;
            }
            RestoreDefault();
            this.OnLoad(new EventArgs());
        }

        //reset ve ban dau
        private void RestoreDefault()
        {
            listSeatSelected.Clear();
            total = 0;
            countTicket = 0;
            discount = 0;
            payment = 0;
            displayPrice = 0;
            LoadBill();
        }

        // btn thanh toan
        private void button3_Click(object sender, EventArgs e)
        {
            if (listSeatSelected.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn vé trước khi thanh toán!");
                return;
            }
            string message = "Bạn có chắc chắn mua những vé: \n";
            foreach (Button btn in listSeatSelected)
            {
                message += "[" + btn.Text + "] ";
            }
            message += "\nKhông?";
            DialogResult result = MessageBox.Show(message, "Hỏi Mua",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                try
                {
                    foreach (Button btn in listSeatSelected)
                    {
                        Ve ticket = btn.Tag as Ve;
                        float TienBanVe = payment / countTicket;
                        BLL_Ve.Instance.BuyTicket(ticket.id,TienBanVe);
                    }
                    MessageBox.Show("Bạn đã mua vé thành công!");
                } 
                catch(Exception)
                {
                    MessageBox.Show("Mua vé thất bại!");
                }
            }
            RestoreDefault();
            this.OnLoad(new EventArgs());
        }

    }
}
