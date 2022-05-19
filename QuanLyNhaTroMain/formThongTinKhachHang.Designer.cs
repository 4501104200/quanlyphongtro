namespace QuanLyNhaTroMain
{
    partial class formThongTinKhachHang
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbMaKhachHang = new System.Windows.Forms.Label();
            this.lbNgaySinh = new System.Windows.Forms.Label();
            this.lbGioiTinh = new System.Windows.Forms.Label();
            this.lbCMND = new System.Windows.Forms.Label();
            this.lbQueQuan = new System.Windows.Forms.Label();
            this.lbNgheNghiep = new System.Windows.Forms.Label();
            this.lbGhiChu = new System.Windows.Forms.Label();
            this.lbIDKhachHang = new System.Windows.Forms.Label();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.tbGhiChu = new System.Windows.Forms.TextBox();
            this.tbCMND = new System.Windows.Forms.TextBox();
            this.tbQueQuan = new System.Windows.Forms.TextBox();
            this.tbNgheNghiep = new System.Windows.Forms.TextBox();
            this.cbGioiTinh = new System.Windows.Forms.ComboBox();
            this.ptbAnh34 = new System.Windows.Forms.PictureBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.btLuu = new System.Windows.Forms.Button();
            this.btHuy = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAnh34)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btHuy);
            this.panel1.Controls.Add(this.btLuu);
            this.panel1.Controls.Add(this.txtHoTen);
            this.panel1.Controls.Add(this.ptbAnh34);
            this.panel1.Controls.Add(this.cbGioiTinh);
            this.panel1.Controls.Add(this.tbNgheNghiep);
            this.panel1.Controls.Add(this.tbQueQuan);
            this.panel1.Controls.Add(this.tbCMND);
            this.panel1.Controls.Add(this.tbGhiChu);
            this.panel1.Controls.Add(this.dtpNgaySinh);
            this.panel1.Controls.Add(this.lbIDKhachHang);
            this.panel1.Controls.Add(this.lbGhiChu);
            this.panel1.Controls.Add(this.lbNgheNghiep);
            this.panel1.Controls.Add(this.lbQueQuan);
            this.panel1.Controls.Add(this.lbCMND);
            this.panel1.Controls.Add(this.lbGioiTinh);
            this.panel1.Controls.Add(this.lbNgaySinh);
            this.panel1.Controls.Add(this.lbMaKhachHang);
            this.panel1.Location = new System.Drawing.Point(40, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(857, 453);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(267, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(389, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông tin khách hàng";
            // 
            // lbMaKhachHang
            // 
            this.lbMaKhachHang.AutoSize = true;
            this.lbMaKhachHang.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbMaKhachHang.Location = new System.Drawing.Point(54, 58);
            this.lbMaKhachHang.Name = "lbMaKhachHang";
            this.lbMaKhachHang.Size = new System.Drawing.Size(179, 26);
            this.lbMaKhachHang.TabIndex = 0;
            this.lbMaKhachHang.Text = "Mã khách hàng:";
            // 
            // lbNgaySinh
            // 
            this.lbNgaySinh.AutoSize = true;
            this.lbNgaySinh.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbNgaySinh.Location = new System.Drawing.Point(54, 107);
            this.lbNgaySinh.Name = "lbNgaySinh";
            this.lbNgaySinh.Size = new System.Drawing.Size(121, 26);
            this.lbNgaySinh.TabIndex = 1;
            this.lbNgaySinh.Text = "Ngày sinh:";
            // 
            // lbGioiTinh
            // 
            this.lbGioiTinh.AutoSize = true;
            this.lbGioiTinh.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbGioiTinh.Location = new System.Drawing.Point(54, 159);
            this.lbGioiTinh.Name = "lbGioiTinh";
            this.lbGioiTinh.Size = new System.Drawing.Size(112, 26);
            this.lbGioiTinh.TabIndex = 2;
            this.lbGioiTinh.Text = "Giới tính:";
            // 
            // lbCMND
            // 
            this.lbCMND.AutoSize = true;
            this.lbCMND.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbCMND.Location = new System.Drawing.Point(54, 210);
            this.lbCMND.Name = "lbCMND";
            this.lbCMND.Size = new System.Drawing.Size(125, 26);
            this.lbCMND.TabIndex = 3;
            this.lbCMND.Text = "Số CMND:";
            // 
            // lbQueQuan
            // 
            this.lbQueQuan.AutoSize = true;
            this.lbQueQuan.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbQueQuan.Location = new System.Drawing.Point(54, 263);
            this.lbQueQuan.Name = "lbQueQuan";
            this.lbQueQuan.Size = new System.Drawing.Size(120, 26);
            this.lbQueQuan.TabIndex = 4;
            this.lbQueQuan.Text = "Quê quán:";
            // 
            // lbNgheNghiep
            // 
            this.lbNgheNghiep.AutoSize = true;
            this.lbNgheNghiep.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbNgheNghiep.Location = new System.Drawing.Point(54, 322);
            this.lbNgheNghiep.Name = "lbNgheNghiep";
            this.lbNgheNghiep.Size = new System.Drawing.Size(152, 26);
            this.lbNgheNghiep.TabIndex = 5;
            this.lbNgheNghiep.Text = "Nghề Nghiệp:";
            // 
            // lbGhiChu
            // 
            this.lbGhiChu.AutoSize = true;
            this.lbGhiChu.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbGhiChu.Location = new System.Drawing.Point(54, 383);
            this.lbGhiChu.Name = "lbGhiChu";
            this.lbGhiChu.Size = new System.Drawing.Size(101, 26);
            this.lbGhiChu.TabIndex = 6;
            this.lbGhiChu.Text = "Ghi chú:";
            // 
            // lbIDKhachHang
            // 
            this.lbIDKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIDKhachHang.Location = new System.Drawing.Point(249, 58);
            this.lbIDKhachHang.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbIDKhachHang.Name = "lbIDKhachHang";
            this.lbIDKhachHang.Size = new System.Drawing.Size(178, 33);
            this.lbIDKhachHang.TabIndex = 7;
            this.lbIDKhachHang.Text = "ID";
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinh.Location = new System.Drawing.Point(255, 107);
            this.dtpNgaySinh.Margin = new System.Windows.Forms.Padding(4);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(189, 36);
            this.dtpNgaySinh.TabIndex = 11;
            // 
            // tbGhiChu
            // 
            this.tbGhiChu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbGhiChu.Location = new System.Drawing.Point(255, 376);
            this.tbGhiChu.Margin = new System.Windows.Forms.Padding(4);
            this.tbGhiChu.Name = "tbGhiChu";
            this.tbGhiChu.Size = new System.Drawing.Size(189, 36);
            this.tbGhiChu.TabIndex = 12;
            // 
            // tbCMND
            // 
            this.tbCMND.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCMND.Location = new System.Drawing.Point(255, 210);
            this.tbCMND.Margin = new System.Windows.Forms.Padding(4);
            this.tbCMND.Name = "tbCMND";
            this.tbCMND.Size = new System.Drawing.Size(189, 36);
            this.tbCMND.TabIndex = 13;
            // 
            // tbQueQuan
            // 
            this.tbQueQuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbQueQuan.Location = new System.Drawing.Point(255, 263);
            this.tbQueQuan.Margin = new System.Windows.Forms.Padding(4);
            this.tbQueQuan.Name = "tbQueQuan";
            this.tbQueQuan.Size = new System.Drawing.Size(189, 36);
            this.tbQueQuan.TabIndex = 14;
            // 
            // tbNgheNghiep
            // 
            this.tbNgheNghiep.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNgheNghiep.Location = new System.Drawing.Point(255, 322);
            this.tbNgheNghiep.Margin = new System.Windows.Forms.Padding(4);
            this.tbNgheNghiep.Name = "tbNgheNghiep";
            this.tbNgheNghiep.Size = new System.Drawing.Size(189, 36);
            this.tbNgheNghiep.TabIndex = 15;
            // 
            // cbGioiTinh
            // 
            this.cbGioiTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGioiTinh.FormattingEnabled = true;
            this.cbGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbGioiTinh.Location = new System.Drawing.Point(255, 159);
            this.cbGioiTinh.Margin = new System.Windows.Forms.Padding(4);
            this.cbGioiTinh.Name = "cbGioiTinh";
            this.cbGioiTinh.Size = new System.Drawing.Size(189, 37);
            this.cbGioiTinh.TabIndex = 17;
            // 
            // ptbAnh34
            // 
            this.ptbAnh34.Image = global::QuanLyNhaTroMain.Properties.Resources.occho;
            this.ptbAnh34.Location = new System.Drawing.Point(550, 46);
            this.ptbAnh34.Margin = new System.Windows.Forms.Padding(4);
            this.ptbAnh34.Name = "ptbAnh34";
            this.ptbAnh34.Size = new System.Drawing.Size(234, 200);
            this.ptbAnh34.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbAnh34.TabIndex = 18;
            this.ptbAnh34.TabStop = false;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTen.Location = new System.Drawing.Point(550, 263);
            this.txtHoTen.Margin = new System.Windows.Forms.Padding(4);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(234, 36);
            this.txtHoTen.TabIndex = 19;
            this.txtHoTen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btLuu
            // 
            this.btLuu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btLuu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btLuu.Location = new System.Drawing.Point(550, 336);
            this.btLuu.Name = "btLuu";
            this.btLuu.Size = new System.Drawing.Size(107, 44);
            this.btLuu.TabIndex = 20;
            this.btLuu.Text = "Lưu";
            this.btLuu.UseVisualStyleBackColor = false;
            // 
            // btHuy
            // 
            this.btHuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btHuy.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btHuy.Location = new System.Drawing.Point(677, 336);
            this.btHuy.Name = "btHuy";
            this.btHuy.Size = new System.Drawing.Size(107, 44);
            this.btHuy.TabIndex = 21;
            this.btHuy.Text = "Hủy";
            this.btHuy.UseVisualStyleBackColor = false;
            // 
            // formThongTinKhachHang
            // 
            this.Appearance.BackColor = System.Drawing.Color.SteelBlue;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 543);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "formThongTinKhachHang";
            this.Text = "formThongTinKhachHang";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAnh34)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbGhiChu;
        private System.Windows.Forms.Label lbNgheNghiep;
        private System.Windows.Forms.Label lbQueQuan;
        private System.Windows.Forms.Label lbCMND;
        private System.Windows.Forms.Label lbGioiTinh;
        private System.Windows.Forms.Label lbNgaySinh;
        private System.Windows.Forms.Label lbMaKhachHang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox ptbAnh34;
        private System.Windows.Forms.ComboBox cbGioiTinh;
        private System.Windows.Forms.TextBox tbNgheNghiep;
        private System.Windows.Forms.TextBox tbQueQuan;
        private System.Windows.Forms.TextBox tbCMND;
        private System.Windows.Forms.TextBox tbGhiChu;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.Label lbIDKhachHang;
        private System.Windows.Forms.Button btHuy;
        private System.Windows.Forms.Button btLuu;
        private System.Windows.Forms.TextBox txtHoTen;
    }
}