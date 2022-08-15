using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity13
//CST-150
//Ryan Coon
//This is my own work
//8/13/2022
{//buttons layout
    //  123
    //  456
    //  789
    public partial class Form1 : Form
    {
        //initialize 3x3 board and player turns
        private int[,] board = new int[3, 3];
        private bool playerTurn = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void ttt_Button1_Click(object sender, EventArgs e)
        {
            if (playerTurn)
            {
                ttt_Button1.Text = "X";
                board[0, 0] = 1;
            }
            else
            {
                ttt_Button1.Text = "O";
                board[0, 0] = 1;
            }
            playerTurn = !playerTurn;
            checkForWinner();
            ttt_Button1.Enabled = false;

        }

        private void ttt_Button2_Click(object sender, EventArgs e)
        {
            if (playerTurn)
            {
                ttt_Button2.Text = "X";
                board[0, 1] = 1;
            }
            else
            {
                ttt_Button2.Text = "O";
                board[0, 1] = 2;
            }
            playerTurn = !playerTurn;
            checkForWinner();
            ttt_Button2.Enabled = false;

        }

        private void ttt_Button3_Click(object sender, EventArgs e)
        {
            if (playerTurn)
            {
                ttt_Button3.Text = "X";
                board[0, 2] = 1;
            }
            else
            {
                ttt_Button3.Text = "O";
                board[0,2] = 2;
            }
            playerTurn = !playerTurn;
            checkForWinner();
            ttt_Button3.Enabled = false;
        }

        private void ttt_Button4_Click(object sender, EventArgs e)
        {
            if (playerTurn)
            {
                ttt_Button4.Text = "X";
                board[1, 0] = 1;
            }
            else
            {
                ttt_Button4.Text = "O";
                board[1, 0] = 2;
            }
            playerTurn = !playerTurn;
            checkForWinner();
            ttt_Button4.Enabled = false;
        }

        private void ttt_Button5_Click(object sender, EventArgs e)
        {
            if (playerTurn)
            {
                ttt_Button5.Text = "X";
                board[1, 1] = 1;
            }
            else
            {
                ttt_Button5.Text = "O";
                board[1, 1] = 2;
            }
            playerTurn = !playerTurn;
            checkForWinner();
            ttt_Button5.Enabled = false;
        }

        private void ttt_Button6_Click(object sender, EventArgs e)
        {
            if (playerTurn)
            {
                ttt_Button6.Text = "X";
                board[1, 2] = 1;
            }
            else
            {
                ttt_Button6.Text = "O";
                board[1, 2] = 2;
            }
            playerTurn = !playerTurn;
            checkForWinner();
            ttt_Button6.Enabled = false;
        }

        private void ttt_Button7_Click(object sender, EventArgs e)
        {
            if (playerTurn)
            {
                ttt_Button7.Text = "X";
                board[2, 0] = 1;
            }
            else
            {
                ttt_Button7.Text = "O";
                board[2, 0] = 2;
            }
            playerTurn = !playerTurn;
            checkForWinner();
            ttt_Button7.Enabled = false;
        }

        private void ttt_Button8_Click(object sender, EventArgs e)
        {
            if (playerTurn)
            {
                ttt_Button8.Text = "X";
                board[2, 1] = 1;
            }
            else
            {
                ttt_Button8.Text = "O";
                board[2, 1] = 2;
            }
            playerTurn = !playerTurn;
            checkForWinner();
            ttt_Button8.Enabled = false;
        }

        private void ttt_Button9_Click(object sender, EventArgs e)
        {
            if (playerTurn)
            {
                ttt_Button9.Text = "X";
                board[2, 2] = 1;
            }
            else
            {
                ttt_Button9.Text = "O";
                board[2, 2] = 2;
            }
            playerTurn = !playerTurn;
            checkForWinner();
            ttt_Button9.Enabled = false;
        }

        private void newGame_Button_Click(object sender, EventArgs e)
        {
            ttt_Button1.Text = "";
            ttt_Button2.Text = "";
            ttt_Button3.Text = "";
            ttt_Button4.Text = "";
            ttt_Button5.Text = "";
            ttt_Button6.Text = "";
            ttt_Button7.Text = "";
            ttt_Button8.Text = "";
            ttt_Button9.Text = "";
            ttt_Button1.Enabled = true;
            ttt_Button2.Enabled = true;
            ttt_Button3.Enabled = true;
            ttt_Button4.Enabled = true;
            ttt_Button5.Enabled = true;
            ttt_Button6.Enabled = true;
            ttt_Button7.Enabled = true;
            ttt_Button8.Enabled = true;
            ttt_Button9.Enabled = true;

            Array.Clear(board, 0, board.Length);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    board[i, j] = 0;
        }
        //Tried to get a draw call if board was full and no winner found
       // public bool boardFull()
       // {
       // bool boardFull = true;
       //for (int i = 0; i < board.Length; i++)
       //   for (int j = 0; j < board.Length - 1; j++)
       // {
       //   if (board[i,j] == 0)
       //  {
       //      boardFull = false;
       //  }
       // }
       // return boardFull;
       // }

        private void checkForWinner()
        {
            // collumns 
            if (board[0, 0] == board[1, 0] && board[0, 0] == board[2, 0])
            {
                if (board[0, 0] == 1)
                    MessageBox.Show("Player X has Won!");
                else if (board[0, 0] == 2)
                    MessageBox.Show("Player O has Won!");

            }
            else if (board[0, 1] == board[1, 1] && board[0, 1] == board[2, 1])
            {
                if (board[0, 1] == 1)
                    MessageBox.Show("Player X has Won!");
                else if (board[0, 1] == 2)
                    MessageBox.Show("Player O has Won!");

            }
            else if (board[0, 0] == board[1, 0] && board[0, 2] == board[2, 2])
            {
                if (board[0, 2] == 1)
                    MessageBox.Show("Player X has Won!");
                else if (board[0, 2] == 2)
                    MessageBox.Show("Player O has Won!");

            }
            // Rows 
            if (board[0, 0] == board[0, 1] && board[0, 0] == board[0, 2])
            {
                if (board[0, 0] == 1)
                    MessageBox.Show("Player X has Won!");
                else if (board[0, 0] == 2)
                    MessageBox.Show("Player O has Won!");

            }
            else if (board[1, 0] == board[1, 1] && board[1, 0] == board[1, 2])
            {
                if (board[1, 0] == 1)
                    MessageBox.Show("Player X has Won!");
                else if (board[1, 0] == 2)
                    MessageBox.Show("Player O has Won!");

            }
            else if (board[2, 0] == board[2, 1] && board[2, 0] == board[2, 2])
            {
                if (board[2, 0] == 1)
                    MessageBox.Show("Player X has Won!");
                else if (board[2, 0] == 2)
                    MessageBox.Show("Player O has Won!");

            }
            //diagonals
            if (board[0, 0] == board[1, 1] && board[0, 0] == board[2, 2])
            {
                if (board[0, 0] == 1)
                    MessageBox.Show("Player X has Won!");
                else if (board[0, 0] == 2)
                    MessageBox.Show("Player O has Won!");

            }
            else if (board[0, 2] == board[1, 1] && board[0, 2] == board[2, 0])
            {
                if (board[0, 2] == 1)
                    MessageBox.Show("Player X has Won!");
                else if (board[0, 2] == 2)
                    MessageBox.Show("Player O has Won!");

            }
        }
    }
}
