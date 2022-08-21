namespace InventoryMaster
{
    partial class AddPartForm
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.partIDLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.costLabel = new System.Windows.Forms.Label();
            this.sellPriceLabel = new System.Windows.Forms.Label();
            this.inventoryLabel = new System.Windows.Forms.Label();
            this.minLabel = new System.Windows.Forms.Label();
            this.maxLabel = new System.Windows.Forms.Label();
            this.vendorLabel = new System.Windows.Forms.Label();
            this.binLocationLabel = new System.Windows.Forms.Label();
            this.partIDTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.costTextBox = new System.Windows.Forms.TextBox();
            this.sellPriceTextBox = new System.Windows.Forms.TextBox();
            this.inventoryTextBox = new System.Windows.Forms.TextBox();
            this.minTextBox = new System.Windows.Forms.TextBox();
            this.maxTextBox = new System.Windows.Forms.TextBox();
            this.vendorTextBox = new System.Windows.Forms.TextBox();
            this.binLocationTextBox = new System.Windows.Forms.TextBox();
            this.addButton1 = new System.Windows.Forms.Button();
            this.cancelButton1 = new System.Windows.Forms.Button();
            this.partBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.partBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.partBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.partBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.partBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.partBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.partBindingSource6 = new System.Windows.Forms.BindingSource(this.components);
            this.partBindingSource7 = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.partBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partBindingSource5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partBindingSource6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partBindingSource7)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cancelButton1);
            this.groupBox1.Controls.Add(this.addButton1);
            this.groupBox1.Controls.Add(this.binLocationTextBox);
            this.groupBox1.Controls.Add(this.vendorTextBox);
            this.groupBox1.Controls.Add(this.maxTextBox);
            this.groupBox1.Controls.Add(this.minTextBox);
            this.groupBox1.Controls.Add(this.inventoryTextBox);
            this.groupBox1.Controls.Add(this.sellPriceTextBox);
            this.groupBox1.Controls.Add(this.costTextBox);
            this.groupBox1.Controls.Add(this.nameTextBox);
            this.groupBox1.Controls.Add(this.partIDTextBox);
            this.groupBox1.Controls.Add(this.binLocationLabel);
            this.groupBox1.Controls.Add(this.vendorLabel);
            this.groupBox1.Controls.Add(this.maxLabel);
            this.groupBox1.Controls.Add(this.minLabel);
            this.groupBox1.Controls.Add(this.inventoryLabel);
            this.groupBox1.Controls.Add(this.sellPriceLabel);
            this.groupBox1.Controls.Add(this.costLabel);
            this.groupBox1.Controls.Add(this.nameLabel);
            this.groupBox1.Controls.Add(this.partIDLabel);
            this.groupBox1.Location = new System.Drawing.Point(9, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(253, 428);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add New Part";
            // 
            // partIDLabel
            // 
            this.partIDLabel.AutoSize = true;
            this.partIDLabel.Location = new System.Drawing.Point(12, 39);
            this.partIDLabel.Name = "partIDLabel";
            this.partIDLabel.Size = new System.Drawing.Size(43, 13);
            this.partIDLabel.TabIndex = 0;
            this.partIDLabel.Text = "Part ID:";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(17, 66);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(38, 13);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Name:";
            // 
            // costLabel
            // 
            this.costLabel.AutoSize = true;
            this.costLabel.Location = new System.Drawing.Point(26, 92);
            this.costLabel.Name = "costLabel";
            this.costLabel.Size = new System.Drawing.Size(31, 13);
            this.costLabel.TabIndex = 2;
            this.costLabel.Text = "Cost:";
            // 
            // sellPriceLabel
            // 
            this.sellPriceLabel.AutoSize = true;
            this.sellPriceLabel.Location = new System.Drawing.Point(3, 118);
            this.sellPriceLabel.Name = "sellPriceLabel";
            this.sellPriceLabel.Size = new System.Drawing.Size(54, 13);
            this.sellPriceLabel.TabIndex = 3;
            this.sellPriceLabel.Text = "Sell Price:";
            // 
            // inventoryLabel
            // 
            this.inventoryLabel.AutoSize = true;
            this.inventoryLabel.Location = new System.Drawing.Point(1, 144);
            this.inventoryLabel.Name = "inventoryLabel";
            this.inventoryLabel.Size = new System.Drawing.Size(54, 13);
            this.inventoryLabel.TabIndex = 4;
            this.inventoryLabel.Text = "Inventory:";
            // 
            // minLabel
            // 
            this.minLabel.AutoSize = true;
            this.minLabel.Location = new System.Drawing.Point(1, 167);
            this.minLabel.Name = "minLabel";
            this.minLabel.Size = new System.Drawing.Size(58, 13);
            this.minLabel.TabIndex = 5;
            this.minLabel.Text = "Min Stock:";
            // 
            // maxLabel
            // 
            this.maxLabel.AutoSize = true;
            this.maxLabel.Location = new System.Drawing.Point(4, 196);
            this.maxLabel.Name = "maxLabel";
            this.maxLabel.Size = new System.Drawing.Size(61, 13);
            this.maxLabel.TabIndex = 6;
            this.maxLabel.Text = "Max Stock:";
            // 
            // vendorLabel
            // 
            this.vendorLabel.AutoSize = true;
            this.vendorLabel.Location = new System.Drawing.Point(13, 222);
            this.vendorLabel.Name = "vendorLabel";
            this.vendorLabel.Size = new System.Drawing.Size(44, 13);
            this.vendorLabel.TabIndex = 7;
            this.vendorLabel.Text = "Vendor:";
            // 
            // binLocationLabel
            // 
            this.binLocationLabel.AutoSize = true;
            this.binLocationLabel.Location = new System.Drawing.Point(3, 248);
            this.binLocationLabel.Name = "binLocationLabel";
            this.binLocationLabel.Size = new System.Drawing.Size(69, 13);
            this.binLocationLabel.TabIndex = 8;
            this.binLocationLabel.Text = "Bin Location:";
            // 
            // partIDTextBox
            // 
            this.partIDTextBox.Enabled = false;
            this.partIDTextBox.Location = new System.Drawing.Point(82, 36);
            this.partIDTextBox.Name = "partIDTextBox";
            this.partIDTextBox.Size = new System.Drawing.Size(132, 20);
            this.partIDTextBox.TabIndex = 9;
            this.partIDTextBox.Text = "Auto-generated";
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.partBindingSource7, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(82, 63);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(132, 20);
            this.nameTextBox.TabIndex = 10;
            // 
            // costTextBox
            // 
            this.costTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.partBindingSource1, "Cost", true));
            this.costTextBox.Location = new System.Drawing.Point(82, 89);
            this.costTextBox.Name = "costTextBox";
            this.costTextBox.Size = new System.Drawing.Size(132, 20);
            this.costTextBox.TabIndex = 11;
            // 
            // sellPriceTextBox
            // 
            this.sellPriceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.partBindingSource2, "SellPrice", true));
            this.sellPriceTextBox.Location = new System.Drawing.Point(82, 115);
            this.sellPriceTextBox.Name = "sellPriceTextBox";
            this.sellPriceTextBox.Size = new System.Drawing.Size(132, 20);
            this.sellPriceTextBox.TabIndex = 12;
            // 
            // inventoryTextBox
            // 
            this.inventoryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.partBindingSource3, "Quantity", true));
            this.inventoryTextBox.Location = new System.Drawing.Point(82, 141);
            this.inventoryTextBox.Name = "inventoryTextBox";
            this.inventoryTextBox.Size = new System.Drawing.Size(132, 20);
            this.inventoryTextBox.TabIndex = 13;
            // 
            // minTextBox
            // 
            this.minTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.partBindingSource, "Min", true));
            this.minTextBox.Location = new System.Drawing.Point(82, 167);
            this.minTextBox.Name = "minTextBox";
            this.minTextBox.Size = new System.Drawing.Size(132, 20);
            this.minTextBox.TabIndex = 14;
            // 
            // maxTextBox
            // 
            this.maxTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.partBindingSource4, "Max", true));
            this.maxTextBox.Location = new System.Drawing.Point(82, 193);
            this.maxTextBox.Name = "maxTextBox";
            this.maxTextBox.Size = new System.Drawing.Size(132, 20);
            this.maxTextBox.TabIndex = 15;
            // 
            // vendorTextBox
            // 
            this.vendorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.partBindingSource5, "Vendor", true));
            this.vendorTextBox.Location = new System.Drawing.Point(81, 219);
            this.vendorTextBox.Name = "vendorTextBox";
            this.vendorTextBox.Size = new System.Drawing.Size(133, 20);
            this.vendorTextBox.TabIndex = 16;
            // 
            // binLocationTextBox
            // 
            this.binLocationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.partBindingSource6, "BinLocation", true));
            this.binLocationTextBox.Location = new System.Drawing.Point(81, 245);
            this.binLocationTextBox.Name = "binLocationTextBox";
            this.binLocationTextBox.Size = new System.Drawing.Size(133, 20);
            this.binLocationTextBox.TabIndex = 17;
            // 
            // addButton1
            // 
            this.addButton1.Location = new System.Drawing.Point(20, 362);
            this.addButton1.Name = "addButton1";
            this.addButton1.Size = new System.Drawing.Size(75, 23);
            this.addButton1.TabIndex = 18;
            this.addButton1.Text = "Add";
            this.addButton1.UseVisualStyleBackColor = true;
            this.addButton1.Click += new System.EventHandler(this.addButton1_Click);
            // 
            // cancelButton1
            // 
            this.cancelButton1.Location = new System.Drawing.Point(155, 362);
            this.cancelButton1.Name = "cancelButton1";
            this.cancelButton1.Size = new System.Drawing.Size(75, 23);
            this.cancelButton1.TabIndex = 19;
            this.cancelButton1.Text = "Cancel";
            this.cancelButton1.UseVisualStyleBackColor = true;
            this.cancelButton1.Click += new System.EventHandler(this.cancelButton1_Click);
            // 
            // partBindingSource
            // 
            this.partBindingSource.DataSource = typeof(InventoryMaster.Part);
            // 
            // partBindingSource1
            // 
            this.partBindingSource1.DataSource = typeof(InventoryMaster.Part);
            // 
            // partBindingSource2
            // 
            this.partBindingSource2.DataSource = typeof(InventoryMaster.Part);
            // 
            // partBindingSource3
            // 
            this.partBindingSource3.DataSource = typeof(InventoryMaster.Part);
            // 
            // partBindingSource4
            // 
            this.partBindingSource4.DataSource = typeof(InventoryMaster.Part);
            // 
            // partBindingSource5
            // 
            this.partBindingSource5.DataSource = typeof(InventoryMaster.Part);
            // 
            // partBindingSource6
            // 
            this.partBindingSource6.DataSource = typeof(InventoryMaster.Part);
            // 
            // partBindingSource7
            // 
            this.partBindingSource7.DataSource = typeof(InventoryMaster.Part);
            // 
            // AddPartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "AddPartForm";
            this.Text = "AddPartForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.partBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partBindingSource5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partBindingSource6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partBindingSource7)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button cancelButton1;
        private System.Windows.Forms.Button addButton1;
        private System.Windows.Forms.TextBox binLocationTextBox;
        private System.Windows.Forms.TextBox vendorTextBox;
        private System.Windows.Forms.TextBox maxTextBox;
        private System.Windows.Forms.TextBox minTextBox;
        private System.Windows.Forms.TextBox inventoryTextBox;
        private System.Windows.Forms.TextBox sellPriceTextBox;
        private System.Windows.Forms.TextBox costTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox partIDTextBox;
        private System.Windows.Forms.Label binLocationLabel;
        private System.Windows.Forms.Label vendorLabel;
        private System.Windows.Forms.Label maxLabel;
        private System.Windows.Forms.Label minLabel;
        private System.Windows.Forms.Label inventoryLabel;
        private System.Windows.Forms.Label sellPriceLabel;
        private System.Windows.Forms.Label costLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label partIDLabel;
        private System.Windows.Forms.BindingSource partBindingSource6;
        private System.Windows.Forms.BindingSource partBindingSource5;
        private System.Windows.Forms.BindingSource partBindingSource4;
        private System.Windows.Forms.BindingSource partBindingSource;
        private System.Windows.Forms.BindingSource partBindingSource3;
        private System.Windows.Forms.BindingSource partBindingSource2;
        private System.Windows.Forms.BindingSource partBindingSource1;
        private System.Windows.Forms.BindingSource partBindingSource7;
    }
}