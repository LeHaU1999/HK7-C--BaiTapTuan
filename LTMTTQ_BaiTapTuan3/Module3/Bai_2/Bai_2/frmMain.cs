using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_2
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            double chieuDai = 0, chieuRong = 0, dienTich;
            if (txtChieuDai.Text == "")
            {
                MessageBox.Show("Nhập Chiều Dài!");
                txtChieuDai.SelectAll();
                txtChieuDai.Focus();
            }
            else if (txtChieuRong.Text == "")
            {
                MessageBox.Show("Nhập Chiều Rộng!");
                txtChieuRong.SelectAll();
                txtChieuRong.Focus();
            }
            else
            {
                chieuDai = Double.Parse(txtChieuDai.Text.Trim(), CultureInfo.InvariantCulture);
                chieuRong = Double.Parse(txtChieuRong.Text.Trim(), CultureInfo.InvariantCulture);

                if (chieuDai <= 0)
                {
                    MessageBox.Show("Chiều Dài > 0!");
                    txtChieuDai.SelectAll();
                    txtChieuDai.Focus();
                }
                else if (chieuRong <= 0)
                {
                    MessageBox.Show("Chiều Rộng > 0!");
                    txtChieuRong.SelectAll();
                    txtChieuRong.Focus();
                }
                else
                {
                    dienTich = chieuDai * chieuRong;
                    //dienTich = 2.1 * 3;
                    txtDienTich.Text = dienTich.ToString();
                }
            }
        }

        private void btnTiep_Click(object sender, EventArgs e)
        {
            txtChieuDai.Clear();
            txtChieuRong.Clear();
            txtDienTich.Clear();
            txtChieuDai.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dl;
            dl = MessageBox.Show("Có chắc chắn là bạn muốn đóng ứng dụng không?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dl == DialogResult.Yes) Close();
        }

        private void txtChieuDai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                // Allow Digits
            }
            else if (e.KeyChar == '.' && !((TextBox)sender).Text.Contains('.'))
            {
                //Allows only one Dot Char
            }
            else
            {
                e.Handled = true;
            }

            // only allow one decimal point
            /*if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }*/
        }

        private void txtChieuRong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'A' && e.KeyChar <= 'Z') || (e.KeyChar >= 'a' && e.KeyChar <= 'z')) e.Handled = true;
        }
    }
}
