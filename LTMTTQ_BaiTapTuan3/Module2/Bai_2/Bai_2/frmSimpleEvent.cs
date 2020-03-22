using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_2
{
    public partial class frmSimpleEvent : Form
    {
        public frmSimpleEvent()
        {
            InitializeComponent();
        }

        private void btnClickMe_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Button was clicked.");
        }

        private void frmSimpleEvent_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Hi, Welcome to C# 2019 programming!");
        }

        private void frmSimpleEvent_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Form was clicked.");
        }
    }
}
