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
            controllerDonhang = new ControllerDonhang(new Connection());
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
                int khachhangid = int.Parse(txtMakh.Text);
                int sanphamid = int.Parse(txtMasp.Text);
                int soluong = int.Parse(txtSoluong.Text);
                DateTime ngaymua = dateMua.Value;

                bool result = controllerDonhang.AddDonhang(khachhangid, sanphamid, soluong, ngaymua);
                if (result)
                {
                    MessageBox.Show("Thêm đơn hàng thành công!");
                    LoadDonhangs(); // Cập nhật danh sách sau khi thêm
                }
                else
                {
                    MessageBox.Show("Thêm đơn hàng thất bại.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(txtID.Text);
                int soluong = int.Parse(txtSoluong.Text);
                DateTime ngaymua = dateMua.Value;

                bool result = controllerDonhang.UpdateDonhang(id, soluong, ngaymua);
                if (result)
                {
                    MessageBox.Show("Cập nhật đơn hàng thành công!");
                    LoadDonhangs(); // Cập nhật danh sách sau khi sửa
                }
                else
                {
                    MessageBox.Show("Cập nhật đơn hàng thất bại.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
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
            try
            {
                int id = int.Parse(txtID.Text);

                List<Donhang> donhangs = controllerDonhang.SearchDonhang(id);
                if (donhangs.Count > 0)
                {
                    dataGridViewDonhang.DataSource = null;
                    dataGridViewDonhang.DataSource = donhangs; // Hiển thị kết quả tìm kiếm
                }
                else
                {
                    MessageBox.Show("Không tìm thấy đơn hàng khớp với ID.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(txtID.Text);

                DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa đơn hàng này?", "Xác nhận", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    bool result = controllerDonhang.DeleteDonhang(id);
                    if (result)
                    {
                        MessageBox.Show("Xóa đơn hàng thành công!");
                        LoadDonhangs(); // Cập nhật danh sách sau khi xóa
                    }
                    else
                    {
                        MessageBox.Show("Xóa đơn hàng thất bại.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
    }
}
