namespace WindowsFormsApplication5
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
            this.accountsBox = new System.Windows.Forms.GroupBox();
            this.savingsRadioButton = new System.Windows.Forms.RadioButton();
            this.checkingRadioButton = new System.Windows.Forms.RadioButton();
            this.accountRadioButton = new System.Windows.Forms.RadioButton();
            this.balanceBox = new System.Windows.Forms.TextBox();
            this.depositLabel = new System.Windows.Forms.Label();
            this.interestLabel = new System.Windows.Forms.Label();
            this.interestBox = new System.Windows.Forms.TextBox();
            this.feeLabel = new System.Windows.Forms.Label();
            this.feeBox = new System.Windows.Forms.TextBox();
            this.creditButton = new System.Windows.Forms.Button();
            this.debitButton = new System.Windows.Forms.Button();
            this.interestButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.amountBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.checkingBalanceBox = new System.Windows.Forms.TextBox();
            this.savingsBalanceBox = new System.Windows.Forms.TextBox();
            this.accountBalanceBox = new System.Windows.Forms.TextBox();
            this.depositButton = new System.Windows.Forms.Button();
            this.accountsBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // accountsBox
            // 
            this.accountsBox.Controls.Add(this.savingsRadioButton);
            this.accountsBox.Controls.Add(this.checkingRadioButton);
            this.accountsBox.Controls.Add(this.accountRadioButton);
            this.accountsBox.Location = new System.Drawing.Point(0, 0);
            this.accountsBox.Name = "accountsBox";
            this.accountsBox.Size = new System.Drawing.Size(200, 100);
            this.accountsBox.TabIndex = 0;
            this.accountsBox.TabStop = false;
            this.accountsBox.Text = "Accounts";
            // 
            // savingsRadioButton
            // 
            this.savingsRadioButton.AutoSize = true;
            this.savingsRadioButton.Location = new System.Drawing.Point(12, 65);
            this.savingsRadioButton.Name = "savingsRadioButton";
            this.savingsRadioButton.Size = new System.Drawing.Size(63, 17);
            this.savingsRadioButton.TabIndex = 1;
            this.savingsRadioButton.Text = "Savings";
            this.savingsRadioButton.UseVisualStyleBackColor = true;
            this.savingsRadioButton.CheckedChanged += new System.EventHandler(this.savingsRadioButton_CheckedChanged);
            // 
            // checkingRadioButton
            // 
            this.checkingRadioButton.AutoSize = true;
            this.checkingRadioButton.Location = new System.Drawing.Point(12, 42);
            this.checkingRadioButton.Name = "checkingRadioButton";
            this.checkingRadioButton.Size = new System.Drawing.Size(70, 17);
            this.checkingRadioButton.TabIndex = 1;
            this.checkingRadioButton.Text = "Checking";
            this.checkingRadioButton.UseVisualStyleBackColor = true;
            this.checkingRadioButton.CheckedChanged += new System.EventHandler(this.checkingRadioButton_CheckedChanged);
            // 
            // accountRadioButton
            // 
            this.accountRadioButton.AutoSize = true;
            this.accountRadioButton.Checked = true;
            this.accountRadioButton.Location = new System.Drawing.Point(12, 19);
            this.accountRadioButton.Name = "accountRadioButton";
            this.accountRadioButton.Size = new System.Drawing.Size(65, 17);
            this.accountRadioButton.TabIndex = 1;
            this.accountRadioButton.TabStop = true;
            this.accountRadioButton.Text = "Account";
            this.accountRadioButton.UseVisualStyleBackColor = true;
            this.accountRadioButton.CheckedChanged += new System.EventHandler(this.accountRadioButton_CheckedChanged);
            // 
            // balanceBox
            // 
            this.balanceBox.Location = new System.Drawing.Point(361, 20);
            this.balanceBox.Name = "balanceBox";
            this.balanceBox.Size = new System.Drawing.Size(100, 20);
            this.balanceBox.TabIndex = 1;
            // 
            // depositLabel
            // 
            this.depositLabel.AutoSize = true;
            this.depositLabel.Location = new System.Drawing.Point(207, 23);
            this.depositLabel.Name = "depositLabel";
            this.depositLabel.Size = new System.Drawing.Size(138, 13);
            this.depositLabel.TabIndex = 2;
            this.depositLabel.Text = "Deposit amount for account";
            // 
            // interestLabel
            // 
            this.interestLabel.AutoSize = true;
            this.interestLabel.Location = new System.Drawing.Point(207, 83);
            this.interestLabel.Name = "interestLabel";
            this.interestLabel.Size = new System.Drawing.Size(107, 13);
            this.interestLabel.TabIndex = 3;
            this.interestLabel.Text = "Input interest percent";
            // 
            // interestBox
            // 
            this.interestBox.Location = new System.Drawing.Point(361, 80);
            this.interestBox.Name = "interestBox";
            this.interestBox.Size = new System.Drawing.Size(100, 20);
            this.interestBox.TabIndex = 4;
            this.interestBox.Visible = false;
            // 
            // feeLabel
            // 
            this.feeLabel.AutoSize = true;
            this.feeLabel.Location = new System.Drawing.Point(207, 49);
            this.feeLabel.Name = "feeLabel";
            this.feeLabel.Size = new System.Drawing.Size(85, 13);
            this.feeLabel.TabIndex = 5;
            this.feeLabel.Text = "Input fee charge";
            // 
            // feeBox
            // 
            this.feeBox.Location = new System.Drawing.Point(361, 46);
            this.feeBox.Name = "feeBox";
            this.feeBox.Size = new System.Drawing.Size(100, 20);
            this.feeBox.TabIndex = 6;
            this.feeBox.Visible = false;
            // 
            // creditButton
            // 
            this.creditButton.Location = new System.Drawing.Point(320, 134);
            this.creditButton.Name = "creditButton";
            this.creditButton.Size = new System.Drawing.Size(75, 23);
            this.creditButton.TabIndex = 7;
            this.creditButton.Text = "Credit";
            this.creditButton.UseVisualStyleBackColor = true;
            this.creditButton.Click += new System.EventHandler(this.creditButton_Click);
            // 
            // debitButton
            // 
            this.debitButton.Location = new System.Drawing.Point(320, 175);
            this.debitButton.Name = "debitButton";
            this.debitButton.Size = new System.Drawing.Size(75, 23);
            this.debitButton.TabIndex = 8;
            this.debitButton.Text = "Debit";
            this.debitButton.UseVisualStyleBackColor = true;
            this.debitButton.Click += new System.EventHandler(this.debitButton_Click);
            // 
            // interestButton
            // 
            this.interestButton.Location = new System.Drawing.Point(320, 222);
            this.interestButton.Name = "interestButton";
            this.interestButton.Size = new System.Drawing.Size(75, 23);
            this.interestButton.TabIndex = 9;
            this.interestButton.Text = "Add interest";
            this.interestButton.UseVisualStyleBackColor = true;
            this.interestButton.Visible = false;
            this.interestButton.Click += new System.EventHandler(this.interestButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Please enter amount to charge";
            // 
            // amountBox
            // 
            this.amountBox.Location = new System.Drawing.Point(186, 177);
            this.amountBox.Name = "amountBox";
            this.amountBox.Size = new System.Drawing.Size(100, 20);
            this.amountBox.TabIndex = 11;
            this.amountBox.Text = "0.00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Checking balance";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Savings balance";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Account balance";
            // 
            // checkingBalanceBox
            // 
            this.checkingBalanceBox.Location = new System.Drawing.Point(186, 203);
            this.checkingBalanceBox.Name = "checkingBalanceBox";
            this.checkingBalanceBox.ReadOnly = true;
            this.checkingBalanceBox.Size = new System.Drawing.Size(100, 20);
            this.checkingBalanceBox.TabIndex = 15;
            this.checkingBalanceBox.Text = "$0.00";
            // 
            // savingsBalanceBox
            // 
            this.savingsBalanceBox.Location = new System.Drawing.Point(186, 225);
            this.savingsBalanceBox.Name = "savingsBalanceBox";
            this.savingsBalanceBox.ReadOnly = true;
            this.savingsBalanceBox.Size = new System.Drawing.Size(100, 20);
            this.savingsBalanceBox.TabIndex = 16;
            this.savingsBalanceBox.Text = "$0.00";
            // 
            // accountBalanceBox
            // 
            this.accountBalanceBox.Location = new System.Drawing.Point(186, 246);
            this.accountBalanceBox.Name = "accountBalanceBox";
            this.accountBalanceBox.ReadOnly = true;
            this.accountBalanceBox.Size = new System.Drawing.Size(100, 20);
            this.accountBalanceBox.TabIndex = 17;
            this.accountBalanceBox.Text = "$0.00";
            // 
            // depositButton
            // 
            this.depositButton.Location = new System.Drawing.Point(493, 78);
            this.depositButton.Name = "depositButton";
            this.depositButton.Size = new System.Drawing.Size(75, 23);
            this.depositButton.TabIndex = 18;
            this.depositButton.Text = "Deposit";
            this.depositButton.UseVisualStyleBackColor = true;
            this.depositButton.Click += new System.EventHandler(this.depositButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 268);
            this.Controls.Add(this.depositButton);
            this.Controls.Add(this.accountBalanceBox);
            this.Controls.Add(this.savingsBalanceBox);
            this.Controls.Add(this.checkingBalanceBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.amountBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.interestButton);
            this.Controls.Add(this.debitButton);
            this.Controls.Add(this.creditButton);
            this.Controls.Add(this.feeBox);
            this.Controls.Add(this.feeLabel);
            this.Controls.Add(this.interestBox);
            this.Controls.Add(this.interestLabel);
            this.Controls.Add(this.depositLabel);
            this.Controls.Add(this.balanceBox);
            this.Controls.Add(this.accountsBox);
            this.Name = "Form1";
            this.Text = "Banking Application";
            this.accountsBox.ResumeLayout(false);
            this.accountsBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox accountsBox;
        private System.Windows.Forms.RadioButton savingsRadioButton;
        private System.Windows.Forms.RadioButton checkingRadioButton;
        private System.Windows.Forms.RadioButton accountRadioButton;
        private System.Windows.Forms.TextBox balanceBox;
        private System.Windows.Forms.Label depositLabel;
        private System.Windows.Forms.Label interestLabel;
        private System.Windows.Forms.TextBox interestBox;
        private System.Windows.Forms.Label feeLabel;
        private System.Windows.Forms.TextBox feeBox;
        private System.Windows.Forms.Button creditButton;
        private System.Windows.Forms.Button debitButton;
        private System.Windows.Forms.Button interestButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox amountBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox checkingBalanceBox;
        private System.Windows.Forms.TextBox savingsBalanceBox;
        private System.Windows.Forms.TextBox accountBalanceBox;
        private System.Windows.Forms.Button depositButton;
    }
}

