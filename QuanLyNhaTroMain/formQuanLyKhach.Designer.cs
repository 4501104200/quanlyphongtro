namespace QuanLyNhaTroMain
{
    partial class formQuanLyKhach
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
            this.lbKhuVuc = new System.Windows.Forms.Label();
            this.btRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.btTimKiem = new DevExpress.XtraEditors.SimpleButton();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lbDanhSachKhachTro = new System.Windows.Forms.Label();
            this.lbThongTinKhachTro = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbMaKhachHang = new System.Windows.Forms.Label();
            this.lbNgaySinh = new System.Windows.Forms.Label();
            this.lbHoTen = new System.Windows.Forms.Label();
            this.lbGioiTinh = new System.Windows.Forms.Label();
            this.lbCMND = new System.Windows.Forms.Label();
            this.lbQueQuan = new System.Windows.Forms.Label();
            this.lbNgheNghiep = new System.Windows.Forms.Label();
            this.lbGhiChu = new System.Windows.Forms.Label();
            this.lbMaKt = new System.Windows.Forms.Label();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.txtHo = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.txtQueQuan = new System.Windows.Forms.TextBox();
            this.txtNgheNghiep = new System.Windows.Forms.TextBox();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.cbGioiTinh = new System.Windows.Forms.ComboBox();
            this.btLuu = new DevExpress.XtraEditors.SimpleButton();
            this.btHuy = new DevExpress.XtraEditors.SimpleButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.btTimKiem);
            this.panel1.Controls.Add(this.btRefresh);
            this.panel1.Controls.Add(this.lbKhuVuc);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1275, 87);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Location = new System.Drawing.Point(0, 119);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(660, 573);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.btHuy);
            this.panel3.Controls.Add(this.btLuu);
            this.panel3.Controls.Add(this.cbGioiTinh);
            this.panel3.Controls.Add(this.txtGhiChu);
            this.panel3.Controls.Add(this.txtNgheNghiep);
            this.panel3.Controls.Add(this.txtQueQuan);
            this.panel3.Controls.Add(this.txtCMND);
            this.panel3.Controls.Add(this.txtTen);
            this.panel3.Controls.Add(this.txtHo);
            this.panel3.Controls.Add(this.dtpNgaySinh);
            this.panel3.Controls.Add(this.lbMaKt);
            this.panel3.Controls.Add(this.lbGhiChu);
            this.panel3.Controls.Add(this.lbNgheNghiep);
            this.panel3.Controls.Add(this.lbQueQuan);
            this.panel3.Controls.Add(this.lbCMND);
            this.panel3.Controls.Add(this.lbGioiTinh);
            this.panel3.Controls.Add(this.lbHoTen);
            this.panel3.Controls.Add(this.lbNgaySinh);
            this.panel3.Controls.Add(this.lbMaKhachHang);
            this.panel3.Location = new System.Drawing.Point(666, 119);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(609, 573);
            this.panel3.TabIndex = 2;
            // 
            // lbKhuVuc
            // 
            this.lbKhuVuc.AutoSize = true;
            this.lbKhuVuc.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbKhuVuc.Location = new System.Drawing.Point(10, 19);
            this.lbKhuVuc.Name = "lbKhuVuc";
            this.lbKhuVuc.Size = new System.Drawing.Size(129, 32);
            this.lbKhuVuc.TabIndex = 0;
            this.lbKhuVuc.Text = "Khu vực:";
            // 
            // btRefresh
            // 
            this.btRefresh.Appearance.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btRefresh.Appearance.Options.UseFont = true;
            this.btRefresh.Location = new System.Drawing.Point(664, 19);
            this.btRefresh.Name = "btRefresh";
            this.btRefresh.Size = new System.Drawing.Size(121, 43);
            this.btRefresh.TabIndex = 1;
            this.btRefresh.Text = "Refresh";
            // 
            // btTimKiem
            // 
            this.btTimKiem.Appearance.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btTimKiem.Appearance.Options.UseFont = true;
            this.btTimKiem.Location = new System.Drawing.Point(1076, 19);
            this.btTimKiem.Name = "btTimKiem";
            this.btTimKiem.Size = new System.Drawing.Size(159, 43);
            this.btTimKiem.TabIndex = 2;
            this.btTimKiem.Text = "Tìm Kiếm";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(792, 19);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(277, 43);
            this.txtSearch.TabIndex = 5;
            // 
            // lbDanhSachKhachTro
            // 
            this.lbDanhSachKhachTro.AutoSize = true;
            this.lbDanhSachKhachTro.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbDanhSachKhachTro.Location = new System.Drawing.Point(198, 100);
            this.lbDanhSachKhachTro.Name = "lbDanhSachKhachTro";
            this.lbDanhSachKhachTro.Size = new System.Drawing.Size(223, 26);
            this.lbDanhSachKhachTro.TabIndex = 0;
            this.lbDanhSachKhachTro.Text = "Danh sách khách trọ";
            // 
            // lbThongTinKhachTro
            // 
            this.lbThongTinKhachTro.AutoSize = true;
            this.lbThongTinKhachTro.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbThongTinKhachTro.Location = new System.Drawing.Point(890, 100);
            this.lbThongTinKhachTro.Name = "lbThongTinKhachTro";
            this.lbThongTinKhachTro.Size = new System.Drawing.Size(216, 26);
            this.lbThongTinKhachTro.TabIndex = 3;
            this.lbThongTinKhachTro.Text = "Thông tin khách trọ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(656, 569);
            this.dataGridView1.TabIndex = 0;
            // 
            // lbMaKhachHang
            // 
            this.lbMaKhachHang.AutoSize = true;
            this.lbMaKhachHang.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbMaKhachHang.Location = new System.Drawing.Point(41, 36);
            this.lbMaKhachHang.Name = "lbMaKhachHang";
            this.lbMaKhachHang.Size = new System.Drawing.Size(179, 26);
            this.lbMaKhachHang.TabIndex = 0;
            this.lbMaKhachHang.Text = "Mã khách hàng:";
            // 
            // lbNgaySinh
            // 
            this.lbNgaySinh.AutoSize = true;
            this.lbNgaySinh.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbNgaySinh.Location = new System.Drawing.Point(45, 83);
            this.lbNgaySinh.Name = "lbNgaySinh";
            this.lbNgaySinh.Size = new System.Drawing.Size(121, 26);
            this.lbNgaySinh.TabIndex = 1;
            this.lbNgaySinh.Text = "Ngày sinh:";
            // 
            // lbHoTen
            // 
            this.lbHoTen.AutoSize = true;
            this.lbHoTen.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbHoTen.Location = new System.Drawing.Point(45, 134);
            this.lbHoTen.Name = "lbHoTen";
            this.lbHoTen.Size = new System.Drawing.Size(89, 26);
            this.lbHoTen.TabIndex = 2;
            this.lbHoTen.Text = "Họ tên:";
            // 
            // lbGioiTinh
            // 
            this.lbGioiTinh.AutoSize = true;
            this.lbGioiTinh.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbGioiTinh.Location = new System.Drawing.Point(45, 184);
            this.lbGioiTinh.Name = "lbGioiTinh";
            this.lbGioiTinh.Size = new System.Drawing.Size(112, 26);
            this.lbGioiTinh.TabIndex = 3;
            this.lbGioiTinh.Text = "Giới tính:";
            // 
            // lbCMND
            // 
            this.lbCMND.AutoSize = true;
            this.lbCMND.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbCMND.Location = new System.Drawing.Point(45, 228);
            this.lbCMND.Name = "lbCMND";
            this.lbCMND.Size = new System.Drawing.Size(125, 26);
            this.lbCMND.TabIndex = 4;
            this.lbCMND.Text = "Số CMND:";
            // 
            // lbQueQuan
            // 
            this.lbQueQuan.AutoSize = true;
            this.lbQueQuan.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbQueQuan.Location = new System.Drawing.Point(46, 283);
            this.lbQueQuan.Name = "lbQueQuan";
            this.lbQueQuan.Size = new System.Drawing.Size(120, 26);
            this.lbQueQuan.TabIndex = 5;
            this.lbQueQuan.Text = "Quê quán:";
            // 
            // lbNgheNghiep
            // 
            this.lbNgheNghiep.AutoSize = true;
            this.lbNgheNghiep.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbNgheNghiep.Location = new System.Drawing.Point(46, 337);
            this.lbNgheNghiep.Name = "lbNgheNghiep";
            this.lbNgheNghiep.Size = new System.Drawing.Size(148, 26);
            this.lbNgheNghiep.TabIndex = 6;
            this.lbNgheNghiep.Text = "Nghề nghiệp:";
            // 
            // lbGhiChu
            // 
            this.lbGhiChu.AutoSize = true;
            this.lbGhiChu.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbGhiChu.Location = new System.Drawing.Point(46, 404);
            this.lbGhiChu.Name = "lbGhiChu";
            this.lbGhiChu.Size = new System.Drawing.Size(101, 26);
            this.lbGhiChu.TabIndex = 7;
            this.lbGhiChu.Text = "Ghi chú:";
            // 
            // lbMaKt
            // 
            this.lbMaKt.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaKt.Location = new System.Drawing.Point(268, 36);
            this.lbMaKt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMaKt.Name = "lbMaKt";
            this.lbMaKt.Size = new System.Drawing.Size(237, 28);
            this.lbMaKt.TabIndex = 21;
            this.lbMaKt.Text = "ID";
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Enabled = false;
            this.dtpNgaySinh.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinh.Location = new System.Drawing.Point(272, 77);
            this.dtpNgaySinh.Margin = new System.Windows.Forms.Padding(4);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(297, 32);
            this.dtpNgaySinh.TabIndex = 22;
            // 
            // txtHo
            // 
            this.txtHo.Enabled = false;
            this.txtHo.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHo.Location = new System.Drawing.Point(272, 131);
            this.txtHo.Margin = new System.Windows.Forms.Padding(4);
            this.txtHo.Name = "txtHo";
            this.txtHo.Size = new System.Drawing.Size(182, 32);
            this.txtHo.TabIndex = 23;
            // 
            // txtTen
            // 
            this.txtTen.Enabled = false;
            this.txtTen.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTen.Location = new System.Drawing.Point(474, 131);
            this.txtTen.Margin = new System.Windows.Forms.Padding(4);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(95, 32);
            this.txtTen.TabIndex = 24;
            // 
            // txtCMND
            // 
            this.txtCMND.Enabled = false;
            this.txtCMND.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCMND.Location = new System.Drawing.Point(272, 225);
            this.txtCMND.Margin = new System.Windows.Forms.Padding(4);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(297, 32);
            this.txtCMND.TabIndex = 15;
            // 
            // txtQueQuan
            // 
            this.txtQueQuan.Enabled = false;
            this.txtQueQuan.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQueQuan.Location = new System.Drawing.Point(272, 280);
            this.txtQueQuan.Margin = new System.Windows.Forms.Padding(4);
            this.txtQueQuan.Name = "txtQueQuan";
            this.txtQueQuan.Size = new System.Drawing.Size(297, 32);
            this.txtQueQuan.TabIndex = 25;
            // 
            // txtNgheNghiep
            // 
            this.txtNgheNghiep.Enabled = false;
            this.txtNgheNghiep.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNgheNghiep.Location = new System.Drawing.Point(272, 334);
            this.txtNgheNghiep.Margin = new System.Windows.Forms.Padding(4);
            this.txtNgheNghiep.Name = "txtNgheNghiep";
            this.txtNgheNghiep.Size = new System.Drawing.Size(297, 32);
            this.txtNgheNghiep.TabIndex = 26;
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Enabled = false;
            this.txtGhiChu.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGhiChu.Location = new System.Drawing.Point(272, 401);
            this.txtGhiChu.Margin = new System.Windows.Forms.Padding(4);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(297, 75);
            this.txtGhiChu.TabIndex = 27;
            // 
            // cbGioiTinh
            // 
            this.cbGioiTinh.FormattingEnabled = true;
            this.cbGioiTinh.Location = new System.Drawing.Point(272, 188);
            this.cbGioiTinh.Name = "cbGioiTinh";
            this.cbGioiTinh.Size = new System.Drawing.Size(297, 24);
            this.cbGioiTinh.TabIndex = 28;
            // 
            // btLuu
            // 
            this.btLuu.Appearance.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btLuu.Appearance.Options.UseFont = true;
            this.btLuu.Location = new System.Drawing.Point(137, 502);
            this.btLuu.Name = "btLuu";
            this.btLuu.Size = new System.Drawing.Size(121, 43);
            this.btLuu.TabIndex = 6;
            this.btLuu.Text = "Lưu";
            // 
            // btHuy
            // 
            this.btHuy.Appearance.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btHuy.Appearance.Options.UseFont = true;
            this.btHuy.Location = new System.Drawing.Point(368, 502);
            this.btHuy.Name = "btHuy";
            this.btHuy.Size = new System.Drawing.Size(121, 43);
            this.btHuy.TabIndex = 29;
            this.btHuy.Text = "Hủy";
            // 
            // formQuanLyKhach
            // 
            this.Appearance.BackColor = System.Drawing.Color.PowderBlue;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1275, 692);
            this.Controls.Add(this.lbThongTinKhachTro);
            this.Controls.Add(this.lbDanhSachKhachTro);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "formQuanLyKhach";
            this.Text = "formQuanLyKhach";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtSearch;
        private DevExpress.XtraEditors.SimpleButton btTimKiem;
        private DevExpress.XtraEditors.SimpleButton btRefresh;
        private System.Windows.Forms.Label lbKhuVuc;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbDanhSachKhachTro;
        private System.Windows.Forms.Label lbThongTinKhachTro;
        private System.Windows.Forms.ComboBox cbGioiTinh;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.TextBox txtNgheNghiep;
        private System.Windows.Forms.TextBox txtQueQuan;
        private System.Windows.Forms.TextBox txtCMND;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtHo;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.Label lbMaKt;
        private System.Windows.Forms.Label lbGhiChu;
        private System.Windows.Forms.Label lbNgheNghiep;
        private System.Windows.Forms.Label lbQueQuan;
        private System.Windows.Forms.Label lbCMND;
        private System.Windows.Forms.Label lbGioiTinh;
        private System.Windows.Forms.Label lbHoTen;
        private System.Windows.Forms.Label lbNgaySinh;
        private System.Windows.Forms.Label lbMaKhachHang;
        private DevExpress.XtraEditors.SimpleButton btHuy;
        private DevExpress.XtraEditors.SimpleButton btLuu;
    }
}