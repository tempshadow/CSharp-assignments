namespace WindowsFormsApplication1
{
    partial class Daily_Cost_Calculator
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
            this.totalMilesDrivenLabel = new System.Windows.Forms.Label();
            this.costPerGallonLabel = new System.Windows.Forms.Label();
            this.averageMPGLabel = new System.Windows.Forms.Label();
            this.parkingFeesLabel = new System.Windows.Forms.Label();
            this.tollsLabel = new System.Windows.Forms.Label();
            this.totalMilesText = new System.Windows.Forms.TextBox();
            this.costPerGallonText = new System.Windows.Forms.TextBox();
            this.averageMPGText = new System.Windows.Forms.TextBox();
            this.parkingFeesText = new System.Windows.Forms.TextBox();
            this.tollsCostText = new System.Windows.Forms.TextBox();
            this.dailyCostLabel = new System.Windows.Forms.Label();
            this.totalText = new System.Windows.Forms.TextBox();
            this.totalButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // totalMilesDrivenLabel
            // 
            this.totalMilesDrivenLabel.AutoSize = true;
            this.totalMilesDrivenLabel.Location = new System.Drawing.Point(0, 0);
            this.totalMilesDrivenLabel.Name = "totalMilesDrivenLabel";
            this.totalMilesDrivenLabel.Size = new System.Drawing.Size(92, 13);
            this.totalMilesDrivenLabel.TabIndex = 0;
            this.totalMilesDrivenLabel.Text = "Total Miles Driven";
            // 
            // costPerGallonLabel
            // 
            this.costPerGallonLabel.AutoSize = true;
            this.costPerGallonLabel.Location = new System.Drawing.Point(0, 28);
            this.costPerGallonLabel.Name = "costPerGallonLabel";
            this.costPerGallonLabel.Size = new System.Drawing.Size(126, 13);
            this.costPerGallonLabel.TabIndex = 1;
            this.costPerGallonLabel.Text = "Cost Per Gallon( in cents)";
            // 
            // averageMPGLabel
            // 
            this.averageMPGLabel.AutoSize = true;
            this.averageMPGLabel.Location = new System.Drawing.Point(0, 54);
            this.averageMPGLabel.Name = "averageMPGLabel";
            this.averageMPGLabel.Size = new System.Drawing.Size(126, 13);
            this.averageMPGLabel.TabIndex = 2;
            this.averageMPGLabel.Text = "Average Miles Per Gallon";
            // 
            // parkingFeesLabel
            // 
            this.parkingFeesLabel.AutoSize = true;
            this.parkingFeesLabel.Location = new System.Drawing.Point(1, 88);
            this.parkingFeesLabel.Name = "parkingFeesLabel";
            this.parkingFeesLabel.Size = new System.Drawing.Size(156, 13);
            this.parkingFeesLabel.TabIndex = 3;
            this.parkingFeesLabel.Text = "Parking Fees Per Day( in cents)";
            // 
            // tollsLabel
            // 
            this.tollsLabel.AutoSize = true;
            this.tollsLabel.Location = new System.Drawing.Point(0, 118);
            this.tollsLabel.Name = "tollsLabel";
            this.tollsLabel.Size = new System.Drawing.Size(116, 13);
            this.tollsLabel.TabIndex = 4;
            this.tollsLabel.Text = "Tolls Per Day( in cents)";
            // 
            // totalMilesText
            // 
            this.totalMilesText.Location = new System.Drawing.Point(183, 0);
            this.totalMilesText.Name = "totalMilesText";
            this.totalMilesText.Size = new System.Drawing.Size(100, 20);
            this.totalMilesText.TabIndex = 5;
            // 
            // costPerGallonText
            // 
            this.costPerGallonText.Location = new System.Drawing.Point(183, 28);
            this.costPerGallonText.Name = "costPerGallonText";
            this.costPerGallonText.Size = new System.Drawing.Size(100, 20);
            this.costPerGallonText.TabIndex = 6;
            // 
            // averageMPGText
            // 
            this.averageMPGText.Location = new System.Drawing.Point(183, 54);
            this.averageMPGText.Name = "averageMPGText";
            this.averageMPGText.Size = new System.Drawing.Size(100, 20);
            this.averageMPGText.TabIndex = 7;
            // 
            // parkingFeesText
            // 
            this.parkingFeesText.Location = new System.Drawing.Point(183, 88);
            this.parkingFeesText.Name = "parkingFeesText";
            this.parkingFeesText.Size = new System.Drawing.Size(100, 20);
            this.parkingFeesText.TabIndex = 8;
            // 
            // tollsCostText
            // 
            this.tollsCostText.Location = new System.Drawing.Point(183, 118);
            this.tollsCostText.Name = "tollsCostText";
            this.tollsCostText.Size = new System.Drawing.Size(100, 20);
            this.tollsCostText.TabIndex = 9;
            // 
            // dailyCostLabel
            // 
            this.dailyCostLabel.AutoSize = true;
            this.dailyCostLabel.Location = new System.Drawing.Point(1, 150);
            this.dailyCostLabel.Name = "dailyCostLabel";
            this.dailyCostLabel.Size = new System.Drawing.Size(100, 13);
            this.dailyCostLabel.TabIndex = 10;
            this.dailyCostLabel.Text = "Daily Cost( in cents)";
            // 
            // totalText
            // 
            this.totalText.Location = new System.Drawing.Point(183, 150);
            this.totalText.Name = "totalText";
            this.totalText.ReadOnly = true;
            this.totalText.Size = new System.Drawing.Size(100, 20);
            this.totalText.TabIndex = 11;
            // 
            // totalButton
            // 
            this.totalButton.Location = new System.Drawing.Point(41, 200);
            this.totalButton.Name = "totalButton";
            this.totalButton.Size = new System.Drawing.Size(75, 23);
            this.totalButton.TabIndex = 12;
            this.totalButton.Text = "Calculate";
            this.totalButton.UseVisualStyleBackColor = true;
            this.totalButton.Click += new System.EventHandler(this.totalButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(163, 200);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 13;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Daily_Cost_Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.totalButton);
            this.Controls.Add(this.totalText);
            this.Controls.Add(this.dailyCostLabel);
            this.Controls.Add(this.tollsCostText);
            this.Controls.Add(this.parkingFeesText);
            this.Controls.Add(this.averageMPGText);
            this.Controls.Add(this.costPerGallonText);
            this.Controls.Add(this.totalMilesText);
            this.Controls.Add(this.tollsLabel);
            this.Controls.Add(this.parkingFeesLabel);
            this.Controls.Add(this.averageMPGLabel);
            this.Controls.Add(this.costPerGallonLabel);
            this.Controls.Add(this.totalMilesDrivenLabel);
            this.Name = "Daily_Cost_Calculator";
            this.Text = "Daily Driving Cost Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label totalMilesDrivenLabel;
        private System.Windows.Forms.Label costPerGallonLabel;
        private System.Windows.Forms.Label averageMPGLabel;
        private System.Windows.Forms.Label parkingFeesLabel;
        private System.Windows.Forms.Label tollsLabel;
        private System.Windows.Forms.TextBox totalMilesText;
        private System.Windows.Forms.TextBox costPerGallonText;
        private System.Windows.Forms.TextBox averageMPGText;
        private System.Windows.Forms.TextBox parkingFeesText;
        private System.Windows.Forms.TextBox tollsCostText;
        private System.Windows.Forms.Label dailyCostLabel;
        private System.Windows.Forms.TextBox totalText;
        private System.Windows.Forms.Button totalButton;
        private System.Windows.Forms.Button exitButton;
    }
}

