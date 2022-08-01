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
    public partial class salesPage : Form
    {
        public salesPage()
        {
            InitializeComponent();
        }

        private void btnHome3_Click(object sender, EventArgs e)
        {
            this.Close();
            homePage homePage = new homePage();
            homePage.Show();
        }
    }
}
