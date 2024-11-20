namespace MobileShop
{
    partial class DanhmucSP
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
            danhsachSP = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)danhsachSP).BeginInit();
            SuspendLayout();
            // 
            // danhsachSP
            // 
            danhsachSP.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            danhsachSP.Location = new Point(81, 122);
            danhsachSP.Name = "danhsachSP";
            danhsachSP.RowHeadersWidth = 51;
            danhsachSP.Size = new Size(631, 253);
            danhsachSP.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(261, 42);
            label1.Name = "label1";
            label1.Size = new Size(286, 38);
            label1.TabIndex = 1;
            label1.Text = "Danh mục sản phẩm";
            // 
            // DanhmucSP
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(danhsachSP);
            Name = "DanhmucSP";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)danhsachSP).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView danhsachSP;
        private Label label1;
    }
}