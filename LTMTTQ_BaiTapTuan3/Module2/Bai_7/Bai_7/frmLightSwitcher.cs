using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_7
{
    public partial class frmLightSwitcher : Form
    {
        public frmLightSwitcher()
        {
            InitializeComponent();
        }

        private void frmLightSwitcher_Load(object sender, EventArgs e)
        {
            txtName.Text = "Jack";
            lblHienThi.Text = txtName.Text.Trim() + ". Turn Off the Light, please!";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picTurnOff_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Trim().Length > 0)
            {
                picTurnOff.Visible = false;
                picTurnOn.Visible = true;
                lblHienThi.Text = txtName.Text + ". Turn Off the Light, please!";
            }
            else
            {
                MessageBox.Show("Vui lòng nhập tên của bạn!");
            }
        }

        private void picTurnOn_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Trim().Length > 0)
            {
                picTurnOff.Visible = true;
                picTurnOn.Visible = false;
                lblHienThi.Text = txtName.Text + ". Turn On the Light, please!";
            }
            else
            {
                MessageBox.Show("Vui lòng nhập tên của bạn!");
            }
        }
    }
}
