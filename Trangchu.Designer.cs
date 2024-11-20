namespace MobileShop
{
    partial class Trangchu
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
            btnDanhmucSP = new Button();
            btnDanhmucKH = new Button();
            btnDonhang = new Button();
            SuspendLayout();
            // 
            // btnDanhmucSP
            // 
            btnDanhmucSP.Location = new Point(57, 32);
            btnDanhmucSP.Name = "btnDanhmucSP";
            btnDanhmucSP.Size = new Size(687, 99);
            btnDanhmucSP.TabIndex = 0;
            btnDanhmucSP.Text = "Danh mục sản phẩm";
            btnDanhmucSP.UseVisualStyleBackColor = true;
            btnDanhmucSP.Click += btnDanhmucSP_Click;
            // 
            // btnDanhmucKH
            // 
            btnDanhmucKH.Location = new Point(57, 148);
            btnDanhmucKH.Name = "btnDanhmucKH";
            btnDanhmucKH.Size = new Size(692, 99);
            btnDanhmucKH.TabIndex = 1;
            btnDanhmucKH.Text = "Danh mục khách hàng";
            btnDanhmucKH.UseVisualStyleBackColor = true;
            btnDanhmucKH.Click += btnDanhmucKH_Click;
            // 
            // btnDonhang
            // 
            btnDonhang.Location = new Point(57, 280);
            btnDonhang.Name = "btnDonhang";
            btnDonhang.Size = new Size(692, 105);
            btnDonhang.TabIndex = 2;
            btnDonhang.Text = "Quản lý đơn hàng";
            btnDonhang.UseVisualStyleBackColor = true;
            btnDonhang.Click += btnDonhang_Click;
            // 
            // Trangchu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDonhang);
            Controls.Add(btnDanhmucKH);
            Controls.Add(btnDanhmucSP);
            Name = "Trangchu";
            Text = "Trang chủ";
            ResumeLayout(false);
        }

        #endregion

        private Button btnDanhmucSP;
        private Button btnDanhmucKH;
        private Button btnDonhang;
    }
}