namespace Activity11
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
            this.rollDiceButton = new System.Windows.Forms.Button();
            this.diceLabel1 = new System.Windows.Forms.Label();
            this.diceLabel2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rollDiceButton
            // 
            this.rollDiceButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rollDiceButton.Location = new System.Drawing.Point(12, 12);
            this.rollDiceButton.Name = "rollDiceButton";
            this.rollDiceButton.Size = new System.Drawing.Size(126, 105);
            this.rollDiceButton.TabIndex = 0;
            this.rollDiceButton.Text = "Roll Dice";
            this.rollDiceButton.UseVisualStyleBackColor = true;
            this.rollDiceButton.Click += new System.EventHandler(this.rollDiceButton_Click);
            // 
            // diceLabel1
            // 
            this.diceLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.diceLabel1.BackColor = System.Drawing.Color.Black;
            this.diceLabel1.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.diceLabel1.ForeColor = System.Drawing.Color.White;
            this.diceLabel1.Location = new System.Drawing.Point(158, 24);
            this.diceLabel1.Name = "diceLabel1";
            this.diceLabel1.Size = new System.Drawing.Size(85, 82);
            this.diceLabel1.TabIndex = 0;
            this.diceLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // diceLabel2
            // 
            this.diceLabel2.BackColor = System.Drawing.Color.Black;
            this.diceLabel2.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.diceLabel2.ForeColor = System.Drawing.Color.White;
            this.diceLabel2.Location = new System.Drawing.Point(276, 24);
            this.diceLabel2.Name = "diceLabel2";
            this.diceLabel2.Size = new System.Drawing.Size(85, 82);
            this.diceLabel2.TabIndex = 1;
            this.diceLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OliveDrab;
            this.ClientSize = new System.Drawing.Size(373, 129);
            this.Controls.Add(this.diceLabel2);
            this.Controls.Add(this.diceLabel1);
            this.Controls.Add(this.rollDiceButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Dice Roller";
            this.ResumeLayout(false);

        }

        #endregion

        private Button rollDiceButton;
        private Label diceLabel1;
        private Label diceLabel2;
    }
}
