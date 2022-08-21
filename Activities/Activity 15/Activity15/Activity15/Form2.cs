using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity15
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            //generate lucky number
            int luckyNumber;
            Random r = new Random();
            luckyNumber = r.Next(999);

            //show result to label
            luckyNumberLabel.Text = luckyNumber.ToString();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();

            Form1 form1 = new Form1();
            form1.Show();
        }

        private void quoteButton_Click(object sender, EventArgs e)
        {
            var quote = new List<string>();

            quote.Add("Success is not final; failure is not fatal: It is the courage to continue that counts. — Winston S. Churchill");
            quote.Add("It is better to fail in originality than to succeed in imitation. — Herman Melville");
            quote.Add("The road to success and the road to failure are almost exactly the same. — Colin R. Davis");
            quote.Add("Success usually comes to those who are too busy looking for it. — Henry David Thoreau");
            quote.Add("Develop success from failures. Discouragement and failure are two of the surest stepping stones to success. —Dale Carnegie");
            quote.Add("There are three ways to ultimate success: The first way is to be kind. The second way is to be kind. The third way is to be kind. —Mister Rogers");
            quote.Add("Success is peace of mind, which is a direct result of self-satisfaction in knowing you made the effort to become the best of which you are capable. —John Wooden");
            quote.Add("I never dreamed about success. I worked for it. —Estée Lauder");
            quote.Add("Success is getting what you want, happiness is wanting what you get. ―W. P. Kinsella");

            Random random = new Random();
            int index = random.Next(quote.Count);

            MessageBox.Show(quote[index]);
            }
        }
    }
