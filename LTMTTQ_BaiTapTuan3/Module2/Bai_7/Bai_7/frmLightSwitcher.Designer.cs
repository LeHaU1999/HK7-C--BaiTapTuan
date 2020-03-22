namespace Bai_7
{
    partial class frmLightSwitcher
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
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.picTurnOff = new System.Windows.Forms.PictureBox();
            this.picTurnOn = new System.Windows.Forms.PictureBox();
            this.lblHienThi = new System.Windows.Forms.Label();
            this.lblDesign = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picTurnOff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTurnOn)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(13, 13);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(54, 17);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.Location = new System.Drawing.Point(73, 12);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(259, 20);
            this.txtName.TabIndex = 1;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // picTurnOff
            // 
            this.picTurnOff.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picTurnOff.Image = global::Bai_7.Properties.Resources.off;
            this.picTurnOff.Location = new System.Drawing.Point(116, 55);
            this.picTurnOff.Name = "picTurnOff";
            this.picTurnOff.Size = new System.Drawing.Size(123, 122);
            this.picTurnOff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTurnOff.TabIndex = 3;
            this.picTurnOff.TabStop = false;
            this.picTurnOff.Visible = false;
            this.picTurnOff.Click += new System.EventHandler(this.picTurnOff_Click);
            // 
            // picTurnOn
            // 
            this.picTurnOn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picTurnOn.Image = global::Bai_7.Properties.Resources.on;
            this.picTurnOn.Location = new System.Drawing.Point(116, 55);
            this.picTurnOn.Name = "picTurnOn";
            this.picTurnOn.Size = new System.Drawing.Size(123, 122);
            this.picTurnOn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTurnOn.TabIndex = 2;
            this.picTurnOn.TabStop = false;
            this.picTurnOn.Click += new System.EventHandler(this.picTurnOn_Click);
            // 
            // lblHienThi
            // 
            this.lblHienThi.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblHienThi.AutoSize = true;
            this.lblHienThi.BackColor = System.Drawing.Color.PaleGreen;
            this.lblHienThi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHienThi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHienThi.Location = new System.Drawing.Point(26, 197);
            this.lblHienThi.Name = "lblHienThi";
            this.lblHienThi.Size = new System.Drawing.Size(292, 27);
            this.lblHienThi.TabIndex = 4;
            this.lblHienThi.Text = "Jack. Turn On the Light, please!";
            // 
            // lblDesign
            // 
            this.lblDesign.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDesign.AutoSize = true;
            this.lblDesign.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesign.Location = new System.Drawing.Point(13, 259);
            this.lblDesign.Name = "lblDesign";
            this.lblDesign.Size = new System.Drawing.Size(244, 17);
            this.lblDesign.TabIndex = 5;
            this.lblDesign.Text = "Designed by: _____Sương_____";
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(262, 246);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(70, 43);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmLightSwitcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(344, 292);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblDesign);
            this.Controls.Add(this.lblHienThi);
            this.Controls.Add(this.picTurnOff);
            this.Controls.Add(this.picTurnOn);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmLightSwitcher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Light";
            this.Load += new System.EventHandler(this.frmLightSwitcher_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picTurnOff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTurnOn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.PictureBox picTurnOn;
        private System.Windows.Forms.PictureBox picTurnOff;
        private System.Windows.Forms.Label lblHienThi;
        private System.Windows.Forms.Label lblDesign;
        private System.Windows.Forms.Button btnExit;
    }
}

