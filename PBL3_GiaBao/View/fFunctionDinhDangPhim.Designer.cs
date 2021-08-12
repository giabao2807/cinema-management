
namespace PBL3_GiaBao.View
{
    partial class fFunctionDinhDangPhim
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
            this.label2 = new System.Windows.Forms.Label();
            this.maLoaiPhim = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbPhongChieu = new System.Windows.Forms.ComboBox();
            this.txtMaDinhDang = new System.Windows.Forms.TextBox();
            this.cbbPhim = new System.Windows.Forms.ComboBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(13, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 24);
            this.label2.TabIndex = 38;
            this.label2.Text = "Phim";
            // 
            // maLoaiPhim
            // 
            this.maLoaiPhim.AutoSize = true;
            this.maLoaiPhim.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.maLoaiPhim.Location = new System.Drawing.Point(13, 27);
            this.maLoaiPhim.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.maLoaiPhim.Name = "maLoaiPhim";
            this.maLoaiPhim.Size = new System.Drawing.Size(138, 24);
            this.maLoaiPhim.TabIndex = 37;
            this.maLoaiPhim.Text = "Mã định dạng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(13, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 24);
            this.label1.TabIndex = 34;
            this.label1.Text = "Phòng chiếu";
            // 
            // cbbPhongChieu
            // 
            this.cbbPhongChieu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbPhongChieu.FormattingEnabled = true;
            this.cbbPhongChieu.Location = new System.Drawing.Point(158, 76);
            this.cbbPhongChieu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbPhongChieu.Name = "cbbPhongChieu";
            this.cbbPhongChieu.Size = new System.Drawing.Size(201, 24);
            this.cbbPhongChieu.TabIndex = 63;
            // 
            // txtMaDinhDang
            // 
            this.txtMaDinhDang.Location = new System.Drawing.Point(158, 30);
            this.txtMaDinhDang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaDinhDang.Name = "txtMaDinhDang";
            this.txtMaDinhDang.Size = new System.Drawing.Size(201, 22);
            this.txtMaDinhDang.TabIndex = 62;
            // 
            // cbbPhim
            // 
            this.cbbPhim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbPhim.FormattingEnabled = true;
            this.cbbPhim.Location = new System.Drawing.Point(158, 125);
            this.cbbPhim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbPhim.Name = "cbbPhim";
            this.cbbPhim.Size = new System.Drawing.Size(201, 24);
            this.cbbPhim.TabIndex = 64;
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnOK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnOK.Location = new System.Drawing.Point(17, 175);
            this.btnOK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(139, 46);
            this.btnOK.TabIndex = 66;
            this.btnOK.Text = "Xác nhận";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnExit.Location = new System.Drawing.Point(220, 175);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(139, 46);
            this.btnExit.TabIndex = 65;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // fFunctionDinhDangPhim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 234);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.cbbPhim);
            this.Controls.Add(this.cbbPhongChieu);
            this.Controls.Add(this.txtMaDinhDang);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.maLoaiPhim);
            this.Controls.Add(this.label1);
            this.Name = "fFunctionDinhDangPhim";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fFunctionDinhDangPhim";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label maLoaiPhim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbPhongChieu;
        private System.Windows.Forms.TextBox txtMaDinhDang;
        private System.Windows.Forms.ComboBox cbbPhim;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnExit;
    }
}