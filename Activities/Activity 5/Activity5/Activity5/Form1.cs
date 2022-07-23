using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Activity5
{
    public partial class Activity5 : Form
    {

        public Activity5()
        {
            InitializeComponent();
        }

        private void selectFileButton_Click(object sender, EventArgs e)
        {
            //exception handling try catch block
            try
            {
                //declaring variables
                //input  files
                StreamReader inputFile;

                //input texts
                string inputText;
                string lowercaseText;
                string completeSentence = "";
                //first and last alphabetically
                string firstAlpha = "z";
                string lastAlpha = "a";
                //longest word counter
                string mostLetters = "";
                int mostLettersCount = 0;
                //most vowels
                string mostVowels = "";
                int highestVowelCount = 0;

                //code to open text files
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    inputFile = File.OpenText(openFileDialog.FileName);

                    //read input file
                    while (inputFile.EndOfStream == false)
                    {
                        inputText = inputFile.ReadLine();
                        //convert that text to all lowercase
                        lowercaseText = inputText.ToLower();
                        //create new file with converted text
                        completeSentence = (completeSentence + " " + lowercaseText);

                        //first word in alphabetical order
                        if (String.Compare(lowercaseText, firstAlpha) < 0)
                        {
                            firstAlpha = lowercaseText;
                        }
                        //last word in alphabetical order
                        if (String.Compare(lowercaseText, lastAlpha) > 0)
                        {
                            lastAlpha = lowercaseText;
                        }

                        //most letters in words counter
                        int letterCount = 0;
                        for (int j = 0; j < lowercaseText.Length; j++)
                        {
                            letterCount++;
                            if (letterCount > mostLettersCount)
                            {
                                mostLettersCount = letterCount;
                                mostLetters = lowercaseText;

                            }
                        }
                        //find word with most vowels
                        int numVowels = 0;
                        for (int i = 0; i < lowercaseText.Length; i++)
                        {
                            char currLetter = lowercaseText[i];

                            if (currLetter == 'a')
                            {
                                numVowels++;

                                if (numVowels > highestVowelCount)
                                {
                                    highestVowelCount = numVowels;
                                    mostVowels = lowercaseText;
                                }
                            }
                            if (currLetter == 'e')
                            {
                                numVowels++;

                                if (numVowels > highestVowelCount)
                                {
                                    highestVowelCount = numVowels;
                                    mostVowels = lowercaseText;
                                }
                            }
                            if (currLetter == 'i')
                            {
                                numVowels++;

                                if (numVowels > highestVowelCount)
                                {
                                    highestVowelCount = numVowels;
                                    mostVowels = lowercaseText;
                                }
                            }
                            if (currLetter == 'o')
                            {
                                numVowels++;

                                if (numVowels > highestVowelCount)
                                {
                                    highestVowelCount = numVowels;
                                    mostVowels = lowercaseText;
                                }
                            }
                            if (currLetter == 'u')
                            {
                                numVowels++;

                                if (numVowels > highestVowelCount)
                                {
                                    highestVowelCount = numVowels;
                                    mostVowels = lowercaseText;
                                }
                            }
                            //show results in the textbox
                            resultsTextBox.Text = ("The words in lowercase are: " + completeSentence + Environment.NewLine + "The first word alphabetically is: " +
                                firstAlpha + Environment.NewLine + "The last word alphabetically is: " + lastAlpha +
                                 Environment.NewLine + "The longest word is: " + mostLetters + Environment.NewLine +
                                "The word with the most vowels is: " + mostVowels);
                        }
                    }
                }

                //in case no file selected exception
                else
                {
                    MessageBox.Show("No file was selected");
                }
            }

            //exception handling
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}