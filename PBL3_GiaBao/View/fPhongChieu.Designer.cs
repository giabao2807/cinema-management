
namespace PBL3_GiaBao.View
{
    partial class fPhongChieu
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
            this.dtgvCinema = new System.Windows.Forms.DataGridView();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.lblScreenType = new System.Windows.Forms.Label();
            this.panel15 = new System.Windows.Forms.Panel();
            this.txtSeatsPerRow = new System.Windows.Forms.TextBox();
            this.lblSeatsPerRow = new System.Windows.Forms.Label();
            this.panel12 = new System.Windows.Forms.Panel();
            this.txtNumberOfRows = new System.Windows.Forms.TextBox();
            this.lblNumberOfRows = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.txtCinemaStatus = new System.Windows.Forms.TextBox();
            this.lblCinemaStatus = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.txtCinemaSeats = new System.Windows.Forms.TextBox();
            this.lblCinemaSeats = new System.Windows.Forms.Label();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.panel31 = new System.Windows.Forms.Panel();
            this.txtCinemaName = new System.Windows.Forms.TextBox();
            this.lblCinemaName = new System.Windows.Forms.Label();
            this.panel32 = new System.Windows.Forms.Panel();
            this.txtCinemaID = new System.Windows.Forms.TextBox();
            this.lblCinemaID = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCinema)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel15.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel8.SuspendLayout();
            this.groupBox.SuspendLayout();
            this.panel31.SuspendLayout();
            this.panel32.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgvCinema
            // 
            this.dtgvCinema.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvCinema.Location = new System.Drawing.Point(495, 25);
            this.dtgvCinema.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgvCinema.Name = "dtgvCinema";
            this.dtgvCinema.RowHeadersWidth = 51;
            this.dtgvCinema.RowTemplate.Height = 24;
            this.dtgvCinema.Size = new System.Drawing.Size(985, 530);
            this.dtgvCinema.TabIndex = 9;
            this.dtgvCinema.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvCinema_CellClick);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.txtDisplay);
            this.panel6.Controls.Add(this.lblScreenType);
            this.panel6.Location = new System.Drawing.Point(23, 156);
            this.panel6.Margin = new System.Windows.Forms.Padding(4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(419, 54);
            this.panel6.TabIndex = 11;
            // 
            // txtDisplay
            // 
            this.txtDisplay.Location = new System.Drawing.Point(197, 11);
            this.txtDisplay.Margin = new System.Windows.Forms.Padding(4);
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.ReadOnly = true;
            this.txtDisplay.Size = new System.Drawing.Size(215, 34);
            this.txtDisplay.TabIndex = 2;
            // 
            // lblScreenType
            // 
            this.lblScreenType.AutoSize = true;
            this.lblScreenType.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblScreenType.Location = new System.Drawing.Point(4, 11);
            this.lblScreenType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblScreenType.Name = "lblScreenType";
            this.lblScreenType.Size = new System.Drawing.Size(105, 24);
            this.lblScreenType.TabIndex = 0;
            this.lblScreenType.Text = "Màn hình:";
            // 
            // panel15
            // 
            this.panel15.Controls.Add(this.txtSeatsPerRow);
            this.panel15.Controls.Add(this.lblSeatsPerRow);
            this.panel15.Location = new System.Drawing.Point(23, 404);
            this.panel15.Margin = new System.Windows.Forms.Padding(4);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(419, 54);
            this.panel15.TabIndex = 12;
            // 
            // txtSeatsPerRow
            // 
            this.txtSeatsPerRow.Location = new System.Drawing.Point(196, 6);
            this.txtSeatsPerRow.Margin = new System.Windows.Forms.Padding(4);
            this.txtSeatsPerRow.Name = "txtSeatsPerRow";
            this.txtSeatsPerRow.ReadOnly = true;
            this.txtSeatsPerRow.Size = new System.Drawing.Size(215, 34);
            this.txtSeatsPerRow.TabIndex = 1;
            // 
            // lblSeatsPerRow
            // 
            this.lblSeatsPerRow.AutoSize = true;
            this.lblSeatsPerRow.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblSeatsPerRow.Location = new System.Drawing.Point(4, 11);
            this.lblSeatsPerRow.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSeatsPerRow.Name = "lblSeatsPerRow";
            this.lblSeatsPerRow.Size = new System.Drawing.Size(149, 24);
            this.lblSeatsPerRow.TabIndex = 0;
            this.lblSeatsPerRow.Text = "Ghế mỗi hàng:";
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.txtNumberOfRows);
            this.panel12.Controls.Add(this.lblNumberOfRows);
            this.panel12.Location = new System.Drawing.Point(23, 342);
            this.panel12.Margin = new System.Windows.Forms.Padding(4);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(419, 54);
            this.panel12.TabIndex = 13;
            // 
            // txtNumberOfRows
            // 
            this.txtNumberOfRows.Location = new System.Drawing.Point(196, 11);
            this.txtNumberOfRows.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumberOfRows.Name = "txtNumberOfRows";
            this.txtNumberOfRows.ReadOnly = true;
            this.txtNumberOfRows.Size = new System.Drawing.Size(215, 34);
            this.txtNumberOfRows.TabIndex = 1;
            // 
            // lblNumberOfRows
            // 
            this.lblNumberOfRows.AutoSize = true;
            this.lblNumberOfRows.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblNumberOfRows.Location = new System.Drawing.Point(4, 11);
            this.lblNumberOfRows.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumberOfRows.Name = "lblNumberOfRows";
            this.lblNumberOfRows.Size = new System.Drawing.Size(136, 24);
            this.lblNumberOfRows.TabIndex = 0;
            this.lblNumberOfRows.Text = "Số hàng ghế:";
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.txtCinemaStatus);
            this.panel9.Controls.Add(this.lblCinemaStatus);
            this.panel9.Location = new System.Drawing.Point(23, 281);
            this.panel9.Margin = new System.Windows.Forms.Padding(4);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(419, 54);
            this.panel9.TabIndex = 14;
            // 
            // txtCinemaStatus
            // 
            this.txtCinemaStatus.Location = new System.Drawing.Point(196, 6);
            this.txtCinemaStatus.Margin = new System.Windows.Forms.Padding(4);
            this.txtCinemaStatus.Name = "txtCinemaStatus";
            this.txtCinemaStatus.ReadOnly = true;
            this.txtCinemaStatus.Size = new System.Drawing.Size(215, 34);
            this.txtCinemaStatus.TabIndex = 1;
            // 
            // lblCinemaStatus
            // 
            this.lblCinemaStatus.AutoSize = true;
            this.lblCinemaStatus.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblCinemaStatus.Location = new System.Drawing.Point(4, 11);
            this.lblCinemaStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCinemaStatus.Name = "lblCinemaStatus";
            this.lblCinemaStatus.Size = new System.Drawing.Size(116, 24);
            this.lblCinemaStatus.TabIndex = 0;
            this.lblCinemaStatus.Text = "Tình trạng:";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.txtCinemaSeats);
            this.panel8.Controls.Add(this.lblCinemaSeats);
            this.panel8.Location = new System.Drawing.Point(23, 219);
            this.panel8.Margin = new System.Windows.Forms.Padding(4);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(419, 54);
            this.panel8.TabIndex = 15;
            // 
            // txtCinemaSeats
            // 
            this.txtCinemaSeats.Location = new System.Drawing.Point(196, 6);
            this.txtCinemaSeats.Margin = new System.Windows.Forms.Padding(4);
            this.txtCinemaSeats.Name = "txtCinemaSeats";
            this.txtCinemaSeats.ReadOnly = true;
            this.txtCinemaSeats.Size = new System.Drawing.Size(215, 34);
            this.txtCinemaSeats.TabIndex = 1;
            // 
            // lblCinemaSeats
            // 
            this.lblCinemaSeats.AutoSize = true;
            this.lblCinemaSeats.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblCinemaSeats.Location = new System.Drawing.Point(4, 11);
            this.lblCinemaSeats.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCinemaSeats.Name = "lblCinemaSeats";
            this.lblCinemaSeats.Size = new System.Drawing.Size(130, 24);
            this.lblCinemaSeats.TabIndex = 0;
            this.lblCinemaSeats.Text = "Số chỗ ngồi:";
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.panel6);
            this.groupBox.Controls.Add(this.panel15);
            this.groupBox.Controls.Add(this.panel12);
            this.groupBox.Controls.Add(this.panel9);
            this.groupBox.Controls.Add(this.panel8);
            this.groupBox.Controls.Add(this.panel31);
            this.groupBox.Controls.Add(this.panel32);
            this.groupBox.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox.Location = new System.Drawing.Point(8, 25);
            this.groupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox.Name = "groupBox";
            this.groupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox.Size = new System.Drawing.Size(477, 465);
            this.groupBox.TabIndex = 10;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Information";
            // 
            // panel31
            // 
            this.panel31.Controls.Add(this.txtCinemaName);
            this.panel31.Controls.Add(this.lblCinemaName);
            this.panel31.Location = new System.Drawing.Point(23, 94);
            this.panel31.Margin = new System.Windows.Forms.Padding(4);
            this.panel31.Name = "panel31";
            this.panel31.Size = new System.Drawing.Size(419, 54);
            this.panel31.TabIndex = 16;
            // 
            // txtCinemaName
            // 
            this.txtCinemaName.Location = new System.Drawing.Point(196, 6);
            this.txtCinemaName.Margin = new System.Windows.Forms.Padding(4);
            this.txtCinemaName.Name = "txtCinemaName";
            this.txtCinemaName.ReadOnly = true;
            this.txtCinemaName.Size = new System.Drawing.Size(215, 34);
            this.txtCinemaName.TabIndex = 1;
            // 
            // lblCinemaName
            // 
            this.lblCinemaName.AutoSize = true;
            this.lblCinemaName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblCinemaName.Location = new System.Drawing.Point(4, 11);
            this.lblCinemaName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCinemaName.Name = "lblCinemaName";
            this.lblCinemaName.Size = new System.Drawing.Size(119, 24);
            this.lblCinemaName.TabIndex = 0;
            this.lblCinemaName.Text = "Tên phòng:";
            // 
            // panel32
            // 
            this.panel32.Controls.Add(this.txtCinemaID);
            this.panel32.Controls.Add(this.lblCinemaID);
            this.panel32.Location = new System.Drawing.Point(23, 33);
            this.panel32.Margin = new System.Windows.Forms.Padding(4);
            this.panel32.Name = "panel32";
            this.panel32.Size = new System.Drawing.Size(419, 54);
            this.panel32.TabIndex = 10;
            // 
            // txtCinemaID
            // 
            this.txtCinemaID.Location = new System.Drawing.Point(196, 10);
            this.txtCinemaID.Margin = new System.Windows.Forms.Padding(4);
            this.txtCinemaID.Name = "txtCinemaID";
            this.txtCinemaID.ReadOnly = true;
            this.txtCinemaID.Size = new System.Drawing.Size(216, 34);
            this.txtCinemaID.TabIndex = 1;
            // 
            // lblCinemaID
            // 
            this.lblCinemaID.AutoSize = true;
            this.lblCinemaID.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblCinemaID.Location = new System.Drawing.Point(4, 14);
            this.lblCinemaID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCinemaID.Name = "lblCinemaID";
            this.lblCinemaID.Size = new System.Drawing.Size(111, 24);
            this.lblCinemaID.TabIndex = 0;
            this.lblCinemaID.Text = "Mã phòng:";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAdd.Location = new System.Drawing.Point(407, 614);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(121, 53);
            this.btnAdd.TabIndex = 23;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnUpdate.Location = new System.Drawing.Point(583, 614);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(121, 53);
            this.btnUpdate.TabIndex = 24;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDelete.Location = new System.Drawing.Point(761, 614);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(121, 53);
            this.btnDelete.TabIndex = 25;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnExit.Location = new System.Drawing.Point(943, 614);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(121, 53);
            this.btnExit.TabIndex = 26;
            this.btnExit.Text = "Đóng";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // fPhongChieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(1523, 718);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.dtgvCinema);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "fPhongChieu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fPhongChieu";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCinema)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel15.ResumeLayout(false);
            this.panel15.PerformLayout();
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.groupBox.ResumeLayout(false);
            this.panel31.ResumeLayout(false);
            this.panel31.PerformLayout();
            this.panel32.ResumeLayout(false);
            this.panel32.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvCinema;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lblScreenType;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.TextBox txtSeatsPerRow;
        private System.Windows.Forms.Label lblSeatsPerRow;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.TextBox txtNumberOfRows;
        private System.Windows.Forms.Label lblNumberOfRows;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label lblCinemaStatus;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox txtCinemaSeats;
        private System.Windows.Forms.Label lblCinemaSeats;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Panel panel31;
        private System.Windows.Forms.TextBox txtCinemaName;
        private System.Windows.Forms.Label lblCinemaName;
        private System.Windows.Forms.Panel panel32;
        private System.Windows.Forms.TextBox txtCinemaID;
        private System.Windows.Forms.Label lblCinemaID;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtCinemaStatus;
        private System.Windows.Forms.TextBox txtDisplay;
    }
}