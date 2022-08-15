using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity14
{
    //CST-150
    //Ryan Coon
    //This is my own work
    //8/13/2022
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            string weapon = " ";
            string health = " ";
            string specials = " ";
            //sets to get the selection from listbox
            string selectedSpecials = (string)specialsListBox.SelectedItem;

            //radio button choices
            if(weaponButton1.Checked)
            {
                weapon = "AK-47";
            }
            if(weaponButton2.Checked)
            {
                weapon = "M1 Garand";
            }
            if(weaponButton3.Checked)
            {
                weapon = "Groza";
            }
            if(weaponButton4.Checked)
            {
                weapon = "FN Scar 17";
            }
            //checkbox selections
            if(healthCheckBox1.Checked)
            {
                health = "Cloth Bandages";
            }
            if(healthCheckBox2.Checked)
            {
                health = "Basic First Aid Kits";
            }
            if(healthCheckBox3.Checked)
            {
                health = "Large First Aid Kits";
            }
            if(healthCheckBox4.Checked)
            {
                health = "Morphene Shots";
            }
            resultLabel.Text = "You will drop with an " + weapon + " some " + health + " and a " + Environment.NewLine + selectedSpecials + " as your special. ";
            resultLabel2.Text = " Good Luck! ";
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            resultLabel.Text = " ";
            resultLabel2.Text = " ";

            weaponButton1.Checked = false;
            weaponButton2.Checked = false;
            weaponButton3.Checked = false;
            weaponButton4.Checked = false;

            healthCheckBox1.Checked = false;
            healthCheckBox2.Checked = false;
            healthCheckBox3.Checked = false;
            healthCheckBox4.Checked = false;

            specialsListBox.ClearSelected();
        }
    }
}
