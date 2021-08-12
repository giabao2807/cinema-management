
namespace PBL3_GiaBao.View
{
    partial class fQuanLyVe
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
            this.dtgvVe = new System.Windows.Forms.DataGridView();
            this.dtgrLichChieu = new System.Windows.Forms.DataGridView();
            this.btnAddVe = new System.Windows.Forms.Button();
            this.btnRemoveVe = new System.Windows.Forms.Button();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.btnShowLichChieuChuatao = new System.Windows.Forms.Button();
            this.btnShowTicketBought = new System.Windows.Forms.Button();
            this.btnShowAllTicketByLichChieu = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvVe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrLichChieu)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvVe
            // 
            this.dtgvVe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvVe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvVe.Location = new System.Drawing.Point(12, 142);
            this.dtgvVe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgvVe.Name = "dtgvVe";
            this.dtgvVe.RowHeadersWidth = 51;
            this.dtgvVe.RowTemplate.Height = 24;
            this.dtgvVe.Size = new System.Drawing.Size(541, 539);
            this.dtgvVe.TabIndex = 0;
            // 
            // dtgrLichChieu
            // 
            this.dtgrLichChieu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgrLichChieu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgrLichChieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrLichChieu.Location = new System.Drawing.Point(560, 142);
            this.dtgrLichChieu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgrLichChieu.Name = "dtgrLichChieu";
            this.dtgrLichChieu.RowHeadersWidth = 51;
            this.dtgrLichChieu.RowTemplate.Height = 24;
            this.dtgrLichChieu.Size = new System.Drawing.Size(812, 539);
            this.dtgrLichChieu.TabIndex = 1;
            // 
            // btnAddVe
            // 
            this.btnAddVe.Font = new System.Drawing.Font("Times New Roman", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnAddVe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAddVe.Location = new System.Drawing.Point(12, 48);
            this.btnAddVe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddVe.Name = "btnAddVe";
            this.btnAddVe.Size = new System.Drawing.Size(197, 66);
            this.btnAddVe.TabIndex = 2;
            this.btnAddVe.Text = "Tự Động Thêm Vé Theo Lịch Chiếu";
            this.btnAddVe.UseVisualStyleBackColor = true;
            this.btnAddVe.Click += new System.EventHandler(this.btnAddVe_Click);
            // 
            // btnRemoveVe
            // 
            this.btnRemoveVe.Font = new System.Drawing.Font("Times New Roman", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnRemoveVe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnRemoveVe.Location = new System.Drawing.Point(237, 48);
            this.btnRemoveVe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRemoveVe.Name = "btnRemoveVe";
            this.btnRemoveVe.Size = new System.Drawing.Size(197, 66);
            this.btnRemoveVe.TabIndex = 3;
            this.btnRemoveVe.Text = "Xóa Vé Theo Lịch Chiếu";
            this.btnRemoveVe.UseVisualStyleBackColor = true;
            this.btnRemoveVe.Click += new System.EventHandler(this.btnRemoveVe_Click);
            // 
            // btnShowAll
            // 
            this.btnShowAll.Font = new System.Drawing.Font("Times New Roman", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnShowAll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnShowAll.Location = new System.Drawing.Point(463, 48);
            this.btnShowAll.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(197, 66);
            this.btnShowAll.TabIndex = 4;
            this.btnShowAll.Text = "Xem Tất Cả Lịch Chiếu";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // btnShowLichChieuChuatao
            // 
            this.btnShowLichChieuChuatao.Font = new System.Drawing.Font("Times New Roman", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnShowLichChieuChuatao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnShowLichChieuChuatao.Location = new System.Drawing.Point(683, 48);
            this.btnShowLichChieuChuatao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnShowLichChieuChuatao.Name = "btnShowLichChieuChuatao";
            this.btnShowLichChieuChuatao.Size = new System.Drawing.Size(197, 66);
            this.btnShowLichChieuChuatao.TabIndex = 5;
            this.btnShowLichChieuChuatao.Text = "Xem Lịch Chiếu Chưa Được Tạo Vé";
            this.btnShowLichChieuChuatao.UseVisualStyleBackColor = true;
            this.btnShowLichChieuChuatao.Click += new System.EventHandler(this.btnShowLichChieuChuatao_Click);
            // 
            // btnShowTicketBought
            // 
            this.btnShowTicketBought.Font = new System.Drawing.Font("Times New Roman", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnShowTicketBought.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnShowTicketBought.Location = new System.Drawing.Point(895, 48);
            this.btnShowTicketBought.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnShowTicketBought.Name = "btnShowTicketBought";
            this.btnShowTicketBought.Size = new System.Drawing.Size(197, 66);
            this.btnShowTicketBought.TabIndex = 6;
            this.btnShowTicketBought.Text = "Xem Các Vé Được Bán Theo Lịch Chiếu";
            this.btnShowTicketBought.UseVisualStyleBackColor = true;
            this.btnShowTicketBought.Click += new System.EventHandler(this.btnShowTicketBought_Click);
            // 
            // btnShowAllTicketByLichChieu
            // 
            this.btnShowAllTicketByLichChieu.Font = new System.Drawing.Font("Times New Roman", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnShowAllTicketByLichChieu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnShowAllTicketByLichChieu.Location = new System.Drawing.Point(1117, 48);
            this.btnShowAllTicketByLichChieu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnShowAllTicketByLichChieu.Name = "btnShowAllTicketByLichChieu";
            this.btnShowAllTicketByLichChieu.Size = new System.Drawing.Size(197, 66);
            this.btnShowAllTicketByLichChieu.TabIndex = 7;
            this.btnShowAllTicketByLichChieu.Text = "Xem Tất Cả Các Vé Theo Lịch Chiếu";
            this.btnShowAllTicketByLichChieu.UseVisualStyleBackColor = true;
            this.btnShowAllTicketByLichChieu.Click += new System.EventHandler(this.btnShowAllTicketByLichChieu_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(1260, 699);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 47);
            this.button1.TabIndex = 8;
            this.button1.Text = "Đóng";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // fQuanLyVe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(1391, 756);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnShowAllTicketByLichChieu);
            this.Controls.Add(this.btnShowTicketBought);
            this.Controls.Add(this.btnShowLichChieuChuatao);
            this.Controls.Add(this.btnShowAll);
            this.Controls.Add(this.btnRemoveVe);
            this.Controls.Add(this.btnAddVe);
            this.Controls.Add(this.dtgrLichChieu);
            this.Controls.Add(this.dtgvVe);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "fQuanLyVe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QLVe";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvVe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrLichChieu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvVe;
        private System.Windows.Forms.DataGridView dtgrLichChieu;
        private System.Windows.Forms.Button btnAddVe;
        private System.Windows.Forms.Button btnRemoveVe;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.Button btnShowLichChieuChuatao;
        private System.Windows.Forms.Button btnShowTicketBought;
        private System.Windows.Forms.Button btnShowAllTicketByLichChieu;
        private System.Windows.Forms.Button button1;
    }
}