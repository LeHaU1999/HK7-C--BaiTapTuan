namespace Bai_5
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
            this.pnTop = new System.Windows.Forms.Panel();
            this.pnBottom = new System.Windows.Forms.Panel();
            this.lblNhapTen = new System.Windows.Forms.Label();
            this.txtNhapTen = new System.Windows.Forms.TextBox();
            this.grbColor = new System.Windows.Forms.GroupBox();
            this.grbFont = new System.Windows.Forms.GroupBox();
            this.lblLapTrinhBoi = new System.Windows.Forms.Label();
            this.lblLapTrinh = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.radRed = new System.Windows.Forms.RadioButton();
            this.radGreen = new System.Windows.Forms.RadioButton();
            this.radBlue = new System.Windows.Forms.RadioButton();
            this.radBlack = new System.Windows.Forms.RadioButton();
            this.chkBold = new System.Windows.Forms.CheckBox();
            this.chkItalic = new System.Windows.Forms.CheckBox();
            this.chkUnderline = new System.Windows.Forms.CheckBox();
            this.pnCenter = new System.Windows.Forms.Panel();
            this.pnLapTrinh = new System.Windows.Forms.Panel();
            this.pnTop.SuspendLayout();
            this.pnBottom.SuspendLayout();
            this.grbColor.SuspendLayout();
            this.grbFont.SuspendLayout();
            this.pnCenter.SuspendLayout();
            this.pnLapTrinh.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnTop
            // 
            this.pnTop.Controls.Add(this.txtNhapTen);
            this.pnTop.Controls.Add(this.lblNhapTen);
            this.pnTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTop.Location = new System.Drawing.Point(0, 0);
            this.pnTop.Name = "pnTop";
            this.pnTop.Size = new System.Drawing.Size(439, 39);
            this.pnTop.TabIndex = 0;
            // 
            // pnBottom
            // 
            this.pnBottom.Controls.Add(this.pnLapTrinh);
            this.pnBottom.Controls.Add(this.btnThoat);
            this.pnBottom.Controls.Add(this.lblLapTrinhBoi);
            this.pnBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnBottom.Location = new System.Drawing.Point(0, 275);
            this.pnBottom.Name = "pnBottom";
            this.pnBottom.Size = new System.Drawing.Size(439, 60);
            this.pnBottom.TabIndex = 1;
            // 
            // lblNhapTen
            // 
            this.lblNhapTen.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblNhapTen.AutoSize = true;
            this.lblNhapTen.BackColor = System.Drawing.Color.Black;
            this.lblNhapTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNhapTen.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblNhapTen.Location = new System.Drawing.Point(3, 11);
            this.lblNhapTen.Name = "lblNhapTen";
            this.lblNhapTen.Size = new System.Drawing.Size(79, 17);
            this.lblNhapTen.TabIndex = 0;
            this.lblNhapTen.Text = "Nhập tên:";
            // 
            // txtNhapTen
            // 
            this.txtNhapTen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNhapTen.ForeColor = System.Drawing.Color.Red;
            this.txtNhapTen.Location = new System.Drawing.Point(88, 11);
            this.txtNhapTen.Name = "txtNhapTen";
            this.txtNhapTen.Size = new System.Drawing.Size(343, 20);
            this.txtNhapTen.TabIndex = 1;
            this.txtNhapTen.TextChanged += new System.EventHandler(this.txtNhapTen_TextChanged);
            // 
            // grbColor
            // 
            this.grbColor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.grbColor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.grbColor.BackColor = System.Drawing.Color.LightSkyBlue;
            this.grbColor.Controls.Add(this.radBlack);
            this.grbColor.Controls.Add(this.radBlue);
            this.grbColor.Controls.Add(this.radGreen);
            this.grbColor.Controls.Add(this.radRed);
            this.grbColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbColor.Location = new System.Drawing.Point(6, 6);
            this.grbColor.Name = "grbColor";
            this.grbColor.Size = new System.Drawing.Size(209, 224);
            this.grbColor.TabIndex = 0;
            this.grbColor.TabStop = false;
            this.grbColor.Text = "Color";
            // 
            // grbFont
            // 
            this.grbFont.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbFont.BackColor = System.Drawing.Color.LightPink;
            this.grbFont.Controls.Add(this.chkUnderline);
            this.grbFont.Controls.Add(this.chkItalic);
            this.grbFont.Controls.Add(this.chkBold);
            this.grbFont.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbFont.Location = new System.Drawing.Point(221, 6);
            this.grbFont.Name = "grbFont";
            this.grbFont.Size = new System.Drawing.Size(210, 224);
            this.grbFont.TabIndex = 0;
            this.grbFont.TabStop = false;
            this.grbFont.Text = "Font";
            // 
            // lblLapTrinhBoi
            // 
            this.lblLapTrinhBoi.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblLapTrinhBoi.AutoSize = true;
            this.lblLapTrinhBoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLapTrinhBoi.ForeColor = System.Drawing.Color.Red;
            this.lblLapTrinhBoi.Location = new System.Drawing.Point(3, 23);
            this.lblLapTrinhBoi.Name = "lblLapTrinhBoi";
            this.lblLapTrinhBoi.Size = new System.Drawing.Size(97, 15);
            this.lblLapTrinhBoi.TabIndex = 0;
            this.lblLapTrinhBoi.Text = "Lập Trình Bởi:";
            // 
            // lblLapTrinh
            // 
            this.lblLapTrinh.AutoSize = true;
            this.lblLapTrinh.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLapTrinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLapTrinh.ForeColor = System.Drawing.Color.Red;
            this.lblLapTrinh.Location = new System.Drawing.Point(3, 8);
            this.lblLapTrinh.Name = "lblLapTrinh";
            this.lblLapTrinh.Size = new System.Drawing.Size(2, 19);
            this.lblLapTrinh.TabIndex = 0;
            // 
            // btnThoat
            // 
            this.btnThoat.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnThoat.Location = new System.Drawing.Point(348, 10);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(83, 41);
            this.btnThoat.TabIndex = 0;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // radRed
            // 
            this.radRed.AutoSize = true;
            this.radRed.Checked = true;
            this.radRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radRed.ForeColor = System.Drawing.Color.Red;
            this.radRed.Location = new System.Drawing.Point(24, 35);
            this.radRed.Name = "radRed";
            this.radRed.Size = new System.Drawing.Size(55, 21);
            this.radRed.TabIndex = 0;
            this.radRed.TabStop = true;
            this.radRed.Text = "Red";
            this.radRed.UseVisualStyleBackColor = true;
            this.radRed.CheckedChanged += new System.EventHandler(this.radRed_CheckedChanged);
            // 
            // radGreen
            // 
            this.radGreen.AutoSize = true;
            this.radGreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radGreen.ForeColor = System.Drawing.Color.Green;
            this.radGreen.Location = new System.Drawing.Point(24, 76);
            this.radGreen.Name = "radGreen";
            this.radGreen.Size = new System.Drawing.Size(71, 21);
            this.radGreen.TabIndex = 1;
            this.radGreen.Text = "Green";
            this.radGreen.UseVisualStyleBackColor = true;
            this.radGreen.CheckedChanged += new System.EventHandler(this.radGreen_CheckedChanged);
            // 
            // radBlue
            // 
            this.radBlue.AutoSize = true;
            this.radBlue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radBlue.ForeColor = System.Drawing.Color.Blue;
            this.radBlue.Location = new System.Drawing.Point(24, 117);
            this.radBlue.Name = "radBlue";
            this.radBlue.Size = new System.Drawing.Size(58, 21);
            this.radBlue.TabIndex = 2;
            this.radBlue.Text = "Blue";
            this.radBlue.UseVisualStyleBackColor = true;
            this.radBlue.CheckedChanged += new System.EventHandler(this.radBlue_CheckedChanged);
            // 
            // radBlack
            // 
            this.radBlack.AutoSize = true;
            this.radBlack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radBlack.Location = new System.Drawing.Point(24, 162);
            this.radBlack.Name = "radBlack";
            this.radBlack.Size = new System.Drawing.Size(65, 21);
            this.radBlack.TabIndex = 3;
            this.radBlack.Text = "Black";
            this.radBlack.UseVisualStyleBackColor = true;
            this.radBlack.CheckedChanged += new System.EventHandler(this.radBlack_CheckedChanged);
            // 
            // chkBold
            // 
            this.chkBold.AutoSize = true;
            this.chkBold.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBold.ForeColor = System.Drawing.Color.Blue;
            this.chkBold.Location = new System.Drawing.Point(40, 36);
            this.chkBold.Name = "chkBold";
            this.chkBold.Size = new System.Drawing.Size(96, 21);
            this.chkBold.TabIndex = 0;
            this.chkBold.Text = "Đậm Bold";
            this.chkBold.UseVisualStyleBackColor = true;
            this.chkBold.CheckedChanged += new System.EventHandler(this.chkBold_CheckedChanged);
            // 
            // chkItalic
            // 
            this.chkItalic.AutoSize = true;
            this.chkItalic.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkItalic.ForeColor = System.Drawing.Color.Blue;
            this.chkItalic.Location = new System.Drawing.Point(40, 77);
            this.chkItalic.Name = "chkItalic";
            this.chkItalic.Size = new System.Drawing.Size(126, 21);
            this.chkItalic.TabIndex = 1;
            this.chkItalic.Text = "Nghiêng Italic";
            this.chkItalic.UseVisualStyleBackColor = true;
            this.chkItalic.CheckedChanged += new System.EventHandler(this.chkItalic_CheckedChanged);
            // 
            // chkUnderline
            // 
            this.chkUnderline.AutoSize = true;
            this.chkUnderline.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkUnderline.ForeColor = System.Drawing.Color.Blue;
            this.chkUnderline.Location = new System.Drawing.Point(40, 118);
            this.chkUnderline.Name = "chkUnderline";
            this.chkUnderline.Size = new System.Drawing.Size(107, 21);
            this.chkUnderline.TabIndex = 2;
            this.chkUnderline.Text = "Gạch Chân";
            this.chkUnderline.UseVisualStyleBackColor = true;
            this.chkUnderline.CheckedChanged += new System.EventHandler(this.chkUnderline_CheckedChanged);
            // 
            // pnCenter
            // 
            this.pnCenter.Controls.Add(this.grbColor);
            this.pnCenter.Controls.Add(this.grbFont);
            this.pnCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnCenter.Location = new System.Drawing.Point(0, 39);
            this.pnCenter.Name = "pnCenter";
            this.pnCenter.Size = new System.Drawing.Size(439, 236);
            this.pnCenter.TabIndex = 2;
            // 
            // pnLapTrinh
            // 
            this.pnLapTrinh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pnLapTrinh.Controls.Add(this.lblLapTrinh);
            this.pnLapTrinh.Location = new System.Drawing.Point(106, 11);
            this.pnLapTrinh.Name = "pnLapTrinh";
            this.pnLapTrinh.Size = new System.Drawing.Size(236, 40);
            this.pnLapTrinh.TabIndex = 1;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 335);
            this.Controls.Add(this.pnCenter);
            this.Controls.Add(this.pnBottom);
            this.Controls.Add(this.pnTop);
            this.KeyPreview = true;
            this.Name = "frmMain";
            this.Text = "Định Dạng (Formater)";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmMain_KeyDown);
            this.pnTop.ResumeLayout(false);
            this.pnTop.PerformLayout();
            this.pnBottom.ResumeLayout(false);
            this.pnBottom.PerformLayout();
            this.grbColor.ResumeLayout(false);
            this.grbColor.PerformLayout();
            this.grbFont.ResumeLayout(false);
            this.grbFont.PerformLayout();
            this.pnCenter.ResumeLayout(false);
            this.pnLapTrinh.ResumeLayout(false);
            this.pnLapTrinh.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnTop;
        private System.Windows.Forms.Panel pnBottom;
        private System.Windows.Forms.Label lblNhapTen;
        private System.Windows.Forms.TextBox txtNhapTen;
        private System.Windows.Forms.GroupBox grbColor;
        private System.Windows.Forms.GroupBox grbFont;
        private System.Windows.Forms.Label lblLapTrinh;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label lblLapTrinhBoi;
        private System.Windows.Forms.RadioButton radBlack;
        private System.Windows.Forms.RadioButton radBlue;
        private System.Windows.Forms.RadioButton radGreen;
        private System.Windows.Forms.RadioButton radRed;
        private System.Windows.Forms.CheckBox chkUnderline;
        private System.Windows.Forms.CheckBox chkItalic;
        private System.Windows.Forms.CheckBox chkBold;
        private System.Windows.Forms.Panel pnCenter;
        private System.Windows.Forms.Panel pnLapTrinh;
    }
}

