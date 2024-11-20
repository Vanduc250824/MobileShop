using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobileShop
{
    public partial class DanhmucKH : Form
    {

        private ControllerUser nguoidung;
        public DanhmucKH()
        {
            InitializeComponent();
            nguoidung = new ControllerUser(new Connection());
            loadUser();
        }
        public void loadUser()
        {
            List<User> users = nguoidung.GetAll();
            dsKhachHang.DataSource = users;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();

            Trangchu frmTrangchu = new Trangchu();
            frmTrangchu.Show();
        }

    }
}
