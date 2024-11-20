namespace MobileShop
{
    partial class DanhmucKH
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
            dsKhachHang = new DataGridView();
            btnDong = new Button();
            ((System.ComponentModel.ISupportInitialize)dsKhachHang).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(206, 66);
            label1.Name = "label1";
            label1.Size = new Size(396, 41);
            label1.TabIndex = 0;
            label1.Text = "DANH MỤC KHÁCH HÀNG";
            // 
            // dsKhachHang
            // 
            dsKhachHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dsKhachHang.Location = new Point(106, 126);
            dsKhachHang.Name = "dsKhachHang";
            dsKhachHang.RowHeadersWidth = 51;
            dsKhachHang.Size = new Size(611, 251);
            dsKhachHang.TabIndex = 1;
            // 
            // btnDong
            // 
            btnDong.Location = new Point(622, 394);
            btnDong.Name = "btnDong";
            btnDong.Size = new Size(94, 29);
            btnDong.TabIndex = 2;
            btnDong.Text = "Đóng";
            btnDong.UseVisualStyleBackColor = true;
            btnDong.Click += btnDong_Click;
            // 
            // DanhmucKH
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDong);
            Controls.Add(dsKhachHang);
            Controls.Add(label1);
            Name = "DanhmucKH";
            Text = "Khách hàng";
            ((System.ComponentModel.ISupportInitialize)dsKhachHang).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dsKhachHang;
        private Button btnDong;
    }
}