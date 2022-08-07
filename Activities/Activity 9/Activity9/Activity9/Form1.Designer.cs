namespace Activity9
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
            this.millimeterLabel = new System.Windows.Forms.Label();
            this.millimeterTextBox = new System.Windows.Forms.TextBox();
            this.convertButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.convertLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // millimeterLabel
            // 
            this.millimeterLabel.AutoSize = true;
            this.millimeterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.millimeterLabel.Location = new System.Drawing.Point(12, 50);
            this.millimeterLabel.Name = "millimeterLabel";
            this.millimeterLabel.Size = new System.Drawing.Size(130, 20);
            this.millimeterLabel.TabIndex = 0;
            this.millimeterLabel.Text = "Enter Millimeters:";
            // 
            // millimeterTextBox
            // 
            this.millimeterTextBox.Location = new System.Drawing.Point(145, 50);
            this.millimeterTextBox.Name = "millimeterTextBox";
            this.millimeterTextBox.Size = new System.Drawing.Size(100, 20);
            this.millimeterTextBox.TabIndex = 1;
            // 
            // convertButton
            // 
            this.convertButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convertButton.Location = new System.Drawing.Point(16, 101);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(89, 53);
            this.convertButton.TabIndex = 2;
            this.convertButton.Text = "Convert to Meters";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Location = new System.Drawing.Point(170, 101);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 53);
            this.clearButton.TabIndex = 3;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // convertLabel
            // 
            this.convertLabel.AutoSize = true;
            this.convertLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convertLabel.Location = new System.Drawing.Point(12, 168);
            this.convertLabel.Name = "convertLabel";
            this.convertLabel.Size = new System.Drawing.Size(0, 20);
            this.convertLabel.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(260, 238);
            this.Controls.Add(this.convertLabel);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.millimeterTextBox);
            this.Controls.Add(this.millimeterLabel);
            this.Name = "Form1";
            this.Text = "Conversion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label millimeterLabel;
        private System.Windows.Forms.TextBox millimeterTextBox;
        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.Button clearButton;
        public System.Windows.Forms.Label convertLabel;
    }
}

