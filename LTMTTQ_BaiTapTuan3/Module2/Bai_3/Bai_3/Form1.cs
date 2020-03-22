using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHo_Click(object sender, EventArgs e)
        {
            lblHoTen.Text = txtHo.Text.Trim();
        }

        private void btnTen_Click(object sender, EventArgs e)
        {
            lblHoTen.Text = txtTen.Text.Trim();
        }

        private void btnHoTen_Click(object sender, EventArgs e)
        {
            lblHoTen.Text = txtHo.Text.Trim() + " " + txtTen.Text.Trim();
        }

        private void lblHoTen_DoubleClick(object sender, EventArgs e)
        {
            lblHoTen.Text = "";
        }

        private void pnHoTen_DoubleClick(object sender, EventArgs e)
        {
            lblHoTen.Text = "";
        }

        private void txtHo_TextChanged(object sender, EventArgs e)
        {
            if (HopLe(txtHo.Text.Trim()))
                btnHo.Enabled = true;
            else btnHo.Enabled = false;

            if (HopLe(txtHo.Text.Trim()) && HopLe(txtTen.Text.Trim()))
                btnHoTen.Enabled = true;
            else btnHoTen.Enabled = false;
        }

        private bool HopLe(string v)
        {
            if (v.Length > 0)
                return true;
            return false;
        }

        private void txtTen_TextChanged(object sender, EventArgs e)
        {
            if (HopLe(txtTen.Text.Trim()))
                btnTen.Enabled = true;
            else btnTen.Enabled = false;

            if (HopLe(txtHo.Text.Trim()) && HopLe(txtTen.Text.Trim()))
                btnHoTen.Enabled = true;
            else btnHoTen.Enabled = false;
        }
    }
}
