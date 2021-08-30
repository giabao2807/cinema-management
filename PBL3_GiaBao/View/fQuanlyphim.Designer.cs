
namespace PBL3_GiaBao.View
{
    partial class fQuanLyPhim
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SaveBtn = new System.Windows.Forms.Button();
            this.txtMoTa = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.pickImageBtn = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.deletePhim = new System.Windows.Forms.Button();
            this.EditPhim = new System.Windows.Forms.Button();
            this.addPhim = new System.Windows.Forms.Button();
            this.cbbTheLoai = new System.Windows.Forms.ComboBox();
            this.btClear = new System.Windows.Forms.Button();
            this.txtThoiLuong = new System.Windows.Forms.TextBox();
            this.txtDaoDien = new System.Windows.Forms.TextBox();
            this.txtTenPhim = new System.Windows.Forms.TextBox();
            this.txtMaPhim = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.phimImageBox = new System.Windows.Forms.PictureBox();
            this.ListPhimDataGridView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.startDatePicker = new System.Windows.Forms.DateTimePicker();
            this.endDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtQuocGia = new System.Windows.Forms.TextBox();
            this.txtNSX = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.phimImageBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListPhimDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SaveBtn
            // 
            this.SaveBtn.BackColor = System.Drawing.Color.Lime;
            this.SaveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.SaveBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SaveBtn.Location = new System.Drawing.Point(467, 740);
            this.SaveBtn.Margin = new System.Windows.Forms.Padding(4);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(85, 42);
            this.SaveBtn.TabIndex = 28;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = false;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // txtMoTa
            // 
            this.txtMoTa.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.txtMoTa.Location = new System.Drawing.Point(115, 421);
            this.txtMoTa.Margin = new System.Windows.Forms.Padding(4);
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Size = new System.Drawing.Size(373, 34);
            this.txtMoTa.TabIndex = 27;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(11, 431);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 24);
            this.label10.TabIndex = 26;
            this.label10.Text = "Mô Tả";
            // 
            // pickImageBtn
            // 
            this.pickImageBtn.Font = new System.Drawing.Font("Times New Roman", 9.818182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pickImageBtn.Location = new System.Drawing.Point(163, 573);
            this.pickImageBtn.Margin = new System.Windows.Forms.Padding(4);
            this.pickImageBtn.Name = "pickImageBtn";
            this.pickImageBtn.Size = new System.Drawing.Size(65, 33);
            this.pickImageBtn.TabIndex = 25;
            this.pickImageBtn.Text = "...";
            this.pickImageBtn.UseVisualStyleBackColor = true;
            this.pickImageBtn.Click += new System.EventHandler(this.pickImageBtn_Click);
            // 
            // close
            // 
            this.close.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.close.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.close.Location = new System.Drawing.Point(355, 740);
            this.close.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(84, 42);
            this.close.TabIndex = 21;
            this.close.Text = "Đóng";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // deletePhim
            // 
            this.deletePhim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.deletePhim.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.deletePhim.Location = new System.Drawing.Point(245, 740);
            this.deletePhim.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.deletePhim.Name = "deletePhim";
            this.deletePhim.Size = new System.Drawing.Size(87, 42);
            this.deletePhim.TabIndex = 20;
            this.deletePhim.Text = "Xóa";
            this.deletePhim.UseVisualStyleBackColor = true;
            this.deletePhim.Click += new System.EventHandler(this.deletePhim_Click);
            // 
            // EditPhim
            // 
            this.EditPhim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.EditPhim.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.EditPhim.Location = new System.Drawing.Point(139, 740);
            this.EditPhim.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EditPhim.Name = "EditPhim";
            this.EditPhim.Size = new System.Drawing.Size(85, 42);
            this.EditPhim.TabIndex = 19;
            this.EditPhim.Text = "Sửa";
            this.EditPhim.UseVisualStyleBackColor = true;
            this.EditPhim.Click += new System.EventHandler(this.EditPhim_Click);
            // 
            // addPhim
            // 
            this.addPhim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.addPhim.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.addPhim.Location = new System.Drawing.Point(27, 740);
            this.addPhim.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addPhim.Name = "addPhim";
            this.addPhim.Size = new System.Drawing.Size(93, 42);
            this.addPhim.TabIndex = 18;
            this.addPhim.Text = "Thêm";
            this.addPhim.UseVisualStyleBackColor = true;
            this.addPhim.Click += new System.EventHandler(this.addPhim_Click);
            // 
            // cbbTheLoai
            // 
            this.cbbTheLoai.BackColor = System.Drawing.SystemColors.HighlightText;
            this.cbbTheLoai.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.cbbTheLoai.FormattingEnabled = true;
            this.cbbTheLoai.Location = new System.Drawing.Point(115, 294);
            this.cbbTheLoai.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbbTheLoai.Name = "cbbTheLoai";
            this.cbbTheLoai.Size = new System.Drawing.Size(160, 34);
            this.cbbTheLoai.TabIndex = 17;
            // 
            // btClear
            // 
            this.btClear.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btClear.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.btClear.Location = new System.Drawing.Point(411, 251);
            this.btClear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(159, 38);
            this.btClear.TabIndex = 16;
            this.btClear.Text = "Clear";
            this.btClear.UseVisualStyleBackColor = false;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // txtThoiLuong
            // 
            this.txtThoiLuong.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.txtThoiLuong.Location = new System.Drawing.Point(395, 567);
            this.txtThoiLuong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtThoiLuong.Name = "txtThoiLuong";
            this.txtThoiLuong.Size = new System.Drawing.Size(93, 34);
            this.txtThoiLuong.TabIndex = 13;
            // 
            // txtDaoDien
            // 
            this.txtDaoDien.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.txtDaoDien.Location = new System.Drawing.Point(115, 379);
            this.txtDaoDien.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDaoDien.Name = "txtDaoDien";
            this.txtDaoDien.Size = new System.Drawing.Size(373, 34);
            this.txtDaoDien.TabIndex = 12;
            // 
            // txtTenPhim
            // 
            this.txtTenPhim.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.txtTenPhim.Location = new System.Drawing.Point(115, 337);
            this.txtTenPhim.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTenPhim.Name = "txtTenPhim";
            this.txtTenPhim.Size = new System.Drawing.Size(373, 34);
            this.txtTenPhim.TabIndex = 11;
            // 
            // txtMaPhim
            // 
            this.txtMaPhim.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.txtMaPhim.Location = new System.Drawing.Point(115, 254);
            this.txtMaPhim.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaPhim.Name = "txtMaPhim";
            this.txtMaPhim.Size = new System.Drawing.Size(160, 34);
            this.txtMaPhim.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(11, 582);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 24);
            this.label9.TabIndex = 9;
            this.label9.Text = "Hình ảnh";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(499, 576);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 24);
            this.label6.TabIndex = 6;
            this.label6.Text = "phút";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(275, 577);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 24);
            this.label5.TabIndex = 5;
            this.label5.Text = "Thời lượng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(11, 389);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "Đạo diễn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(8, 298);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Thể loại";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(8, 341);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên phim";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(9, 258);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã phim";
            // 
            // phimImageBox
            // 
            this.phimImageBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.phimImageBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.phimImageBox.Location = new System.Drawing.Point(177, 4);
            this.phimImageBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.phimImageBox.Name = "phimImageBox";
            this.phimImageBox.Size = new System.Drawing.Size(215, 240);
            this.phimImageBox.TabIndex = 0;
            this.phimImageBox.TabStop = false;
            // 
            // ListPhimDataGridView
            // 
            this.ListPhimDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListPhimDataGridView.Location = new System.Drawing.Point(612, 18);
            this.ListPhimDataGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ListPhimDataGridView.Name = "ListPhimDataGridView";
            this.ListPhimDataGridView.RowHeadersWidth = 51;
            this.ListPhimDataGridView.RowTemplate.Height = 24;
            this.ListPhimDataGridView.Size = new System.Drawing.Size(899, 798);
            this.ListPhimDataGridView.TabIndex = 5;
            this.ListPhimDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListPhimDataGridView_CellClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.startDatePicker);
            this.panel1.Controls.Add(this.endDatePicker);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.SaveBtn);
            this.panel1.Controls.Add(this.txtMoTa);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.pickImageBtn);
            this.panel1.Controls.Add(this.close);
            this.panel1.Controls.Add(this.deletePhim);
            this.panel1.Controls.Add(this.EditPhim);
            this.panel1.Controls.Add(this.addPhim);
            this.panel1.Controls.Add(this.cbbTheLoai);
            this.panel1.Controls.Add(this.btClear);
            this.panel1.Controls.Add(this.txtQuocGia);
            this.panel1.Controls.Add(this.txtNSX);
            this.panel1.Controls.Add(this.txtThoiLuong);
            this.panel1.Controls.Add(this.txtDaoDien);
            this.panel1.Controls.Add(this.txtTenPhim);
            this.panel1.Controls.Add(this.txtMaPhim);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.phimImageBox);
            this.panel1.Location = new System.Drawing.Point(15, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(591, 798);
            this.panel1.TabIndex = 4;
            // 
            // startDatePicker
            // 
            this.startDatePicker.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.startDatePicker.Location = new System.Drawing.Point(201, 631);
            this.startDatePicker.Margin = new System.Windows.Forms.Padding(4);
            this.startDatePicker.Name = "startDatePicker";
            this.startDatePicker.Size = new System.Drawing.Size(335, 34);
            this.startDatePicker.TabIndex = 32;
            // 
            // endDatePicker
            // 
            this.endDatePicker.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.endDatePicker.Location = new System.Drawing.Point(201, 686);
            this.endDatePicker.Margin = new System.Windows.Forms.Padding(4);
            this.endDatePicker.Name = "endDatePicker";
            this.endDatePicker.Size = new System.Drawing.Size(335, 34);
            this.endDatePicker.TabIndex = 31;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(11, 686);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(150, 24);
            this.label12.TabIndex = 30;
            this.label12.Text = "Ngày Kết Thúc";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(11, 639);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(169, 24);
            this.label11.TabIndex = 29;
            this.label11.Text = "Ngày Khởi Chiếu";
            // 
            // txtQuocGia
            // 
            this.txtQuocGia.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.txtQuocGia.Location = new System.Drawing.Point(163, 517);
            this.txtQuocGia.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtQuocGia.Name = "txtQuocGia";
            this.txtQuocGia.Size = new System.Drawing.Size(159, 34);
            this.txtQuocGia.TabIndex = 15;
            // 
            // txtNSX
            // 
            this.txtNSX.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.txtNSX.Location = new System.Drawing.Point(163, 472);
            this.txtNSX.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNSX.Name = "txtNSX";
            this.txtNSX.Size = new System.Drawing.Size(159, 34);
            this.txtNSX.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(11, 527);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 24);
            this.label8.TabIndex = 8;
            this.label8.Text = "Quốc gia";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(9, 482);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 24);
            this.label7.TabIndex = 7;
            this.label7.Text = "Năm sản xuất";
            // 
            // fQuanLyPhim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(1523, 827);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ListPhimDataGridView);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "fQuanLyPhim";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fQuanLyPhim";
            ((System.ComponentModel.ISupportInitialize)(this.phimImageBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListPhimDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.TextBox txtMoTa;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button pickImageBtn;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Button deletePhim;
        private System.Windows.Forms.Button EditPhim;
        private System.Windows.Forms.Button addPhim;
        private System.Windows.Forms.ComboBox cbbTheLoai;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.TextBox txtThoiLuong;
        private System.Windows.Forms.TextBox txtDaoDien;
        private System.Windows.Forms.TextBox txtTenPhim;
        private System.Windows.Forms.TextBox txtMaPhim;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox phimImageBox;
        private System.Windows.Forms.DataGridView ListPhimDataGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtQuocGia;
        private System.Windows.Forms.TextBox txtNSX;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker startDatePicker;
        private System.Windows.Forms.DateTimePicker endDatePicker;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
    }
}