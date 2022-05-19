
namespace Login
{
    partial class Login
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
            this.Logo = new System.Windows.Forms.PictureBox();
            this.username = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dki = new System.Windows.Forms.LinkLabel();
            this.dnhap = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // Logo
            // 
            this.Logo.BackColor = System.Drawing.Color.Transparent;
            this.Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Logo.Image = global::Login.Properties.Resources.logo;
            this.Logo.Location = new System.Drawing.Point(348, 63);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(379, 121);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Logo.TabIndex = 0;
            this.Logo.TabStop = false;
            this.Logo.Click += new System.EventHandler(this.Logo_Click);
            // 
            // username
            // 
            this.username.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.username.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(241)))), ((int)(((byte)(254)))));
            this.username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.username.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.ForeColor = System.Drawing.Color.Black;
            this.username.Location = new System.Drawing.Point(376, 220);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(351, 29);
            this.username.TabIndex = 1;
            this.username.Text = "Tên đăng nhập:";
            // 
            // password
            // 
            this.password.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(241)))), ((int)(((byte)(254)))));
            this.password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.password.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.ForeColor = System.Drawing.Color.Black;
            this.password.HideSelection = false;
            this.password.Location = new System.Drawing.Point(376, 272);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(351, 29);
            this.password.TabIndex = 2;
            this.password.Text = "Mật khẩu:";
            this.password.UseSystemPasswordChar = true;
            this.password.UseWaitCursor = true;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(376, 249);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 2);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(377, 301);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(350, 2);
            this.label2.TabIndex = 4;
            this.label2.Text = "label2";
            // 
            // dki
            // 
            this.dki.AutoSize = true;
            this.dki.BackColor = System.Drawing.Color.Transparent;
            this.dki.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dki.Location = new System.Drawing.Point(655, 322);
            this.dki.Name = "dki";
            this.dki.Size = new System.Drawing.Size(72, 24);
            this.dki.TabIndex = 6;
            this.dki.TabStop = true;
            this.dki.Text = "đăng kí";
            this.dki.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dnhap
            // 
            this.dnhap.BackColor = System.Drawing.Color.Transparent;
            this.dnhap.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dnhap.ForeColor = System.Drawing.Color.Black;
            this.dnhap.Location = new System.Drawing.Point(422, 379);
            this.dnhap.Name = "dnhap";
            this.dnhap.Size = new System.Drawing.Size(252, 59);
            this.dnhap.TabIndex = 7;
            this.dnhap.Text = "Đăng nhập";
            this.dnhap.UseVisualStyleBackColor = false;
            this.dnhap.Click += new System.EventHandler(this.dnhap_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Login.Properties.Resources.bglogin;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(836, 488);
            this.Controls.Add(this.dnhap);
            this.Controls.Add(this.dki);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Controls.Add(this.Logo);
            this.Name = "Login";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel dki;
        private System.Windows.Forms.Button dnhap;
    }
}

