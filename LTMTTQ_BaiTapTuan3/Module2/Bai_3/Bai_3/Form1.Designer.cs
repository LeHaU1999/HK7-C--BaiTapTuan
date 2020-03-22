namespace Bai_3
{
    partial class Form1
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
            this.lblHoTen = new System.Windows.Forms.Label();
            this.pnHoTen = new System.Windows.Forms.Panel();
            this.lblHoLot = new System.Windows.Forms.Label();
            this.lblTen = new System.Windows.Forms.Label();
            this.txtHo = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.btnHo = new System.Windows.Forms.Button();
            this.btnTen = new System.Windows.Forms.Button();
            this.btnHoTen = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.pnHoTen.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoTen.ForeColor = System.Drawing.Color.Snow;
            this.lblHoTen.Location = new System.Drawing.Point(3, 9);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(92, 31);
            this.lblHoTen.TabIndex = 0;
            this.lblHoTen.Text = "label1";
            this.lblHoTen.DoubleClick += new System.EventHandler(this.lblHoTen_DoubleClick);
            // 
            // pnHoTen
            // 
            this.pnHoTen.BackColor = System.Drawing.Color.DodgerBlue;
            this.pnHoTen.Controls.Add(this.lblHoTen);
            this.pnHoTen.Location = new System.Drawing.Point(0, 0);
            this.pnHoTen.Name = "pnHoTen";
            this.pnHoTen.Size = new System.Drawing.Size(384, 55);
            this.pnHoTen.TabIndex = 1;
            this.pnHoTen.DoubleClick += new System.EventHandler(this.pnHoTen_DoubleClick);
            // 
            // lblHoLot
            // 
            this.lblHoLot.AutoSize = true;
            this.lblHoLot.Location = new System.Drawing.Point(13, 73);
            this.lblHoLot.Name = "lblHoLot";
            this.lblHoLot.Size = new System.Drawing.Size(35, 13);
            this.lblHoLot.TabIndex = 2;
            this.lblHoLot.Text = "Họ lót";
            // 
            // lblTen
            // 
            this.lblTen.AutoSize = true;
            this.lblTen.Location = new System.Drawing.Point(12, 106);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(26, 13);
            this.lblTen.TabIndex = 3;
            this.lblTen.Text = "Tên";
            // 
            // txtHo
            // 
            this.txtHo.Location = new System.Drawing.Point(64, 70);
            this.txtHo.Name = "txtHo";
            this.txtHo.Size = new System.Drawing.Size(297, 20);
            this.txtHo.TabIndex = 4;
            this.txtHo.TextChanged += new System.EventHandler(this.txtHo_TextChanged);
            // 
            // txtTen
            // 
            this.txtTen.BackColor = System.Drawing.Color.Crimson;
            this.txtTen.ForeColor = System.Drawing.Color.White;
            this.txtTen.Location = new System.Drawing.Point(64, 103);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(297, 20);
            this.txtTen.TabIndex = 5;
            this.txtTen.TextChanged += new System.EventHandler(this.txtTen_TextChanged);
            // 
            // btnHo
            // 
            this.btnHo.Enabled = false;
            this.btnHo.Location = new System.Drawing.Point(16, 139);
            this.btnHo.Name = "btnHo";
            this.btnHo.Size = new System.Drawing.Size(75, 33);
            this.btnHo.TabIndex = 6;
            this.btnHo.Text = "&Họ Lót";
            this.btnHo.UseVisualStyleBackColor = true;
            this.btnHo.Click += new System.EventHandler(this.btnHo_Click);
            // 
            // btnTen
            // 
            this.btnTen.Enabled = false;
            this.btnTen.Location = new System.Drawing.Point(150, 139);
            this.btnTen.Name = "btnTen";
            this.btnTen.Size = new System.Drawing.Size(75, 33);
            this.btnTen.TabIndex = 7;
            this.btnTen.Text = "&Tên";
            this.btnTen.UseVisualStyleBackColor = true;
            this.btnTen.Click += new System.EventHandler(this.btnTen_Click);
            // 
            // btnHoTen
            // 
            this.btnHoTen.Enabled = false;
            this.btnHoTen.Location = new System.Drawing.Point(286, 139);
            this.btnHoTen.Name = "btnHoTen";
            this.btnHoTen.Size = new System.Drawing.Size(75, 33);
            this.btnHoTen.TabIndex = 8;
            this.btnHoTen.Text = "Họ và Tên";
            this.btnHoTen.UseVisualStyleBackColor = true;
            this.btnHoTen.Click += new System.EventHandler(this.btnHoTen_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(129, 181);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(116, 42);
            this.button4.TabIndex = 9;
            this.button4.Text = "Thoát Chương Trình";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 235);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnHoTen);
            this.Controls.Add(this.btnTen);
            this.Controls.Add(this.btnHo);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.txtHo);
            this.Controls.Add(this.lblTen);
            this.Controls.Add(this.lblHoLot);
            this.Controls.Add(this.pnHoTen);
            this.Name = "Form1";
            this.Text = "Bài Tập Họ Tên";
            this.pnHoTen.ResumeLayout(false);
            this.pnHoTen.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Panel pnHoTen;
        private System.Windows.Forms.Label lblHoLot;
        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.TextBox txtHo;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Button btnHo;
        private System.Windows.Forms.Button btnTen;
        private System.Windows.Forms.Button btnHoTen;
        private System.Windows.Forms.Button button4;
    }
}

