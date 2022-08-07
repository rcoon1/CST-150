using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            Convert mConvert = new Convert();

            int mm;

            if (int.TryParse(millimeterTextBox.Text, out mm))
            {
                mConvert.displayMeters(mm);
            }
            else
            {
                MessageBox.Show("Please enter a valid integer");
            }
        }
        public class Convert
        {
            public void displayMeters(int mm)
            {
                //Form1 form1 = new Form1();  
                double m = mm / 1000.00;
                MessageBox.Show(mm + " millimeters equals " + m + " meters");
                //form1.convertLabel.Text=(mm + " millimeters equals " + m + " meters"); //cant get it to display to the label
            }

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            millimeterTextBox.Text = "";

        }
    }

}
public class Methods
{
    //method 1 takes two integers and displays their sum.
    public void sumOfTwoNumbers(int a, int b)
    {
        //calculate and return total
        int sum = a + b;
        MessageBox.Show("The total is " + sum.ToString());
    }

    //method 2 takes five doubles and returns their average.
    public double averageOfFiveDoubles(double num1, double num2, double num3, double num4, double num5)
    {
        //calculate and return average
        double average = (num1 + num2 + num3 + num4 + num5) / 5;
        return average;
    }

    //method 3 returns the sum of two randomly generated integers.
    public int randSum()
    {
        int a;
        int b;
        Random randNumber = new Random();

        //random number generator
        a = randNumber.Next();
        b = randNumber.Next();

        //calculate and return total
        int sum = a + b;
        return sum;
    }

    //method 4 takes three integers and returns true if their sum is divisible by 3, false otherwise.
    public bool divideByThree(int a, int b, int c)
    {
        //check if ints are divisible by 3
        if ((a + b + c) % 3 == 0)
        {
            return true;
        }
        //return false if not divisible by 3
        else
        {
            return false;
        }
    }
    //method 5 takes two strings and displays the string that has fewer characters.
    public void shortestString(string x, string y)
    {
        //get length of x
        int charactersInX = 0;
        for (int j = 0; j < x.Length; j++)
        {
            charactersInX++;
        }
        //get length of y
        int charactersInY = 0;
        for (int i = 0; i < y.Length; i++)
        {
            charactersInY++;
        }

        //show shorter string
        if (charactersInX < charactersInY)
        {
            MessageBox.Show("The first string was shorter and it was: " + x);
        }
        if (charactersInY < charactersInX)
        {
            MessageBox.Show("The second string was shorter and it was: " + y);
        }
        else
        {
            MessageBox.Show("Both strings have an equal amount of characters.");
        }
    }
    //method 6 takes an array of doubles and returns the largest value in the array.
    public double largestDoubleArray(double[] arrayA)
    {
        //find largest
        double highestValue = 0;

        for (int i=0; i<arrayA.Length; i++)
        {
            if(arrayA[i] > highestValue)
                highestValue = arrayA[i];
        }
        //return highest value
        return highestValue;
    }
    //method 7 generates and returns an array of fifty integer values.
    public int[] integerArray()
    {
        Random randNumber = new Random();
        //create array
        int[] array = new int[50];

        //fill array with 50 random integers
        for (int i=0; i<array.Length; i++)
            array[i] = randNumber.Next();
        return array;
    }
    //method 8 takes two bool variables and returns true if they have the same value, false otherwise.
    public bool matchBool(bool x, bool y)
    {
        if (x == y)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    //method 9 takes an int and a double and returns their product.
    public double mixedProduct(int a, double b)
    {
        //calculate and return result
        double product = a * b;
        return product;
    }
    //method 10 takes a two-dimensional array of integers and returns the average of the entries.
    public double averageArray(int[][] arrayA)
    {
        //initialize the variables
        int sum = 0;
        int entries = 0;

        //move across rows
        for (int row = 0; row < arrayA.Length; row++)
        {
            //move across columns
            for (int col = 0; col < arrayA[row].Length; col++)
            {
                //add to total
                sum += arrayA[row][col];

                //count entries
                entries++;
            }
        }
        //calculate average and return result
        double average = sum / entries;
        return average;
    }
}