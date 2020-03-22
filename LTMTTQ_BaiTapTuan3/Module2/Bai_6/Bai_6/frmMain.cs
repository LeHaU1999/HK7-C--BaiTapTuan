using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_6
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            this.ActiveControl = txtName;
            txtName.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
            if (e.KeyCode == Keys.Enter)
            {
                if (HopLe(txtName.Text.Trim()) && HopLe(txtMessage.Text.Trim()))
                    lblMessage.Text = txtName.Text.Trim() + " : " + txtMessage.Text.Trim();
                else
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
            }
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            lblMessage.Text = txtName.Text.Trim() + " : " + txtMessage.Text.Trim();
        }

        private bool HopLe(string v)
        {
            if (v.Length > 0)
                return true;
            return false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (HopLe(txtName.Text.Trim()) || HopLe(txtMessage.Text.Trim()))
            {
                txtName.Clear();
                txtMessage.Clear();
                txtName.Focus();
            }
        }

        private void radRed_CheckedChanged(object sender, EventArgs e)
        {
            lblMessage.ForeColor = Color.Red;
        }

        private void radGreen_CheckedChanged(object sender, EventArgs e)
        {
            lblMessage.ForeColor = Color.Green;
        }

        private void radBlue_CheckedChanged(object sender, EventArgs e)
        {
            lblMessage.ForeColor = Color.Blue;
        }

        private void radBlack_CheckedChanged(object sender, EventArgs e)
        {
            lblMessage.ForeColor = Color.Black;
        }

        private void chkVisible_CheckedChanged(object sender, EventArgs e)
        {
            lblMessage.Visible = chkVisible.Checked;
        }

        private void picBig_Click(object sender, EventArgs e)
        {
            picBig.Visible = false;
            picSmall.Visible = true;
        }

        private void picSmall_Click(object sender, EventArgs e)
        {
            picBig.Visible = true;
            picSmall.Visible = false;
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (HopLe(txtName.Text.Trim()) && HopLe(txtMessage.Text.Trim()))
                btnDisplay.Enabled = true;
            else btnDisplay.Enabled = false;

            if (HopLe(txtName.Text.Trim()) || HopLe(txtMessage.Text.Trim()))
                btnClear.Enabled = true;
            else btnClear.Enabled = false;
        }

        private void txtMessage_TextChanged(object sender, EventArgs e)
        {
            if (HopLe(txtName.Text.Trim()) && HopLe(txtMessage.Text.Trim()))
                btnDisplay.Enabled = true;
            else btnDisplay.Enabled = false;

            if (HopLe(txtName.Text.Trim()) || HopLe(txtMessage.Text.Trim()))
                btnClear.Enabled = true;
            else btnClear.Enabled = false;
        }
    }
}
