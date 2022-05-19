namespace QuanLyNhaTroMain
{
    partial class formQuanLyPhongTro
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
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btTimKiem = new DevExpress.XtraEditors.SimpleButton();
            this.btRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.lbKhuVuc = new System.Windows.Forms.Label();
            this.btThemPhongMoi = new DevExpress.XtraEditors.SimpleButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtgvDanhSachPhongTro = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDanhSachPhongTro)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btThemPhongMoi);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.btTimKiem);
            this.panel1.Controls.Add(this.btRefresh);
            this.panel1.Controls.Add(this.lbKhuVuc);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1284, 87);
            this.panel1.TabIndex = 1;
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
            // btThemPhongMoi
            // 
            this.btThemPhongMoi.Appearance.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btThemPhongMoi.Appearance.Options.UseFont = true;
            this.btThemPhongMoi.Location = new System.Drawing.Point(353, 19);
            this.btThemPhongMoi.Name = "btThemPhongMoi";
            this.btThemPhongMoi.Size = new System.Drawing.Size(262, 43);
            this.btThemPhongMoi.TabIndex = 6;
            this.btThemPhongMoi.Text = "Thêm Phòng Mới";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dtgvDanhSachPhongTro);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 87);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1284, 701);
            this.panel2.TabIndex = 2;
            // 
            // dtgvDanhSachPhongTro
            // 
            this.dtgvDanhSachPhongTro.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgvDanhSachPhongTro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDanhSachPhongTro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvDanhSachPhongTro.Location = new System.Drawing.Point(0, 0);
            this.dtgvDanhSachPhongTro.Name = "dtgvDanhSachPhongTro";
            this.dtgvDanhSachPhongTro.RowHeadersWidth = 51;
            this.dtgvDanhSachPhongTro.RowTemplate.Height = 24;
            this.dtgvDanhSachPhongTro.Size = new System.Drawing.Size(1284, 701);
            this.dtgvDanhSachPhongTro.TabIndex = 0;
            // 
            // formQuanLyPhongTro
            // 
            this.Appearance.BackColor = System.Drawing.Color.Gray;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 788);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "formQuanLyPhongTro";
            this.Text = "formQuanLyPhongTro";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDanhSachPhongTro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtSearch;
        private DevExpress.XtraEditors.SimpleButton btTimKiem;
        private DevExpress.XtraEditors.SimpleButton btRefresh;
        private System.Windows.Forms.Label lbKhuVuc;
        private DevExpress.XtraEditors.SimpleButton btThemPhongMoi;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dtgvDanhSachPhongTro;
    }
}