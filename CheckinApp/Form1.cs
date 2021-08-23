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

        PinModel pinModel = new PinModel();

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

        private void Button_Click(object sender, EventArgs e)
        {
            if (!pinModel.MaxPinCount())
            {
                var pinValue = ((Button)sender).Text;
                pinModel.Pin.Add(Int32.Parse(pinValue));
                pin_label.Text = string.Join(" ", pinModel.Pin.ToArray());
                pin_max_error.Visible = false;
                check_in.Enabled = false;
            }
            else
            {
                pin_max_error.Text = "Pin can be maximum 4 errors";
                pin_max_error.Visible = true;
            }

            // Recheck if we have max amount of pins set after we set it's value
            if(pinModel.MaxPinCount())
            {
                check_in.Enabled = true;
            }

        }

        private void remove_single_pin_Click(object sender, EventArgs e)
        {
            check_in.Enabled = false;
            if (pinModel.Pin.Count > 0)
            {
                pinModel.Pin.RemoveAt(pinModel.Pin.Count - 1);
                pin_label.Text = string.Join(" ", pinModel.Pin.ToArray());
                pin_max_error.Visible = false;
            } else
            {
                pin_max_error.Text = "There are no digits to delete";
                pin_max_error.Visible = true;
            }
        }


        private void check_in_Click(object sender, EventArgs e)
        {
            if (pinModel.MaxPinCount() && pinModel.IsValidPin())
            {
                Debug.WriteLine("Valid Pin!");
            }
        }
    }
}
