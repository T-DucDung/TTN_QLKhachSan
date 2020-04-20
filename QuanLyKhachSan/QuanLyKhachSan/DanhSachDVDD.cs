using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan
{
    class DanhSachDVDD
    {
        private string ma;
        private string ten;
        private int soLuong;
        private decimal thanhTien;
        private bool check;

        public DanhSachDVDD(string ma, string ten, int soLuong, decimal thanhTien, bool check)
        {
            this.ma = ma;
            this.ten = ten;
            this.soLuong = soLuong;
            this.thanhTien = thanhTien;
            this.check = check;
        }

        public string Ma { get => ma; set => ma = value; }
        public string Ten { get => ten; set => ten = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public decimal ThanhTien { get => thanhTien; set => thanhTien = value; }
        public bool Check { get => check; set => check = value; }
    }
}
