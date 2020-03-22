namespace Bai_6
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
            this.pnLeft = new System.Windows.Forms.Panel();
            this.pnRight = new System.Windows.Forms.Panel();
            this.pnCenter = new System.Windows.Forms.Panel();
            this.grInputNameMessage = new System.Windows.Forms.GroupBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblMessageInput = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.grColor = new System.Windows.Forms.GroupBox();
            this.grAction = new System.Windows.Forms.GroupBox();
            this.radRed = new System.Windows.Forms.RadioButton();
            this.radGreen = new System.Windows.Forms.RadioButton();
            this.radBlue = new System.Windows.Forms.RadioButton();
            this.radBlack = new System.Windows.Forms.RadioButton();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.chkVisible = new System.Windows.Forms.CheckBox();
            this.picSmall = new System.Windows.Forms.PictureBox();
            this.picBig = new System.Windows.Forms.PictureBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.pnTop.SuspendLayout();
            this.pnBottom.SuspendLayout();
            this.pnLeft.SuspendLayout();
            this.pnRight.SuspendLayout();
            this.pnCenter.SuspendLayout();
            this.grInputNameMessage.SuspendLayout();
            this.grColor.SuspendLayout();
            this.grAction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSmall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBig)).BeginInit();
            this.SuspendLayout();
            // 
            // pnTop
            // 
            this.pnTop.Controls.Add(this.grInputNameMessage);
            this.pnTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTop.Location = new System.Drawing.Point(0, 0);
            this.pnTop.Name = "pnTop";
            this.pnTop.Size = new System.Drawing.Size(604, 167);
            this.pnTop.TabIndex = 0;
            // 
            // pnBottom
            // 
            this.pnBottom.BackColor = System.Drawing.Color.Pink;
            this.pnBottom.Controls.Add(this.lblMessage);
            this.pnBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnBottom.Location = new System.Drawing.Point(0, 393);
            this.pnBottom.Name = "pnBottom";
            this.pnBottom.Size = new System.Drawing.Size(604, 36);
            this.pnBottom.TabIndex = 1;
            // 
            // pnLeft
            // 
            this.pnLeft.Controls.Add(this.grColor);
            this.pnLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnLeft.Location = new System.Drawing.Point(0, 167);
            this.pnLeft.Name = "pnLeft";
            this.pnLeft.Size = new System.Drawing.Size(200, 226);
            this.pnLeft.TabIndex = 2;
            // 
            // pnRight
            // 
            this.pnRight.Controls.Add(this.grAction);
            this.pnRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnRight.Location = new System.Drawing.Point(404, 167);
            this.pnRight.Name = "pnRight";
            this.pnRight.Size = new System.Drawing.Size(200, 226);
            this.pnRight.TabIndex = 3;
            // 
            // pnCenter
            // 
            this.pnCenter.Controls.Add(this.picBig);
            this.pnCenter.Controls.Add(this.picSmall);
            this.pnCenter.Controls.Add(this.chkVisible);
            this.pnCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnCenter.Location = new System.Drawing.Point(200, 167);
            this.pnCenter.Name = "pnCenter";
            this.pnCenter.Size = new System.Drawing.Size(204, 226);
            this.pnCenter.TabIndex = 4;
            // 
            // grInputNameMessage
            // 
            this.grInputNameMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.grInputNameMessage.Controls.Add(this.txtMessage);
            this.grInputNameMessage.Controls.Add(this.txtName);
            this.grInputNameMessage.Controls.Add(this.lblMessageInput);
            this.grInputNameMessage.Controls.Add(this.lblName);
            this.grInputNameMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grInputNameMessage.Location = new System.Drawing.Point(12, 12);
            this.grInputNameMessage.Name = "grInputNameMessage";
            this.grInputNameMessage.Size = new System.Drawing.Size(581, 140);
            this.grInputNameMessage.TabIndex = 0;
            this.grInputNameMessage.TabStop = false;
            this.grInputNameMessage.Text = "Input Name && Message";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(23, 38);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(49, 17);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            // 
            // lblMessageInput
            // 
            this.lblMessageInput.AutoSize = true;
            this.lblMessageInput.Location = new System.Drawing.Point(23, 82);
            this.lblMessageInput.Name = "lblMessageInput";
            this.lblMessageInput.Size = new System.Drawing.Size(69, 17);
            this.lblMessageInput.TabIndex = 1;
            this.lblMessageInput.Text = "Message:";
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.BackColor = System.Drawing.Color.NavajoWhite;
            this.txtName.Location = new System.Drawing.Point(99, 35);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(441, 23);
            this.txtName.TabIndex = 2;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // txtMessage
            // 
            this.txtMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMessage.BackColor = System.Drawing.Color.NavajoWhite;
            this.txtMessage.Location = new System.Drawing.Point(99, 79);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(441, 23);
            this.txtMessage.TabIndex = 3;
            this.txtMessage.TextChanged += new System.EventHandler(this.txtMessage_TextChanged);
            // 
            // grColor
            // 
            this.grColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.grColor.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.grColor.Controls.Add(this.radBlack);
            this.grColor.Controls.Add(this.radBlue);
            this.grColor.Controls.Add(this.radGreen);
            this.grColor.Controls.Add(this.radRed);
            this.grColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grColor.Location = new System.Drawing.Point(12, 6);
            this.grColor.Name = "grColor";
            this.grColor.Size = new System.Drawing.Size(182, 214);
            this.grColor.TabIndex = 0;
            this.grColor.TabStop = false;
            this.grColor.Text = "Color";
            // 
            // grAction
            // 
            this.grAction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.grAction.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.grAction.Controls.Add(this.btnExit);
            this.grAction.Controls.Add(this.btnClear);
            this.grAction.Controls.Add(this.btnDisplay);
            this.grAction.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grAction.Location = new System.Drawing.Point(6, 6);
            this.grAction.Name = "grAction";
            this.grAction.Size = new System.Drawing.Size(183, 214);
            this.grAction.TabIndex = 0;
            this.grAction.TabStop = false;
            this.grAction.Text = "Action";
            // 
            // radRed
            // 
            this.radRed.AutoSize = true;
            this.radRed.Checked = true;
            this.radRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radRed.ForeColor = System.Drawing.Color.Red;
            this.radRed.Location = new System.Drawing.Point(26, 40);
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
            this.radGreen.Location = new System.Drawing.Point(26, 77);
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
            this.radBlue.Location = new System.Drawing.Point(26, 121);
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
            this.radBlack.Location = new System.Drawing.Point(26, 162);
            this.radBlack.Name = "radBlack";
            this.radBlack.Size = new System.Drawing.Size(65, 21);
            this.radBlack.TabIndex = 3;
            this.radBlack.Text = "Black";
            this.radBlack.UseVisualStyleBackColor = true;
            this.radBlack.CheckedChanged += new System.EventHandler(this.radBlack_CheckedChanged);
            // 
            // btnDisplay
            // 
            this.btnDisplay.Enabled = false;
            this.btnDisplay.Location = new System.Drawing.Point(57, 38);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(75, 41);
            this.btnDisplay.TabIndex = 0;
            this.btnDisplay.Text = "&Display";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // btnClear
            // 
            this.btnClear.Enabled = false;
            this.btnClear.Location = new System.Drawing.Point(57, 96);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 41);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(57, 150);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 39);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // chkVisible
            // 
            this.chkVisible.AutoSize = true;
            this.chkVisible.Checked = true;
            this.chkVisible.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkVisible.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkVisible.Location = new System.Drawing.Point(42, 6);
            this.chkVisible.Name = "chkVisible";
            this.chkVisible.Size = new System.Drawing.Size(129, 21);
            this.chkVisible.TabIndex = 0;
            this.chkVisible.Text = "Message Visible";
            this.chkVisible.UseVisualStyleBackColor = true;
            this.chkVisible.CheckedChanged += new System.EventHandler(this.chkVisible_CheckedChanged);
            // 
            // picSmall
            // 
            this.picSmall.Image = global::Bai_6.Properties.Resources.cdrom;
            this.picSmall.Location = new System.Drawing.Point(68, 84);
            this.picSmall.Name = "picSmall";
            this.picSmall.Size = new System.Drawing.Size(63, 59);
            this.picSmall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSmall.TabIndex = 1;
            this.picSmall.TabStop = false;
            this.picSmall.Visible = false;
            this.picSmall.Click += new System.EventHandler(this.picSmall_Click);
            // 
            // picBig
            // 
            this.picBig.Image = global::Bai_6.Properties.Resources.cdrom;
            this.picBig.Location = new System.Drawing.Point(15, 44);
            this.picBig.Name = "picBig";
            this.picBig.Size = new System.Drawing.Size(174, 165);
            this.picBig.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBig.TabIndex = 1;
            this.picBig.TabStop = false;
            this.picBig.Click += new System.EventHandler(this.picBig_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.ForeColor = System.Drawing.Color.Red;
            this.lblMessage.Location = new System.Drawing.Point(3, 10);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 17);
            this.lblMessage.TabIndex = 0;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 429);
            this.Controls.Add(this.pnCenter);
            this.Controls.Add(this.pnRight);
            this.Controls.Add(this.pnLeft);
            this.Controls.Add(this.pnBottom);
            this.Controls.Add(this.pnTop);
            this.KeyPreview = true;
            this.Name = "frmMain";
            this.Text = "Message Formater";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmMain_KeyDown);
            this.pnTop.ResumeLayout(false);
            this.pnBottom.ResumeLayout(false);
            this.pnBottom.PerformLayout();
            this.pnLeft.ResumeLayout(false);
            this.pnRight.ResumeLayout(false);
            this.pnCenter.ResumeLayout(false);
            this.pnCenter.PerformLayout();
            this.grInputNameMessage.ResumeLayout(false);
            this.grInputNameMessage.PerformLayout();
            this.grColor.ResumeLayout(false);
            this.grColor.PerformLayout();
            this.grAction.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picSmall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBig)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnTop;
        private System.Windows.Forms.GroupBox grInputNameMessage;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblMessageInput;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Panel pnBottom;
        private System.Windows.Forms.Panel pnLeft;
        private System.Windows.Forms.Panel pnRight;
        private System.Windows.Forms.Panel pnCenter;
        private System.Windows.Forms.GroupBox grColor;
        private System.Windows.Forms.RadioButton radBlack;
        private System.Windows.Forms.RadioButton radBlue;
        private System.Windows.Forms.RadioButton radGreen;
        private System.Windows.Forms.RadioButton radRed;
        private System.Windows.Forms.GroupBox grAction;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.CheckBox chkVisible;
        private System.Windows.Forms.PictureBox picSmall;
        private System.Windows.Forms.PictureBox picBig;
        private System.Windows.Forms.Label lblMessage;
    }
}

