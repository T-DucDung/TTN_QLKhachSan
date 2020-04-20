using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan
{
    class DichVu
    {
        private string maDV;
        private string tenDV;
        private decimal gia;

        public DichVu()
        {
            this.maDV = "";
            this.tenDV = "";
            this.gia = 0;
        }
        public DichVu(string maDV, string tenDV, decimal gia)
        {
            this.maDV = maDV;
            this.tenDV = tenDV;
            this.gia = gia;
        }

        public string MaDV { get => maDV; set => maDV = value; }
        public string TenDV { get => tenDV; set => tenDV = value; }
        public decimal Gia { get => gia; set => gia = value; }
    }
}
