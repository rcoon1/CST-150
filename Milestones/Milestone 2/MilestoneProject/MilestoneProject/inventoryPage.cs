using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//
//Ryan Coon
//CST-150
//July 31, 2022
//This is my own work
//

namespace MilestoneProject
{
    public partial class inventoryList : Form
    {
        public inventoryList()
        {
            InitializeComponent();
        }
        public void updateDataGrid(string updateText)
        {
            dataGridView1.Rows[0].Cells[0].Value = updateText;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();
            homePage homePage = new homePage();
            homePage.Show();
        }

        private void editProductButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please select a row");
        }

        private void sellButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please select a row");
        }

        private void addProductButton_Click(object sender, EventArgs e)
        {
            this.Close();
            addItemPage addItemPage = new addItemPage();
            addItemPage.Show();
        }
    }
}
