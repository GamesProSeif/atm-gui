namespace ATM_GUI
{
    partial class LoginForm
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
            this.password = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.username = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.registerLabel = new System.Windows.Forms.LinkLabel();
            this.WrongInfo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("Roboto", 8.25F);
            this.password.ForeColor = System.Drawing.Color.Gray;
            this.password.Location = new System.Drawing.Point(134, 221);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(125, 21);
            this.password.TabIndex = 1;
            this.password.Text = "Enter Your Password";
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.LimeGreen;
            this.loginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginButton.Font = new System.Drawing.Font("Roboto", 10F);
            this.loginButton.Location = new System.Drawing.Point(134, 259);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(125, 30);
            this.loginButton.TabIndex = 2;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // username
            // 
            this.username.Font = new System.Drawing.Font("Roboto", 8.25F);
            this.username.ForeColor = System.Drawing.Color.Gray;
            this.username.Location = new System.Drawing.Point(134, 174);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(125, 21);
            this.username.TabIndex = 0;
            this.username.Text = "Enter Your Username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 10F);
            this.label1.ForeColor = System.Drawing.Color.LimeGreen;
            this.label1.Location = new System.Drawing.Point(131, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 10F);
            this.label2.ForeColor = System.Drawing.Color.LimeGreen;
            this.label2.Location = new System.Drawing.Point(131, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password";
            // 
            // registerLabel
            // 
            this.registerLabel.AutoSize = true;
            this.registerLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registerLabel.Font = new System.Drawing.Font("Roboto", 10F);
            this.registerLabel.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.registerLabel.Location = new System.Drawing.Point(227, 322);
            this.registerLabel.Name = "registerLabel";
            this.registerLabel.Size = new System.Drawing.Size(145, 17);
            this.registerLabel.TabIndex = 3;
            this.registerLabel.TabStop = true;
            this.registerLabel.Text = "Register New Account";
            this.registerLabel.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.registerLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.registerLabel_LinkClicked);
            // 
            // WrongInfo
            // 
            this.WrongInfo.AutoSize = true;
            this.WrongInfo.Font = new System.Drawing.Font("Roboto", 10F);
            this.WrongInfo.ForeColor = System.Drawing.Color.Tomato;
            this.WrongInfo.Location = new System.Drawing.Point(103, 130);
            this.WrongInfo.Name = "WrongInfo";
            this.WrongInfo.Size = new System.Drawing.Size(197, 17);
            this.WrongInfo.TabIndex = 7;
            this.WrongInfo.Text = "Wrong Password or Username\r\n";
            this.WrongInfo.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ATM_GUI.Properties.Resources.coolbank;
            this.pictureBox1.Location = new System.Drawing.Point(95, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(208, 87);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.WrongInfo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.registerLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.username);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.password);
            this.Name = "LoginForm";
            this.Text = "ATM GUI";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel registerLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label WrongInfo;
    }
}

