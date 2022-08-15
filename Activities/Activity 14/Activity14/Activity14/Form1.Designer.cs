namespace Activity14
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.loadoutLabel = new System.Windows.Forms.Label();
            this.weaponButton1 = new System.Windows.Forms.RadioButton();
            this.weaponButton2 = new System.Windows.Forms.RadioButton();
            this.weaponButton3 = new System.Windows.Forms.RadioButton();
            this.weaponButton4 = new System.Windows.Forms.RadioButton();
            this.healthCheckBox1 = new System.Windows.Forms.CheckBox();
            this.healthCheckBox2 = new System.Windows.Forms.CheckBox();
            this.healthCheckBox3 = new System.Windows.Forms.CheckBox();
            this.healthCheckBox4 = new System.Windows.Forms.CheckBox();
            this.weaponsGroupBox = new System.Windows.Forms.GroupBox();
            this.healthGroupBox = new System.Windows.Forms.GroupBox();
            this.specialsListBox = new System.Windows.Forms.ListBox();
            this.specialsLabel = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.resultLabel = new System.Windows.Forms.Label();
            this.resultLabel2 = new System.Windows.Forms.Label();
            this.weaponsGroupBox.SuspendLayout();
            this.healthGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // loadoutLabel
            // 
            this.loadoutLabel.AutoSize = true;
            this.loadoutLabel.Font = new System.Drawing.Font("Lucida Sans", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadoutLabel.Location = new System.Drawing.Point(90, 22);
            this.loadoutLabel.Name = "loadoutLabel";
            this.loadoutLabel.Size = new System.Drawing.Size(289, 32);
            this.loadoutLabel.TabIndex = 0;
            this.loadoutLabel.Text = "Choose your loadout";
            // 
            // weaponButton1
            // 
            this.weaponButton1.AutoSize = true;
            this.weaponButton1.Location = new System.Drawing.Point(0, 19);
            this.weaponButton1.Name = "weaponButton1";
            this.weaponButton1.Size = new System.Drawing.Size(54, 17);
            this.weaponButton1.TabIndex = 1;
            this.weaponButton1.TabStop = true;
            this.weaponButton1.Text = "AK-47";
            this.weaponButton1.UseVisualStyleBackColor = true;
            // 
            // weaponButton2
            // 
            this.weaponButton2.AutoSize = true;
            this.weaponButton2.Location = new System.Drawing.Point(0, 42);
            this.weaponButton2.Name = "weaponButton2";
            this.weaponButton2.Size = new System.Drawing.Size(78, 17);
            this.weaponButton2.TabIndex = 2;
            this.weaponButton2.TabStop = true;
            this.weaponButton2.Text = "M1 Garand";
            this.weaponButton2.UseVisualStyleBackColor = true;
            // 
            // weaponButton3
            // 
            this.weaponButton3.AutoSize = true;
            this.weaponButton3.Location = new System.Drawing.Point(0, 65);
            this.weaponButton3.Name = "weaponButton3";
            this.weaponButton3.Size = new System.Drawing.Size(53, 17);
            this.weaponButton3.TabIndex = 3;
            this.weaponButton3.TabStop = true;
            this.weaponButton3.Text = "Groza";
            this.weaponButton3.UseVisualStyleBackColor = true;
            // 
            // weaponButton4
            // 
            this.weaponButton4.AutoSize = true;
            this.weaponButton4.Location = new System.Drawing.Point(0, 88);
            this.weaponButton4.Name = "weaponButton4";
            this.weaponButton4.Size = new System.Drawing.Size(79, 17);
            this.weaponButton4.TabIndex = 4;
            this.weaponButton4.TabStop = true;
            this.weaponButton4.Text = "FN Scar 17";
            this.weaponButton4.UseVisualStyleBackColor = true;
            // 
            // healthCheckBox1
            // 
            this.healthCheckBox1.AutoSize = true;
            this.healthCheckBox1.Location = new System.Drawing.Point(6, 19);
            this.healthCheckBox1.Name = "healthCheckBox1";
            this.healthCheckBox1.Size = new System.Drawing.Size(96, 17);
            this.healthCheckBox1.TabIndex = 5;
            this.healthCheckBox1.Text = "Cloth Bandage";
            this.healthCheckBox1.UseVisualStyleBackColor = true;
            // 
            // healthCheckBox2
            // 
            this.healthCheckBox2.AutoSize = true;
            this.healthCheckBox2.Location = new System.Drawing.Point(6, 42);
            this.healthCheckBox2.Name = "healthCheckBox2";
            this.healthCheckBox2.Size = new System.Drawing.Size(107, 17);
            this.healthCheckBox2.TabIndex = 6;
            this.healthCheckBox2.Text = "Basic First Aid Kit";
            this.healthCheckBox2.UseVisualStyleBackColor = true;
            // 
            // healthCheckBox3
            // 
            this.healthCheckBox3.AutoSize = true;
            this.healthCheckBox3.Location = new System.Drawing.Point(6, 65);
            this.healthCheckBox3.Name = "healthCheckBox3";
            this.healthCheckBox3.Size = new System.Drawing.Size(108, 17);
            this.healthCheckBox3.TabIndex = 7;
            this.healthCheckBox3.Text = "Large First Aid Kit";
            this.healthCheckBox3.UseVisualStyleBackColor = true;
            // 
            // healthCheckBox4
            // 
            this.healthCheckBox4.AutoSize = true;
            this.healthCheckBox4.Location = new System.Drawing.Point(6, 88);
            this.healthCheckBox4.Name = "healthCheckBox4";
            this.healthCheckBox4.Size = new System.Drawing.Size(99, 17);
            this.healthCheckBox4.TabIndex = 8;
            this.healthCheckBox4.Text = "Morphene Shot";
            this.healthCheckBox4.UseVisualStyleBackColor = true;
            // 
            // weaponsGroupBox
            // 
            this.weaponsGroupBox.Controls.Add(this.weaponButton1);
            this.weaponsGroupBox.Controls.Add(this.weaponButton2);
            this.weaponsGroupBox.Controls.Add(this.weaponButton3);
            this.weaponsGroupBox.Controls.Add(this.weaponButton4);
            this.weaponsGroupBox.Location = new System.Drawing.Point(29, 85);
            this.weaponsGroupBox.Name = "weaponsGroupBox";
            this.weaponsGroupBox.Size = new System.Drawing.Size(128, 113);
            this.weaponsGroupBox.TabIndex = 9;
            this.weaponsGroupBox.TabStop = false;
            this.weaponsGroupBox.Text = "Weapon";
            // 
            // healthGroupBox
            // 
            this.healthGroupBox.Controls.Add(this.healthCheckBox1);
            this.healthGroupBox.Controls.Add(this.healthCheckBox3);
            this.healthGroupBox.Controls.Add(this.healthCheckBox4);
            this.healthGroupBox.Controls.Add(this.healthCheckBox2);
            this.healthGroupBox.Location = new System.Drawing.Point(182, 85);
            this.healthGroupBox.Name = "healthGroupBox";
            this.healthGroupBox.Size = new System.Drawing.Size(126, 113);
            this.healthGroupBox.TabIndex = 10;
            this.healthGroupBox.TabStop = false;
            this.healthGroupBox.Text = "Health";
            // 
            // specialsListBox
            // 
            this.specialsListBox.FormattingEnabled = true;
            this.specialsListBox.Items.AddRange(new object[] {
            "Parachute",
            "Glider",
            "Airstrike",
            "Radar Jammer"});
            this.specialsListBox.Location = new System.Drawing.Point(335, 90);
            this.specialsListBox.Name = "specialsListBox";
            this.specialsListBox.Size = new System.Drawing.Size(120, 108);
            this.specialsListBox.TabIndex = 11;
            // 
            // specialsLabel
            // 
            this.specialsLabel.AutoSize = true;
            this.specialsLabel.Location = new System.Drawing.Point(332, 74);
            this.specialsLabel.Name = "specialsLabel";
            this.specialsLabel.Size = new System.Drawing.Size(47, 13);
            this.specialsLabel.TabIndex = 12;
            this.specialsLabel.Text = "Specials";
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(108, 258);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(97, 23);
            this.submitButton.TabIndex = 13;
            this.submitButton.Text = "Submit Loadout";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(335, 258);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 14;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultLabel.Location = new System.Drawing.Point(26, 322);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(0, 15);
            this.resultLabel.TabIndex = 15;
            // 
            // resultLabel2
            // 
            this.resultLabel2.AutoSize = true;
            this.resultLabel2.Font = new System.Drawing.Font("Lucida Sans", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultLabel2.Location = new System.Drawing.Point(188, 361);
            this.resultLabel2.Name = "resultLabel2";
            this.resultLabel2.Size = new System.Drawing.Size(0, 32);
            this.resultLabel2.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(476, 402);
            this.Controls.Add(this.resultLabel2);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.specialsLabel);
            this.Controls.Add(this.specialsListBox);
            this.Controls.Add(this.healthGroupBox);
            this.Controls.Add(this.weaponsGroupBox);
            this.Controls.Add(this.loadoutLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Loadout Selector";
            this.weaponsGroupBox.ResumeLayout(false);
            this.weaponsGroupBox.PerformLayout();
            this.healthGroupBox.ResumeLayout(false);
            this.healthGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label loadoutLabel;
        private System.Windows.Forms.RadioButton weaponButton1;
        private System.Windows.Forms.RadioButton weaponButton2;
        private System.Windows.Forms.RadioButton weaponButton3;
        private System.Windows.Forms.RadioButton weaponButton4;
        private System.Windows.Forms.CheckBox healthCheckBox1;
        private System.Windows.Forms.CheckBox healthCheckBox2;
        private System.Windows.Forms.CheckBox healthCheckBox3;
        private System.Windows.Forms.CheckBox healthCheckBox4;
        private System.Windows.Forms.GroupBox weaponsGroupBox;
        private System.Windows.Forms.GroupBox healthGroupBox;
        private System.Windows.Forms.ListBox specialsListBox;
        private System.Windows.Forms.Label specialsLabel;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Label resultLabel2;
    }
}

