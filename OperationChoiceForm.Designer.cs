namespace ATM_GUI
{
    partial class OperationChoiceForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.chooseOperationLabel = new System.Windows.Forms.Label();
            this.depositButton = new System.Windows.Forms.Button();
            this.withdrawButton = new System.Windows.Forms.Button();
            this.showBalanceButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ATM_GUI.Properties.Resources.coolbank;
            this.pictureBox1.Location = new System.Drawing.Point(113, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(208, 87);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // chooseOperationLabel
            // 
            this.chooseOperationLabel.AutoSize = true;
            this.chooseOperationLabel.Font = new System.Drawing.Font("Montserrat", 24F);
            this.chooseOperationLabel.ForeColor = System.Drawing.Color.White;
            this.chooseOperationLabel.Location = new System.Drawing.Point(64, 102);
            this.chooseOperationLabel.Name = "chooseOperationLabel";
            this.chooseOperationLabel.Size = new System.Drawing.Size(311, 44);
            this.chooseOperationLabel.TabIndex = 8;
            this.chooseOperationLabel.Text = "Choose Operation";
            // 
            // depositButton
            // 
            this.depositButton.BackColor = System.Drawing.Color.LimeGreen;
            this.depositButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.depositButton.Font = new System.Drawing.Font("Roboto", 12F);
            this.depositButton.ForeColor = System.Drawing.Color.Black;
            this.depositButton.Location = new System.Drawing.Point(42, 175);
            this.depositButton.Name = "depositButton";
            this.depositButton.Size = new System.Drawing.Size(134, 41);
            this.depositButton.TabIndex = 9;
            this.depositButton.Text = "Deposit";
            this.depositButton.UseVisualStyleBackColor = false;
            this.depositButton.Click += new System.EventHandler(this.depositButton_Click);
            // 
            // withdrawButton
            // 
            this.withdrawButton.BackColor = System.Drawing.Color.LimeGreen;
            this.withdrawButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.withdrawButton.Font = new System.Drawing.Font("Roboto", 12F);
            this.withdrawButton.ForeColor = System.Drawing.Color.Black;
            this.withdrawButton.Location = new System.Drawing.Point(256, 175);
            this.withdrawButton.Name = "withdrawButton";
            this.withdrawButton.Size = new System.Drawing.Size(134, 41);
            this.withdrawButton.TabIndex = 10;
            this.withdrawButton.Text = "Withdraw";
            this.withdrawButton.UseVisualStyleBackColor = false;
            this.withdrawButton.Click += new System.EventHandler(this.withdrawButton_Click);
            // 
            // showBalanceButton
            // 
            this.showBalanceButton.BackColor = System.Drawing.Color.LimeGreen;
            this.showBalanceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showBalanceButton.Font = new System.Drawing.Font("Roboto", 12F);
            this.showBalanceButton.ForeColor = System.Drawing.Color.Black;
            this.showBalanceButton.Location = new System.Drawing.Point(42, 240);
            this.showBalanceButton.Name = "showBalanceButton";
            this.showBalanceButton.Size = new System.Drawing.Size(134, 41);
            this.showBalanceButton.TabIndex = 11;
            this.showBalanceButton.Text = "Show Balance";
            this.showBalanceButton.UseVisualStyleBackColor = false;
            this.showBalanceButton.Click += new System.EventHandler(this.showBalanceButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.Salmon;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Font = new System.Drawing.Font("Roboto", 12F);
            this.cancelButton.ForeColor = System.Drawing.Color.Black;
            this.cancelButton.Location = new System.Drawing.Point(256, 240);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(134, 41);
            this.cancelButton.TabIndex = 12;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // OperationChoiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(432, 319);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.showBalanceButton);
            this.Controls.Add(this.withdrawButton);
            this.Controls.Add(this.depositButton);
            this.Controls.Add(this.chooseOperationLabel);
            this.Controls.Add(this.pictureBox1);
            this.Name = "OperationChoiceForm";
            this.Text = "Choose Operation";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label chooseOperationLabel;
        private System.Windows.Forms.Button depositButton;
        private System.Windows.Forms.Button withdrawButton;
        private System.Windows.Forms.Button showBalanceButton;
        private System.Windows.Forms.Button cancelButton;
    }
}