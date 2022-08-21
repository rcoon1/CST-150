namespace InventoryMaster
{
    partial class HomePage
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
            this.btnInventory = new System.Windows.Forms.Button();
            this.vendorButton = new System.Windows.Forms.Button();
            this.binLocationButton = new System.Windows.Forms.Button();
            this.salesButton = new System.Windows.Forms.Button();
            this.usersButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnInventory
            // 
            this.btnInventory.Location = new System.Drawing.Point(12, 56);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Size = new System.Drawing.Size(75, 23);
            this.btnInventory.TabIndex = 0;
            this.btnInventory.Text = "Inventory";
            this.btnInventory.UseVisualStyleBackColor = true;
            this.btnInventory.Click += new System.EventHandler(this.btnInventory_Click);
            // 
            // vendorButton
            // 
            this.vendorButton.Location = new System.Drawing.Point(12, 143);
            this.vendorButton.Name = "vendorButton";
            this.vendorButton.Size = new System.Drawing.Size(75, 23);
            this.vendorButton.TabIndex = 1;
            this.vendorButton.Text = "Vendors";
            this.vendorButton.UseVisualStyleBackColor = true;
            this.vendorButton.Click += new System.EventHandler(this.vendorButton_Click);
            // 
            // binLocationButton
            // 
            this.binLocationButton.Location = new System.Drawing.Point(12, 224);
            this.binLocationButton.Name = "binLocationButton";
            this.binLocationButton.Size = new System.Drawing.Size(75, 38);
            this.binLocationButton.TabIndex = 2;
            this.binLocationButton.Text = "Bin Locations";
            this.binLocationButton.UseVisualStyleBackColor = true;
            this.binLocationButton.Click += new System.EventHandler(this.binLocationButton_Click);
            // 
            // salesButton
            // 
            this.salesButton.Location = new System.Drawing.Point(12, 303);
            this.salesButton.Name = "salesButton";
            this.salesButton.Size = new System.Drawing.Size(75, 23);
            this.salesButton.TabIndex = 3;
            this.salesButton.Text = "Sales";
            this.salesButton.UseVisualStyleBackColor = true;
            this.salesButton.Click += new System.EventHandler(this.salesButton_Click);
            // 
            // usersButton
            // 
            this.usersButton.Location = new System.Drawing.Point(12, 384);
            this.usersButton.Name = "usersButton";
            this.usersButton.Size = new System.Drawing.Size(75, 23);
            this.usersButton.TabIndex = 4;
            this.usersButton.Text = "Users";
            this.usersButton.UseVisualStyleBackColor = true;
            this.usersButton.Click += new System.EventHandler(this.usersButton_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(242, 56);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(488, 351);
            this.tableLayoutPanel1.TabIndex = 5;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(733, 12);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(55, 23);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // homePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.usersButton);
            this.Controls.Add(this.salesButton);
            this.Controls.Add(this.binLocationButton);
            this.Controls.Add(this.vendorButton);
            this.Controls.Add(this.btnInventory);
            this.Name = "homePage";
            this.Text = "Home Screen";
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInventory;
        private System.Windows.Forms.Button vendorButton;
        private System.Windows.Forms.Button binLocationButton;
        private System.Windows.Forms.Button salesButton;
        private System.Windows.Forms.Button usersButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnLogout;
    }
}