
namespace QuanLyNhaTroMain
{
    partial class GiaoDienAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GiaoDienAdmin));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.buttonTrangThaiThue = new DevExpress.XtraBars.BarButtonItem();
            this.buttonThuTien = new DevExpress.XtraBars.BarButtonItem();
            this.buttonTraPhong = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonChucNang = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageQuanLy = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.ribbonPageHeThong = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.ribbonQuanLy = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPhongTro = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonThongTin = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.barButtonItem7 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem8 = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.buttonTrangThaiThue,
            this.buttonThuTien,
            this.buttonTraPhong,
            this.barButtonItem4,
            this.barButtonItem1,
            this.barButtonItem2,
            this.barButtonItem3,
            this.barButtonItem5,
            this.barButtonItem6,
            this.barButtonItem7,
            this.barButtonItem8});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 12;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonChucNang,
            this.ribbonQuanLy});
            this.ribbon.Size = new System.Drawing.Size(833, 158);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // buttonTrangThaiThue
            // 
            this.buttonTrangThaiThue.Caption = "Trạng thái thuê";
            this.buttonTrangThaiThue.Id = 1;
            this.buttonTrangThaiThue.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.buttonTrangThaiThue.Name = "buttonTrangThaiThue";
            this.buttonTrangThaiThue.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            // 
            // buttonThuTien
            // 
            this.buttonThuTien.Caption = "Danh sách thu tiền";
            this.buttonThuTien.Id = 2;
            this.buttonThuTien.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.Image")));
            this.buttonThuTien.Name = "buttonThuTien";
            this.buttonThuTien.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            // 
            // buttonTraPhong
            // 
            this.buttonTraPhong.Caption = "Trả phòng";
            this.buttonTraPhong.Id = 3;
            this.buttonTraPhong.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.Image")));
            this.buttonTraPhong.Name = "buttonTraPhong";
            this.buttonTraPhong.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "Thêm người";
            this.barButtonItem4.Id = 4;
            this.barButtonItem4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem4.ImageOptions.Image")));
            this.barButtonItem4.Name = "barButtonItem4";
            this.barButtonItem4.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // ribbonChucNang
            // 
            this.ribbonChucNang.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageQuanLy,
            this.ribbonPageHeThong});
            this.ribbonChucNang.Name = "ribbonChucNang";
            this.ribbonChucNang.Text = "Chức Năng";
            // 
            // ribbonPageQuanLy
            // 
            this.ribbonPageQuanLy.ItemLinks.Add(this.buttonTrangThaiThue);
            this.ribbonPageQuanLy.ItemLinks.Add(this.buttonThuTien);
            this.ribbonPageQuanLy.ItemLinks.Add(this.buttonTraPhong);
            this.ribbonPageQuanLy.ItemLinks.Add(this.barButtonItem4);
            this.ribbonPageQuanLy.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageQuanLy.Name = "ribbonPageQuanLy";
            this.ribbonPageQuanLy.Text = "Chức Năng Quản Lý";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 531);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(833, 24);
            // 
            // ribbonPageHeThong
            // 
            this.ribbonPageHeThong.ItemLinks.Add(this.barButtonItem2);
            this.ribbonPageHeThong.ItemLinks.Add(this.barButtonItem3);
            this.ribbonPageHeThong.Name = "ribbonPageHeThong";
            this.ribbonPageHeThong.Text = "Chức Năng Hệ Thống";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Đăng ký phòng trống";
            this.barButtonItem1.Id = 5;
            this.barButtonItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image1")));
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Danh sách khách trọ";
            this.barButtonItem2.Id = 6;
            this.barButtonItem2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.Image1")));
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Tính tiền phòng";
            this.barButtonItem3.Id = 7;
            this.barButtonItem3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.Image1")));
            this.barButtonItem3.Name = "barButtonItem3";
            this.barButtonItem3.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Location = new System.Drawing.Point(12, 164);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.Size = new System.Drawing.Size(809, 361);
            this.xtraTabControl1.TabIndex = 2;
            // 
            // ribbonQuanLy
            // 
            this.ribbonQuanLy.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPhongTro,
            this.ribbonThongTin});
            this.ribbonQuanLy.Name = "ribbonQuanLy";
            this.ribbonQuanLy.Text = "Quản Lý";
            // 
            // ribbonPhongTro
            // 
            this.ribbonPhongTro.ItemLinks.Add(this.barButtonItem5);
            this.ribbonPhongTro.ItemLinks.Add(this.barButtonItem6);
            this.ribbonPhongTro.Name = "ribbonPhongTro";
            this.ribbonPhongTro.Text = "Phòng Trọ";
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "Danh sách";
            this.barButtonItem5.Id = 8;
            this.barButtonItem5.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem5.ImageOptions.Image")));
            this.barButtonItem5.Name = "barButtonItem5";
            this.barButtonItem5.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // barButtonItem6
            // 
            this.barButtonItem6.Caption = "Loại phòng";
            this.barButtonItem6.Id = 9;
            this.barButtonItem6.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem6.ImageOptions.Image")));
            this.barButtonItem6.Name = "barButtonItem6";
            this.barButtonItem6.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // ribbonThongTin
            // 
            this.ribbonThongTin.ItemLinks.Add(this.barButtonItem7);
            this.ribbonThongTin.ItemLinks.Add(this.barButtonItem8);
            this.ribbonThongTin.Name = "ribbonThongTin";
            this.ribbonThongTin.Text = "Thông tin thêm";
            // 
            // barButtonItem7
            // 
            this.barButtonItem7.Caption = "Thống kê doanh thu";
            this.barButtonItem7.Id = 10;
            this.barButtonItem7.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem7.ImageOptions.Image")));
            this.barButtonItem7.Name = "barButtonItem7";
            this.barButtonItem7.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // barButtonItem8
            // 
            this.barButtonItem8.Caption = "Bảng giá phòng";
            this.barButtonItem8.Id = 11;
            this.barButtonItem8.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem8.ImageOptions.Image")));
            this.barButtonItem8.Name = "barButtonItem8";
            this.barButtonItem8.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // GiaoDienAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 555);
            this.Controls.Add(this.xtraTabControl1);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Name = "GiaoDienAdmin";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "GiaoDienAdmin";
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonChucNang;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageQuanLy;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem buttonTrangThaiThue;
        private DevExpress.XtraBars.BarButtonItem buttonThuTien;
        private DevExpress.XtraBars.BarButtonItem buttonTraPhong;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageHeThong;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.BarButtonItem barButtonItem6;
        private DevExpress.XtraBars.BarButtonItem barButtonItem7;
        private DevExpress.XtraBars.BarButtonItem barButtonItem8;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonQuanLy;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPhongTro;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonThongTin;
    }
}