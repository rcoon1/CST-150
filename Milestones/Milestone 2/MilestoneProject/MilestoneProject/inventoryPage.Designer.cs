namespace MilestoneProject
{
    partial class inventoryList
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
            this.partNumberColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vendorColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.onHandColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sellPriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.binLocationColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addProductButton = new System.Windows.Forms.Button();
            this.editProductButton = new System.Windows.Forms.Button();
            this.sellButton = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.partNumberColumn,
            this.vendorColumn,
            this.onHandColumn,
            this.costColumn,
            this.sellPriceColumn,
            this.binLocationColumn});
            this.dataGridView1.Location = new System.Drawing.Point(83, 47);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(644, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // partNumberColumn
            // 
            this.partNumberColumn.HeaderText = "Part Number";
            this.partNumberColumn.Name = "partNumberColumn";
            // 
            // vendorColumn
            // 
            this.vendorColumn.HeaderText = "Vendor";
            this.vendorColumn.Name = "vendorColumn";
            // 
            // onHandColumn
            // 
            this.onHandColumn.HeaderText = "On Hand";
            this.onHandColumn.Name = "onHandColumn";
            // 
            // costColumn
            // 
            this.costColumn.HeaderText = "Cost";
            this.costColumn.Name = "costColumn";
            // 
            // sellPriceColumn
            // 
            this.sellPriceColumn.HeaderText = "Sell Price";
            this.sellPriceColumn.Name = "sellPriceColumn";
            // 
            // binLocationColumn
            // 
            this.binLocationColumn.HeaderText = "Bin Location";
            this.binLocationColumn.Name = "binLocationColumn";
            // 
            // addProductButton
            // 
            this.addProductButton.Location = new System.Drawing.Point(107, 253);
            this.addProductButton.Name = "addProductButton";
            this.addProductButton.Size = new System.Drawing.Size(75, 23);
            this.addProductButton.TabIndex = 1;
            this.addProductButton.Text = "Add Product";
            this.addProductButton.UseVisualStyleBackColor = true;
            this.addProductButton.Click += new System.EventHandler(this.addProductButton_Click);
            // 
            // editProductButton
            // 
            this.editProductButton.Location = new System.Drawing.Point(335, 253);
            this.editProductButton.Name = "editProductButton";
            this.editProductButton.Size = new System.Drawing.Size(75, 41);
            this.editProductButton.TabIndex = 2;
            this.editProductButton.Text = "Edit Selected";
            this.editProductButton.UseVisualStyleBackColor = true;
            this.editProductButton.Click += new System.EventHandler(this.editProductButton_Click);
            // 
            // sellButton
            // 
            this.sellButton.Location = new System.Drawing.Point(565, 253);
            this.sellButton.Name = "sellButton";
            this.sellButton.Size = new System.Drawing.Size(75, 41);
            this.sellButton.TabIndex = 3;
            this.sellButton.Text = "Sell Selected";
            this.sellButton.UseVisualStyleBackColor = true;
            this.sellButton.Click += new System.EventHandler(this.sellButton_Click);
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(12, 12);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(44, 23);
            this.btnHome.TabIndex = 4;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // inventoryList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.sellButton);
            this.Controls.Add(this.editProductButton);
            this.Controls.Add(this.addProductButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "inventoryList";
            this.Text = "Inventory List";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn partNumberColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vendorColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn onHandColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sellPriceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn binLocationColumn;
        private System.Windows.Forms.Button addProductButton;
        private System.Windows.Forms.Button editProductButton;
        private System.Windows.Forms.Button sellButton;
        private System.Windows.Forms.Button btnHome;
        public System.Windows.Forms.DataGridView dataGridView1;
    }
}