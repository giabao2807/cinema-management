
namespace PBL3_GiaBao.View
{
    partial class fTheLoaiPhim
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
            this.btDong = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.LoaiPhimDataGridView = new System.Windows.Forms.DataGridView();
            this.theLoaitxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.maLoaiPhim = new System.Windows.Forms.Label();
            this.maLoaiPhimtxt = new System.Windows.Forms.TextBox();
            this.clearbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.LoaiPhimDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btDong
            // 
            this.btDong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btDong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btDong.Location = new System.Drawing.Point(207, 217);
            this.btDong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btDong.Name = "btDong";
            this.btDong.Size = new System.Drawing.Size(103, 46);
            this.btDong.TabIndex = 19;
            this.btDong.Text = "Đóng";
            this.btDong.UseVisualStyleBackColor = true;
            this.btDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btXoa
            // 
            this.btXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btXoa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btXoa.Location = new System.Drawing.Point(207, 140);
            this.btXoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(103, 46);
            this.btXoa.TabIndex = 18;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btThem
            // 
            this.btThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btThem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btThem.Location = new System.Drawing.Point(54, 217);
            this.btThem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(104, 46);
            this.btThem.TabIndex = 17;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // LoaiPhimDataGridView
            // 
            this.LoaiPhimDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LoaiPhimDataGridView.Location = new System.Drawing.Point(372, 41);
            this.LoaiPhimDataGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LoaiPhimDataGridView.Name = "LoaiPhimDataGridView";
            this.LoaiPhimDataGridView.RowHeadersWidth = 51;
            this.LoaiPhimDataGridView.RowTemplate.Height = 24;
            this.LoaiPhimDataGridView.Size = new System.Drawing.Size(537, 233);
            this.LoaiPhimDataGridView.TabIndex = 16;
            this.LoaiPhimDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.LoaiPhimDataGridView_CellClick);
            // 
            // theLoaitxt
            // 
            this.theLoaitxt.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.theLoaitxt.Location = new System.Drawing.Point(135, 87);
            this.theLoaitxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.theLoaitxt.Name = "theLoaitxt";
            this.theLoaitxt.Size = new System.Drawing.Size(204, 34);
            this.theLoaitxt.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(21, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 24);
            this.label1.TabIndex = 14;
            this.label1.Text = "Thể loại";
            // 
            // maLoaiPhim
            // 
            this.maLoaiPhim.AutoSize = true;
            this.maLoaiPhim.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.maLoaiPhim.Location = new System.Drawing.Point(21, 41);
            this.maLoaiPhim.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.maLoaiPhim.Name = "maLoaiPhim";
            this.maLoaiPhim.Size = new System.Drawing.Size(137, 24);
            this.maLoaiPhim.TabIndex = 21;
            this.maLoaiPhim.Text = "Mã Loại Phim";
            // 
            // maLoaiPhimtxt
            // 
            this.maLoaiPhimtxt.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.maLoaiPhimtxt.Location = new System.Drawing.Point(207, 41);
            this.maLoaiPhimtxt.Margin = new System.Windows.Forms.Padding(4);
            this.maLoaiPhimtxt.Name = "maLoaiPhimtxt";
            this.maLoaiPhimtxt.Size = new System.Drawing.Size(132, 34);
            this.maLoaiPhimtxt.TabIndex = 20;
            // 
            // clearbtn
            // 
            this.clearbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.clearbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.clearbtn.Location = new System.Drawing.Point(54, 140);
            this.clearbtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.clearbtn.Name = "clearbtn";
            this.clearbtn.Size = new System.Drawing.Size(104, 46);
            this.clearbtn.TabIndex = 23;
            this.clearbtn.Text = "Clear";
            this.clearbtn.UseVisualStyleBackColor = true;
            this.clearbtn.Click += new System.EventHandler(this.clearbtn_Click);
            // 
            // fTheLoaiPhim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(921, 293);
            this.Controls.Add(this.clearbtn);
            this.Controls.Add(this.maLoaiPhim);
            this.Controls.Add(this.maLoaiPhimtxt);
            this.Controls.Add(this.btDong);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.LoaiPhimDataGridView);
            this.Controls.Add(this.theLoaitxt);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "fTheLoaiPhim";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fTheLoaiPhim";
            ((System.ComponentModel.ISupportInitialize)(this.LoaiPhimDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btDong;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.DataGridView LoaiPhimDataGridView;
        private System.Windows.Forms.TextBox theLoaitxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label maLoaiPhim;
        private System.Windows.Forms.TextBox maLoaiPhimtxt;
        private System.Windows.Forms.Button clearbtn;
    }
}