namespace Bai_2
{
    partial class frmMain
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
            this.lblChieuDai = new System.Windows.Forms.Label();
            this.lblChieuRong = new System.Windows.Forms.Label();
            this.txtChieuDai = new System.Windows.Forms.TextBox();
            this.txtChieuRong = new System.Windows.Forms.TextBox();
            this.txtDienTich = new System.Windows.Forms.TextBox();
            this.lblDienTich = new System.Windows.Forms.Label();
            this.btnTinh = new System.Windows.Forms.Button();
            this.btnTiep = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblChieuDai
            // 
            this.lblChieuDai.AutoSize = true;
            this.lblChieuDai.Location = new System.Drawing.Point(133, 43);
            this.lblChieuDai.Name = "lblChieuDai";
            this.lblChieuDai.Size = new System.Drawing.Size(53, 13);
            this.lblChieuDai.TabIndex = 0;
            this.lblChieuDai.Text = "Chiều Dài";
            // 
            // lblChieuRong
            // 
            this.lblChieuRong.AutoSize = true;
            this.lblChieuRong.Location = new System.Drawing.Point(133, 90);
            this.lblChieuRong.Name = "lblChieuRong";
            this.lblChieuRong.Size = new System.Drawing.Size(63, 13);
            this.lblChieuRong.TabIndex = 1;
            this.lblChieuRong.Text = "Chiều Rộng";
            // 
            // txtChieuDai
            // 
            this.txtChieuDai.Location = new System.Drawing.Point(199, 40);
            this.txtChieuDai.Name = "txtChieuDai";
            this.txtChieuDai.Size = new System.Drawing.Size(100, 20);
            this.txtChieuDai.TabIndex = 2;
            this.txtChieuDai.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtChieuDai_KeyPress);
            // 
            // txtChieuRong
            // 
            this.txtChieuRong.Location = new System.Drawing.Point(199, 87);
            this.txtChieuRong.Name = "txtChieuRong";
            this.txtChieuRong.Size = new System.Drawing.Size(100, 20);
            this.txtChieuRong.TabIndex = 3;
            this.txtChieuRong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtChieuRong_KeyPress);
            // 
            // txtDienTich
            // 
            this.txtDienTich.Location = new System.Drawing.Point(199, 134);
            this.txtDienTich.Name = "txtDienTich";
            this.txtDienTich.ReadOnly = true;
            this.txtDienTich.Size = new System.Drawing.Size(100, 20);
            this.txtDienTich.TabIndex = 4;
            // 
            // lblDienTich
            // 
            this.lblDienTich.AutoSize = true;
            this.lblDienTich.Location = new System.Drawing.Point(133, 137);
            this.lblDienTich.Name = "lblDienTich";
            this.lblDienTich.Size = new System.Drawing.Size(51, 13);
            this.lblDienTich.TabIndex = 5;
            this.lblDienTich.Text = "Diện tích";
            // 
            // btnTinh
            // 
            this.btnTinh.Location = new System.Drawing.Point(78, 190);
            this.btnTinh.Name = "btnTinh";
            this.btnTinh.Size = new System.Drawing.Size(75, 23);
            this.btnTinh.TabIndex = 6;
            this.btnTinh.Text = "Tính";
            this.btnTinh.UseVisualStyleBackColor = true;
            this.btnTinh.Click += new System.EventHandler(this.btnTinh_Click);
            // 
            // btnTiep
            // 
            this.btnTiep.Location = new System.Drawing.Point(179, 190);
            this.btnTiep.Name = "btnTiep";
            this.btnTiep.Size = new System.Drawing.Size(75, 23);
            this.btnTiep.TabIndex = 7;
            this.btnTiep.Text = "Tiếp";
            this.btnTiep.UseVisualStyleBackColor = true;
            this.btnTiep.Click += new System.EventHandler(this.btnTiep_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(278, 190);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 8;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frmMain
            // 
            this.AcceptButton = this.btnTinh;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnThoat;
            this.ClientSize = new System.Drawing.Size(433, 255);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnTiep);
            this.Controls.Add(this.btnTinh);
            this.Controls.Add(this.lblDienTich);
            this.Controls.Add(this.txtDienTich);
            this.Controls.Add(this.txtChieuRong);
            this.Controls.Add(this.txtChieuDai);
            this.Controls.Add(this.lblChieuRong);
            this.Controls.Add(this.lblChieuDai);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chương trình tính diện tích hình chữ nhật";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblChieuDai;
        private System.Windows.Forms.Label lblChieuRong;
        private System.Windows.Forms.TextBox txtChieuDai;
        private System.Windows.Forms.TextBox txtChieuRong;
        private System.Windows.Forms.TextBox txtDienTich;
        private System.Windows.Forms.Label lblDienTich;
        private System.Windows.Forms.Button btnTinh;
        private System.Windows.Forms.Button btnTiep;
        private System.Windows.Forms.Button btnThoat;
    }
}

