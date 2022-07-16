namespace Activity4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.conversion_btn = new System.Windows.Forms.Button();
            this.secondsInput_txtbox = new System.Windows.Forms.TextBox();
            this.secondsInLabel = new System.Windows.Forms.Label();
            this.secondsOutTextBox = new System.Windows.Forms.TextBox();
            this.minutesOutTextBox = new System.Windows.Forms.TextBox();
            this.hoursOutTextBox = new System.Windows.Forms.TextBox();
            this.daysOutTextBox = new System.Windows.Forms.TextBox();
            this.secondLabel = new System.Windows.Forms.Label();
            this.minutesOutLabel = new System.Windows.Forms.Label();
            this.hoursOutLabel = new System.Windows.Forms.Label();
            this.daysOutLabel = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // conversion_btn
            // 
            this.conversion_btn.Location = new System.Drawing.Point(43, 478);
            this.conversion_btn.Name = "conversion_btn";
            this.conversion_btn.Size = new System.Drawing.Size(75, 28);
            this.conversion_btn.TabIndex = 0;
            this.conversion_btn.Text = "Convert";
            this.conversion_btn.UseVisualStyleBackColor = true;
            this.conversion_btn.Click += new System.EventHandler(this.conversion_btn_Click);
            // 
            // secondsInput_txtbox
            // 
            this.secondsInput_txtbox.Location = new System.Drawing.Point(184, 105);
            this.secondsInput_txtbox.Name = "secondsInput_txtbox";
            this.secondsInput_txtbox.Size = new System.Drawing.Size(100, 23);
            this.secondsInput_txtbox.TabIndex = 1;
            // 
            // secondsInLabel
            // 
            this.secondsInLabel.AutoSize = true;
            this.secondsInLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.secondsInLabel.Location = new System.Drawing.Point(12, 107);
            this.secondsInLabel.Name = "secondsInLabel";
            this.secondsInLabel.Size = new System.Drawing.Size(166, 21);
            this.secondsInLabel.TabIndex = 2;
            this.secondsInLabel.Text = "Enter seconds elapsed:";
            // 
            // secondsOutTextBox
            // 
            this.secondsOutTextBox.Location = new System.Drawing.Point(184, 221);
            this.secondsOutTextBox.Name = "secondsOutTextBox";
            this.secondsOutTextBox.Size = new System.Drawing.Size(100, 23);
            this.secondsOutTextBox.TabIndex = 3;
            // 
            // minutesOutTextBox
            // 
            this.minutesOutTextBox.Location = new System.Drawing.Point(184, 276);
            this.minutesOutTextBox.Name = "minutesOutTextBox";
            this.minutesOutTextBox.Size = new System.Drawing.Size(100, 23);
            this.minutesOutTextBox.TabIndex = 4;
            // 
            // hoursOutTextBox
            // 
            this.hoursOutTextBox.Location = new System.Drawing.Point(184, 327);
            this.hoursOutTextBox.Name = "hoursOutTextBox";
            this.hoursOutTextBox.Size = new System.Drawing.Size(100, 23);
            this.hoursOutTextBox.TabIndex = 5;
            // 
            // daysOutTextBox
            // 
            this.daysOutTextBox.Location = new System.Drawing.Point(184, 384);
            this.daysOutTextBox.Name = "daysOutTextBox";
            this.daysOutTextBox.Size = new System.Drawing.Size(100, 23);
            this.daysOutTextBox.TabIndex = 6;
            // 
            // secondLabel
            // 
            this.secondLabel.AutoSize = true;
            this.secondLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.secondLabel.Location = new System.Drawing.Point(107, 223);
            this.secondLabel.Name = "secondLabel";
            this.secondLabel.Size = new System.Drawing.Size(71, 21);
            this.secondLabel.TabIndex = 7;
            this.secondLabel.Text = "Seconds:";
            // 
            // minutesOutLabel
            // 
            this.minutesOutLabel.AutoSize = true;
            this.minutesOutLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.minutesOutLabel.Location = new System.Drawing.Point(107, 278);
            this.minutesOutLabel.Name = "minutesOutLabel";
            this.minutesOutLabel.Size = new System.Drawing.Size(69, 21);
            this.minutesOutLabel.TabIndex = 8;
            this.minutesOutLabel.Text = "Minutes:";
            // 
            // hoursOutLabel
            // 
            this.hoursOutLabel.AutoSize = true;
            this.hoursOutLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.hoursOutLabel.Location = new System.Drawing.Point(107, 329);
            this.hoursOutLabel.Name = "hoursOutLabel";
            this.hoursOutLabel.Size = new System.Drawing.Size(55, 21);
            this.hoursOutLabel.TabIndex = 9;
            this.hoursOutLabel.Text = "Hours:";
            // 
            // daysOutLabel
            // 
            this.daysOutLabel.AutoSize = true;
            this.daysOutLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.daysOutLabel.Location = new System.Drawing.Point(107, 386);
            this.daysOutLabel.Name = "daysOutLabel";
            this.daysOutLabel.Size = new System.Drawing.Size(47, 21);
            this.daysOutLabel.TabIndex = 10;
            this.daysOutLabel.Text = "Days:";
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(209, 481);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 11;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 518);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.daysOutLabel);
            this.Controls.Add(this.hoursOutLabel);
            this.Controls.Add(this.minutesOutLabel);
            this.Controls.Add(this.secondLabel);
            this.Controls.Add(this.daysOutTextBox);
            this.Controls.Add(this.hoursOutTextBox);
            this.Controls.Add(this.minutesOutTextBox);
            this.Controls.Add(this.secondsOutTextBox);
            this.Controls.Add(this.secondsInLabel);
            this.Controls.Add(this.secondsInput_txtbox);
            this.Controls.Add(this.conversion_btn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Activity4";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button conversion_btn;
        private TextBox secondsInput_txtbox;
        private Label secondsInLabel;
        private TextBox secondsOutTextBox;
        private TextBox minutesOutTextBox;
        private TextBox hoursOutTextBox;
        private TextBox daysOutTextBox;
        private Label secondLabel;
        private Label minutesOutLabel;
        private Label hoursOutLabel;
        private Label daysOutLabel;
        private Button clearButton;
    }
}