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
    public partial class Trangchu : Form
    {
        

        public Trangchu()
        {
            InitializeComponent();
            
        }

        private void btnDanhmucSP_Click(object sender, EventArgs e)
        {
            DanhmucSP form = new DanhmucSP();

            this.Hide();

            form.ShowDialog(); 
            
        }
        
    }
}
