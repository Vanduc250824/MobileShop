using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileShop
{
    internal class Sanpham
    {
        public int SanphamId { get; set; }
        public string TenSP { get; set; }
        public decimal Gia { get; set; }
        public string HangSX { get; set; }

        // Constructor mặc định
        public Sanpham() { }

        // Constructor với tham số
        public Sanpham(string tenSP, decimal gia, string hangSX)
        {
            TenSP = tenSP;
            Gia = gia;
            HangSX = hangSX;
        }
    }
}
