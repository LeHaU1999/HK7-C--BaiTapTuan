using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_1
{
    public partial class frmSuDungLabelTextBox : Form
    {
        public frmSuDungLabelTextBox()
        {
            InitializeComponent();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            txtHienThi.Text = txtNhapPassWord.Text;
        }

        private void btnTiep_Click(object sender, EventArgs e)
        {
            txtHienThi.Text = "";
            txtNhapPassWord.Clear();
            txtNhapPassWord.Focus();
        }

        private void txtNhapPassWord_TextChanged(object sender, EventArgs e)
        {
            if (HopLe(txtNhapPassWord.Text))
                btnHienThi.Enabled = true;
            else btnHienThi.Enabled = false;
        }

        private bool HopLe(string text)
        {
            if (text.Trim().Length > 0)
                return true;
            return false;
        }

        private void txtHienThi_TextChanged(object sender, EventArgs e)
        {
            if (HopLe(txtHienThi.Text))
                btnTiep.Enabled = true;
            else btnTiep.Enabled = false;
        }
    }
}
