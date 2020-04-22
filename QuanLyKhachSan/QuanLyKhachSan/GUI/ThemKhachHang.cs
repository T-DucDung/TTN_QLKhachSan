using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
  
namespace QuanLyKhachSan.GUI
{
    // 2 lựa chọn khi thêm mới kách hàng đặt phòng và khách hàng cũ đến đặt phòng
    public partial class ThemKhachHang : Form
    {
        public ThemKhachHang()
        {
            InitializeComponent();
            this.Name = "Thêm khách hàng";
        }

        public ThemKhachHang(string TenKhachHang, string SDT, string CMT)
        {
            InitializeComponent();
            this.Name = "Đặt phòng";
        }

        private void huyBt_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
