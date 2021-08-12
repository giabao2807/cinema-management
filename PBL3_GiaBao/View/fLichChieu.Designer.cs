
namespace PBL3_GiaBao.View
{
    partial class fLichChieu
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtmShowtimeTime = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dtmShowtimeDate = new System.Windows.Forms.DateTimePicker();
            this.dtgvShowTime = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMovieName_Showtime = new System.Windows.Forms.TextBox();
            this.cboCinemaID_Showtime = new System.Windows.Forms.ComboBox();
            this.cboFormatID_Showtime = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtScreenTypeName_Showtime = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtShowtimeID = new System.Windows.Forms.TextBox();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.btnSearchShowtime = new System.Windows.Forms.Button();
            this.txtSearchShowtime = new System.Windows.Forms.TextBox();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvShowTime)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.dtmShowtimeTime);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.dtmShowtimeDate);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.groupBox2.Location = new System.Drawing.Point(24, 419);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(452, 133);
            this.groupBox2.TabIndex = 79;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thời gian chiếu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(5, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 24);
            this.label3.TabIndex = 50;
            this.label3.Text = "Giờ:";
            // 
            // dtmShowtimeTime
            // 
            this.dtmShowtimeTime.CalendarFont = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtmShowtimeTime.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.dtmShowtimeTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtmShowtimeTime.Location = new System.Drawing.Point(177, 86);
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
            this.label5.Location = new System.Drawing.Point(6, 51);
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
            this.dtmShowtimeDate.Location = new System.Drawing.Point(177, 44);
            this.dtmShowtimeDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtmShowtimeDate.Name = "dtmShowtimeDate";
            this.dtmShowtimeDate.Size = new System.Drawing.Size(216, 34);
            this.dtmShowtimeDate.TabIndex = 58;
            // 
            // dtgvShowTime
            // 
            this.dtgvShowTime.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvShowTime.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvShowTime.Location = new System.Drawing.Point(509, 82);
            this.dtgvShowTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgvShowTime.Name = "dtgvShowTime";
            this.dtgvShowTime.RowHeadersWidth = 82;
            this.dtgvShowTime.RowTemplate.Height = 33;
            this.dtgvShowTime.Size = new System.Drawing.Size(973, 470);
            this.dtgvShowTime.TabIndex = 75;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMovieName_Showtime);
            this.groupBox1.Controls.Add(this.cboCinemaID_Showtime);
            this.groupBox1.Controls.Add(this.cboFormatID_Showtime);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtScreenTypeName_Showtime);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtShowtimeID);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.groupBox1.Location = new System.Drawing.Point(24, 82);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(452, 321);
            this.groupBox1.TabIndex = 78;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin lịch chiếu";
            // 
            // txtMovieName_Showtime
            // 
            this.txtMovieName_Showtime.Location = new System.Drawing.Point(177, 138);
            this.txtMovieName_Showtime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMovieName_Showtime.Name = "txtMovieName_Showtime";
            this.txtMovieName_Showtime.ReadOnly = true;
            this.txtMovieName_Showtime.Size = new System.Drawing.Size(256, 34);
            this.txtMovieName_Showtime.TabIndex = 64;
            // 
            // cboCinemaID_Showtime
            // 
            this.cboCinemaID_Showtime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCinemaID_Showtime.FormattingEnabled = true;
            this.cboCinemaID_Showtime.Location = new System.Drawing.Point(177, 226);
            this.cboCinemaID_Showtime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboCinemaID_Showtime.Name = "cboCinemaID_Showtime";
            this.cboCinemaID_Showtime.Size = new System.Drawing.Size(256, 34);
            this.cboCinemaID_Showtime.TabIndex = 62;
            // 
            // cboFormatID_Showtime
            // 
            this.cboFormatID_Showtime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFormatID_Showtime.FormattingEnabled = true;
            this.cboFormatID_Showtime.Location = new System.Drawing.Point(177, 92);
            this.cboFormatID_Showtime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboFormatID_Showtime.Name = "cboFormatID_Showtime";
            this.cboFormatID_Showtime.Size = new System.Drawing.Size(256, 34);
            this.cboFormatID_Showtime.TabIndex = 61;
            this.cboFormatID_Showtime.SelectedIndexChanged += new System.EventHandler(this.cboFormatID_Showtime_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(5, 234);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 24);
            this.label7.TabIndex = 60;
            this.label7.Text = "Phòng chiếu:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(5, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 24);
            this.label1.TabIndex = 59;
            this.label1.Text = "Phim:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(5, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 24);
            this.label2.TabIndex = 58;
            this.label2.Text = "Mã định dạng:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(5, 190);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 24);
            this.label8.TabIndex = 55;
            this.label8.Text = "Màn hình:";
            // 
            // txtScreenTypeName_Showtime
            // 
            this.txtScreenTypeName_Showtime.Location = new System.Drawing.Point(177, 186);
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
            this.label6.Location = new System.Drawing.Point(5, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 24);
            this.label6.TabIndex = 53;
            this.label6.Text = "Mã lịch chiếu:";
            // 
            // txtShowtimeID
            // 
            this.txtShowtimeID.Location = new System.Drawing.Point(177, 52);
            this.txtShowtimeID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtShowtimeID.Name = "txtShowtimeID";
            this.txtShowtimeID.Size = new System.Drawing.Size(256, 34);
            this.txtShowtimeID.TabIndex = 52;
            this.txtShowtimeID.TextChanged += new System.EventHandler(this.txtShowtimeID_TextChanged);
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonExit.Location = new System.Drawing.Point(959, 617);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(121, 53);
            this.buttonExit.TabIndex = 74;
            this.buttonExit.Text = "Đóng";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonDelete.Location = new System.Drawing.Point(782, 617);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(121, 53);
            this.buttonDelete.TabIndex = 73;
            this.buttonDelete.Text = "Xóa";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // btnSearchShowtime
            // 
            this.btnSearchShowtime.Location = new System.Drawing.Point(1455, 34);
            this.btnSearchShowtime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearchShowtime.Name = "btnSearchShowtime";
            this.btnSearchShowtime.Size = new System.Drawing.Size(27, 27);
            this.btnSearchShowtime.TabIndex = 77;
            this.btnSearchShowtime.UseVisualStyleBackColor = true;
            this.btnSearchShowtime.Click += new System.EventHandler(this.btnSearchShowtime_Click);
            // 
            // txtSearchShowtime
            // 
            this.txtSearchShowtime.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.txtSearchShowtime.Location = new System.Drawing.Point(1084, 34);
            this.txtSearchShowtime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearchShowtime.Multiline = true;
            this.txtSearchShowtime.Name = "txtSearchShowtime";
            this.txtSearchShowtime.Size = new System.Drawing.Size(334, 27);
            this.txtSearchShowtime.TabIndex = 76;
            this.txtSearchShowtime.Text = "Tìm theo tên phim...";
            this.txtSearchShowtime.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtSearchShowtime_MouseClick);
            this.txtSearchShowtime.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearchShowtime_KeyDown);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonUpdate.Location = new System.Drawing.Point(602, 617);
            this.buttonUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(121, 53);
            this.buttonUpdate.TabIndex = 72;
            this.buttonUpdate.Text = "Sửa";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonAdd.Location = new System.Drawing.Point(416, 617);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(121, 53);
            this.buttonAdd.TabIndex = 71;
            this.buttonAdd.Text = "Thêm";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // fLichChieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(1523, 718);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dtgvShowTime);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.btnSearchShowtime);
            this.Controls.Add(this.txtSearchShowtime);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonAdd);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "fLichChieu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fLichChieu";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvShowTime)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtmShowtimeTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtmShowtimeDate;
        private System.Windows.Forms.DataGridView dtgvShowTime;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMovieName_Showtime;
        private System.Windows.Forms.ComboBox cboCinemaID_Showtime;
        private System.Windows.Forms.ComboBox cboFormatID_Showtime;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtScreenTypeName_Showtime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtShowtimeID;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button btnSearchShowtime;
        private System.Windows.Forms.TextBox txtSearchShowtime;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonAdd;
    }
}