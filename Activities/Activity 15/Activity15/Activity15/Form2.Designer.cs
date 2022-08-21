namespace Activity15
{
    partial class Form2
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
            this.luckyLabel = new System.Windows.Forms.Label();
            this.luckyNumberLabel = new System.Windows.Forms.Label();
            this.quoteButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // luckyLabel
            // 
            this.luckyLabel.AutoSize = true;
            this.luckyLabel.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.luckyLabel.ForeColor = System.Drawing.Color.Red;
            this.luckyLabel.Location = new System.Drawing.Point(12, 32);
            this.luckyLabel.Name = "luckyLabel";
            this.luckyLabel.Size = new System.Drawing.Size(245, 24);
            this.luckyLabel.TabIndex = 0;
            this.luckyLabel.Text = "Your lucky number is...";
            // 
            // luckyNumberLabel
            // 
            this.luckyNumberLabel.AutoSize = true;
            this.luckyNumberLabel.Font = new System.Drawing.Font("Lucida Sans", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.luckyNumberLabel.ForeColor = System.Drawing.Color.Red;
            this.luckyNumberLabel.Location = new System.Drawing.Point(70, 84);
            this.luckyNumberLabel.Name = "luckyNumberLabel";
            this.luckyNumberLabel.Size = new System.Drawing.Size(150, 72);
            this.luckyNumberLabel.TabIndex = 1;
            this.luckyNumberLabel.Text = "252";
            // 
            // quoteButton
            // 
            this.quoteButton.Location = new System.Drawing.Point(12, 205);
            this.quoteButton.Name = "quoteButton";
            this.quoteButton.Size = new System.Drawing.Size(87, 35);
            this.quoteButton.TabIndex = 2;
            this.quoteButton.Text = "Random Inspiration";
            this.quoteButton.UseVisualStyleBackColor = true;
            this.quoteButton.Click += new System.EventHandler(this.quoteButton_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(182, 205);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 35);
            this.backButton.TabIndex = 3;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(265, 252);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.quoteButton);
            this.Controls.Add(this.luckyNumberLabel);
            this.Controls.Add(this.luckyLabel);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label luckyLabel;
        private System.Windows.Forms.Label luckyNumberLabel;
        private System.Windows.Forms.Button quoteButton;
        private System.Windows.Forms.Button backButton;
    }
}