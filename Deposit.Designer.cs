namespace ATM_GUI
{
    partial class Deposit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Deposit));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TB_DEPO = new System.Windows.Forms.TextBox();
            this.depositButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.logoutLabel = new System.Windows.Forms.LinkLabel();
            this.Back_button = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(152, 115);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "DEPOSIT";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LimeGreen;
            this.label3.Location = new System.Drawing.Point(80, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 19);
            this.label3.TabIndex = 25;
            this.label3.Text = "AMOUNT";
            // 
            // TB_DEPO
            // 
            this.TB_DEPO.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.TB_DEPO.ForeColor = System.Drawing.Color.Gray;
            this.TB_DEPO.Location = new System.Drawing.Point(198, 184);
            this.TB_DEPO.Name = "TB_DEPO";
            this.TB_DEPO.Size = new System.Drawing.Size(190, 20);
            this.TB_DEPO.TabIndex = 21;
            this.TB_DEPO.Text = "Enter The Amount";
            this.TB_DEPO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // depositButton
            // 
            this.depositButton.BackColor = System.Drawing.Color.LimeGreen;
            this.depositButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.depositButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.depositButton.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depositButton.Location = new System.Drawing.Point(254, 225);
            this.depositButton.Name = "depositButton";
            this.depositButton.Size = new System.Drawing.Size(134, 41);
            this.depositButton.TabIndex = 24;
            this.depositButton.Text = "DEPOSIT";
            this.depositButton.UseVisualStyleBackColor = false;
            this.depositButton.Click += new System.EventHandler(this.depositButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(454, 89);
            this.panel1.TabIndex = 31;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ATM_GUI.Properties.Resources.coolbank;
            this.pictureBox1.Location = new System.Drawing.Point(0, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(454, 87);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 361);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(454, 18);
            this.panel2.TabIndex = 32;
            // 
            // logoutLabel
            // 
            this.logoutLabel.ActiveLinkColor = System.Drawing.Color.DarkSalmon;
            this.logoutLabel.AutoSize = true;
            this.logoutLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoutLabel.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Bold);
            this.logoutLabel.LinkColor = System.Drawing.Color.Salmon;
            this.logoutLabel.Location = new System.Drawing.Point(188, 301);
            this.logoutLabel.Name = "logoutLabel";
            this.logoutLabel.Size = new System.Drawing.Size(70, 17);
            this.logoutLabel.TabIndex = 5;
            this.logoutLabel.TabStop = true;
            this.logoutLabel.Text = "LOGOUT";
            this.logoutLabel.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.logoutLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.logoutLabel_LinkClicked);
            // 
            // Back_button
            // 
            this.Back_button.BackColor = System.Drawing.Color.Salmon;
            this.Back_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Back_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Back_button.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back_button.Location = new System.Drawing.Point(84, 225);
            this.Back_button.Name = "Back_button";
            this.Back_button.Size = new System.Drawing.Size(134, 41);
            this.Back_button.TabIndex = 45;
            this.Back_button.Text = "BACK";
            this.Back_button.UseVisualStyleBackColor = false;
            this.Back_button.Click += new System.EventHandler(this.Back_button_Click);
            // 
            // Deposit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(454, 379);
            this.Controls.Add(this.Back_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.logoutLabel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TB_DEPO);
            this.Controls.Add(this.depositButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Deposit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "The Cool Bank";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TB_DEPO;
        private System.Windows.Forms.Button depositButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.LinkLabel logoutLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Back_button;
    }
}