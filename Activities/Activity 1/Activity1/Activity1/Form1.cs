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
//CST-150
//This is my own work
//July 10, 2022
namespace Activity1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            String firstName = firstNameTextbox.Text.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
        private void clearButton_Click(object sender, EventArgs e)
        {
            // Clear the TextBox controls.
            firstNameTextbox.Text = " ";
            lastNameTextbox.Text = " ";
            locationTextBox.Text = " ";


            // Set the focus to firstNameTextBox.
            firstNameTextbox.Focus();
        }
        private void showInfoButton_Click(object sender, EventArgs e)
        {
            String firstName = firstNameTextbox.Text.ToString();
            String lastName = lastNameTextbox.Text.ToString();
            String location = locationTextBox.Text.ToString();
            String date = dateTimePicker1.ToString();
            MessageBox.Show("The information entered was: " + firstName + " " + lastName + " from " + location + "!" + Environment.NewLine
                 + "The Date Recorded: " + dateTimePicker1);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}