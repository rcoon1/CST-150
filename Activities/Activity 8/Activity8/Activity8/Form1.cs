namespace Activity8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //calculations for fat and carb calories
        private int FatCalorie(int fatGrams)
        {
            return fatGrams * 9;
        }

        private int CarbCalorie(int carbGrams)
        {
            return carbGrams * 4;
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            //declare variables here
            int calFromFat;
            int calFromCarb;
            int gramsFromFat;
            int gramsFromCarb;

           try
            {
                //this part for exception handling
                if(int.TryParse(fatTextBox.Text, out gramsFromFat))
                {
                    if(int.TryParse(carbsTextBox.Text, out gramsFromCarb))
                    {
                        //calculations method
                        calFromFat = FatCalorie(gramsFromFat);
                        calFromCarb = CarbCalorie(gramsFromCarb);

                        //output the results to label
                        resultLabel.Text = ("The Calories from fat are " + calFromFat.ToString() + Environment.NewLine + "and the Calories from carbs are " + calFromCarb.ToString());
                    }
                    //exception
                    else
                    {
                        MessageBox.Show("Invalid Carb entry. Please enter a valid integer.");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Fat entry. Please enter a valid integer.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            //clear textboxes
            fatTextBox.Text = " ";
            carbsTextBox.Text = " ";
            //clear results
            resultLabel.Text = " ";

            //set focus on fat textbox
            fatTextBox.Focus();
        }
    }
}