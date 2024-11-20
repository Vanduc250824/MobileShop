namespace MobileShop
{
    partial class QuanlySP
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            txtID = new TextBox();
            txtMakh = new TextBox();
            label3 = new Label();
            txtMasp = new TextBox();
            label4 = new Label();
            dateMua = new DateTimePicker();
            btnThem = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            dataGridViewDonhang = new DataGridView();
            label5 = new Label();
            btnTimkiem = new Button();
            btnDong = new Button();
            label6 = new Label();
            txtSoluong = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDonhang).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 101);
            label1.Name = "label1";
            label1.Size = new Size(111, 20);
            label1.TabIndex = 0;
            label1.Text = "ID                     :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(236, 19);
            label2.Name = "label2";
            label2.Size = new Size(317, 41);
            label2.TabIndex = 1;
            label2.Text = "QUẢN LÝ SẢN PHẨM";
            // 
            // txtID
            // 
            txtID.Location = new Point(172, 94);
            txtID.Name = "txtID";
            txtID.Size = new Size(125, 27);
            txtID.TabIndex = 2;
            // 
            // txtMakh
            // 
            txtMakh.Location = new Point(172, 148);
            txtMakh.Name = "txtMakh";
            txtMakh.Size = new Size(125, 27);
            txtMakh.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(54, 155);
            label3.Name = "label3";
            label3.Size = new Size(112, 20);
            label3.TabIndex = 3;
            label3.Text = "Mã khách hàng:";
            // 
            // txtMasp
            // 
            txtMasp.Location = new Point(172, 192);
            txtMasp.Name = "txtMasp";
            txtMasp.Size = new Size(125, 27);
            txtMasp.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(54, 199);
            label4.Name = "label4";
            label4.Size = new Size(101, 20);
            label4.TabIndex = 5;
            label4.Text = "Mã sản phẩm:";
            // 
            // dateMua
            // 
            dateMua.Location = new Point(172, 262);
            dateMua.Name = "dateMua";
            dateMua.Size = new Size(250, 27);
            dateMua.TabIndex = 8;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(515, 424);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 9;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(771, 424);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 10;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(646, 424);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 11;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // dataGridViewDonhang
            // 
            dataGridViewDonhang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDonhang.Location = new Point(515, 63);
            dataGridViewDonhang.Name = "dataGridViewDonhang";
            dataGridViewDonhang.RowHeadersWidth = 51;
            dataGridViewDonhang.Size = new Size(350, 330);
            dataGridViewDonhang.TabIndex = 12;
            dataGridViewDonhang.CellClick += dataGridViewDonhang_CellClick;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(54, 267);
            label5.Name = "label5";
            label5.Size = new Size(80, 20);
            label5.TabIndex = 13;
            label5.Text = "Ngày mua:";
            // 
            // btnTimkiem
            // 
            btnTimkiem.Location = new Point(342, 424);
            btnTimkiem.Name = "btnTimkiem";
            btnTimkiem.Size = new Size(94, 29);
            btnTimkiem.TabIndex = 14;
            btnTimkiem.Text = "Tìm kiếm";
            btnTimkiem.UseVisualStyleBackColor = true;
            btnTimkiem.Click += btnTimkiem_Click;
            // 
            // btnDong
            // 
            btnDong.Location = new Point(54, 424);
            btnDong.Name = "btnDong";
            btnDong.Size = new Size(94, 29);
            btnDong.TabIndex = 15;
            btnDong.Text = "Đóng";
            btnDong.UseVisualStyleBackColor = true;
            btnDong.Click += btnDong_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(59, 318);
            label6.Name = "label6";
            label6.Size = new Size(72, 20);
            label6.TabIndex = 16;
            label6.Text = "Số lượng:";
            // 
            // txtSoluong
            // 
            txtSoluong.Location = new Point(172, 318);
            txtSoluong.Name = "txtSoluong";
            txtSoluong.Size = new Size(125, 27);
            txtSoluong.TabIndex = 17;
            // 
            // QuanlySP
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(887, 484);
            Controls.Add(txtSoluong);
            Controls.Add(label6);
            Controls.Add(btnDong);
            Controls.Add(btnTimkiem);
            Controls.Add(label5);
            Controls.Add(dataGridViewDonhang);
            Controls.Add(btnSua);
            Controls.Add(btnXoa);
            Controls.Add(btnThem);
            Controls.Add(dateMua);
            Controls.Add(txtMasp);
            Controls.Add(label4);
            Controls.Add(txtMakh);
            Controls.Add(label3);
            Controls.Add(txtID);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "QuanlySP";
            Text = "Quản lý";
            ((System.ComponentModel.ISupportInitialize)dataGridViewDonhang).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtID;
        private TextBox txtMakh;
        private Label label3;
        private TextBox txtMasp;
        private Label label4;
        private DateTimePicker dateMua;
        private Button btnThem;
        private Button btnXoa;
        private Button btnSua;
        private DataGridView dataGridViewDonhang;
        private Label label5;
        private Button btnTimkiem;
        private Button btnDong;
        private Label label6;
        private TextBox txtSoluong;
    }
}