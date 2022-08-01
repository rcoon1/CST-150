using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MilestoneProject
{
    public partial class addItemPage : Form
    {

        public addItemPage()
        {
            InitializeComponent();
        }

        public void submitButton_Click(object sender, EventArgs e)
        {
            inventoryList inventoryList = new inventoryList();
            inventoryList.dataGridView1.Rows.Add(partNumberTextBox.Text, vendorComboBox.Text, costTextbox.Text, costTextbox.Text ,sellPriceTextBox.Text, binLocationComboBox.Text);
            MessageBox.Show("Inventory item added!");
            this.Close();
            inventoryList.Show();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
