namespace QuanLyNhaTroMain
{
    partial class formThemPhong
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
            this.lbThemPhong = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbMaPhong = new System.Windows.Forms.Label();
            this.lbKhuVuc = new System.Windows.Forms.Label();
            this.lbDay = new System.Windows.Forms.Label();
            this.lbLoaiPhong = new System.Windows.Forms.Label();
            this.lbTenPhong = new System.Windows.Forms.Label();
            this.cbKhuVuc = new System.Windows.Forms.ComboBox();
            this.cbLoaiPhong = new System.Windows.Forms.ComboBox();
            this.tbMaPhong = new System.Windows.Forms.TextBox();
            this.tbTenPhong = new System.Windows.Forms.TextBox();
            this.tbDay = new System.Windows.Forms.TextBox();
            this.sbtThem = new DevExpress.XtraEditors.SimpleButton();
            this.sbtHuy = new DevExpress.XtraEditors.SimpleButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbThemPhong
            // 
            this.lbThemPhong.AutoSize = true;
            this.lbThemPhong.Font = new System.Drawing.Font("Times New Roman", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThemPhong.Location = new System.Drawing.Point(407, 34);
            this.lbThemPhong.Name = "lbThemPhong";
            this.lbThemPhong.Size = new System.Drawing.Size(235, 46);
            this.lbThemPhong.TabIndex = 0;
            this.lbThemPhong.Text = "Thêm Phòng";
            this.lbThemPhong.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.sbtHuy);
            this.panel1.Controls.Add(this.sbtThem);
            this.panel1.Controls.Add(this.tbDay);
            this.panel1.Controls.Add(this.tbTenPhong);
            this.panel1.Controls.Add(this.tbMaPhong);
            this.panel1.Controls.Add(this.cbLoaiPhong);
            this.panel1.Controls.Add(this.cbKhuVuc);
            this.panel1.Controls.Add(this.lbTenPhong);
            this.panel1.Controls.Add(this.lbLoaiPhong);
            this.panel1.Controls.Add(this.lbDay);
            this.panel1.Controls.Add(this.lbKhuVuc);
            this.panel1.Controls.Add(this.lbMaPhong);
            this.panel1.Location = new System.Drawing.Point(41, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(970, 533);
            this.panel1.TabIndex = 1;
            // 
            // lbMaPhong
            // 
            this.lbMaPhong.AutoSize = true;
            this.lbMaPhong.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbMaPhong.Location = new System.Drawing.Point(70, 124);
            this.lbMaPhong.Name = "lbMaPhong";
            this.lbMaPhong.Size = new System.Drawing.Size(124, 26);
            this.lbMaPhong.TabIndex = 0;
            this.lbMaPhong.Text = "Mã phòng:";
            // 
            // lbKhuVuc
            // 
            this.lbKhuVuc.AutoSize = true;
            this.lbKhuVuc.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbKhuVuc.Location = new System.Drawing.Point(70, 228);
            this.lbKhuVuc.Name = "lbKhuVuc";
            this.lbKhuVuc.Size = new System.Drawing.Size(107, 26);
            this.lbKhuVuc.TabIndex = 1;
            this.lbKhuVuc.Text = "Khu vực:";
            // 
            // lbDay
            // 
            this.lbDay.AutoSize = true;
            this.lbDay.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbDay.Location = new System.Drawing.Point(70, 326);
            this.lbDay.Name = "lbDay";
            this.lbDay.Size = new System.Drawing.Size(61, 26);
            this.lbDay.TabIndex = 2;
            this.lbDay.Text = "Dãy:";
            // 
            // lbLoaiPhong
            // 
            this.lbLoaiPhong.AutoSize = true;
            this.lbLoaiPhong.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbLoaiPhong.Location = new System.Drawing.Point(593, 124);
            this.lbLoaiPhong.Name = "lbLoaiPhong";
            this.lbLoaiPhong.Size = new System.Drawing.Size(136, 26);
            this.lbLoaiPhong.TabIndex = 3;
            this.lbLoaiPhong.Text = "Loại phòng:";
            // 
            // lbTenPhong
            // 
            this.lbTenPhong.AutoSize = true;
            this.lbTenPhong.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbTenPhong.Location = new System.Drawing.Point(593, 224);
            this.lbTenPhong.Name = "lbTenPhong";
            this.lbTenPhong.Size = new System.Drawing.Size(128, 26);
            this.lbTenPhong.TabIndex = 4;
            this.lbTenPhong.Text = "Tên phòng:";
            // 
            // cbKhuVuc
            // 
            this.cbKhuVuc.FormattingEnabled = true;
            this.cbKhuVuc.Location = new System.Drawing.Point(210, 228);
            this.cbKhuVuc.Name = "cbKhuVuc";
            this.cbKhuVuc.Size = new System.Drawing.Size(216, 24);
            this.cbKhuVuc.TabIndex = 8;
            // 
            // cbLoaiPhong
            // 
            this.cbLoaiPhong.FormattingEnabled = true;
            this.cbLoaiPhong.Location = new System.Drawing.Point(735, 128);
            this.cbLoaiPhong.Name = "cbLoaiPhong";
            this.cbLoaiPhong.Size = new System.Drawing.Size(163, 24);
            this.cbLoaiPhong.TabIndex = 9;
            // 
            // tbMaPhong
            // 
            this.tbMaPhong.Location = new System.Drawing.Point(210, 130);
            this.tbMaPhong.Multiline = true;
            this.tbMaPhong.Name = "tbMaPhong";
            this.tbMaPhong.Size = new System.Drawing.Size(216, 22);
            this.tbMaPhong.TabIndex = 10;
            // 
            // tbTenPhong
            // 
            this.tbTenPhong.Location = new System.Drawing.Point(735, 224);
            this.tbTenPhong.Name = "tbTenPhong";
            this.tbTenPhong.Size = new System.Drawing.Size(163, 23);
            this.tbTenPhong.TabIndex = 11;
            // 
            // tbDay
            // 
            this.tbDay.Location = new System.Drawing.Point(210, 330);
            this.tbDay.Name = "tbDay";
            this.tbDay.Size = new System.Drawing.Size(216, 23);
            this.tbDay.TabIndex = 12;
            // 
            // sbtThem
            // 
            this.sbtThem.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.sbtThem.Appearance.Options.UseFont = true;
            this.sbtThem.Location = new System.Drawing.Point(332, 417);
            this.sbtThem.Name = "sbtThem";
            this.sbtThem.Size = new System.Drawing.Size(116, 56);
            this.sbtThem.TabIndex = 13;
            this.sbtThem.Text = "Thêm";
            // 
            // sbtHuy
            // 
            this.sbtHuy.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.sbtHuy.Appearance.Options.UseFont = true;
            this.sbtHuy.Location = new System.Drawing.Point(566, 417);
            this.sbtHuy.Name = "sbtHuy";
            this.sbtHuy.Size = new System.Drawing.Size(104, 56);
            this.sbtHuy.TabIndex = 14;
            this.sbtHuy.Text = "Hủy";
            // 
            // formThemPhong
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 634);
            this.Controls.Add(this.lbThemPhong);
            this.Controls.Add(this.panel1);
            this.Name = "formThemPhong";
            this.Text = "formThemPhong";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbThemPhong;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbTenPhong;
        private System.Windows.Forms.Label lbLoaiPhong;
        private System.Windows.Forms.Label lbDay;
        private System.Windows.Forms.Label lbKhuVuc;
        private System.Windows.Forms.Label lbMaPhong;
        private System.Windows.Forms.TextBox tbDay;
        private System.Windows.Forms.TextBox tbTenPhong;
        private System.Windows.Forms.TextBox tbMaPhong;
        private System.Windows.Forms.ComboBox cbLoaiPhong;
        private System.Windows.Forms.ComboBox cbKhuVuc;
        private DevExpress.XtraEditors.SimpleButton sbtHuy;
        private DevExpress.XtraEditors.SimpleButton sbtThem;
    }
}