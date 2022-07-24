namespace Activity7
{
    //Ryan Coon
    //CST-150
    //This is my own work.
    //July 23, 2022
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            //variables
            int numTerms;
            double finResult = 0;

            //exception
            if (int.TryParse(inputTextBox.Text, out numTerms))//takes input from user and turns it into a useable variable
            {
                //loop 
                for (int j = 1; j <= numTerms; j++)
                {
                    //even
                    if (j % 2 == 0)
                    {
                        finResult = finResult - (4.0 / ((2 * j) - 1));
                    }
                    //odd
                    else
                    {
                        finResult = finResult + (4.0 / ((2 * j) - 1));
                    }
                }
                //display answer
                answerLabel.Text = ("Approximate value of pi after " + inputTextBox.Text + " terms" + Environment.NewLine + "= " + finResult.ToString());
            }
            //error message popup
            else
            {
                MessageBox.Show("Please enter a valid integer type.");
            }
        }
    }
}