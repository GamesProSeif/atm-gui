namespace ATM_GUI
{
    partial class MainForm
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
            this.pinCode = new System.Windows.Forms.TextBox();
            this.enterButton = new System.Windows.Forms.Button();
            this.username = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // pinCode
            // 
            this.pinCode.Location = new System.Drawing.Point(163, 159);
            this.pinCode.Name = "pinCode";
            this.pinCode.Size = new System.Drawing.Size(100, 20);
            this.pinCode.TabIndex = 0;
            // 
            // enterButton
            // 
            this.enterButton.Location = new System.Drawing.Point(176, 185);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(75, 23);
            this.enterButton.TabIndex = 1;
            this.enterButton.Text = "Enter";
            this.enterButton.UseVisualStyleBackColor = true;
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(163, 133);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(100, 20);
            this.username.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 388);
            this.Controls.Add(this.username);
            this.Controls.Add(this.enterButton);
            this.Controls.Add(this.pinCode);
            this.Name = "MainForm";
            this.Text = "ATM GUI";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox pinCode;
        private System.Windows.Forms.Button enterButton;
        private System.Windows.Forms.TextBox username;
    }
}

