using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClickCounter
{
    public partial class Counter : Form
    {
        int times = 0;

        public Counter()
        {
            InitializeComponent();
        }

        private void clickButton_Click(object sender, EventArgs e)
        {
            times++;
            countLabel.Text = " " + times + " ";
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            times = 0;
            countLabel.Text = " " + times + " ";
        }

        private void textLabel2_Click(object sender, EventArgs e)
        {

        }
    }
}
