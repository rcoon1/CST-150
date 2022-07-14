namespace MilestoneProject
{
    partial class locationsPage
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
            this.locationColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addLocationButton = new System.Windows.Forms.Button();
            this.editLocationButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.locationColumn,
            this.descriptionColumn});
            this.dataGridView1.Location = new System.Drawing.Point(250, 97);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 113);
            this.dataGridView1.TabIndex = 0;
            // 
            // locationColumn
            // 
            this.locationColumn.HeaderText = "Bin Location";
            this.locationColumn.Name = "locationColumn";
            // 
            // descriptionColumn
            // 
            this.descriptionColumn.HeaderText = "Description";
            this.descriptionColumn.Name = "descriptionColumn";
            // 
            // addLocationButton
            // 
            this.addLocationButton.Location = new System.Drawing.Point(250, 263);
            this.addLocationButton.Name = "addLocationButton";
            this.addLocationButton.Size = new System.Drawing.Size(75, 38);
            this.addLocationButton.TabIndex = 1;
            this.addLocationButton.Text = "Add Location";
            this.addLocationButton.UseVisualStyleBackColor = true;
            this.addLocationButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // editLocationButton
            // 
            this.editLocationButton.Location = new System.Drawing.Point(406, 263);
            this.editLocationButton.Name = "editLocationButton";
            this.editLocationButton.Size = new System.Drawing.Size(75, 38);
            this.editLocationButton.TabIndex = 2;
            this.editLocationButton.Text = "Edit Selected";
            this.editLocationButton.UseVisualStyleBackColor = true;
            // 
            // locationsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.editLocationButton);
            this.Controls.Add(this.addLocationButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "locationsPage";
            this.Text = "Bin Locations";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionColumn;
        private System.Windows.Forms.Button addLocationButton;
        private System.Windows.Forms.Button editLocationButton;
    }
}