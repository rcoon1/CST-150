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
        //placeholder to allow a click in the data grid
        private void partsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        private void editButton_Click(object sender, EventArgs e)
        {
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
        private void searchButton_Click(object sender, EventArgs e)
        {
            bool found = false;
            if (!int.TryParse(textBox1.Text, out int searchID))
            {
                MessageBox.Show("Must be a number", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            foreach (DataGridViewRow row in partsDataGridView.Rows)
            {
                Part part = (Part)row.DataBoundItem;
                if (part.PartID == searchID)
                {
                    row.Selected = true;
                    found = true;
                    break;
                }
            }
            if (!found) { MessageBox.Show("Part ID not found", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
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

