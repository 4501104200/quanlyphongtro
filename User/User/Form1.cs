using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace User
{
    public partial class ManHinhChinhUser : Form
    {
        public ManHinhChinhUser()
        {
            InitializeComponent();
        }

        private void btThanhToan_Click(object sender, EventArgs e)
        {
            // tạo khai báo form mới
            HoaDonHangHoa add = new HoaDonHangHoa();
            this.Visible = false;
            // hiển thị form dó lên
            add.ShowDialog();
            this.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // tạo khai báo form mới
            HoaDonHangHoa add = new HoaDonHangHoa();
            this.Visible = false;
            // hiển thị form dó lên
            add.ShowDialog();
            this.Visible = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btDangBaiBanHang_Click(object sender, EventArgs e)
        {
            // tạo khai báo form mới
            DanhMucBanHang add = new DanhMucBanHang();
            this.Visible = false;
            // hiển thị form dó lên
            add.ShowDialog();
            this.Visible = true;
        }
       
    }
}
