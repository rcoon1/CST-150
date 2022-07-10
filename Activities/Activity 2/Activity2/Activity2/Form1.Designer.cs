namespace Activity2
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
            this.earthLabel = new System.Windows.Forms.Label();
            this.earthWeightBox = new System.Windows.Forms.TextBox();
            this.marsLabel = new System.Windows.Forms.Label();
            this.marsWeightBox = new System.Windows.Forms.TextBox();
            this.convertButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // earthLabel
            // 
            this.earthLabel.AutoSize = true;
            this.earthLabel.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.earthLabel.Location = new System.Drawing.Point(42, 45);
            this.earthLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.earthLabel.Name = "earthLabel";
            this.earthLabel.Size = new System.Drawing.Size(210, 19);
            this.earthLabel.TabIndex = 0;
            this.earthLabel.Text = "Enter your weight on Earth";
            // 
            // earthWeightBox
            // 
            this.earthWeightBox.Location = new System.Drawing.Point(289, 46);
            this.earthWeightBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.earthWeightBox.Name = "earthWeightBox";
            this.earthWeightBox.Size = new System.Drawing.Size(116, 23);
            this.earthWeightBox.TabIndex = 0;
            // 
            // marsLabel
            // 
            this.marsLabel.AutoSize = true;
            this.marsLabel.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.marsLabel.Location = new System.Drawing.Point(85, 107);
            this.marsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.marsLabel.Name = "marsLabel";
            this.marsLabel.Size = new System.Drawing.Size(165, 19);
            this.marsLabel.TabIndex = 1;
            this.marsLabel.Text = "Your Weight on Mars";
            // 
            // marsWeightBox
            // 
            this.marsWeightBox.Location = new System.Drawing.Point(289, 108);
            this.marsWeightBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.marsWeightBox.Name = "marsWeightBox";
            this.marsWeightBox.Size = new System.Drawing.Size(116, 23);
            this.marsWeightBox.TabIndex = 2;
            // 
            // convertButton
            // 
            this.convertButton.Location = new System.Drawing.Point(302, 191);
            this.convertButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(103, 34);
            this.convertButton.TabIndex = 3;
            this.convertButton.Text = "Convert";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 278);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.marsWeightBox);
            this.Controls.Add(this.marsLabel);
            this.Controls.Add(this.earthWeightBox);
            this.Controls.Add(this.earthLabel);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Your Weight on Mars";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label earthLabel;
        private System.Windows.Forms.TextBox earthWeightBox;
        private System.Windows.Forms.Label marsLabel;
        private System.Windows.Forms.TextBox marsWeightBox;
        private System.Windows.Forms.Button convertButton;
    }
}
