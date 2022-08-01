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
    public partial class locationsPage : Form
    {
        public locationsPage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnHome2_Click(object sender, EventArgs e)
        {
            this.Close();
            homePage homePage = new homePage();
            homePage.Show();
        }
    }
}
