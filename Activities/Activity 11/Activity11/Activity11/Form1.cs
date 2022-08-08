namespace Activity11
{
    //CST-150
    //Ryan Coon
    //This is my own work
    //8/7/2022
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void rollDiceButton_Click(object sender, EventArgs e)
        {
            {
                //generate random number of sides for dice.
                Random randSides = new Random();
                int sides = randSides.Next(4, 20);
                //create dice objects
                Dice dice1 = new Dice(sides, 0);
                Dice dice2 = new Dice(sides, 0);
                //initialize to count number of rolls until snake eyes
                int rolls = 0;
                do
                {
                    //roll with increment for each roll
                    dice1.RollDice();
                    dice2.RollDice();
                    rolls++;
                    //continue to roll until we get snake eyes
                } while (dice1.SnakeEyes(dice2));
                //display results with snake eyes on black dice
                diceLabel1.Text = "1";
                diceLabel2.Text = "1";
                MessageBox.Show("It took " + rolls + " rolls to get snake eyes!");
            }
        }
    }
    public class Dice
    {
        //initialize variables
        public int value;
        private int countSides;
        Random rollNumber = new Random();
        public Dice()
        {
            this.countSides = 0;
            this.value = 0;
        }
        //constructors
        public Dice(int countSides, int value)
        {
            //restrict constructor
            if (countSides <= 20 && countSides >= 4)
            {
                this.countSides = countSides;
                this.value = value;
            }
            else
            {
                MessageBox.Show("Invalid number of sides");
            }
        }
        //rolls the dice
        public int RollDice()
        {
            this.value = (int)(rollNumber.Next(1, this.countSides));
            return this.value;
        }
        //check for snake eyes
        public bool SnakeEyes(Dice getDice)
        {
            if (this.value != 1 && getDice.value != 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}