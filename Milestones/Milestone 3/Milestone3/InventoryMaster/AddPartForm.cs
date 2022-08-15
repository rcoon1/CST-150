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

            Inventory.AddPart(new purchase("Pickle", 22.99, 74.54, 5, 2, 6, "Terex", "A14"));
            RefreshDataGridViews();
            this.Close();
        }
        public void RefreshDataGridViews()
        {

           InventoryForm.partsBinder.ResetBindings(true);
        }
    }
}
