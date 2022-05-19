namespace QuanLyNhaTroMain
{
    partial class formDkyPhongTrong
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lstLoaiPhong = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel4 = new System.Windows.Forms.Panel();
            this.btHuy = new System.Windows.Forms.Button();
            this.lbThongTinDangKyPhong = new System.Windows.Forms.Label();
            this.lbThongTinKhach = new System.Windows.Forms.Label();
            this.lbChonPhongThue = new System.Windows.Forms.Label();
            this.lbThongTinPhong = new System.Windows.Forms.Label();
            this.btNhapLai = new System.Windows.Forms.Button();
            this.btGui = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lbHoVaTen = new System.Windows.Forms.Label();
            this.lbNgaySinh = new System.Windows.Forms.Label();
            this.lbGioiTinh = new System.Windows.Forms.Label();
            this.lbCMND = new System.Windows.Forms.Label();
            this.lbQueQuan = new System.Windows.Forms.Label();
            this.lbNgheNghiep = new System.Windows.Forms.Label();
            this.lbKhuVuc = new System.Windows.Forms.Label();
            this.lbLoai = new System.Windows.Forms.Label();
            this.lbThongTinPhongKhuVuc = new System.Windows.Forms.Label();
            this.tbHo = new System.Windows.Forms.TextBox();
            this.tbTen = new System.Windows.Forms.TextBox();
            this.tbCMND = new System.Windows.Forms.TextBox();
            this.tbQueQuan = new System.Windows.Forms.TextBox();
            this.tbNgheNghiep = new System.Windows.Forms.TextBox();
            this.tbLoai = new System.Windows.Forms.TextBox();
            this.tbKhuVuc = new System.Windows.Forms.TextBox();
            this.cbGioiTinh = new System.Windows.Forms.ComboBox();
            this.cbKhuVuc = new System.Windows.Forms.ComboBox();
            this.dtiNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btGui);
            this.panel1.Controls.Add(this.btNhapLai);
            this.panel1.Controls.Add(this.lbChonPhongThue);
            this.panel1.Controls.Add(this.lbThongTinKhach);
            this.panel1.Controls.Add(this.btHuy);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(9, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1032, 568);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.dtiNgaySinh);
            this.panel2.Controls.Add(this.cbGioiTinh);
            this.panel2.Controls.Add(this.tbNgheNghiep);
            this.panel2.Controls.Add(this.tbQueQuan);
            this.panel2.Controls.Add(this.tbCMND);
            this.panel2.Controls.Add(this.tbTen);
            this.panel2.Controls.Add(this.tbHo);
            this.panel2.Controls.Add(this.lbNgheNghiep);
            this.panel2.Controls.Add(this.lbQueQuan);
            this.panel2.Controls.Add(this.lbCMND);
            this.panel2.Controls.Add(this.lbGioiTinh);
            this.panel2.Controls.Add(this.lbNgaySinh);
            this.panel2.Controls.Add(this.lbHoVaTen);
            this.panel2.Location = new System.Drawing.Point(44, 87);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(318, 364);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.cbKhuVuc);
            this.panel3.Controls.Add(this.lbKhuVuc);
            this.panel3.Controls.Add(this.lbThongTinPhong);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.lstLoaiPhong);
            this.panel3.Location = new System.Drawing.Point(383, 88);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(612, 362);
            this.panel3.TabIndex = 1;
            // 
            // lstLoaiPhong
            // 
            this.lstLoaiPhong.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lstLoaiPhong.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstLoaiPhong.FullRowSelect = true;
            this.lstLoaiPhong.HideSelection = false;
            this.lstLoaiPhong.Location = new System.Drawing.Point(22, 125);
            this.lstLoaiPhong.Margin = new System.Windows.Forms.Padding(4);
            this.lstLoaiPhong.MultiSelect = false;
            this.lstLoaiPhong.Name = "lstLoaiPhong";
            this.lstLoaiPhong.Size = new System.Drawing.Size(329, 207);
            this.lstLoaiPhong.TabIndex = 4;
            this.lstLoaiPhong.UseCompatibleStateImageBehavior = false;
            this.lstLoaiPhong.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã";
            this.columnHeader1.Width = 40;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Loại phòng";
            this.columnHeader2.Width = 102;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Diện tích";
            this.columnHeader3.Width = 87;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Đơn giá";
            this.columnHeader4.Width = 81;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.tbKhuVuc);
            this.panel4.Controls.Add(this.tbLoai);
            this.panel4.Controls.Add(this.lbLoai);
            this.panel4.Controls.Add(this.lbThongTinPhongKhuVuc);
            this.panel4.Location = new System.Drawing.Point(373, 125);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(220, 206);
            this.panel4.TabIndex = 5;
            // 
            // btHuy
            // 
            this.btHuy.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btHuy.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btHuy.Location = new System.Drawing.Point(632, 515);
            this.btHuy.Name = "btHuy";
            this.btHuy.Size = new System.Drawing.Size(78, 35);
            this.btHuy.TabIndex = 2;
            this.btHuy.Text = "Hủy";
            this.btHuy.UseVisualStyleBackColor = false;
            // 
            // lbThongTinDangKyPhong
            // 
            this.lbThongTinDangKyPhong.AutoSize = true;
            this.lbThongTinDangKyPhong.Font = new System.Drawing.Font("Times New Roman", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbThongTinDangKyPhong.Location = new System.Drawing.Point(307, 9);
            this.lbThongTinDangKyPhong.Name = "lbThongTinDangKyPhong";
            this.lbThongTinDangKyPhong.Size = new System.Drawing.Size(436, 46);
            this.lbThongTinDangKyPhong.TabIndex = 5;
            this.lbThongTinDangKyPhong.Text = "Thông tin đăng ký phòng";
            // 
            // lbThongTinKhach
            // 
            this.lbThongTinKhach.AutoSize = true;
            this.lbThongTinKhach.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbThongTinKhach.Location = new System.Drawing.Point(115, 71);
            this.lbThongTinKhach.Name = "lbThongTinKhach";
            this.lbThongTinKhach.Size = new System.Drawing.Size(179, 26);
            this.lbThongTinKhach.TabIndex = 0;
            this.lbThongTinKhach.Text = "Thông tin khách";
            // 
            // lbChonPhongThue
            // 
            this.lbChonPhongThue.AutoSize = true;
            this.lbChonPhongThue.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbChonPhongThue.Location = new System.Drawing.Point(571, 71);
            this.lbChonPhongThue.Name = "lbChonPhongThue";
            this.lbChonPhongThue.Size = new System.Drawing.Size(273, 26);
            this.lbChonPhongThue.TabIndex = 5;
            this.lbChonPhongThue.Text = "Chọn loại phòng cần thuê";
            // 
            // lbThongTinPhong
            // 
            this.lbThongTinPhong.AutoSize = true;
            this.lbThongTinPhong.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbThongTinPhong.Location = new System.Drawing.Point(391, 106);
            this.lbThongTinPhong.Name = "lbThongTinPhong";
            this.lbThongTinPhong.Size = new System.Drawing.Size(180, 26);
            this.lbThongTinPhong.TabIndex = 6;
            this.lbThongTinPhong.Text = "Thông tin phòng";
            // 
            // btNhapLai
            // 
            this.btNhapLai.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btNhapLai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btNhapLai.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btNhapLai.Location = new System.Drawing.Point(465, 515);
            this.btNhapLai.Name = "btNhapLai";
            this.btNhapLai.Size = new System.Drawing.Size(98, 35);
            this.btNhapLai.TabIndex = 6;
            this.btNhapLai.Text = "Nhập lại";
            this.btNhapLai.UseVisualStyleBackColor = false;
            // 
            // btGui
            // 
            this.btGui.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btGui.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btGui.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btGui.Location = new System.Drawing.Point(304, 515);
            this.btGui.Name = "btGui";
            this.btGui.Size = new System.Drawing.Size(78, 35);
            this.btGui.TabIndex = 7;
            this.btGui.Text = "Gửi";
            this.btGui.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(293, 475);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(439, 23);
            this.label5.TabIndex = 8;
            this.label5.Text = "Xin quý khách kiểm tra kỹ thông tin trước khi gửi !";
            // 
            // lbHoVaTen
            // 
            this.lbHoVaTen.AutoSize = true;
            this.lbHoVaTen.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbHoVaTen.Location = new System.Drawing.Point(5, 37);
            this.lbHoVaTen.Name = "lbHoVaTen";
            this.lbHoVaTen.Size = new System.Drawing.Size(98, 23);
            this.lbHoVaTen.TabIndex = 0;
            this.lbHoVaTen.Text = "Họ và tên:";
            // 
            // lbNgaySinh
            // 
            this.lbNgaySinh.AutoSize = true;
            this.lbNgaySinh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lbNgaySinh.Location = new System.Drawing.Point(5, 92);
            this.lbNgaySinh.Name = "lbNgaySinh";
            this.lbNgaySinh.Size = new System.Drawing.Size(99, 23);
            this.lbNgaySinh.TabIndex = 1;
            this.lbNgaySinh.Text = "Ngày sinh:";
            // 
            // lbGioiTinh
            // 
            this.lbGioiTinh.AutoSize = true;
            this.lbGioiTinh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lbGioiTinh.Location = new System.Drawing.Point(5, 151);
            this.lbGioiTinh.Name = "lbGioiTinh";
            this.lbGioiTinh.Size = new System.Drawing.Size(92, 23);
            this.lbGioiTinh.TabIndex = 2;
            this.lbGioiTinh.Text = "Giới tính:";
            // 
            // lbCMND
            // 
            this.lbCMND.AutoSize = true;
            this.lbCMND.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lbCMND.Location = new System.Drawing.Point(5, 203);
            this.lbCMND.Name = "lbCMND";
            this.lbCMND.Size = new System.Drawing.Size(77, 23);
            this.lbCMND.TabIndex = 3;
            this.lbCMND.Text = "CMND:";
            // 
            // lbQueQuan
            // 
            this.lbQueQuan.AutoSize = true;
            this.lbQueQuan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lbQueQuan.Location = new System.Drawing.Point(5, 251);
            this.lbQueQuan.Name = "lbQueQuan";
            this.lbQueQuan.Size = new System.Drawing.Size(97, 23);
            this.lbQueQuan.TabIndex = 4;
            this.lbQueQuan.Text = "Quê quán:";
            // 
            // lbNgheNghiep
            // 
            this.lbNgheNghiep.AutoSize = true;
            this.lbNgheNghiep.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lbNgheNghiep.Location = new System.Drawing.Point(5, 304);
            this.lbNgheNghiep.Name = "lbNgheNghiep";
            this.lbNgheNghiep.Size = new System.Drawing.Size(121, 23);
            this.lbNgheNghiep.TabIndex = 5;
            this.lbNgheNghiep.Text = "Nghề nghiệp:";
            // 
            // lbKhuVuc
            // 
            this.lbKhuVuc.AutoSize = true;
            this.lbKhuVuc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lbKhuVuc.Location = new System.Drawing.Point(31, 55);
            this.lbKhuVuc.Name = "lbKhuVuc";
            this.lbKhuVuc.Size = new System.Drawing.Size(87, 23);
            this.lbKhuVuc.TabIndex = 6;
            this.lbKhuVuc.Text = "Khu vực:";
            // 
            // lbLoai
            // 
            this.lbLoai.AutoSize = true;
            this.lbLoai.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lbLoai.Location = new System.Drawing.Point(18, 52);
            this.lbLoai.Name = "lbLoai";
            this.lbLoai.Size = new System.Drawing.Size(55, 23);
            this.lbLoai.TabIndex = 7;
            this.lbLoai.Text = "Loại:";
            // 
            // lbThongTinPhongKhuVuc
            // 
            this.lbThongTinPhongKhuVuc.AutoSize = true;
            this.lbThongTinPhongKhuVuc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lbThongTinPhongKhuVuc.Location = new System.Drawing.Point(18, 123);
            this.lbThongTinPhongKhuVuc.Name = "lbThongTinPhongKhuVuc";
            this.lbThongTinPhongKhuVuc.Size = new System.Drawing.Size(87, 23);
            this.lbThongTinPhongKhuVuc.TabIndex = 8;
            this.lbThongTinPhongKhuVuc.Text = "Khu vực:";
            // 
            // tbHo
            // 
            this.tbHo.Location = new System.Drawing.Point(132, 40);
            this.tbHo.Name = "tbHo";
            this.tbHo.Size = new System.Drawing.Size(88, 23);
            this.tbHo.TabIndex = 6;
            // 
            // tbTen
            // 
            this.tbTen.Location = new System.Drawing.Point(226, 40);
            this.tbTen.Name = "tbTen";
            this.tbTen.Size = new System.Drawing.Size(68, 23);
            this.tbTen.TabIndex = 7;
            // 
            // tbCMND
            // 
            this.tbCMND.Location = new System.Drawing.Point(132, 205);
            this.tbCMND.Name = "tbCMND";
            this.tbCMND.Size = new System.Drawing.Size(162, 23);
            this.tbCMND.TabIndex = 8;
            // 
            // tbQueQuan
            // 
            this.tbQueQuan.Location = new System.Drawing.Point(132, 251);
            this.tbQueQuan.Name = "tbQueQuan";
            this.tbQueQuan.Size = new System.Drawing.Size(162, 23);
            this.tbQueQuan.TabIndex = 9;
            // 
            // tbNgheNghiep
            // 
            this.tbNgheNghiep.Location = new System.Drawing.Point(132, 304);
            this.tbNgheNghiep.Name = "tbNgheNghiep";
            this.tbNgheNghiep.Size = new System.Drawing.Size(162, 23);
            this.tbNgheNghiep.TabIndex = 10;
            // 
            // tbLoai
            // 
            this.tbLoai.Location = new System.Drawing.Point(101, 54);
            this.tbLoai.Name = "tbLoai";
            this.tbLoai.Size = new System.Drawing.Size(112, 23);
            this.tbLoai.TabIndex = 7;
            // 
            // tbKhuVuc
            // 
            this.tbKhuVuc.Location = new System.Drawing.Point(101, 123);
            this.tbKhuVuc.Name = "tbKhuVuc";
            this.tbKhuVuc.Size = new System.Drawing.Size(112, 23);
            this.tbKhuVuc.TabIndex = 9;
            // 
            // cbGioiTinh
            // 
            this.cbGioiTinh.FormattingEnabled = true;
            this.cbGioiTinh.Location = new System.Drawing.Point(132, 151);
            this.cbGioiTinh.Name = "cbGioiTinh";
            this.cbGioiTinh.Size = new System.Drawing.Size(162, 24);
            this.cbGioiTinh.TabIndex = 11;
            // 
            // cbKhuVuc
            // 
            this.cbKhuVuc.FormattingEnabled = true;
            this.cbKhuVuc.Location = new System.Drawing.Point(124, 54);
            this.cbKhuVuc.Name = "cbKhuVuc";
            this.cbKhuVuc.Size = new System.Drawing.Size(223, 24);
            this.cbKhuVuc.TabIndex = 12;
            // 
            // dtiNgaySinh
            // 
            this.dtiNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtiNgaySinh.Location = new System.Drawing.Point(132, 92);
            this.dtiNgaySinh.Margin = new System.Windows.Forms.Padding(4);
            this.dtiNgaySinh.Name = "dtiNgaySinh";
            this.dtiNgaySinh.Size = new System.Drawing.Size(162, 23);
            this.dtiNgaySinh.TabIndex = 13;
            // 
            // formDkyPhongTrong
            // 
            this.Appearance.BackColor = System.Drawing.SystemColors.Info;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 619);
            this.Controls.Add(this.lbThongTinDangKyPhong);
            this.Controls.Add(this.panel1);
            this.Name = "formDkyPhongTrong";
            this.Text = "formDkyPhongTrong";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btGui;
        private System.Windows.Forms.Button btNhapLai;
        private System.Windows.Forms.Label lbChonPhongThue;
        private System.Windows.Forms.Label lbThongTinKhach;
        private System.Windows.Forms.Button btHuy;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cbKhuVuc;
        private System.Windows.Forms.Label lbKhuVuc;
        private System.Windows.Forms.Label lbThongTinPhong;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox tbKhuVuc;
        private System.Windows.Forms.TextBox tbLoai;
        private System.Windows.Forms.Label lbLoai;
        private System.Windows.Forms.Label lbThongTinPhongKhuVuc;
        private System.Windows.Forms.ListView lstLoaiPhong;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker dtiNgaySinh;
        private System.Windows.Forms.ComboBox cbGioiTinh;
        private System.Windows.Forms.TextBox tbNgheNghiep;
        private System.Windows.Forms.TextBox tbQueQuan;
        private System.Windows.Forms.TextBox tbCMND;
        private System.Windows.Forms.TextBox tbTen;
        private System.Windows.Forms.TextBox tbHo;
        private System.Windows.Forms.Label lbNgheNghiep;
        private System.Windows.Forms.Label lbQueQuan;
        private System.Windows.Forms.Label lbCMND;
        private System.Windows.Forms.Label lbGioiTinh;
        private System.Windows.Forms.Label lbNgaySinh;
        private System.Windows.Forms.Label lbHoVaTen;
        private System.Windows.Forms.Label lbThongTinDangKyPhong;
    }
}