namespace joe_and_bob_banking
{
    partial class Form1
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
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.secondNameLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.secondNameDollars = new System.Windows.Forms.Label();
            this.firstNameDollars = new System.Windows.Forms.Label();
            this.valueToTransfer = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.firstUserTransferButton = new System.Windows.Forms.Button();
            this.secondUserTransferButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(9, 9);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(53, 13);
            this.firstNameLabel.TabIndex = 0;
            this.firstNameLabel.Text = "nameOne";
            // 
            // secondNameLabel
            // 
            this.secondNameLabel.AutoSize = true;
            this.secondNameLabel.Location = new System.Drawing.Point(9, 31);
            this.secondNameLabel.Name = "secondNameLabel";
            this.secondNameLabel.Size = new System.Drawing.Size(54, 13);
            this.secondNameLabel.TabIndex = 1;
            this.secondNameLabel.Text = "nameTwo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(119, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "has";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(119, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "has";
            // 
            // secondNameDollars
            // 
            this.secondNameDollars.AutoSize = true;
            this.secondNameDollars.Location = new System.Drawing.Point(149, 31);
            this.secondNameDollars.Name = "secondNameDollars";
            this.secondNameDollars.Size = new System.Drawing.Size(13, 13);
            this.secondNameDollars.TabIndex = 4;
            this.secondNameDollars.Text = "0";
            // 
            // firstNameDollars
            // 
            this.firstNameDollars.AutoSize = true;
            this.firstNameDollars.Location = new System.Drawing.Point(149, 9);
            this.firstNameDollars.Name = "firstNameDollars";
            this.firstNameDollars.Size = new System.Drawing.Size(13, 13);
            this.firstNameDollars.TabIndex = 5;
            this.firstNameDollars.Text = "0";
            // 
            // valueToTransfer
            // 
            this.valueToTransfer.Location = new System.Drawing.Point(12, 58);
            this.valueToTransfer.Name = "valueToTransfer";
            this.valueToTransfer.Size = new System.Drawing.Size(100, 20);
            this.valueToTransfer.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(119, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Money to transfer";
            // 
            // firstUserTransferButton
            // 
            this.firstUserTransferButton.Location = new System.Drawing.Point(15, 99);
            this.firstUserTransferButton.Name = "firstUserTransferButton";
            this.firstUserTransferButton.Size = new System.Drawing.Size(147, 23);
            this.firstUserTransferButton.TabIndex = 8;
            this.firstUserTransferButton.Text = "Transfer to user1";
            this.firstUserTransferButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.firstUserTransferButton.UseVisualStyleBackColor = true;
            this.firstUserTransferButton.Click += new System.EventHandler(this.firstUserTransferButton_Click);
            // 
            // secondUserTransferButton
            // 
            this.secondUserTransferButton.Location = new System.Drawing.Point(168, 99);
            this.secondUserTransferButton.Name = "secondUserTransferButton";
            this.secondUserTransferButton.Size = new System.Drawing.Size(147, 23);
            this.secondUserTransferButton.TabIndex = 9;
            this.secondUserTransferButton.Text = "Transfer to user1";
            this.secondUserTransferButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.secondUserTransferButton.UseVisualStyleBackColor = true;
            this.secondUserTransferButton.Click += new System.EventHandler(this.secondUserTransferButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 138);
            this.Controls.Add(this.secondUserTransferButton);
            this.Controls.Add(this.firstUserTransferButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.valueToTransfer);
            this.Controls.Add(this.firstNameDollars);
            this.Controls.Add(this.secondNameDollars);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.secondNameLabel);
            this.Controls.Add(this.firstNameLabel);
            this.Name = "Form1";
            this.Text = "Two User Ledger";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label secondNameLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label secondNameDollars;
        private System.Windows.Forms.Label firstNameDollars;
        private System.Windows.Forms.TextBox valueToTransfer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button firstUserTransferButton;
        private System.Windows.Forms.Button secondUserTransferButton;
    }
}

