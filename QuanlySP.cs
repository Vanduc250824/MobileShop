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
    public partial class QuanlySP : Form
    {
        private ControllerDonhang controllerDonhang;
        public QuanlySP()
        {
            InitializeComponent();
            controllerDonhang = new ControllerDonhang(new Connection()); // Khởi tạo controllerDonhang với kết nối
            LoadDonhangs(); // Gọi LoadDonhangs sau khi khởi tạo controllerDonhang
        }



        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();

            Trangchu frmTrangchu = new Trangchu();
            frmTrangchu.Show();
            LoadDonhangs();
        }

        private void LoadDonhangs()
        {
            List<Donhang> donhangs = controllerDonhang.GetAllDonhangs();

            // Nếu có dữ liệu, thêm vào DataGridView
            dataGridViewDonhang.DataSource = null;  // Reset DataGridView
            dataGridViewDonhang.DataSource = donhangs;  // Gán nguồn dữ liệu cho DataGridView

            // Đảm bảo hiển thị đúng thông tin trong DataGridView
            dataGridViewDonhang.Columns["Id"].HeaderText = "ID";
            dataGridViewDonhang.Columns["Khachhangid"].HeaderText = "Khách hàng ID";
            dataGridViewDonhang.Columns["Sanphamid"].HeaderText = "Sản phẩm ID";
            dataGridViewDonhang.Columns["Soluong"].HeaderText = "Số lượng";
            dataGridViewDonhang.Columns["Ngaymua"].HeaderText = "Ngày mua";
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                int maKhach = int.Parse(txtMakh.Text);  // Lấy mã khách hàng từ TextBox
                int maHang = int.Parse(txtMasp.Text);   // Lấy mã sản phẩm từ TextBox
                int sl = int.Parse(txtSoluong.Text);    // Lấy số lượng từ TextBox
                DateTime ngayMua = dateMua.Value;      // Lấy ngày mua từ DateTimePicker

                // Gọi phương thức thêm đơn hàng từ ControllerDonhang
                bool success = controllerDonhang.AddDonhang(maKhach, maHang, sl, ngayMua);

                if (success)
                {
                    MessageBox.Show("Thêm đơn hàng thành công!");
                    LoadDonhangs();  // Load lại danh sách đơn hàng sau khi thêm
                }
                else
                {
                    MessageBox.Show("Thêm đơn hàng thất bại!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dataGridViewDonhang.SelectedRows.Count > 0)
            {
                try
                {
                    // Lấy thông tin từ dòng đã chọn trong DataGridView
                    int id = Convert.ToInt32(txtID.Text);  // Lấy ID từ TextBox
                    int maKhach = Convert.ToInt32(txtMakh.Text);  // Mã khách hàng
                    int maHang = Convert.ToInt32(txtMasp.Text);   // Mã sản phẩm
                    int sl = Convert.ToInt32(txtSoluong.Text);    // Số lượng
                    DateTime ngayMua = dateMua.Value;  // Ngày mua từ DateTimePicker

                    // Gọi phương thức sửa đơn hàng trong ControllerDonhang
                    bool success = controllerDonhang.UpdateDonhang(id, maKhach, maHang, sl, ngayMua);

                    if (success)
                    {
                        MessageBox.Show("Sửa đơn hàng thành công!");
                        LoadDonhangs();  // Load lại danh sách đơn hàng sau khi sửa
                    }
                    else
                    {
                        MessageBox.Show("Sửa đơn hàng thất bại!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn đơn hàng để sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dataGridViewDonhang_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewDonhang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Chọn toàn bộ dòng
                dataGridViewDonhang.Rows[e.RowIndex].Selected = true;

                // Lấy thông tin dòng được chọn
                DataGridViewRow selectedRow = dataGridViewDonhang.Rows[e.RowIndex];

                // Gán giá trị từ các ô trong dòng vào các TextBox và DateTimePicker
                txtID.Text = selectedRow.Cells["Id"].Value.ToString();
                txtMakh.Text = selectedRow.Cells["Khachhangid"].Value.ToString();
                txtMasp.Text = selectedRow.Cells["Sanphamid"].Value.ToString();
                txtSoluong.Text = selectedRow.Cells["Soluong"].Value.ToString();
                dateMua.Value = Convert.ToDateTime(selectedRow.Cells["Ngaymua"].Value);
            }
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
        }
    }
}
