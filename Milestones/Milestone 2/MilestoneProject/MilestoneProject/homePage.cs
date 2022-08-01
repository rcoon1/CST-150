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
    public partial class homePage : Form
    {
        public homePage()
        {
            InitializeComponent();
        }

        private void homePage_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            this.Hide();
            inventoryList inventoryPage = new inventoryList();
            inventoryPage.Show();
            
        }

        private void vendorButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            vendorPage vendorPage = new vendorPage();
            vendorPage.Show();  
        }

        private void binLocationButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            locationsPage locationsPage = new locationsPage();
            locationsPage.Show();
        }

        private void salesButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            salesPage salesPage = new salesPage();
            salesPage.Show();
        }

        private void usersButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            usersPage usersPage = new usersPage();
            usersPage.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
