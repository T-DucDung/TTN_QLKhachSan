using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan
{
    class DoDung : SuDung
    {
        private string donVi;

        public DoDung() : base()
        {
            this.donVi = "";
        }
        public DoDung(string maDD, string tenDD, decimal gia, string donVi) : base()
        {
            this.donVi = donVi;
        }
        public string DonVi { get => donVi; set => donVi = value; }
    }
}
