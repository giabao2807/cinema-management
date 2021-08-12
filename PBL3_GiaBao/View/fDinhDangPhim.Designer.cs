
namespace PBL3_GiaBao.View
{
    partial class fDinhDangPhim
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
            this.maLoaiPhim = new System.Windows.Forms.Label();
            this.txtMaDinhDang = new System.Windows.Forms.TextBox();
            this.btDong = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.dtgvDinhDangPhim = new System.Windows.Forms.DataGridView();
            this.txtPhongChieu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPhim = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSua = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDinhDangPhim)).BeginInit();
            this.SuspendLayout();
            // 
            // maLoaiPhim
            // 
            this.maLoaiPhim.AutoSize = true;
            this.maLoaiPhim.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.maLoaiPhim.Location = new System.Drawing.Point(13, 17);
            this.maLoaiPhim.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.maLoaiPhim.Name = "maLoaiPhim";
            this.maLoaiPhim.Size = new System.Drawing.Size(138, 24);
            this.maLoaiPhim.TabIndex = 31;
            this.maLoaiPhim.Text = "Mã định dạng";
            // 
            // txtMaDinhDang
            // 
            this.txtMaDinhDang.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.txtMaDinhDang.Location = new System.Drawing.Point(168, 13);
            this.txtMaDinhDang.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaDinhDang.Name = "txtMaDinhDang";
            this.txtMaDinhDang.Size = new System.Drawing.Size(187, 34);
            this.txtMaDinhDang.TabIndex = 30;
            // 
            // btDong
            // 
            this.btDong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btDong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btDong.Location = new System.Drawing.Point(394, 186);
            this.btDong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btDong.Name = "btDong";
            this.btDong.Size = new System.Drawing.Size(100, 45);
            this.btDong.TabIndex = 29;
            this.btDong.Text = "Đóng";
            this.btDong.UseVisualStyleBackColor = true;
            this.btDong.Click += new System.EventHandler(this.btDong_Click);
            // 
            // btXoa
            // 
            this.btXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btXoa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btXoa.Location = new System.Drawing.Point(267, 184);
            this.btXoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(100, 45);
            this.btXoa.TabIndex = 28;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btThem
            // 
            this.btThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btThem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btThem.Location = new System.Drawing.Point(19, 184);
            this.btThem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(100, 45);
            this.btThem.TabIndex = 27;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // dtgvDinhDangPhim
            // 
            this.dtgvDinhDangPhim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDinhDangPhim.Location = new System.Drawing.Point(507, 13);
            this.dtgvDinhDangPhim.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtgvDinhDangPhim.Name = "dtgvDinhDangPhim";
            this.dtgvDinhDangPhim.RowHeadersWidth = 51;
            this.dtgvDinhDangPhim.RowTemplate.Height = 24;
            this.dtgvDinhDangPhim.Size = new System.Drawing.Size(499, 217);
            this.dtgvDinhDangPhim.TabIndex = 26;
            this.dtgvDinhDangPhim.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvDinhDangPhim_CellClick);
            // 
            // txtPhongChieu
            // 
            this.txtPhongChieu.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.txtPhongChieu.Location = new System.Drawing.Point(168, 59);
            this.txtPhongChieu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPhongChieu.Name = "txtPhongChieu";
            this.txtPhongChieu.Size = new System.Drawing.Size(187, 34);
            this.txtPhongChieu.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(13, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 24);
            this.label1.TabIndex = 24;
            this.label1.Text = "Phòng chiếu";
            // 
            // txtPhim
            // 
            this.txtPhim.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.txtPhim.Location = new System.Drawing.Point(168, 111);
            this.txtPhim.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPhim.Name = "txtPhim";
            this.txtPhim.Size = new System.Drawing.Size(326, 34);
            this.txtPhim.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(13, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 24);
            this.label2.TabIndex = 32;
            this.label2.Text = "Phim";
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSua.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSua.Location = new System.Drawing.Point(141, 184);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(100, 45);
            this.btnSua.TabIndex = 34;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // fDinhDangPhim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 244);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.txtPhim);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.maLoaiPhim);
            this.Controls.Add(this.txtMaDinhDang);
            this.Controls.Add(this.btDong);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.dtgvDinhDangPhim);
            this.Controls.Add(this.txtPhongChieu);
            this.Controls.Add(this.label1);
            this.Name = "fDinhDangPhim";
            this.Text = "fDinhDangPhim";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDinhDangPhim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label maLoaiPhim;
        private System.Windows.Forms.TextBox txtMaDinhDang;
        private System.Windows.Forms.Button btDong;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.DataGridView dtgvDinhDangPhim;
        private System.Windows.Forms.TextBox txtPhongChieu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPhim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSua;
    }
}