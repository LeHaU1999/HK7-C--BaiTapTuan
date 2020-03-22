using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_8
{
    public partial class frmStepByStep2_4 : Form
    {
        int count = -1;
        public frmStepByStep2_4()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            count++;
            Button newButton = new Button();
            newButton.Text = "Element " + count.ToString();
            newButton.Click += new System.EventHandler(Button_Click);
            pnButton.Controls.Add(newButton);
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            lblStatus.Text = "Status: " + button.Text + "  is clicked.";
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            pnButton.Controls.Remove(button);
        }
    }
}
