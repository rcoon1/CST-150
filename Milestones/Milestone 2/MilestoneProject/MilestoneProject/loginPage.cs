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
    public partial class loginPage : Form
    {
        public loginPage()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (usernameTextBox.Text == "test" && passwordTextBox.Text == "test")
            {
                this.Hide();
                homePage homePage = new homePage();
                homePage.FormClosed += (s, args) => this.Close();
                homePage.Show();
            }
            else
            {
                MessageBox.Show("Invalid login credentials.");
            }

        }
    }
}
