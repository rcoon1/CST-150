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
    public partial class InventoryForm : Form
    {
        public int currPart { get; set; }
        // binds  partslist to the DataGridView   
        public static BindingSource partsBinder = new BindingSource();
        public static BindingList<Part> parts = new BindingList<Part>(Inventory.AllParts);


        public InventoryForm()
        {
            InitializeComponent();
            partsBinder.DataSource = parts;
            partsDataGridView.DataSource = partsBinder;
        }
        private void addButton_Click(object sender, EventArgs e)
        {
            AddPartForm AddPartForm = new AddPartForm();
            AddPartForm.Show();
        }
        // allows a click in within the data grid
        public void partsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Inventory.CurrPartIndex = e.RowIndex;
            Inventory.CurrentPart = Inventory.AllParts[Inventory.CurrPartIndex];
        }
        private void editButton_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = partsDataGridView.SelectedRows[0];
            Inventory.CurrPartIndex = (int)selectedRow.Cells["PartID"].Value;

            if (Inventory.CurrPartIndex >= 0)
            {
                this.Hide();
                EditPartForm EditPart = new EditPartForm();
                EditPart.ShowDialog();
            }
            else
            {
                MessageBox.Show("There are no parts to modify.", "Error");
            }

        }
        //delete a part
        private void deleteButton_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = partsDataGridView.SelectedRows[0];
            int partID = Convert.ToInt32(selectedRow.Cells["PartID"].Value);
            Part partToDelete = Inventory.FindPart(partID);

            if (MessageBox.Show(
                "Are you sure you want to remove this part?" + Environment.NewLine +
                "PartID: " + partID + Environment.NewLine + "Name: " + selectedRow.Cells["Name"].Value,
                "Remove Product", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    Inventory.DeletePart(partToDelete);
                    RefreshDataGridViews();
                }
                catch
                {
                    MessageBox.Show("Unable to delete selected part", "Deletion Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

        }
        //refreshes after any changes
        public void RefreshDataGridViews()
        {
            partsBinder.ResetBindings(true);
        }
        //search
        private void searchButton_Click(object sender, EventArgs e)
        {
            bool found = false;
            string searchValue = textBox1.Text;
            foreach (DataGridViewRow rows in partsDataGridView.Rows)
            {
                Part part = (Part)rows.DataBoundItem;
                if (part.Name == searchValue)
                {
                    rows.Selected = true;
                    found = true;
                    break;
                }
                else if (part.Vendor == searchValue)
                {
                    rows.Selected = true;
                    found = true;
                    break;
                }
            }
            if (!found)
            {
                MessageBox.Show("Part not found", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        //back to home screen
        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();

            HomePage HomePage = new HomePage();
            HomePage.Show();

        }

    }
}

