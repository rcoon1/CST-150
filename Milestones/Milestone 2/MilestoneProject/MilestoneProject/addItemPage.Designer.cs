namespace MilestoneProject
{
    partial class addItemPage
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
            this.partNumberlabel = new System.Windows.Forms.Label();
            this.vendorLabel = new System.Windows.Forms.Label();
            this.onHandLabel = new System.Windows.Forms.Label();
            this.costLabel = new System.Windows.Forms.Label();
            this.sellPriceLabel = new System.Windows.Forms.Label();
            this.binLocationLabel = new System.Windows.Forms.Label();
            this.partNumberTextBox = new System.Windows.Forms.TextBox();
            this.onHandTextBox = new System.Windows.Forms.TextBox();
            this.costTextbox = new System.Windows.Forms.TextBox();
            this.sellPriceTextBox = new System.Windows.Forms.TextBox();
            this.vendorComboBox = new System.Windows.Forms.ComboBox();
            this.binLocationComboBox = new System.Windows.Forms.ComboBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // partNumberlabel
            // 
            this.partNumberlabel.AutoSize = true;
            this.partNumberlabel.Location = new System.Drawing.Point(29, 48);
            this.partNumberlabel.Name = "partNumberlabel";
            this.partNumberlabel.Size = new System.Drawing.Size(69, 13);
            this.partNumberlabel.TabIndex = 0;
            this.partNumberlabel.Text = "Part Number:";
            // 
            // vendorLabel
            // 
            this.vendorLabel.AutoSize = true;
            this.vendorLabel.Location = new System.Drawing.Point(29, 101);
            this.vendorLabel.Name = "vendorLabel";
            this.vendorLabel.Size = new System.Drawing.Size(44, 13);
            this.vendorLabel.TabIndex = 1;
            this.vendorLabel.Text = "Vendor:";
            // 
            // onHandLabel
            // 
            this.onHandLabel.AutoSize = true;
            this.onHandLabel.Location = new System.Drawing.Point(29, 149);
            this.onHandLabel.Name = "onHandLabel";
            this.onHandLabel.Size = new System.Drawing.Size(53, 13);
            this.onHandLabel.TabIndex = 2;
            this.onHandLabel.Text = "On Hand:";
            // 
            // costLabel
            // 
            this.costLabel.AutoSize = true;
            this.costLabel.Location = new System.Drawing.Point(29, 190);
            this.costLabel.Name = "costLabel";
            this.costLabel.Size = new System.Drawing.Size(31, 13);
            this.costLabel.TabIndex = 3;
            this.costLabel.Text = "Cost:";
            // 
            // sellPriceLabel
            // 
            this.sellPriceLabel.AutoSize = true;
            this.sellPriceLabel.Location = new System.Drawing.Point(29, 236);
            this.sellPriceLabel.Name = "sellPriceLabel";
            this.sellPriceLabel.Size = new System.Drawing.Size(54, 13);
            this.sellPriceLabel.TabIndex = 4;
            this.sellPriceLabel.Text = "Sell Price:";
            // 
            // binLocationLabel
            // 
            this.binLocationLabel.AutoSize = true;
            this.binLocationLabel.Location = new System.Drawing.Point(29, 280);
            this.binLocationLabel.Name = "binLocationLabel";
            this.binLocationLabel.Size = new System.Drawing.Size(69, 13);
            this.binLocationLabel.TabIndex = 5;
            this.binLocationLabel.Text = "Bin Location:";
            // 
            // partNumberTextBox
            // 
            this.partNumberTextBox.Location = new System.Drawing.Point(142, 45);
            this.partNumberTextBox.Name = "partNumberTextBox";
            this.partNumberTextBox.Size = new System.Drawing.Size(150, 20);
            this.partNumberTextBox.TabIndex = 6;
            // 
            // onHandTextBox
            // 
            this.onHandTextBox.Location = new System.Drawing.Point(142, 142);
            this.onHandTextBox.Name = "onHandTextBox";
            this.onHandTextBox.Size = new System.Drawing.Size(150, 20);
            this.onHandTextBox.TabIndex = 7;
            // 
            // costTextbox
            // 
            this.costTextbox.Location = new System.Drawing.Point(143, 183);
            this.costTextbox.Name = "costTextbox";
            this.costTextbox.Size = new System.Drawing.Size(150, 20);
            this.costTextbox.TabIndex = 8;
            // 
            // sellPriceTextBox
            // 
            this.sellPriceTextBox.Location = new System.Drawing.Point(143, 229);
            this.sellPriceTextBox.Name = "sellPriceTextBox";
            this.sellPriceTextBox.Size = new System.Drawing.Size(149, 20);
            this.sellPriceTextBox.TabIndex = 9;
            // 
            // vendorComboBox
            // 
            this.vendorComboBox.FormattingEnabled = true;
            this.vendorComboBox.Location = new System.Drawing.Point(143, 93);
            this.vendorComboBox.Name = "vendorComboBox";
            this.vendorComboBox.Size = new System.Drawing.Size(149, 21);
            this.vendorComboBox.TabIndex = 10;
            // 
            // binLocationComboBox
            // 
            this.binLocationComboBox.FormattingEnabled = true;
            this.binLocationComboBox.Location = new System.Drawing.Point(143, 272);
            this.binLocationComboBox.Name = "binLocationComboBox";
            this.binLocationComboBox.Size = new System.Drawing.Size(149, 21);
            this.binLocationComboBox.TabIndex = 11;
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(32, 341);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 12;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(218, 341);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 13;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // addItemPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 376);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.binLocationComboBox);
            this.Controls.Add(this.vendorComboBox);
            this.Controls.Add(this.sellPriceTextBox);
            this.Controls.Add(this.costTextbox);
            this.Controls.Add(this.onHandTextBox);
            this.Controls.Add(this.partNumberTextBox);
            this.Controls.Add(this.binLocationLabel);
            this.Controls.Add(this.sellPriceLabel);
            this.Controls.Add(this.costLabel);
            this.Controls.Add(this.onHandLabel);
            this.Controls.Add(this.vendorLabel);
            this.Controls.Add(this.partNumberlabel);
            this.Name = "addItemPage";
            this.Text = "Add Inventory Item";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label partNumberlabel;
        private System.Windows.Forms.Label vendorLabel;
        private System.Windows.Forms.Label onHandLabel;
        private System.Windows.Forms.Label costLabel;
        private System.Windows.Forms.Label sellPriceLabel;
        private System.Windows.Forms.Label binLocationLabel;
        private System.Windows.Forms.TextBox partNumberTextBox;
        private System.Windows.Forms.TextBox onHandTextBox;
        private System.Windows.Forms.TextBox costTextbox;
        private System.Windows.Forms.TextBox sellPriceTextBox;
        private System.Windows.Forms.ComboBox vendorComboBox;
        private System.Windows.Forms.ComboBox binLocationComboBox;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button cancelButton;
    }
}