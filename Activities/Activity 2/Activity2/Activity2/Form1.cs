using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


//Ryan Coon
//This is my own work.
//July 10, 2022
//CST-150

namespace Activity2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            decimal earthWeight = 0;
            decimal marsWeight = 0;
            decimal earthGravity = 9.81m;
            decimal marsGravity = 3.711m;

            earthWeight = decimal.Parse(earthWeightBox.Text);

            marsWeight = (earthWeight / earthGravity) * marsGravity;

            marsWeightBox.Text = marsWeight.ToString("N6");
        }
    }
}