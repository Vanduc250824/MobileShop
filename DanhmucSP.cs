using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobileShop
{
   
    public partial class DanhmucSP : Form
    {
        private ControllerSP sanpham;
        public DanhmucSP()
        {
            InitializeComponent();
            sanpham = new ControllerSP(new Connection());
            LoadProduct();
        }
        public void LoadProduct()
        {
            List<Sanpham> products = sanpham.GetAll();
            danhsachSP.DataSource = products;
        }
    }
}
