namespace Bai_1
{
    partial class frmSuDungLabelTextBox
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
            this.lblNhapPassWord = new System.Windows.Forms.Label();
            this.lblHienThi = new System.Windows.Forms.Label();
            this.txtNhapPassWord = new System.Windows.Forms.TextBox();
            this.txtHienThi = new System.Windows.Forms.TextBox();
            this.btnHienThi = new System.Windows.Forms.Button();
            this.btnTiep = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNhapPassWord
            // 
            this.lblNhapPassWord.AutoSize = true;
            this.lblNhapPassWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNhapPassWord.Location = new System.Drawing.Point(31, 33);
            this.lblNhapPassWord.Name = "lblNhapPassWord";
            this.lblNhapPassWord.Size = new System.Drawing.Size(99, 13);
            this.lblNhapPassWord.TabIndex = 0;
            this.lblNhapPassWord.Text = "Nhập Password:";
            // 
            // lblHienThi
            // 
            this.lblHienThi.AutoSize = true;
            this.lblHienThi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHienThi.Location = new System.Drawing.Point(34, 68);
            this.lblHienThi.Name = "lblHienThi";
            this.lblHienThi.Size = new System.Drawing.Size(55, 13);
            this.lblHienThi.TabIndex = 1;
            this.lblHienThi.Text = "Hiển thị:";
            // 
            // txtNhapPassWord
            // 
            this.txtNhapPassWord.Location = new System.Drawing.Point(136, 30);
            this.txtNhapPassWord.Name = "txtNhapPassWord";
            this.txtNhapPassWord.PasswordChar = '#';
            this.txtNhapPassWord.Size = new System.Drawing.Size(237, 20);
            this.txtNhapPassWord.TabIndex = 2;
            this.txtNhapPassWord.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNhapPassWord.TextChanged += new System.EventHandler(this.txtNhapPassWord_TextChanged);
            // 
            // txtHienThi
            // 
            this.txtHienThi.Location = new System.Drawing.Point(136, 65);
            this.txtHienThi.Name = "txtHienThi";
            this.txtHienThi.ReadOnly = true;
            this.txtHienThi.Size = new System.Drawing.Size(237, 20);
            this.txtHienThi.TabIndex = 3;
            this.txtHienThi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtHienThi.TextChanged += new System.EventHandler(this.txtHienThi_TextChanged);
            // 
            // btnHienThi
            // 
            this.btnHienThi.Enabled = false;
            this.btnHienThi.Location = new System.Drawing.Point(59, 122);
            this.btnHienThi.Name = "btnHienThi";
            this.btnHienThi.Size = new System.Drawing.Size(75, 23);
            this.btnHienThi.TabIndex = 4;
            this.btnHienThi.Text = "Hiển thị";
            this.btnHienThi.UseVisualStyleBackColor = true;
            this.btnHienThi.Click += new System.EventHandler(this.btnHienThi_Click);
            // 
            // btnTiep
            // 
            this.btnTiep.Enabled = false;
            this.btnTiep.Location = new System.Drawing.Point(178, 122);
            this.btnTiep.Name = "btnTiep";
            this.btnTiep.Size = new System.Drawing.Size(75, 23);
            this.btnTiep.TabIndex = 5;
            this.btnTiep.Text = "Tiếp";
            this.btnTiep.UseVisualStyleBackColor = true;
            this.btnTiep.Click += new System.EventHandler(this.btnTiep_Click);
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(297, 122);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(75, 23);
            this.btnDong.TabIndex = 6;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // frmSuDungLabelTextBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 178);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnTiep);
            this.Controls.Add(this.btnHienThi);
            this.Controls.Add(this.txtHienThi);
            this.Controls.Add(this.txtNhapPassWord);
            this.Controls.Add(this.lblHienThi);
            this.Controls.Add(this.lblNhapPassWord);
            this.Name = "frmSuDungLabelTextBox";
            this.Text = "Sử dụng Label & Textbox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNhapPassWord;
        private System.Windows.Forms.Label lblHienThi;
        private System.Windows.Forms.TextBox txtNhapPassWord;
        private System.Windows.Forms.TextBox txtHienThi;
        private System.Windows.Forms.Button btnHienThi;
        private System.Windows.Forms.Button btnTiep;
        private System.Windows.Forms.Button btnDong;
    }
}

