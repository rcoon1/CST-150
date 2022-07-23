namespace Activity5
{
    partial class Activity5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Activity5));
            this.selectFileButton = new System.Windows.Forms.Button();
            this.resultsTextBox = new System.Windows.Forms.TextBox();
            this.selectFileLabel = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.resultsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // selectFileButton
            // 
            this.selectFileButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.selectFileButton.Location = new System.Drawing.Point(331, 70);
            this.selectFileButton.Name = "selectFileButton";
            this.selectFileButton.Size = new System.Drawing.Size(75, 52);
            this.selectFileButton.TabIndex = 0;
            this.selectFileButton.Text = "Select File";
            this.selectFileButton.UseVisualStyleBackColor = true;
            this.selectFileButton.Click += new System.EventHandler(this.selectFileButton_Click);
            // 
            // resultsTextBox
            // 
            this.resultsTextBox.BackColor = System.Drawing.Color.AliceBlue;
            this.resultsTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.resultsTextBox.Location = new System.Drawing.Point(12, 186);
            this.resultsTextBox.Multiline = true;
            this.resultsTextBox.Name = "resultsTextBox";
            this.resultsTextBox.Size = new System.Drawing.Size(408, 173);
            this.resultsTextBox.TabIndex = 1;
            // 
            // selectFileLabel
            // 
            this.selectFileLabel.AutoSize = true;
            this.selectFileLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.selectFileLabel.Location = new System.Drawing.Point(113, 86);
            this.selectFileLabel.Name = "selectFileLabel";
            this.selectFileLabel.Size = new System.Drawing.Size(151, 21);
            this.selectFileLabel.TabIndex = 2;
            this.selectFileLabel.Text = "Select file to process";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            this.openFileDialog.Title = "File for processing";
            // 
            // resultsLabel
            // 
            this.resultsLabel.AutoSize = true;
            this.resultsLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.resultsLabel.Location = new System.Drawing.Point(12, 162);
            this.resultsLabel.Name = "resultsLabel";
            this.resultsLabel.Size = new System.Drawing.Size(214, 21);
            this.resultsLabel.TabIndex = 3;
            this.resultsLabel.Text = "Results from sorted input file:";
            // 
            // Activity5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(430, 371);
            this.Controls.Add(this.resultsLabel);
            this.Controls.Add(this.selectFileLabel);
            this.Controls.Add(this.resultsTextBox);
            this.Controls.Add(this.selectFileButton);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Activity5";
            this.Text = "Activity 5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button selectFileButton;
        private TextBox resultsTextBox;
        private Label selectFileLabel;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private Label resultsLabel;
    }
}