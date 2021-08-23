
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
            this.first_name_label = new System.Windows.Forms.Label();
            this.last_name_label = new System.Windows.Forms.Label();
            this.first_name = new System.Windows.Forms.TextBox();
            this.last_name = new System.Windows.Forms.TextBox();
            this.age_label = new System.Windows.Forms.Label();
            this.age = new System.Windows.Forms.TextBox();
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
            // first_name_label
            // 
            this.first_name_label.AutoSize = true;
            this.first_name_label.Location = new System.Drawing.Point(24, 182);
            this.first_name_label.Name = "first_name_label";
            this.first_name_label.Size = new System.Drawing.Size(62, 15);
            this.first_name_label.TabIndex = 1;
            this.first_name_label.Text = "First name";
            // 
            // last_name_label
            // 
            this.last_name_label.AutoSize = true;
            this.last_name_label.Location = new System.Drawing.Point(24, 221);
            this.last_name_label.Name = "last_name_label";
            this.last_name_label.Size = new System.Drawing.Size(61, 15);
            this.last_name_label.TabIndex = 2;
            this.last_name_label.Text = "Last name";
            // 
            // first_name
            // 
            this.first_name.Location = new System.Drawing.Point(105, 179);
            this.first_name.MaxLength = 32;
            this.first_name.Name = "first_name";
            this.first_name.Size = new System.Drawing.Size(100, 23);
            this.first_name.TabIndex = 3;
            // 
            // last_name
            // 
            this.last_name.Location = new System.Drawing.Point(105, 218);
            this.last_name.MaxLength = 32;
            this.last_name.Name = "last_name";
            this.last_name.Size = new System.Drawing.Size(100, 23);
            this.last_name.TabIndex = 4;
            // 
            // age_label
            // 
            this.age_label.AutoSize = true;
            this.age_label.Location = new System.Drawing.Point(24, 261);
            this.age_label.Name = "age_label";
            this.age_label.Size = new System.Drawing.Size(28, 15);
            this.age_label.TabIndex = 5;
            this.age_label.Text = "Age";
            // 
            // age
            // 
            this.age.Location = new System.Drawing.Point(105, 258);
            this.age.MaxLength = 32;
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(100, 23);
            this.age.TabIndex = 6;
            // 
            // user_details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.age);
            this.Controls.Add(this.age_label);
            this.Controls.Add(this.last_name);
            this.Controls.Add(this.first_name);
            this.Controls.Add(this.last_name_label);
            this.Controls.Add(this.first_name_label);
            this.Controls.Add(this.pictureBox1);
            this.Name = "user_details";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label first_name_label;
        private System.Windows.Forms.Label last_name_label;
        private System.Windows.Forms.TextBox first_name;
        private System.Windows.Forms.TextBox last_name;
        private System.Windows.Forms.Label age_label;
        private System.Windows.Forms.TextBox age;
    }
}