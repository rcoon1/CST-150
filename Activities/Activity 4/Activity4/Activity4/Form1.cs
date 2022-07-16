namespace Activity4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Ryan Coon
        //CST-150
        //
        //This is my own work
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void conversion_btn_Click(object sender, EventArgs e)
        {
            //initialize variables
            int input;//users input
            int numberSeconds;//seconds displayed
            int numberMinutes;//minutes displayed
            int numberHours;//hours displayed
            int numberDays;//days displayed

            //logic take user input and sort it by sec,min,hours,and days
            if (int.TryParse(secondsInput_txtbox.Text,out input))
            {
                if (input >= 60 && input < 3600)
                {
                    numberMinutes = input / 60;
                    numberSeconds = input % 60;
                    //displays totals in the textboxes
                    minutesOutTextBox.Text = numberMinutes.ToString();
                    secondsOutTextBox.Text = numberSeconds.ToString();
                }
                else if (input >= 3600 && input < 86400)
                {
                    numberHours = input / 3600;
                    numberMinutes = (input - (numberHours * 3600)) / 60;
                    numberSeconds = (input - (numberMinutes * 60)) % 3600;
                    //display
                    hoursOutTextBox.Text = numberHours.ToString();
                    minutesOutTextBox.Text = numberMinutes.ToString();
                    secondsOutTextBox.Text = numberSeconds.ToString();
                }
                else if (input >= 86400)
                {
                    numberDays = input / 86400;
                    numberHours = (input - (numberDays * 86400)) / 3600;
                    numberMinutes = (input - (numberDays * 86400) - (numberHours * 3600)) / 60;
                    numberSeconds = (input - (numberMinutes * 60)) % 3600;
                    //display
                    daysOutTextBox.Text = numberDays.ToString();
                    hoursOutTextBox.Text = numberHours.ToString();
                    minutesOutTextBox.Text = numberMinutes.ToString();
                    secondsOutTextBox.Text = numberSeconds.ToString();
                }
                else
                {
                    secondsOutTextBox.Text = input.ToString();//display seconds if under a minute
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid integer.");//show error popup when an invalid input is put in
            }
        }
        //clears all textboxes when clicked
        private void clearButton_Click(object sender, EventArgs e)
        {
            secondsInput_txtbox.Text = "";
            secondsOutTextBox.Text = "";
            minutesOutTextBox.Text = "";
            hoursOutTextBox.Text = "";
            daysOutTextBox.Text = "";
        }
    }
}