using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLyNhaTroMain
{
    public partial class Main : DevExpress.XtraBars.TabForm
    {
        string tenDangNhap = "", matKhau = "", loaiTaiKhoan = "";
        int iD = 0;
        public Main()
        {
            InitializeComponent();
        }

        public Main(string name, string pass, string type, int id)
        {
            this.tenDangNhap = name;
            this.matKhau = pass;
            this.loaiTaiKhoan = type;
            this.iD = id;
        }

        void OnOuterFormCreating(object sender, OuterFormCreatingEventArgs e)
        {
            Main form = new Main();
            form.TabFormControl.Pages.Clear();
            e.Form = form;
            OpenFormCount++;
        }
        static int OpenFormCount = 1;

        private void buttonDangNhap_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-DD26MM5\MSSQLSERVER01;Initial Catalog=QLPhongTro;Integrated Security=True");
            SqlDataAdapter dataAdapter = new SqlDataAdapter("select * from tblLoaiTaiKhoan where TenDangNhap = N'" + txtTaiKhoan.Text + "' and MatKhau = N'" + txtMatKhau.Text + "'", connection);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            if (dataTable.Rows.Count > 0)
            {
                Main main = new Main(dataTable.Rows[0][0].ToString(), dataTable.Rows[0][1].ToString(), dataTable.Rows[0][2].ToString(), Int32.Parse(dataTable.Rows[0][3].ToString()));
                if (main.loaiTaiKhoan.ToUpper() == "ADMIN")
                {
                    MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    GiaoDienAdmin giaoDienAdmin = new GiaoDienAdmin();
                    giaoDienAdmin.Show();
                }
                if (main.loaiTaiKhoan.ToUpper() == "USER")
                {
                    MessageBox.Show("Đăng nhập thất bại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
