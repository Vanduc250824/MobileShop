namespace MobileShop
{
    public partial class Dangnhap : Form
    {
        private Connection conn;
        private ControllerAccount account;
        public Dangnhap()
        {
            InitializeComponent();
             account = new ControllerAccount();
        }

        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            string tk = txtTaikhoan.Text.Trim();
            string mk = txtMatkhau.Text.Trim();

            if (string.IsNullOrEmpty(tk) || string.IsNullOrEmpty(mk))  // Kiểm tra nếu tài khoản hoặc mật khẩu rỗng
            {
                MessageBox.Show("Vui lòng nhập đầy đủ tài khoản và mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool checkAccount = account.CheckAccount(tk, mk);

            if (checkAccount)
            {
                MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                
                Trangchu frmTrangchu = new Trangchu();
                // Đóng form Dangnhap sau khi mở Trangchu
                this.Hide();
                // Mở form Trangchu theo chế độ hộp thoại (modal)
                frmTrangchu.ShowDialog();
                
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
