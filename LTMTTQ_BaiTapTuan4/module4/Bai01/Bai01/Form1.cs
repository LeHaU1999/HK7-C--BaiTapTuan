using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai01
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
                float miLies = Convert.ToInt32(txtMiles.Text);
                float gaLion = Convert.ToInt32(txtGalion.Text);
                if (miLies>0||gaLion>0)
                {
                    txtKetQua.Text = "" + miLies / gaLion;
                }
                else
                {
                    MessageBox.Show("lỗi số dương");
                }
                
            }
            catch (DivideByZeroException )
            {

                MessageBox.Show("lỗi chia cho 0");
            }
            catch (OverflowException)
            {
                MessageBox.Show("lỗi tràn gì đó");
            }
            catch (FormatException)
            {
                MessageBox.Show("lỗi nd9ainh5 dạng");
            }
        }
    }
}
