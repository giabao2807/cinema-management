
namespace PBL3_GiaBao.View
{
    partial class fThemLichChieu
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
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtmShowtimeTime = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dtmShowtimeDate = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTicketFee = new System.Windows.Forms.TextBox();
            this.cbbMovie = new System.Windows.Forms.ComboBox();
            this.cbbCinema = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtScreenTypeName_Showtime = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtShowtimeID = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonExit.Location = new System.Drawing.Point(303, 549);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(121, 53);
            this.buttonExit.TabIndex = 76;
            this.buttonExit.Text = "Đóng";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonOK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonOK.Location = new System.Drawing.Point(46, 549);
            this.buttonOK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(121, 53);
            this.buttonOK.TabIndex = 75;
            this.buttonOK.Text = "Xác nhận";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.dtmShowtimeTime);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.dtmShowtimeDate);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.groupBox2.Location = new System.Drawing.Point(16, 369);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(452, 133);
            this.groupBox2.TabIndex = 81;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thời gian chiếu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(5, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 24);
            this.label3.TabIndex = 50;
            this.label3.Text = "Giờ:";
            // 
            // dtmShowtimeTime
            // 
            this.dtmShowtimeTime.CalendarFont = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtmShowtimeTime.CustomFormat = "  HH:mm";
            this.dtmShowtimeTime.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.dtmShowtimeTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtmShowtimeTime.Location = new System.Drawing.Point(177, 71);
            this.dtmShowtimeTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtmShowtimeTime.Name = "dtmShowtimeTime";
            this.dtmShowtimeTime.ShowUpDown = true;
            this.dtmShowtimeTime.Size = new System.Drawing.Size(216, 34);
            this.dtmShowtimeTime.TabIndex = 59;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(5, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 24);
            this.label5.TabIndex = 51;
            this.label5.Text = "Ngày:";
            // 
            // dtmShowtimeDate
            // 
            this.dtmShowtimeDate.CalendarFont = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtmShowtimeDate.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.dtmShowtimeDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtmShowtimeDate.Location = new System.Drawing.Point(177, 23);
            this.dtmShowtimeDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtmShowtimeDate.Name = "dtmShowtimeDate";
            this.dtmShowtimeDate.Size = new System.Drawing.Size(216, 34);
            this.dtmShowtimeDate.TabIndex = 58;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtTicketFee);
            this.groupBox1.Controls.Add(this.cbbMovie);
            this.groupBox1.Controls.Add(this.cbbCinema);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtScreenTypeName_Showtime);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtShowtimeID);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.groupBox1.Location = new System.Drawing.Point(17, 24);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(452, 321);
            this.groupBox1.TabIndex = 80;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin lịch chiếu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(9, 262);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 24);
            this.label2.TabIndex = 65;
            this.label2.Text = "Giá vé:";
            // 
            // txtTicketFee
            // 
            this.txtTicketFee.Location = new System.Drawing.Point(181, 258);
            this.txtTicketFee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTicketFee.Name = "txtTicketFee";
            this.txtTicketFee.Size = new System.Drawing.Size(256, 34);
            this.txtTicketFee.TabIndex = 64;
            // 
            // cbbMovie
            // 
            this.cbbMovie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbMovie.FormattingEnabled = true;
            this.cbbMovie.Location = new System.Drawing.Point(181, 167);
            this.cbbMovie.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbMovie.Name = "cbbMovie";
            this.cbbMovie.Size = new System.Drawing.Size(256, 34);
            this.cbbMovie.TabIndex = 63;
            // 
            // cbbCinema
            // 
            this.cbbCinema.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCinema.FormattingEnabled = true;
            this.cbbCinema.Location = new System.Drawing.Point(181, 121);
            this.cbbCinema.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbCinema.Name = "cbbCinema";
            this.cbbCinema.Size = new System.Drawing.Size(256, 34);
            this.cbbCinema.TabIndex = 62;
            this.cbbCinema.SelectedIndexChanged += new System.EventHandler(this.cbbCinema_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(9, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 24);
            this.label7.TabIndex = 60;
            this.label7.Text = "Phòng chiếu:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(9, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 24);
            this.label1.TabIndex = 59;
            this.label1.Text = "Phim:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(9, 216);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 24);
            this.label8.TabIndex = 55;
            this.label8.Text = "Màn hình:";
            // 
            // txtScreenTypeName_Showtime
            // 
            this.txtScreenTypeName_Showtime.Location = new System.Drawing.Point(181, 212);
            this.txtScreenTypeName_Showtime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtScreenTypeName_Showtime.Name = "txtScreenTypeName_Showtime";
            this.txtScreenTypeName_Showtime.ReadOnly = true;
            this.txtScreenTypeName_Showtime.Size = new System.Drawing.Size(256, 34);
            this.txtScreenTypeName_Showtime.TabIndex = 54;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(9, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 24);
            this.label6.TabIndex = 53;
            this.label6.Text = "Mã lịch chiếu:";
            // 
            // txtShowtimeID
            // 
            this.txtShowtimeID.Location = new System.Drawing.Point(181, 77);
            this.txtShowtimeID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtShowtimeID.Name = "txtShowtimeID";
            this.txtShowtimeID.Size = new System.Drawing.Size(256, 34);
            this.txtShowtimeID.TabIndex = 52;
            // 
            // fThemLichChieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 622);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonOK);
            this.Name = "fThemLichChieu";
            this.Text = "fThemLichChieu";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtmShowtimeTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtmShowtimeDate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtScreenTypeName_Showtime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtShowtimeID;
        private System.Windows.Forms.ComboBox cbbMovie;
        private System.Windows.Forms.ComboBox cbbCinema;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTicketFee;
    }
}