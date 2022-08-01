namespace MilestoneProject
{
    partial class vendorPage
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.vendorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vendorAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vendorPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vendorProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editButton = new System.Windows.Forms.Button();
            this.addVendorButton = new System.Windows.Forms.Button();
            this.btnHome5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vendorName,
            this.vendorAddress,
            this.vendorPhone,
            this.vendorProduct});
            this.dataGridView1.Location = new System.Drawing.Point(162, 100);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(443, 192);
            this.dataGridView1.TabIndex = 0;
            // 
            // vendorName
            // 
            this.vendorName.HeaderText = "Vendor Name";
            this.vendorName.Name = "vendorName";
            // 
            // vendorAddress
            // 
            this.vendorAddress.HeaderText = "Vendor Address";
            this.vendorAddress.Name = "vendorAddress";
            // 
            // vendorPhone
            // 
            this.vendorPhone.HeaderText = "Vendor Phone";
            this.vendorPhone.Name = "vendorPhone";
            // 
            // vendorProduct
            // 
            this.vendorProduct.HeaderText = "Product Type";
            this.vendorProduct.Name = "vendorProduct";
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(236, 298);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(75, 34);
            this.editButton.TabIndex = 1;
            this.editButton.Text = "Edit Selected";
            this.editButton.UseVisualStyleBackColor = true;
            // 
            // addVendorButton
            // 
            this.addVendorButton.Location = new System.Drawing.Point(453, 309);
            this.addVendorButton.Name = "addVendorButton";
            this.addVendorButton.Size = new System.Drawing.Size(75, 23);
            this.addVendorButton.TabIndex = 2;
            this.addVendorButton.Text = "Add Vendor";
            this.addVendorButton.UseVisualStyleBackColor = true;
            // 
            // btnHome5
            // 
            this.btnHome5.Location = new System.Drawing.Point(12, 12);
            this.btnHome5.Name = "btnHome5";
            this.btnHome5.Size = new System.Drawing.Size(43, 23);
            this.btnHome5.TabIndex = 3;
            this.btnHome5.Text = "Home";
            this.btnHome5.UseVisualStyleBackColor = true;
            this.btnHome5.Click += new System.EventHandler(this.btnHome5_Click);
            // 
            // vendorPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnHome5);
            this.Controls.Add(this.addVendorButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "vendorPage";
            this.Text = "Vendors";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn vendorName;
        private System.Windows.Forms.DataGridViewTextBoxColumn vendorAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn vendorPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn vendorProduct;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button addVendorButton;
        private System.Windows.Forms.Button btnHome5;
    }
}