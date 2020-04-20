using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan
{
    class DoDung
    {
        private string maDD;
        private string tenDD;
        private decimal gia;
        private string donVi;

        public DoDung()
        {
            this.maDD = "";
            this.tenDD = "";
            this.gia = 0;
            this.donVi = "";
        }
        public DoDung(string maDD, string tenDD, decimal gia, string donVi)
        {
            this.maDD = maDD;
            this.tenDD = tenDD;
            this.gia = gia;
            this.donVi = donVi;
        }

        public string MaDD { get => maDD; set => maDD = value; }
        public string TenDD { get => tenDD; set => tenDD = value; }
        public decimal Gia { get => gia; set => gia = value; }
        public string DonVi { get => donVi; set => donVi = value; }
    }
}
