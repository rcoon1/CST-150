using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryMaster
{
    public partial class AddPartForm : Form

    {
        public AddPartForm()
        {

            InitializeComponent();

        

        }

        private void cancelButton1_Click(object sender, EventArgs e)
        {
            this.Close();
            InventoryForm InventoryForm = new InventoryForm();
            InventoryForm.Show();
        }

        private void addButton1_Click(object sender, EventArgs e)
        {

            Inventory.AddPart(new purchase(nameTextBox.Text, Double.Parse(costTextBox.Text), Double.Parse(sellPriceTextBox.Text), Int32.Parse(inventoryTextBox.Text), Int32.Parse(minTextBox.Text), Int32.Parse(maxTextBox.Text), vendorTextBox.Text, binLocationTextBox.Text));
            RefreshDataGridViews();
            this.Close();
        }
        public void RefreshDataGridViews()
        {
           InventoryForm.partsBinder.ResetBindings(true);
        }
    }
}
