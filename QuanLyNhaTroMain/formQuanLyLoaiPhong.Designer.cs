namespace QuanLyNhaTroMain
{
    partial class formQuanLyLoaiPhong
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
            this.btThem = new DevExpress.XtraEditors.SimpleButton();
            this.btXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btSua = new DevExpress.XtraEditors.SimpleButton();
            this.btLuu = new DevExpress.XtraEditors.SimpleButton();
            this.btHuy = new DevExpress.XtraEditors.SimpleButton();
            this.dtgvDanhSachLoaiPhong = new System.Windows.Forms.DataGridView();
            this.lbDanhSachLoaiPhong = new System.Windows.Forms.Label();
            this.lbThongTinLoaiPhong = new System.Windows.Forms.Label();
            this.lbChucNang = new System.Windows.Forms.Label();
            this.lbMaLoaiPhong = new System.Windows.Forms.Label();
            this.lbTenLoaiPhong = new System.Windows.Forms.Label();
            this.lbDienTich = new System.Windows.Forms.Label();
            this.lbGia = new System.Windows.Forms.Label();
            this.tbMaLoaiPhong = new System.Windows.Forms.TextBox();
            this.tbTenLoaiPhong = new System.Windows.Forms.TextBox();
            this.tbDienTich = new System.Windows.Forms.TextBox();
            this.tbGia = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDanhSachLoaiPhong)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.dtgvDanhSachLoaiPhong);
            this.panel1.Location = new System.Drawing.Point(15, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(557, 561);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.tbGia);
            this.panel2.Controls.Add(this.tbDienTich);
            this.panel2.Controls.Add(this.tbTenLoaiPhong);
            this.panel2.Controls.Add(this.tbMaLoaiPhong);
            this.panel2.Controls.Add(this.lbGia);
            this.panel2.Controls.Add(this.lbDienTich);
            this.panel2.Controls.Add(this.lbTenLoaiPhong);
            this.panel2.Controls.Add(this.lbMaLoaiPhong);
            this.panel2.Location = new System.Drawing.Point(592, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(534, 255);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.btSua);
            this.panel3.Controls.Add(this.btXoa);
            this.panel3.Controls.Add(this.btThem);
            this.panel3.Location = new System.Drawing.Point(594, 325);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(531, 168);
            this.panel3.TabIndex = 2;
            // 
            // btThem
            // 
            this.btThem.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btThem.Appearance.Options.UseFont = true;
            this.btThem.Location = new System.Drawing.Point(37, 60);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(114, 51);
            this.btThem.TabIndex = 0;
            this.btThem.Text = "Thêm";
            // 
            // btXoa
            // 
            this.btXoa.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btXoa.Appearance.Options.UseFont = true;
            this.btXoa.Location = new System.Drawing.Point(385, 60);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(112, 51);
            this.btXoa.TabIndex = 1;
            this.btXoa.Text = "Xóa";
            // 
            // btSua
            // 
            this.btSua.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btSua.Appearance.Options.UseFont = true;
            this.btSua.Location = new System.Drawing.Point(219, 60);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(119, 51);
            this.btSua.TabIndex = 2;
            this.btSua.Text = "Sửa";
            // 
            // btLuu
            // 
            this.btLuu.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btLuu.Appearance.Options.UseFont = true;
            this.btLuu.Location = new System.Drawing.Point(723, 528);
            this.btLuu.Name = "btLuu";
            this.btLuu.Size = new System.Drawing.Size(132, 49);
            this.btLuu.TabIndex = 3;
            this.btLuu.Text = "Lưu";
            // 
            // btHuy
            // 
            this.btHuy.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btHuy.Appearance.Options.UseFont = true;
            this.btHuy.Location = new System.Drawing.Point(903, 528);
            this.btHuy.Name = "btHuy";
            this.btHuy.Size = new System.Drawing.Size(128, 49);
            this.btHuy.TabIndex = 4;
            this.btHuy.Text = "Hủy";
            // 
            // dtgvDanhSachLoaiPhong
            // 
            this.dtgvDanhSachLoaiPhong.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dtgvDanhSachLoaiPhong.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgvDanhSachLoaiPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDanhSachLoaiPhong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvDanhSachLoaiPhong.Location = new System.Drawing.Point(0, 0);
            this.dtgvDanhSachLoaiPhong.Name = "dtgvDanhSachLoaiPhong";
            this.dtgvDanhSachLoaiPhong.RowHeadersWidth = 51;
            this.dtgvDanhSachLoaiPhong.RowTemplate.Height = 24;
            this.dtgvDanhSachLoaiPhong.Size = new System.Drawing.Size(553, 557);
            this.dtgvDanhSachLoaiPhong.TabIndex = 0;
            // 
            // lbDanhSachLoaiPhong
            // 
            this.lbDanhSachLoaiPhong.AutoSize = true;
            this.lbDanhSachLoaiPhong.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbDanhSachLoaiPhong.Location = new System.Drawing.Point(24, 9);
            this.lbDanhSachLoaiPhong.Name = "lbDanhSachLoaiPhong";
            this.lbDanhSachLoaiPhong.Size = new System.Drawing.Size(231, 26);
            this.lbDanhSachLoaiPhong.TabIndex = 5;
            this.lbDanhSachLoaiPhong.Text = "Danh sách loại phòng";
            // 
            // lbThongTinLoaiPhong
            // 
            this.lbThongTinLoaiPhong.AutoSize = true;
            this.lbThongTinLoaiPhong.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbThongTinLoaiPhong.Location = new System.Drawing.Point(606, 9);
            this.lbThongTinLoaiPhong.Name = "lbThongTinLoaiPhong";
            this.lbThongTinLoaiPhong.Size = new System.Drawing.Size(224, 26);
            this.lbThongTinLoaiPhong.TabIndex = 6;
            this.lbThongTinLoaiPhong.Text = "Thông tin loại phòng";
            // 
            // lbChucNang
            // 
            this.lbChucNang.AutoSize = true;
            this.lbChucNang.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbChucNang.Location = new System.Drawing.Point(606, 308);
            this.lbChucNang.Name = "lbChucNang";
            this.lbChucNang.Size = new System.Drawing.Size(123, 26);
            this.lbChucNang.TabIndex = 7;
            this.lbChucNang.Text = "Chức năng";
            // 
            // lbMaLoaiPhong
            // 
            this.lbMaLoaiPhong.AutoSize = true;
            this.lbMaLoaiPhong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbMaLoaiPhong.Location = new System.Drawing.Point(29, 34);
            this.lbMaLoaiPhong.Name = "lbMaLoaiPhong";
            this.lbMaLoaiPhong.Size = new System.Drawing.Size(135, 23);
            this.lbMaLoaiPhong.TabIndex = 0;
            this.lbMaLoaiPhong.Text = "Mã loại phòng:";
            // 
            // lbTenLoaiPhong
            // 
            this.lbTenLoaiPhong.AutoSize = true;
            this.lbTenLoaiPhong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbTenLoaiPhong.Location = new System.Drawing.Point(33, 87);
            this.lbTenLoaiPhong.Name = "lbTenLoaiPhong";
            this.lbTenLoaiPhong.Size = new System.Drawing.Size(139, 23);
            this.lbTenLoaiPhong.TabIndex = 1;
            this.lbTenLoaiPhong.Text = "Tên loại phòng:";
            // 
            // lbDienTich
            // 
            this.lbDienTich.AutoSize = true;
            this.lbDienTich.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbDienTich.Location = new System.Drawing.Point(35, 144);
            this.lbDienTich.Name = "lbDienTich";
            this.lbDienTich.Size = new System.Drawing.Size(137, 23);
            this.lbDienTich.TabIndex = 2;
            this.lbDienTich.Text = "Diện tích (m2):";
            // 
            // lbGia
            // 
            this.lbGia.AutoSize = true;
            this.lbGia.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbGia.Location = new System.Drawing.Point(35, 192);
            this.lbGia.Name = "lbGia";
            this.lbGia.Size = new System.Drawing.Size(48, 23);
            this.lbGia.TabIndex = 3;
            this.lbGia.Text = "Giá:";
            // 
            // tbMaLoaiPhong
            // 
            this.tbMaLoaiPhong.Enabled = false;
            this.tbMaLoaiPhong.Location = new System.Drawing.Point(212, 34);
            this.tbMaLoaiPhong.Multiline = true;
            this.tbMaLoaiPhong.Name = "tbMaLoaiPhong";
            this.tbMaLoaiPhong.Size = new System.Drawing.Size(252, 32);
            this.tbMaLoaiPhong.TabIndex = 8;
            // 
            // tbTenLoaiPhong
            // 
            this.tbTenLoaiPhong.Enabled = false;
            this.tbTenLoaiPhong.Location = new System.Drawing.Point(212, 87);
            this.tbTenLoaiPhong.Multiline = true;
            this.tbTenLoaiPhong.Name = "tbTenLoaiPhong";
            this.tbTenLoaiPhong.Size = new System.Drawing.Size(252, 32);
            this.tbTenLoaiPhong.TabIndex = 10;
            // 
            // tbDienTich
            // 
            this.tbDienTich.Enabled = false;
            this.tbDienTich.Location = new System.Drawing.Point(212, 144);
            this.tbDienTich.Multiline = true;
            this.tbDienTich.Name = "tbDienTich";
            this.tbDienTich.Size = new System.Drawing.Size(252, 32);
            this.tbDienTich.TabIndex = 11;
            // 
            // tbGia
            // 
            this.tbGia.Enabled = false;
            this.tbGia.Location = new System.Drawing.Point(212, 192);
            this.tbGia.Multiline = true;
            this.tbGia.Name = "tbGia";
            this.tbGia.Size = new System.Drawing.Size(252, 32);
            this.tbGia.TabIndex = 12;
            // 
            // formQuanLyLoaiPhong
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 629);
            this.Controls.Add(this.lbChucNang);
            this.Controls.Add(this.lbThongTinLoaiPhong);
            this.Controls.Add(this.lbDanhSachLoaiPhong);
            this.Controls.Add(this.btLuu);
            this.Controls.Add(this.btHuy);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "formQuanLyLoaiPhong";
            this.Text = "formQuanLyLoaiPhong";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDanhSachLoaiPhong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dtgvDanhSachLoaiPhong;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraEditors.SimpleButton btSua;
        private DevExpress.XtraEditors.SimpleButton btXoa;
        private DevExpress.XtraEditors.SimpleButton btThem;
        private DevExpress.XtraEditors.SimpleButton btLuu;
        private DevExpress.XtraEditors.SimpleButton btHuy;
        private System.Windows.Forms.TextBox tbGia;
        private System.Windows.Forms.TextBox tbDienTich;
        private System.Windows.Forms.TextBox tbTenLoaiPhong;
        private System.Windows.Forms.TextBox tbMaLoaiPhong;
        private System.Windows.Forms.Label lbGia;
        private System.Windows.Forms.Label lbDienTich;
        private System.Windows.Forms.Label lbTenLoaiPhong;
        private System.Windows.Forms.Label lbMaLoaiPhong;
        private System.Windows.Forms.Label lbDanhSachLoaiPhong;
        private System.Windows.Forms.Label lbThongTinLoaiPhong;
        private System.Windows.Forms.Label lbChucNang;
    }
}