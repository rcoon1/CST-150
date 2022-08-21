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
    public partial class EditPartForm : Form
    {

        public EditPartForm()
        {
            InitializeComponent();

            //pull selected part to show on form
            Inventory.CurrentPart = Inventory.AllParts[Inventory.CurrPartIndex];

            partIDTextBox.Text = Inventory.CurrentPart.PartID.ToString();
            nameTextBox.Text = Inventory.CurrentPart.Name;
            costTextBox.Text = Inventory.CurrentPart.Cost.ToString();
            sellPriceTextBox.Text = Inventory.CurrentPart.SellPrice.ToString();
            inventoryTextBox.Text = Inventory.CurrentPart.Quantity.ToString();
            minTextBox.Text = Inventory.CurrentPart.Min.ToString();
            maxTextBox.Text = Inventory.CurrentPart.Max.ToString();
            vendorTextBox.Text = Inventory.CurrentPart.Vendor.ToString();
            binLocationTextBox.Text = Inventory.CurrentPart.BinLocation.ToString();
        }

        private void cancelButton1_Click(object sender, EventArgs e)
        {
            this.Close();
            InventoryForm InventoryForm = new InventoryForm();
            InventoryForm.Show();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Part updatedPart;
                        
            updatedPart = new purchase(nameTextBox.Text, Double.Parse(costTextBox.Text), Double.Parse(sellPriceTextBox.Text), Int32.Parse(inventoryTextBox.Text), Int32.Parse(minTextBox.Text), Int32.Parse(maxTextBox.Text), vendorTextBox.Text, binLocationTextBox.Text);
            

            Inventory.EditPart(Convert.ToInt32(partIDTextBox.Text), updatedPart);
            RefreshDataGridViews();
            this.Close();
            InventoryForm InventoryForm = new InventoryForm();
            InventoryForm.Show();
        }
        public void RefreshDataGridViews()
        {

            InventoryForm.partsBinder.ResetBindings(true);
        }

    }

            
        }
    
