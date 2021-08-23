
using System;

namespace CheckinApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.check_in = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.numpad_9 = new System.Windows.Forms.Button();
            this.numpad_8 = new System.Windows.Forms.Button();
            this.numpad_7 = new System.Windows.Forms.Button();
            this.numpad_6 = new System.Windows.Forms.Button();
            this.numpad_5 = new System.Windows.Forms.Button();
            this.numpad_4 = new System.Windows.Forms.Button();
            this.numpad_3 = new System.Windows.Forms.Button();
            this.numpad_2 = new System.Windows.Forms.Button();
            this.numpad_1 = new System.Windows.Forms.Button();
            this.pin_label = new System.Windows.Forms.Label();
            this.remove_single_pin = new System.Windows.Forms.Button();
            this.pin_max_error = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // check_in
            // 
            this.check_in.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.check_in.Enabled = false;
            this.check_in.Location = new System.Drawing.Point(67, 376);
            this.check_in.Name = "check_in";
            this.check_in.Size = new System.Drawing.Size(175, 62);
            this.check_in.TabIndex = 0;
            this.check_in.Text = "Check in";
            this.check_in.UseVisualStyleBackColor = true;
            this.check_in.Click += new System.EventHandler(this.check_in_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33332F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Controls.Add(this.numpad_9, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.numpad_8, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.numpad_7, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.numpad_6, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.numpad_5, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.numpad_4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.numpad_3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.numpad_2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.numpad_1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(304, 234);
            this.tableLayoutPanel1.TabIndex = 1;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // numpad_9
            // 
            this.numpad_9.Location = new System.Drawing.Point(205, 159);
            this.numpad_9.Name = "numpad_9";
            this.numpad_9.Size = new System.Drawing.Size(95, 71);
            this.numpad_9.TabIndex = 9;
            this.numpad_9.Text = "9";
            this.numpad_9.UseVisualStyleBackColor = true;
            this.numpad_9.Click += new System.EventHandler(this.Button_Click);
            // 
            // numpad_8
            // 
            this.numpad_8.Location = new System.Drawing.Point(104, 159);
            this.numpad_8.Name = "numpad_8";
            this.numpad_8.Size = new System.Drawing.Size(95, 71);
            this.numpad_8.TabIndex = 8;
            this.numpad_8.Text = "8";
            this.numpad_8.UseVisualStyleBackColor = true;
            this.numpad_8.Click += new System.EventHandler(this.Button_Click);
            // 
            // numpad_7
            // 
            this.numpad_7.Location = new System.Drawing.Point(3, 159);
            this.numpad_7.Name = "numpad_7";
            this.numpad_7.Size = new System.Drawing.Size(95, 71);
            this.numpad_7.TabIndex = 7;
            this.numpad_7.Text = "7";
            this.numpad_7.UseVisualStyleBackColor = true;
            this.numpad_7.Click += new System.EventHandler(this.Button_Click);
            // 
            // numpad_6
            // 
            this.numpad_6.Location = new System.Drawing.Point(205, 81);
            this.numpad_6.Name = "numpad_6";
            this.numpad_6.Size = new System.Drawing.Size(95, 71);
            this.numpad_6.TabIndex = 6;
            this.numpad_6.Text = "6";
            this.numpad_6.UseVisualStyleBackColor = true;
            this.numpad_6.Click += new System.EventHandler(this.Button_Click);
            // 
            // numpad_5
            // 
            this.numpad_5.Location = new System.Drawing.Point(104, 81);
            this.numpad_5.Name = "numpad_5";
            this.numpad_5.Size = new System.Drawing.Size(95, 71);
            this.numpad_5.TabIndex = 5;
            this.numpad_5.Text = "5";
            this.numpad_5.UseVisualStyleBackColor = true;
            this.numpad_5.Click += new System.EventHandler(this.Button_Click);
            // 
            // numpad_4
            // 
            this.numpad_4.Location = new System.Drawing.Point(3, 81);
            this.numpad_4.Name = "numpad_4";
            this.numpad_4.Size = new System.Drawing.Size(95, 71);
            this.numpad_4.TabIndex = 3;
            this.numpad_4.Text = "4";
            this.numpad_4.UseVisualStyleBackColor = true;
            this.numpad_4.Click += new System.EventHandler(this.Button_Click);
            // 
            // numpad_3
            // 
            this.numpad_3.Location = new System.Drawing.Point(205, 3);
            this.numpad_3.Name = "numpad_3";
            this.numpad_3.Size = new System.Drawing.Size(95, 71);
            this.numpad_3.TabIndex = 2;
            this.numpad_3.Text = "3";
            this.numpad_3.UseVisualStyleBackColor = true;
            this.numpad_3.Click += new System.EventHandler(this.Button_Click);
            // 
            // numpad_2
            // 
            this.numpad_2.Location = new System.Drawing.Point(104, 3);
            this.numpad_2.Name = "numpad_2";
            this.numpad_2.Size = new System.Drawing.Size(95, 71);
            this.numpad_2.TabIndex = 1;
            this.numpad_2.Text = "2";
            this.numpad_2.UseVisualStyleBackColor = true;
            this.numpad_2.Click += new System.EventHandler(this.Button_Click);
            // 
            // numpad_1
            // 
            this.numpad_1.Location = new System.Drawing.Point(3, 3);
            this.numpad_1.Name = "numpad_1";
            this.numpad_1.Size = new System.Drawing.Size(95, 71);
            this.numpad_1.TabIndex = 0;
            this.numpad_1.Text = "1";
            this.numpad_1.UseVisualStyleBackColor = true;
            this.numpad_1.Click += new System.EventHandler(this.Button_Click);
            // 
            // pin_label
            // 
            this.pin_label.AutoSize = true;
            this.pin_label.Location = new System.Drawing.Point(67, 358);
            this.pin_label.Name = "pin_label";
            this.pin_label.Size = new System.Drawing.Size(0, 15);
            this.pin_label.TabIndex = 2;
            // 
            // remove_single_pin
            // 
            this.remove_single_pin.Location = new System.Drawing.Point(15, 261);
            this.remove_single_pin.Name = "remove_single_pin";
            this.remove_single_pin.Size = new System.Drawing.Size(75, 23);
            this.remove_single_pin.TabIndex = 3;
            this.remove_single_pin.Text = "Delete";
            this.remove_single_pin.UseVisualStyleBackColor = true;
            this.remove_single_pin.Click += new System.EventHandler(this.remove_single_pin_Click);
            // 
            // pin_max_error
            // 
            this.pin_max_error.AutoSize = true;
            this.pin_max_error.ForeColor = System.Drawing.Color.Red;
            this.pin_max_error.Location = new System.Drawing.Point(93, 332);
            this.pin_max_error.Name = "pin_max_error";
            this.pin_max_error.Size = new System.Drawing.Size(129, 15);
            this.pin_max_error.TabIndex = 4;
            this.pin_max_error.Text = "Pin can be max 4 digits";
            this.pin_max_error.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 450);
            this.Controls.Add(this.pin_max_error);
            this.Controls.Add(this.remove_single_pin);
            this.Controls.Add(this.pin_label);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.check_in);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void numpad_1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Button check_in;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button numpad_2;
        private System.Windows.Forms.Button numpad_1;
        private System.Windows.Forms.Button numpad_9;
        private System.Windows.Forms.Button numpad_8;
        private System.Windows.Forms.Button numpad_7;
        private System.Windows.Forms.Button numpad_6;
        private System.Windows.Forms.Button numpad_5;
        private System.Windows.Forms.Button numpad_4;
        private System.Windows.Forms.Button numpad_3;
        private System.Windows.Forms.Label pin_label;
        private System.Windows.Forms.Button remove_single_pin;
        private System.Windows.Forms.Label pin_max_error;
    }
}

