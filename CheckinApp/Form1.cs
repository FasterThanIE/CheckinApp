using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckinApp
{

    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void onButtonClick(object sender, EventArgs e)
        {
            var getValue = ((Button)sender).Text;
            Debug.WriteLine(getValue);
        }

        private void numpad_1_Click_1(object sender, EventArgs e)
        {
            onButtonClick(sender, e);
        }

        private void numpad_2_Click(object sender, EventArgs e)
        {
            onButtonClick(sender, e);
        }

        private void numpad_3_Click(object sender, EventArgs e)
        {
            onButtonClick(sender, e);
        }

        private void numpad_4_Click(object sender, EventArgs e)
        {
            onButtonClick(sender, e);
        }

        private void numpad_5_Click(object sender, EventArgs e)
        {
            onButtonClick(sender, e);
        }

        private void numpad_6_Click(object sender, EventArgs e)
        {
            onButtonClick(sender, e);
        }

        private void numpad_7_Click(object sender, EventArgs e)
        {
            onButtonClick(sender, e);
        }

        private void numpad_8_Click(object sender, EventArgs e)
        {
            onButtonClick(sender, e);
        }

        private void numpad_9_Click(object sender, EventArgs e)
        {
            onButtonClick(sender, e);
        }
    }
}
