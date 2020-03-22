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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            // khai báo biến cục bộ
            int intSoLuong = 0;
            decimal decDonGia = 0, decThanhTien = 0;

            //kiểm tra giá trị rỗng
            if (txtSoLuong.Text == "")
            {
                MessageBox.Show("Chưa nhập số lượng hàng");
                txtSoLuong.Focus();
            }
            else if (txtDonGia.Text == "")
            {
                MessageBox.Show("Chưa nhập đơn giá");
                txtDonGia.Focus();
            }
            else
            {
                //nếu dữ liệu khác rỗng, gán vào biến
                intSoLuong = Convert.ToInt32(txtSoLuong.Text);
                decDonGia = Convert.ToDecimal(txtDonGia.Text);
                //kiểm tra dữ liệu hợp lệ
                if (intSoLuong <= 0)
                {
                    MessageBox.Show("Số lượng hàng > 0");
                    txtSoLuong.SelectAll();
                    txtSoLuong.Focus();
                }
                else if (decDonGia <= 0)
                {
                    MessageBox.Show("Đơn giá > 0");
                    txtDonGia.SelectAll();
                    txtDonGia.Focus();
                }
                else
                {
                    //tính thành tiền
                    decThanhTien = intSoLuong * decDonGia;
                    //xuất kết quả ra label
                    txtThanhTien.Text = decThanhTien.ToString();
                }
            }
        }
        //chỉ cho nhập số vào textbox
        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'A' && e.KeyChar <= 'Z') || (e.KeyChar >= 'a' && e.KeyChar <= 'z')) e.Handled = true;
        }

        private void btnKetThuc_Click(object sender, EventArgs e)
        {
            DialogResult dl;
            dl = MessageBox.Show("Có chắc chắn là bạn muốn đóng ứng dụng?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dl == DialogResult.Yes) Close();
        }

        private void btnTiep_Click(object sender, EventArgs e)
        {
            txtTenHang.Clear();
            txtSoLuong.Clear();
            txtDonGia.Clear();
            txtThanhTien.Clear();
            txtTenHang.Focus();
        }
    }
}
