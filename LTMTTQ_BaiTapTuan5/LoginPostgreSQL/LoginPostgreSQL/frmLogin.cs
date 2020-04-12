
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginPostgreSQL
{
    public partial class frmLogin : Form
    {
        
        public frmLogin()
        {
            InitializeComponent();
        }
        LinQConnectionDataContext linQConnect = new LinQConnectionDataContext();
        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                var dangnhap = (from TaiKhoang in linQConnect.TaiKhoangs
                                where TaiKhoang.Username == txtUserName.Text.Trim() && TaiKhoang.Password == txtPassword.Text
                                select TaiKhoang).SingleOrDefault();
                if (dangnhap == null)
                {
                    MessageBox.Show("Đang Nhập Thất Bại. Vui Lòng Xem LẠi ^-^ !!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Đang Nhập Thành Công ^-^ !!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                 
                    this.Hide();
                    new frmMain(txtUserName.Text).Show();
                }
            }
            catch
            {
                MessageBox.Show("Đã Xảy ra Lỗi Trong Quá Trình Đăng Nhập^-^ !!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
        }
    }
}
