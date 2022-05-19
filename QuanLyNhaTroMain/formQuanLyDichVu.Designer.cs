namespace QuanLyNhaTroMain
{
    partial class formQuanLyDichVu
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
            this.lbDanhSachDichVu = new System.Windows.Forms.Label();
            this.lbChucNang = new System.Windows.Forms.Label();
            this.lbThongTinDichVu = new System.Windows.Forms.Label();
            this.dtgvDichVu = new System.Windows.Forms.DataGridView();
            this.lbID = new System.Windows.Forms.Label();
            this.lbTenDichVu = new System.Windows.Forms.Label();
            this.lbDonGia = new System.Windows.Forms.Label();
            this.tbID = new System.Windows.Forms.TextBox();
            this.tbTenDichVu = new System.Windows.Forms.TextBox();
            this.tbDonGia = new System.Windows.Forms.TextBox();
            this.btThem = new DevExpress.XtraEditors.SimpleButton();
            this.btSua = new DevExpress.XtraEditors.SimpleButton();
            this.btXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btLuu = new DevExpress.XtraEditors.SimpleButton();
            this.btHuy = new DevExpress.XtraEditors.SimpleButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDichVu)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.dtgvDichVu);
            this.panel1.Location = new System.Drawing.Point(11, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(578, 591);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.tbDonGia);
            this.panel2.Controls.Add(this.tbTenDichVu);
            this.panel2.Controls.Add(this.tbID);
            this.panel2.Controls.Add(this.lbDonGia);
            this.panel2.Controls.Add(this.lbTenDichVu);
            this.panel2.Controls.Add(this.lbID);
            this.panel2.Location = new System.Drawing.Point(606, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(594, 259);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.btXoa);
            this.panel3.Controls.Add(this.btSua);
            this.panel3.Controls.Add(this.btThem);
            this.panel3.Location = new System.Drawing.Point(610, 314);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(589, 173);
            this.panel3.TabIndex = 2;
            // 
            // lbDanhSachDichVu
            // 
            this.lbDanhSachDichVu.AutoSize = true;
            this.lbDanhSachDichVu.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbDanhSachDichVu.ForeColor = System.Drawing.Color.Green;
            this.lbDanhSachDichVu.Location = new System.Drawing.Point(29, -1);
            this.lbDanhSachDichVu.Name = "lbDanhSachDichVu";
            this.lbDanhSachDichVu.Size = new System.Drawing.Size(237, 32);
            this.lbDanhSachDichVu.TabIndex = 0;
            this.lbDanhSachDichVu.Text = "Danh sách dịch vụ";
            // 
            // lbChucNang
            // 
            this.lbChucNang.AutoSize = true;
            this.lbChucNang.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbChucNang.ForeColor = System.Drawing.Color.Green;
            this.lbChucNang.Location = new System.Drawing.Point(647, 286);
            this.lbChucNang.Name = "lbChucNang";
            this.lbChucNang.Size = new System.Drawing.Size(147, 32);
            this.lbChucNang.TabIndex = 3;
            this.lbChucNang.Text = "Chức năng";
            // 
            // lbThongTinDichVu
            // 
            this.lbThongTinDichVu.AutoSize = true;
            this.lbThongTinDichVu.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbThongTinDichVu.ForeColor = System.Drawing.Color.Green;
            this.lbThongTinDichVu.Location = new System.Drawing.Point(630, -1);
            this.lbThongTinDichVu.Name = "lbThongTinDichVu";
            this.lbThongTinDichVu.Size = new System.Drawing.Size(229, 32);
            this.lbThongTinDichVu.TabIndex = 4;
            this.lbThongTinDichVu.Text = "Thông tin dịch vụ";
            // 
            // dtgvDichVu
            // 
            this.dtgvDichVu.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgvDichVu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgvDichVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDichVu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvDichVu.Location = new System.Drawing.Point(0, 0);
            this.dtgvDichVu.Name = "dtgvDichVu";
            this.dtgvDichVu.RowHeadersWidth = 51;
            this.dtgvDichVu.RowTemplate.Height = 24;
            this.dtgvDichVu.Size = new System.Drawing.Size(574, 587);
            this.dtgvDichVu.TabIndex = 0;
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbID.Location = new System.Drawing.Point(41, 41);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(38, 23);
            this.lbID.TabIndex = 0;
            this.lbID.Text = "ID:";
            // 
            // lbTenDichVu
            // 
            this.lbTenDichVu.AutoSize = true;
            this.lbTenDichVu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbTenDichVu.Location = new System.Drawing.Point(41, 113);
            this.lbTenDichVu.Name = "lbTenDichVu";
            this.lbTenDichVu.Size = new System.Drawing.Size(113, 23);
            this.lbTenDichVu.TabIndex = 1;
            this.lbTenDichVu.Text = "Tên dịch vụ:";
            // 
            // lbDonGia
            // 
            this.lbDonGia.AutoSize = true;
            this.lbDonGia.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbDonGia.Location = new System.Drawing.Point(41, 187);
            this.lbDonGia.Name = "lbDonGia";
            this.lbDonGia.Size = new System.Drawing.Size(82, 23);
            this.lbDonGia.TabIndex = 2;
            this.lbDonGia.Text = "Đơn giá:";
            // 
            // tbID
            // 
            this.tbID.Enabled = false;
            this.tbID.Location = new System.Drawing.Point(181, 32);
            this.tbID.Margin = new System.Windows.Forms.Padding(4);
            this.tbID.Multiline = true;
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(335, 43);
            this.tbID.TabIndex = 3;
            // 
            // tbTenDichVu
            // 
            this.tbTenDichVu.Enabled = false;
            this.tbTenDichVu.Location = new System.Drawing.Point(181, 107);
            this.tbTenDichVu.Margin = new System.Windows.Forms.Padding(4);
            this.tbTenDichVu.Multiline = true;
            this.tbTenDichVu.Name = "tbTenDichVu";
            this.tbTenDichVu.Size = new System.Drawing.Size(335, 40);
            this.tbTenDichVu.TabIndex = 4;
            // 
            // tbDonGia
            // 
            this.tbDonGia.Enabled = false;
            this.tbDonGia.Location = new System.Drawing.Point(181, 181);
            this.tbDonGia.Margin = new System.Windows.Forms.Padding(4);
            this.tbDonGia.Multiline = true;
            this.tbDonGia.Name = "tbDonGia";
            this.tbDonGia.Size = new System.Drawing.Size(335, 40);
            this.tbDonGia.TabIndex = 5;
            // 
            // btThem
            // 
            this.btThem.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btThem.Appearance.Options.UseFont = true;
            this.btThem.Location = new System.Drawing.Point(41, 58);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(126, 53);
            this.btThem.TabIndex = 0;
            this.btThem.Text = "Thêm";
            // 
            // btSua
            // 
            this.btSua.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btSua.Appearance.Options.UseFont = true;
            this.btSua.Location = new System.Drawing.Point(240, 58);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(127, 53);
            this.btSua.TabIndex = 1;
            this.btSua.Text = "Sửa";
            // 
            // btXoa
            // 
            this.btXoa.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btXoa.Appearance.Options.UseFont = true;
            this.btXoa.Location = new System.Drawing.Point(421, 58);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(124, 53);
            this.btXoa.TabIndex = 2;
            this.btXoa.Text = "Xóa";
            // 
            // btLuu
            // 
            this.btLuu.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btLuu.Appearance.Options.UseFont = true;
            this.btLuu.Location = new System.Drawing.Point(708, 519);
            this.btLuu.Name = "btLuu";
            this.btLuu.Size = new System.Drawing.Size(122, 55);
            this.btLuu.TabIndex = 3;
            this.btLuu.Text = "Lưu";
            // 
            // btHuy
            // 
            this.btHuy.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btHuy.Appearance.Options.UseFont = true;
            this.btHuy.Location = new System.Drawing.Point(988, 519);
            this.btHuy.Name = "btHuy";
            this.btHuy.Size = new System.Drawing.Size(125, 55);
            this.btHuy.TabIndex = 4;
            this.btHuy.Text = "Hủy";
            // 
            // formQuanLyDichVu
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1216, 640);
            this.Controls.Add(this.btLuu);
            this.Controls.Add(this.btHuy);
            this.Controls.Add(this.lbThongTinDichVu);
            this.Controls.Add(this.lbChucNang);
            this.Controls.Add(this.lbDanhSachDichVu);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "formQuanLyDichVu";
            this.Text = "formQuanLyDichVu";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDichVu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dtgvDichVu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tbDonGia;
        private System.Windows.Forms.TextBox tbTenDichVu;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label lbDonGia;
        private System.Windows.Forms.Label lbTenDichVu;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraEditors.SimpleButton btXoa;
        private DevExpress.XtraEditors.SimpleButton btSua;
        private DevExpress.XtraEditors.SimpleButton btThem;
        private System.Windows.Forms.Label lbDanhSachDichVu;
        private System.Windows.Forms.Label lbChucNang;
        private System.Windows.Forms.Label lbThongTinDichVu;
        private DevExpress.XtraEditors.SimpleButton btLuu;
        private DevExpress.XtraEditors.SimpleButton btHuy;
    }
}