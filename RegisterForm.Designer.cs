namespace ATM_GUI
{
    partial class RegisterForm
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
            this.loginLabel = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.TextBox();
            this.registerButton = new System.Windows.Forms.Button();
            this.password = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.passconfirm = new System.Windows.Forms.TextBox();
            this.UserTaken = new System.Windows.Forms.Label();
            this.passmatch = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Location = new System.Drawing.Point(258, 324);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(127, 13);
            this.loginLabel.TabIndex = 12;
            this.loginLabel.TabStop = true;
            this.loginLabel.Text = "Login to Existing Account";
            this.loginLabel.VisitedLinkColor = System.Drawing.Color.Blue;
            this.loginLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.loginLabel_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 8.25F);
            this.label2.ForeColor = System.Drawing.Color.LimeGreen;
            this.label2.Location = new System.Drawing.Point(131, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 8.25F);
            this.label1.ForeColor = System.Drawing.Color.LimeGreen;
            this.label1.Location = new System.Drawing.Point(131, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "Username";
            // 
            // username
            // 
            this.username.ForeColor = System.Drawing.Color.Gray;
            this.username.Location = new System.Drawing.Point(134, 155);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(124, 20);
            this.username.TabIndex = 9;
            this.username.Text = "Enter Your Username";
            // 
            // registerButton
            // 
            this.registerButton.BackColor = System.Drawing.Color.LimeGreen;
            this.registerButton.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 8.25F);
            this.registerButton.Location = new System.Drawing.Point(134, 298);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(124, 23);
            this.registerButton.TabIndex = 8;
            this.registerButton.Text = "Register";
            this.registerButton.UseVisualStyleBackColor = false;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // password
            // 
            this.password.ForeColor = System.Drawing.Color.Gray;
            this.password.Location = new System.Drawing.Point(134, 202);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(124, 20);
            this.password.TabIndex = 7;
            this.password.Text = "Enter Your Password";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ATM_GUI.Properties.Resources.coolbank;
            this.pictureBox1.Location = new System.Drawing.Point(95, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(208, 87);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 8.25F);
            this.label4.ForeColor = System.Drawing.Color.LimeGreen;
            this.label4.Location = new System.Drawing.Point(131, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 18);
            this.label4.TabIndex = 18;
            this.label4.Text = "Confirm Password";
            // 
            // passconfirm
            // 
            this.passconfirm.ForeColor = System.Drawing.Color.Gray;
            this.passconfirm.Location = new System.Drawing.Point(134, 257);
            this.passconfirm.Name = "passconfirm";
            this.passconfirm.Size = new System.Drawing.Size(124, 20);
            this.passconfirm.TabIndex = 17;
            this.passconfirm.Text = "Confirm Password";
            // 
            // UserTaken
            // 
            this.UserTaken.AutoSize = true;
            this.UserTaken.Font = new System.Drawing.Font("Gill Sans MT Condensed", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserTaken.ForeColor = System.Drawing.Color.Tomato;
            this.UserTaken.Location = new System.Drawing.Point(215, 134);
            this.UserTaken.Name = "UserTaken";
            this.UserTaken.Size = new System.Drawing.Size(120, 18);
            this.UserTaken.TabIndex = 19;
            this.UserTaken.Text = "Username Already Taken";
            this.UserTaken.Visible = false;
            // 
            // passmatch
            // 
            this.passmatch.AutoSize = true;
            this.passmatch.Font = new System.Drawing.Font("Gill Sans MT Condensed", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passmatch.ForeColor = System.Drawing.Color.Tomato;
            this.passmatch.Location = new System.Drawing.Point(215, 178);
            this.passmatch.Name = "passmatch";
            this.passmatch.Size = new System.Drawing.Size(127, 18);
            this.passmatch.TabIndex = 20;
            this.passmatch.Text = "Password is not Matching";
            this.passmatch.Visible = false;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.passmatch);
            this.Controls.Add(this.UserTaken);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.passconfirm);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.username);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.password);
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.LinkLabel loginLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox passconfirm;
        private System.Windows.Forms.Label UserTaken;
        private System.Windows.Forms.Label passmatch;
    }
}