namespace WindowsFormsApplication4
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
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.directorySearcher2 = new System.DirectoryServices.DirectorySearcher();
            this.directorySearcher3 = new System.DirectoryServices.DirectorySearcher();
            this.directorySearcher4 = new System.DirectoryServices.DirectorySearcher();
            this.directorySearcher5 = new System.DirectoryServices.DirectorySearcher();
            this.directorySearcher6 = new System.DirectoryServices.DirectorySearcher();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.folderBrowserDialog2 = new System.Windows.Forms.FolderBrowserDialog();
            this.folderBrowserDialog3 = new System.Windows.Forms.FolderBrowserDialog();
            this.folderBrowserDialog4 = new System.Windows.Forms.FolderBrowserDialog();
            this.folderBrowserDialog5 = new System.Windows.Forms.FolderBrowserDialog();
            this.folderBrowserDialog6 = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBoxCourse = new System.Windows.Forms.GroupBox();
            this.radioButtonSalad = new System.Windows.Forms.RadioButton();
            this.radioButtonPizza = new System.Windows.Forms.RadioButton();
            this.radioButtonHamburger = new System.Windows.Forms.RadioButton();
            this.groupBoxAddOnItems = new System.Windows.Forms.GroupBox();
            this.addOn3 = new System.Windows.Forms.CheckBox();
            this.addOn2 = new System.Windows.Forms.CheckBox();
            this.addOn1 = new System.Windows.Forms.CheckBox();
            this.groupBoxTotal = new System.Windows.Forms.GroupBox();
            this.textBoxTotal = new System.Windows.Forms.TextBox();
            this.textBoxTax = new System.Windows.Forms.TextBox();
            this.textBoxSubtotal = new System.Windows.Forms.TextBox();
            this.labelTotal = new System.Windows.Forms.Label();
            this.labelTax = new System.Windows.Forms.Label();
            this.labelSubtotal = new System.Windows.Forms.Label();
            this.calculate = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.groupBoxCourse.SuspendLayout();
            this.groupBoxAddOnItems.SuspendLayout();
            this.groupBoxTotal.SuspendLayout();
            this.SuspendLayout();
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // directorySearcher2
            // 
            this.directorySearcher2.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher2.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher2.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // directorySearcher3
            // 
            this.directorySearcher3.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher3.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher3.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // directorySearcher4
            // 
            this.directorySearcher4.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher4.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher4.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // directorySearcher5
            // 
            this.directorySearcher5.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher5.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher5.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // directorySearcher6
            // 
            this.directorySearcher6.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher6.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher6.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // groupBoxCourse
            // 
            this.groupBoxCourse.Controls.Add(this.radioButtonSalad);
            this.groupBoxCourse.Controls.Add(this.radioButtonPizza);
            this.groupBoxCourse.Controls.Add(this.radioButtonHamburger);
            this.groupBoxCourse.Location = new System.Drawing.Point(12, 12);
            this.groupBoxCourse.Name = "groupBoxCourse";
            this.groupBoxCourse.Size = new System.Drawing.Size(127, 100);
            this.groupBoxCourse.TabIndex = 0;
            this.groupBoxCourse.TabStop = false;
            this.groupBoxCourse.Text = "Main course";
            // 
            // radioButtonSalad
            // 
            this.radioButtonSalad.AutoSize = true;
            this.radioButtonSalad.Location = new System.Drawing.Point(6, 65);
            this.radioButtonSalad.Name = "radioButtonSalad";
            this.radioButtonSalad.Size = new System.Drawing.Size(88, 17);
            this.radioButtonSalad.TabIndex = 5;
            this.radioButtonSalad.Text = "Salad - $4.95";
            this.radioButtonSalad.UseVisualStyleBackColor = true;
            this.radioButtonSalad.CheckedChanged += new System.EventHandler(this.radioButtonSalad_CheckedChanged);
            // 
            // radioButtonPizza
            // 
            this.radioButtonPizza.AutoSize = true;
            this.radioButtonPizza.Location = new System.Drawing.Point(6, 42);
            this.radioButtonPizza.Name = "radioButtonPizza";
            this.radioButtonPizza.Size = new System.Drawing.Size(86, 17);
            this.radioButtonPizza.TabIndex = 4;
            this.radioButtonPizza.Text = "Pizza - $5.95";
            this.radioButtonPizza.UseVisualStyleBackColor = true;
            this.radioButtonPizza.CheckedChanged += new System.EventHandler(this.radioButtonPizza_CheckedChanged);
            // 
            // radioButtonHamburger
            // 
            this.radioButtonHamburger.AutoSize = true;
            this.radioButtonHamburger.Checked = true;
            this.radioButtonHamburger.Location = new System.Drawing.Point(6, 19);
            this.radioButtonHamburger.Name = "radioButtonHamburger";
            this.radioButtonHamburger.Size = new System.Drawing.Size(113, 17);
            this.radioButtonHamburger.TabIndex = 4;
            this.radioButtonHamburger.TabStop = true;
            this.radioButtonHamburger.Text = "Hamburger - $6.95";
            this.radioButtonHamburger.UseVisualStyleBackColor = true;
            this.radioButtonHamburger.CheckedChanged += new System.EventHandler(this.radioButtonHamburger_CheckedChanged);
            // 
            // groupBoxAddOnItems
            // 
            this.groupBoxAddOnItems.Controls.Add(this.addOn3);
            this.groupBoxAddOnItems.Controls.Add(this.addOn2);
            this.groupBoxAddOnItems.Controls.Add(this.addOn1);
            this.groupBoxAddOnItems.Location = new System.Drawing.Point(164, 12);
            this.groupBoxAddOnItems.Name = "groupBoxAddOnItems";
            this.groupBoxAddOnItems.Size = new System.Drawing.Size(181, 100);
            this.groupBoxAddOnItems.TabIndex = 1;
            this.groupBoxAddOnItems.TabStop = false;
            this.groupBoxAddOnItems.Text = "Add-on items ($.75/each)";
            // 
            // addOn3
            // 
            this.addOn3.AutoSize = true;
            this.addOn3.Location = new System.Drawing.Point(6, 66);
            this.addOn3.Name = "addOn3";
            this.addOn3.Size = new System.Drawing.Size(81, 17);
            this.addOn3.TabIndex = 4;
            this.addOn3.Text = "French fries";
            this.addOn3.UseVisualStyleBackColor = true;
            this.addOn3.CheckedChanged += new System.EventHandler(this.addOn3_CheckedChanged);
            // 
            // addOn2
            // 
            this.addOn2.AutoSize = true;
            this.addOn2.Location = new System.Drawing.Point(6, 43);
            this.addOn2.Name = "addOn2";
            this.addOn2.Size = new System.Drawing.Size(161, 17);
            this.addOn2.TabIndex = 4;
            this.addOn2.Text = "Ketchup, mustard, and mayo";
            this.addOn2.UseVisualStyleBackColor = true;
            this.addOn2.CheckedChanged += new System.EventHandler(this.addOn2_CheckedChanged);
            // 
            // addOn1
            // 
            this.addOn1.AutoSize = true;
            this.addOn1.Location = new System.Drawing.Point(6, 20);
            this.addOn1.Name = "addOn1";
            this.addOn1.Size = new System.Drawing.Size(158, 17);
            this.addOn1.TabIndex = 4;
            this.addOn1.Text = "Lettuce, tomato, and onions";
            this.addOn1.UseVisualStyleBackColor = true;
            this.addOn1.CheckedChanged += new System.EventHandler(this.addOn1_CheckedChanged);
            // 
            // groupBoxTotal
            // 
            this.groupBoxTotal.Controls.Add(this.textBoxTotal);
            this.groupBoxTotal.Controls.Add(this.textBoxTax);
            this.groupBoxTotal.Controls.Add(this.textBoxSubtotal);
            this.groupBoxTotal.Controls.Add(this.labelTotal);
            this.groupBoxTotal.Controls.Add(this.labelTax);
            this.groupBoxTotal.Controls.Add(this.labelSubtotal);
            this.groupBoxTotal.Location = new System.Drawing.Point(12, 134);
            this.groupBoxTotal.Name = "groupBoxTotal";
            this.groupBoxTotal.Size = new System.Drawing.Size(200, 100);
            this.groupBoxTotal.TabIndex = 2;
            this.groupBoxTotal.TabStop = false;
            this.groupBoxTotal.Text = "Order total";
            // 
            // textBoxTotal
            // 
            this.textBoxTotal.Location = new System.Drawing.Point(94, 74);
            this.textBoxTotal.Name = "textBoxTotal";
            this.textBoxTotal.ReadOnly = true;
            this.textBoxTotal.Size = new System.Drawing.Size(100, 20);
            this.textBoxTotal.TabIndex = 4;
            this.textBoxTotal.Text = "$0.00";
            // 
            // textBoxTax
            // 
            this.textBoxTax.Location = new System.Drawing.Point(94, 48);
            this.textBoxTax.Name = "textBoxTax";
            this.textBoxTax.ReadOnly = true;
            this.textBoxTax.Size = new System.Drawing.Size(100, 20);
            this.textBoxTax.TabIndex = 4;
            this.textBoxTax.Text = "$0.00";
            // 
            // textBoxSubtotal
            // 
            this.textBoxSubtotal.Location = new System.Drawing.Point(94, 22);
            this.textBoxSubtotal.Name = "textBoxSubtotal";
            this.textBoxSubtotal.ReadOnly = true;
            this.textBoxSubtotal.Size = new System.Drawing.Size(100, 20);
            this.textBoxSubtotal.TabIndex = 7;
            this.textBoxSubtotal.Text = "$0.00";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(36, 77);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(59, 13);
            this.labelTotal.TabIndex = 6;
            this.labelTotal.Text = "Order total:";
            // 
            // labelTax
            // 
            this.labelTax.AutoSize = true;
            this.labelTax.Location = new System.Drawing.Point(32, 50);
            this.labelTax.Name = "labelTax";
            this.labelTax.Size = new System.Drawing.Size(63, 13);
            this.labelTax.TabIndex = 5;
            this.labelTax.Text = "Tax(7.75%):";
            // 
            // labelSubtotal
            // 
            this.labelSubtotal.AutoSize = true;
            this.labelSubtotal.Location = new System.Drawing.Point(46, 25);
            this.labelSubtotal.Name = "labelSubtotal";
            this.labelSubtotal.Size = new System.Drawing.Size(49, 13);
            this.labelSubtotal.TabIndex = 4;
            this.labelSubtotal.Text = "Subtotal:";
            // 
            // calculate
            // 
            this.calculate.Location = new System.Drawing.Point(255, 149);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(75, 23);
            this.calculate.TabIndex = 3;
            this.calculate.Text = "Place Order";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(255, 211);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(75, 23);
            this.exit.TabIndex = 0;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 261);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.groupBoxTotal);
            this.Controls.Add(this.groupBoxAddOnItems);
            this.Controls.Add(this.groupBoxCourse);
            this.Name = "Form1";
            this.Text = "Lunch Order";
            this.groupBoxCourse.ResumeLayout(false);
            this.groupBoxCourse.PerformLayout();
            this.groupBoxAddOnItems.ResumeLayout(false);
            this.groupBoxAddOnItems.PerformLayout();
            this.groupBoxTotal.ResumeLayout(false);
            this.groupBoxTotal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.DirectoryServices.DirectorySearcher directorySearcher2;
        private System.DirectoryServices.DirectorySearcher directorySearcher3;
        private System.DirectoryServices.DirectorySearcher directorySearcher4;
        private System.DirectoryServices.DirectorySearcher directorySearcher5;
        private System.DirectoryServices.DirectorySearcher directorySearcher6;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog2;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog3;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog4;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog5;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog6;
        private System.Windows.Forms.GroupBox groupBoxCourse;
        private System.Windows.Forms.RadioButton radioButtonSalad;
        private System.Windows.Forms.RadioButton radioButtonPizza;
        private System.Windows.Forms.RadioButton radioButtonHamburger;
        private System.Windows.Forms.GroupBox groupBoxAddOnItems;
        private System.Windows.Forms.CheckBox addOn3;
        private System.Windows.Forms.CheckBox addOn2;
        private System.Windows.Forms.CheckBox addOn1;
        private System.Windows.Forms.GroupBox groupBoxTotal;
        private System.Windows.Forms.TextBox textBoxTax;
        private System.Windows.Forms.TextBox textBoxSubtotal;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label labelTax;
        private System.Windows.Forms.Label labelSubtotal;
        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.TextBox textBoxTotal;
    }
}

