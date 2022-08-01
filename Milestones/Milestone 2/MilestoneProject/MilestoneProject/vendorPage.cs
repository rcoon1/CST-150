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
    public partial class vendorPage : Form
    {
        public vendorPage()
        {
            InitializeComponent();
        }

        private void btnHome5_Click(object sender, EventArgs e)
        {
            this.Close();
            homePage homePage = new homePage();
            homePage.Show();
        }
    }
}
