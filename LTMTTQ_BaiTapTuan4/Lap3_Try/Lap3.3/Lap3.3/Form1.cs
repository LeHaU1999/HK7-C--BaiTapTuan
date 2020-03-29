using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lap3._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            try
            {
                string soNhap;
                soNhap = txtNhap.Text;
                int so = Convert.ToInt32(soNhap);
                lblKetQua.Text = "" + Math.Sqrt(so);
            }
            catch (Exception)
            {

                MessageBox.Show("nhập đúng định dạng:");
            }


        }
    }
}
