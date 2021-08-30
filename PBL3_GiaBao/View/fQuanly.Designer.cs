
namespace PBL3_GiaBao.View
{
    partial class fControl
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
            this.btThoat = new System.Windows.Forms.Button();
            this.btDoiMK = new System.Windows.Forms.Button();
            this.btBanVe = new System.Windows.Forms.Button();
            this.btQuanly = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btThoat
            // 
            this.btThoat.BackColor = System.Drawing.Color.White;
            this.btThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btThoat.Location = new System.Drawing.Point(508, 280);
            this.btThoat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(151, 43);
            this.btThoat.TabIndex = 7;
            this.btThoat.Text = "Đăng xuất";
            this.btThoat.UseVisualStyleBackColor = false;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // btDoiMK
            // 
            this.btDoiMK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btDoiMK.Location = new System.Drawing.Point(12, 11);
            this.btDoiMK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btDoiMK.Name = "btDoiMK";
            this.btDoiMK.Size = new System.Drawing.Size(169, 43);
            this.btDoiMK.TabIndex = 6;
            this.btDoiMK.Text = "Đổi mật khẩu";
            this.btDoiMK.UseVisualStyleBackColor = false;
            this.btDoiMK.Click += new System.EventHandler(this.btDoiMK_Click);
            // 
            // btBanVe
            // 
            this.btBanVe.BackColor = System.Drawing.Color.OldLace;
            this.btBanVe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btBanVe.Location = new System.Drawing.Point(347, 127);
            this.btBanVe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btBanVe.Name = "btBanVe";
            this.btBanVe.Size = new System.Drawing.Size(177, 95);
            this.btBanVe.TabIndex = 5;
            this.btBanVe.Text = "Bán Vé";
            this.btBanVe.UseVisualStyleBackColor = false;
            this.btBanVe.Click += new System.EventHandler(this.btBanVe_Click);
            // 
            // btQuanly
            // 
            this.btQuanly.BackColor = System.Drawing.Color.OldLace;
            this.btQuanly.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btQuanly.Location = new System.Drawing.Point(150, 127);
            this.btQuanly.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btQuanly.Name = "btQuanly";
            this.btQuanly.Size = new System.Drawing.Size(181, 95);
            this.btQuanly.TabIndex = 4;
            this.btQuanly.Text = "Quản lý";
            this.btQuanly.UseVisualStyleBackColor = false;
            this.btQuanly.Click += new System.EventHandler(this.btQuanly_Click);
            // 
            // fControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 345);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.btDoiMK);
            this.Controls.Add(this.btBanVe);
            this.Controls.Add(this.btQuanly);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "fControl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fQuanLy";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.Button btDoiMK;
        private System.Windows.Forms.Button btBanVe;
        private System.Windows.Forms.Button btQuanly;
    }
}