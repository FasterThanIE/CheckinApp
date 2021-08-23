
namespace CheckinApp
{
    partial class user_details
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(user_details));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.email_label = new System.Windows.Forms.Label();
            this.password_label = new System.Windows.Forms.Label();
            this.email_input = new System.Windows.Forms.TextBox();
            this.password_input = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(24, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(279, 146);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // email_label
            // 
            this.email_label.AutoSize = true;
            this.email_label.Location = new System.Drawing.Point(24, 182);
            this.email_label.Name = "email_label";
            this.email_label.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.email_label.Size = new System.Drawing.Size(36, 15);
            this.email_label.TabIndex = 1;
            this.email_label.Text = "Email";
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.Location = new System.Drawing.Point(24, 240);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(57, 15);
            this.password_label.TabIndex = 2;
            this.password_label.Text = "Password";
            // 
            // email_input
            // 
            this.email_input.Location = new System.Drawing.Point(24, 200);
            this.email_input.MaxLength = 32;
            this.email_input.Name = "email_input";
            this.email_input.Size = new System.Drawing.Size(279, 23);
            this.email_input.TabIndex = 3;
            // 
            // password_input
            // 
            this.password_input.Location = new System.Drawing.Point(24, 258);
            this.password_input.MaxLength = 32;
            this.password_input.Name = "password_input";
            this.password_input.Size = new System.Drawing.Size(279, 23);
            this.password_input.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 298);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(279, 42);
            this.button1.TabIndex = 7;
            this.button1.Text = "Register";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // user_details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 358);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.password_input);
            this.Controls.Add(this.email_input);
            this.Controls.Add(this.password_label);
            this.Controls.Add(this.email_label);
            this.Controls.Add(this.pictureBox1);
            this.Name = "user_details";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.User_details_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label email_label;
        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.TextBox email_input;
        private System.Windows.Forms.TextBox password_input;
        private System.Windows.Forms.Button button1;
    }
}