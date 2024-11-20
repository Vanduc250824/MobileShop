using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileShop
{
    internal class User
    {
        public int KhachhangId { get; set; }   
        public string Ten { get; set; }        
        public string Diachi { get; set; }     
        public string Sdt { get; set; }

        public User() { }

        public User(int khachhangId, string ten, string diachi, string sdt)
        {
            KhachhangId = khachhangId;
            Ten = ten;
            Diachi = diachi;
            Sdt = sdt;
        }

    }
}
