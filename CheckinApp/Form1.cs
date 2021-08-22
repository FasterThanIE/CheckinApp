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

        private List<int> pin = new List<int>();

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
            if(pin.Count < 4)
            {
                var pinValue = ((Button)sender).Text;
                pin.Add(Int32.Parse(pinValue));
                pin_label.Text = string.Join(" ", pin.ToArray());
                pin_max_error.Visible = false;
            } else
            {
                pin_max_error.Visible = true;
            }
            
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

        private void remove_single_pin_Click(object sender, EventArgs e)
        {
            if(pin.Count > 0)
            {
                pin.RemoveAt(pin.Count - 1);
                pin_label.Text = string.Join(" ", pin.ToArray());
                pin_max_error.Visible = false;
            } 
        }
    }
}
