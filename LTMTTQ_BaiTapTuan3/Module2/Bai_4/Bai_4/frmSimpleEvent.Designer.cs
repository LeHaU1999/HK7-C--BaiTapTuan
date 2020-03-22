namespace Bai_4
{
    partial class frmSimpleEvent
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
            this.btnClickMe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClickMe
            // 
            this.btnClickMe.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnClickMe.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClickMe.ForeColor = System.Drawing.Color.Red;
            this.btnClickMe.Location = new System.Drawing.Point(83, 63);
            this.btnClickMe.Name = "btnClickMe";
            this.btnClickMe.Size = new System.Drawing.Size(205, 78);
            this.btnClickMe.TabIndex = 0;
            this.btnClickMe.Text = "Click Me";
            this.btnClickMe.UseVisualStyleBackColor = true;
            this.btnClickMe.Click += new System.EventHandler(this.btnClickMe_Click);
            // 
            // frmSimpleEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 205);
            this.Controls.Add(this.btnClickMe);
            this.Name = "frmSimpleEvent";
            this.Text = "Simple Event Example";
            this.Load += new System.EventHandler(this.frmSimpleEvent_Load);
            this.Click += new System.EventHandler(this.frmSimpleEvent_Click);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClickMe;
    }
}

