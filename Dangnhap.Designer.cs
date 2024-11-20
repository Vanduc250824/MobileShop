namespace MobileShop
{
    partial class Dangnhap
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtTaikhoan = new TextBox();
            txtMatkhau = new TextBox();
            btnDangnhap = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(335, 61);
            label1.Name = "label1";
            label1.Size = new Size(134, 28);
            label1.TabIndex = 0;
            label1.Text = "ĐĂNG NHẬP";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(146, 164);
            label2.Name = "label2";
            label2.Size = new Size(78, 20);
            label2.TabIndex = 1;
            label2.Text = "Tài khoản: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(146, 238);
            label3.Name = "label3";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 2;
            label3.Text = "Mật khẩu:";
            // 
            // txtTaikhoan
            // 
            txtTaikhoan.Location = new Point(230, 161);
            txtTaikhoan.Name = "txtTaikhoan";
            txtTaikhoan.Size = new Size(395, 27);
            txtTaikhoan.TabIndex = 3;
            // 
            // txtMatkhau
            // 
            txtMatkhau.Location = new Point(230, 231);
            txtMatkhau.Name = "txtMatkhau";
            txtMatkhau.PasswordChar = '*';
            txtMatkhau.Size = new Size(395, 27);
            txtMatkhau.TabIndex = 4;
            // 
            // btnDangnhap
            // 
            btnDangnhap.Location = new Point(360, 317);
            btnDangnhap.Name = "btnDangnhap";
            btnDangnhap.Size = new Size(94, 29);
            btnDangnhap.TabIndex = 5;
            btnDangnhap.Text = "Đăng nhập";
            btnDangnhap.UseVisualStyleBackColor = true;
            btnDangnhap.Click += btnDangnhap_Click;
            // 
            // Dangnhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDangnhap);
            Controls.Add(txtMatkhau);
            Controls.Add(txtTaikhoan);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Dangnhap";
            Text = "Đăng nhập";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtTaikhoan;
        private TextBox txtMatkhau;
        private Button btnDangnhap;
    }
}
