
namespace QuanLyNhaTroMain
{
    partial class Main
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
            bool isDesignMode = DesignMode;
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
            if (--OpenFormCount == 0 && !isDesignMode)
            {
                System.Windows.Forms.Application.Exit();
            }
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.formGiaoDienChinh = new DevExpress.XtraBars.TabFormControl();
            this.tabFormDefaultManager1 = new DevExpress.XtraBars.TabFormDefaultManager();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.tabTrangChu = new DevExpress.XtraBars.TabFormPage();
            this.tabFormContentContainer1 = new DevExpress.XtraBars.TabFormContentContainer();
            this.tabDangNhap = new DevExpress.XtraBars.TabFormPage();
            this.tabFormContentContainer2 = new DevExpress.XtraBars.TabFormContentContainer();
            this.buttonDangNhap = new System.Windows.Forms.Button();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.txtTaiKhoan = new System.Windows.Forms.TextBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.imageEdit1 = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.formGiaoDienChinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabFormDefaultManager1)).BeginInit();
            this.tabFormContentContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // formGiaoDienChinh
            // 
            this.formGiaoDienChinh.AllowMoveTabs = false;
            this.formGiaoDienChinh.AllowMoveTabsToOuterForm = false;
            this.formGiaoDienChinh.AllowTabAnimation = false;
            this.formGiaoDienChinh.Location = new System.Drawing.Point(0, 0);
            this.formGiaoDienChinh.Manager = this.tabFormDefaultManager1;
            this.formGiaoDienChinh.Name = "formGiaoDienChinh";
            this.formGiaoDienChinh.Pages.Add(this.tabTrangChu);
            this.formGiaoDienChinh.Pages.Add(this.tabDangNhap);
            this.formGiaoDienChinh.SelectedPage = this.tabDangNhap;
            this.formGiaoDienChinh.ShowAddPageButton = false;
            this.formGiaoDienChinh.ShowTabCloseButtons = false;
            this.formGiaoDienChinh.Size = new System.Drawing.Size(704, 71);
            this.formGiaoDienChinh.TabForm = this;
            this.formGiaoDienChinh.TabIndex = 0;
            this.formGiaoDienChinh.TabStop = false;
            this.formGiaoDienChinh.OuterFormCreating += new DevExpress.XtraBars.OuterFormCreatingEventHandler(this.OnOuterFormCreating);
            // 
            // tabFormDefaultManager1
            // 
            this.tabFormDefaultManager1.DockControls.Add(this.barDockControlTop);
            this.tabFormDefaultManager1.DockControls.Add(this.barDockControlBottom);
            this.tabFormDefaultManager1.DockControls.Add(this.barDockControlLeft);
            this.tabFormDefaultManager1.DockControls.Add(this.barDockControlRight);
            this.tabFormDefaultManager1.DockingEnabled = false;
            this.tabFormDefaultManager1.Form = this;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 71);
            this.barDockControlTop.Manager = null;
            this.barDockControlTop.Size = new System.Drawing.Size(704, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 524);
            this.barDockControlBottom.Manager = null;
            this.barDockControlBottom.Size = new System.Drawing.Size(704, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 71);
            this.barDockControlLeft.Manager = null;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 453);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(704, 71);
            this.barDockControlRight.Manager = null;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 453);
            // 
            // tabTrangChu
            // 
            this.tabTrangChu.ContentContainer = this.tabFormContentContainer1;
            this.tabTrangChu.Name = "tabTrangChu";
            this.tabTrangChu.Text = "Trang Chủ";
            // 
            // tabFormContentContainer1
            // 
            this.tabFormContentContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabFormContentContainer1.Location = new System.Drawing.Point(0, 71);
            this.tabFormContentContainer1.Name = "tabFormContentContainer1";
            this.tabFormContentContainer1.Size = new System.Drawing.Size(704, 453);
            this.tabFormContentContainer1.TabIndex = 1;
            // 
            // tabDangNhap
            // 
            this.tabDangNhap.ContentContainer = this.tabFormContentContainer2;
            this.tabDangNhap.Name = "tabDangNhap";
            this.tabDangNhap.Text = "Đăng Nhập";
            // 
            // tabFormContentContainer2
            // 
            this.tabFormContentContainer2.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.tabFormContentContainer2.Appearance.Options.UseBackColor = true;
            this.tabFormContentContainer2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabFormContentContainer2.BackgroundImage")));
            this.tabFormContentContainer2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabFormContentContainer2.Controls.Add(this.buttonDangNhap);
            this.tabFormContentContainer2.Controls.Add(this.txtMatKhau);
            this.tabFormContentContainer2.Controls.Add(this.txtTaiKhoan);
            this.tabFormContentContainer2.Controls.Add(this.labelControl2);
            this.tabFormContentContainer2.Controls.Add(this.labelControl1);
            this.tabFormContentContainer2.Controls.Add(this.imageEdit1);
            this.tabFormContentContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabFormContentContainer2.Location = new System.Drawing.Point(0, 71);
            this.tabFormContentContainer2.Name = "tabFormContentContainer2";
            this.tabFormContentContainer2.Size = new System.Drawing.Size(704, 453);
            this.tabFormContentContainer2.TabIndex = 4;
            // 
            // buttonDangNhap
            // 
            this.buttonDangNhap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonDangNhap.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDangNhap.ForeColor = System.Drawing.Color.DarkCyan;
            this.buttonDangNhap.Image = ((System.Drawing.Image)(resources.GetObject("buttonDangNhap.Image")));
            this.buttonDangNhap.Location = new System.Drawing.Point(414, 291);
            this.buttonDangNhap.Name = "buttonDangNhap";
            this.buttonDangNhap.Size = new System.Drawing.Size(187, 52);
            this.buttonDangNhap.TabIndex = 5;
            this.buttonDangNhap.Text = "Đăng Nhập";
            this.buttonDangNhap.UseVisualStyleBackColor = true;
            this.buttonDangNhap.Click += new System.EventHandler(this.buttonDangNhap_Click);
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(414, 245);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(188, 21);
            this.txtMatKhau.TabIndex = 4;
            this.txtMatKhau.UseSystemPasswordChar = true;
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.Location = new System.Drawing.Point(413, 200);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.Size = new System.Drawing.Size(188, 21);
            this.txtTaiKhoan.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(288, 241);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(101, 25);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Mật Khẩu";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(285, 196);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(105, 25);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Tài Khoản";
            // 
            // imageEdit1
            // 
            this.imageEdit1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imageEdit1.EditValue = ((object)(resources.GetObject("imageEdit1.EditValue")));
            this.imageEdit1.Location = new System.Drawing.Point(202, 17);
            this.imageEdit1.MenuManager = this.tabFormDefaultManager1;
            this.imageEdit1.Name = "imageEdit1";
            this.imageEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.imageEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.imageEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.imageEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.imageEdit1.Size = new System.Drawing.Size(484, 150);
            this.imageEdit1.TabIndex = 0;
            this.imageEdit1.TabStop = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 524);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Controls.Add(this.tabFormContentContainer2);
            this.Controls.Add(this.formGiaoDienChinh);
            this.Name = "Main";
            this.TabFormControl = this.formGiaoDienChinh;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.formGiaoDienChinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabFormDefaultManager1)).EndInit();
            this.tabFormContentContainer2.ResumeLayout(false);
            this.tabFormContentContainer2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.TabFormControl formGiaoDienChinh;
        private DevExpress.XtraBars.TabFormDefaultManager tabFormDefaultManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.TabFormContentContainer tabFormContentContainer1;
        private DevExpress.XtraBars.TabFormPage tabTrangChu;
        private DevExpress.XtraBars.TabFormPage tabDangNhap;
        private DevExpress.XtraBars.TabFormContentContainer tabFormContentContainer2;
        private System.Windows.Forms.Button buttonDangNhap;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.TextBox txtTaiKhoan;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.PictureEdit imageEdit1;
    }
}

