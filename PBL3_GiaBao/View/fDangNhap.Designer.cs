
namespace PBL3_GiaBao.View
{
    partial class fDangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fDangNhap));
            this.checkboxMk = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btHuy = new System.Windows.Forms.Button();
            this.btDNhap = new System.Windows.Forms.Button();
            this.txtMK = new System.Windows.Forms.TextBox();
            this.txtTentk = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // checkboxMk
            // 
            this.checkboxMk.AutoSize = true;
            this.checkboxMk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.checkboxMk.Location = new System.Drawing.Point(379, 229);
            this.checkboxMk.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkboxMk.Name = "checkboxMk";
            this.checkboxMk.Size = new System.Drawing.Size(159, 29);
            this.checkboxMk.TabIndex = 26;
            this.checkboxMk.Text = "Hiện mật khẩu";
            this.checkboxMk.UseVisualStyleBackColor = true;
            this.checkboxMk.CheckedChanged += new System.EventHandler(this.checkboxMk_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(55, 98);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(115, 110);
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // btHuy
            // 
            this.btHuy.BackColor = System.Drawing.Color.Red;
            this.btHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btHuy.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btHuy.Location = new System.Drawing.Point(379, 266);
            this.btHuy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btHuy.Name = "btHuy";
            this.btHuy.Size = new System.Drawing.Size(149, 44);
            this.btHuy.TabIndex = 24;
            this.btHuy.Text = "Hủy";
            this.btHuy.UseVisualStyleBackColor = false;
            this.btHuy.Click += new System.EventHandler(this.btHuy_Click);
            // 
            // btDNhap
            // 
            this.btDNhap.BackColor = System.Drawing.Color.Chartreuse;
            this.btDNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btDNhap.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btDNhap.Location = new System.Drawing.Point(196, 266);
            this.btDNhap.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btDNhap.Name = "btDNhap";
            this.btDNhap.Size = new System.Drawing.Size(149, 44);
            this.btDNhap.TabIndex = 23;
            this.btDNhap.Text = "Đăng nhập";
            this.btDNhap.UseVisualStyleBackColor = false;
            this.btDNhap.Click += new System.EventHandler(this.btDNhap_Click);
            // 
            // txtMK
            // 
            this.txtMK.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.txtMK.Location = new System.Drawing.Point(379, 179);
            this.txtMK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMK.Name = "txtMK";
            this.txtMK.Size = new System.Drawing.Size(243, 34);
            this.txtMK.TabIndex = 22;
            this.txtMK.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMK_KeyPress);
            // 
            // txtTentk
            // 
            this.txtTentk.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.txtTentk.Location = new System.Drawing.Point(379, 118);
            this.txtTentk.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTentk.Name = "txtTentk";
            this.txtTentk.Size = new System.Drawing.Size(243, 34);
            this.txtTentk.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(193, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 24);
            this.label3.TabIndex = 20;
            this.label3.Text = "Mật khẩu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(193, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 24);
            this.label2.TabIndex = 19;
            this.label2.Text = "Tên đăng nhập";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.74545F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(196, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 27);
            this.label1.TabIndex = 18;
            this.label1.Text = "ĐĂNG NHẬP HỆ THỐNG";
            // 
            // fDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 345);
            this.Controls.Add(this.checkboxMk);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btHuy);
            this.Controls.Add(this.btDNhap);
            this.Controls.Add(this.txtMK);
            this.Controls.Add(this.txtTentk);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "fDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fDangNhap";
            this.Load += new System.EventHandler(this.fLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkboxMk;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btHuy;
        private System.Windows.Forms.Button btDNhap;
        private System.Windows.Forms.TextBox txtMK;
        private System.Windows.Forms.TextBox txtTentk;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}