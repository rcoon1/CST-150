namespace MilestoneProject
{
    partial class salesPage
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
            this.dateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoiceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.generateInvoiceButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dateColumn,
            this.invoiceColumn,
            this.customerColumn,
            this.priceColumn});
            this.dataGridView1.Location = new System.Drawing.Point(170, 54);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(443, 192);
            this.dataGridView1.TabIndex = 0;
            // 
            // dateColumn
            // 
            this.dateColumn.HeaderText = "Date";
            this.dateColumn.Name = "dateColumn";
            // 
            // invoiceColumn
            // 
            this.invoiceColumn.HeaderText = "Invoice Number";
            this.invoiceColumn.Name = "invoiceColumn";
            // 
            // customerColumn
            // 
            this.customerColumn.HeaderText = "Customer";
            this.customerColumn.Name = "customerColumn";
            // 
            // priceColumn
            // 
            this.priceColumn.HeaderText = "Total";
            this.priceColumn.Name = "priceColumn";
            // 
            // generateInvoiceButton
            // 
            this.generateInvoiceButton.Location = new System.Drawing.Point(372, 300);
            this.generateInvoiceButton.Name = "generateInvoiceButton";
            this.generateInvoiceButton.Size = new System.Drawing.Size(75, 41);
            this.generateInvoiceButton.TabIndex = 1;
            this.generateInvoiceButton.Text = "Generate Invoice";
            this.generateInvoiceButton.UseVisualStyleBackColor = true;
            // 
            // salesPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.generateInvoiceButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "salesPage";
            this.Text = "Sales";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoiceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceColumn;
        private System.Windows.Forms.Button generateInvoiceButton;
    }
}