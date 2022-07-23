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
//July 23, 2022
//CST-150
//adding on to activity 2
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

            //earthWeight = decimal.Parse(earthWeightBox.Text);
            try
            {
                //user input
                if (decimal.TryParse(earthWeightBox.Text, out earthWeight))
                {
                    //math to process input
                    marsWeight = (earthWeight / earthGravity) * marsGravity;
                    //return output to textbox with 3 decimal points
                    marsWeightBox.Text = marsWeight.ToString("N3");
                }
                //exception
                else
                {
                    MessageBox.Show("This is not a valid number.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            //clears textboxes
            earthWeightBox.Text = " ";
            marsWeightBox.Text = " ";

            //set focus on the earth textbox
            earthWeightBox.Focus();
        }
    }
}

