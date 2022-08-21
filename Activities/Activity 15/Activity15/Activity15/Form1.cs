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
    //Ryan Coon
    //CST-150
    //August 20, 2022
    //This is my own work
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
            InitializeMonthComboBox();
            InitializeDayComboBox();
            InitializeYearComboBox();
        }


        private void luckyNumberButton_Click(object sender, EventArgs e)

        {

                this.Hide();
                Form2 luckyNumberForm = new Form2();
                luckyNumberForm.Show();
            
        }

        //programmatically initialize month combo box
        public void InitializeMonthComboBox()
        {
            ComboBox monthComboBox = new ComboBox();
            monthComboBox.Location = new Point(106, 69);
            monthComboBox.Name = "monthComboBox";
            monthComboBox.Size = new Size(121, 21);
            monthComboBox.Text = "Month";

            this.Controls.Add(monthComboBox);

            monthComboBox.Items.Add("January");
            monthComboBox.Items.Add("February");
            monthComboBox.Items.Add("March");
            monthComboBox.Items.Add("April");
            monthComboBox.Items.Add("May");
            monthComboBox.Items.Add("June");
            monthComboBox.Items.Add("July");
            monthComboBox.Items.Add("August");
            monthComboBox.Items.Add("September");
            monthComboBox.Items.Add("October");
            monthComboBox.Items.Add("November");
            monthComboBox.Items.Add("December");
        }
        //day combo box
        public void InitializeDayComboBox()
        {
            ComboBox dayComboBox = new ComboBox();
            dayComboBox.Location = new Point(106, 96);
            dayComboBox.Name = "dayComboBox";
            dayComboBox.Size = new Size(121, 21);
            dayComboBox.Text = "Day";

            this.Controls.Add(dayComboBox);
            //used string so it would put text in combobox
            dayComboBox.Items.Add("1");
            dayComboBox.Items.Add("2");
            dayComboBox.Items.Add("3");
            dayComboBox.Items.Add("4");
            dayComboBox.Items.Add("5");
            dayComboBox.Items.Add("6");
            dayComboBox.Items.Add("7");
            dayComboBox.Items.Add("8");
            dayComboBox.Items.Add("9");
            dayComboBox.Items.Add("10");
            dayComboBox.Items.Add("11");
            dayComboBox.Items.Add("12");
            dayComboBox.Items.Add("13");
            dayComboBox.Items.Add("14");
            dayComboBox.Items.Add("15");
            dayComboBox.Items.Add("16");
            dayComboBox.Items.Add("17");
            dayComboBox.Items.Add("18");
            dayComboBox.Items.Add("19");
            dayComboBox.Items.Add("20");
            dayComboBox.Items.Add("21");
            dayComboBox.Items.Add("22");
            dayComboBox.Items.Add("23");
            dayComboBox.Items.Add("24");
            dayComboBox.Items.Add("25");
            dayComboBox.Items.Add("26");
            dayComboBox.Items.Add("27");
            dayComboBox.Items.Add("28");
            dayComboBox.Items.Add("29");
            dayComboBox.Items.Add("30");
            dayComboBox.Items.Add("31");



        }

        //year combobox
        public void InitializeYearComboBox()
        {
            ComboBox yearComboBox = new ComboBox();
            yearComboBox.Location = new Point(106, 123);
            yearComboBox.Name = "yearComboBox";
            yearComboBox.Size = new Size(121, 21);
            yearComboBox.Text = "Year";

            this.Controls.Add(yearComboBox);

            // int[] years = new int[41]
            // {
            //                   1970, 1971, 1972, 1973, 1974, 1975, 1976, 1977, 1978, 1979, 1980, 1981, 1982, 1983, 1984, 1985, 1986, 1987, 1988, 1989,  1990, 1991, 1992, 1993, 1994, 1995, 1996, 1997,
            //     1998, 1999, 2000, 2001, 2002, 2003, 2004, 2005,
            //     2006, 2007, 2008, 2009, 2010
            // };
            yearComboBox.Items.Add("2022");
            yearComboBox.Items.Add("2021");
            yearComboBox.Items.Add("2020");
            yearComboBox.Items.Add("2019");
            yearComboBox.Items.Add("2018");
            yearComboBox.Items.Add("2017");
            yearComboBox.Items.Add("2016");
            yearComboBox.Items.Add("2015");
            yearComboBox.Items.Add("2014");
            yearComboBox.Items.Add("2013");
            yearComboBox.Items.Add("2012");
            yearComboBox.Items.Add("2011");
            yearComboBox.Items.Add("2010");
            yearComboBox.Items.Add("2009");
            yearComboBox.Items.Add("2008");
            yearComboBox.Items.Add("2007");
            yearComboBox.Items.Add("2006");
            yearComboBox.Items.Add("2005");
            yearComboBox.Items.Add("2004");
            yearComboBox.Items.Add("2003");
            yearComboBox.Items.Add("2002");
            yearComboBox.Items.Add("2001");
            yearComboBox.Items.Add("2000");
            yearComboBox.Items.Add("1999");
            yearComboBox.Items.Add("1998");
            yearComboBox.Items.Add("1997");
            yearComboBox.Items.Add("1996");
            yearComboBox.Items.Add("1995");
            yearComboBox.Items.Add("1994");
            yearComboBox.Items.Add("1993");
            yearComboBox.Items.Add("1992");
            yearComboBox.Items.Add("1991");
            yearComboBox.Items.Add("1990");
            yearComboBox.Items.Add("1989");
            yearComboBox.Items.Add("1988");
            yearComboBox.Items.Add("1987");
            yearComboBox.Items.Add("1986");
            yearComboBox.Items.Add("1985");
            yearComboBox.Items.Add("1984");
            yearComboBox.Items.Add("1983");
            yearComboBox.Items.Add("1982");
            yearComboBox.Items.Add("1981");
            yearComboBox.Items.Add("1980");
            yearComboBox.Items.Add("1979");
            yearComboBox.Items.Add("1978");
            yearComboBox.Items.Add("1977");
            yearComboBox.Items.Add("1976");
            yearComboBox.Items.Add("1975");
            yearComboBox.Items.Add("1974");
            yearComboBox.Items.Add("1973");
            yearComboBox.Items.Add("1972");
            yearComboBox.Items.Add("1971");
            yearComboBox.Items.Add("1970");
        }

        public void monthComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //get month from combo box
            ComboBox monthComboBox = (ComboBox)sender;
            int selectedMonth = 0;
            if (monthComboBox.SelectedItem != null)
            {
                selectedMonth = int.Parse(monthComboBox.SelectedIndex.ToString());
            }
            else
            {
                selectedMonth = 0;
            }
        }
        public void dayComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //get month from combo box
            ComboBox dayComboBox = (ComboBox)sender;
            int selectedDay = 0;
            if (dayComboBox.SelectedItem != null)
            {
                selectedDay = int.Parse(dayComboBox.SelectedIndex.ToString());
            }
            else
            {
                selectedDay = 0;
            }
        }
        public void yeaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //get month from combo box
            ComboBox yearComboBox = (ComboBox)sender;
            int selectedYear = 0;
            if (yearComboBox.SelectedItem != null)
            {
                selectedYear = int.Parse(yearComboBox.SelectedIndex.ToString());
            }
            else
            {
                selectedYear = 0;
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
