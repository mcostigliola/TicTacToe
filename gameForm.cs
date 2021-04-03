using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicTacToe.Game;

namespace TicTacToe
{
    public partial class gameForm : Form
    {
        /// <summary>
        /// Initialize the game creating players.
        /// </summary>
        Player player1 = new Player(0, "Marco", true);
        Player player2 = new Player(0, "Fabio",false);
        //GameBoard gameBoard = new GameBoard();
        int boardComplete = -1;
        int winnerPlayerX = 0;
        int winnerPlayerO = 0;
        int gameInProgress = -1;
        public int boardCheck()
        {
            if (
            button1.Text == "X" && button2.Text == "X" && button3.Text == "X" ||
            button4.Text == "X" && button5.Text == "X" && button6.Text == "X" ||
            button7.Text == "X" && button8.Text == "X" && button9.Text == "X" ||
            button1.Text == "X" && button4.Text == "X" && button7.Text == "X" ||
            button2.Text == "X" && button5.Text == "X" && button8.Text == "X" ||
            button3.Text == "X" && button6.Text == "X" && button9.Text == "X" ||
            button1.Text == "X" && button5.Text == "X" && button9.Text == "X" ||
            button3.Text == "X" && button5.Text == "X" && button7.Text == "X"
                )
            {
                winnerPlayerX = 1;
                return winnerPlayerX;
            }
            else if (
            button1.Text == "O" && button2.Text == "O" && button3.Text == "O" ||
            button4.Text == "O" && button5.Text == "O" && button6.Text == "O" ||
            button7.Text == "O" && button8.Text == "O" && button9.Text == "O" ||
            button1.Text == "O" && button4.Text == "O" && button7.Text == "O" ||
            button2.Text == "O" && button5.Text == "O" && button8.Text == "O" ||
            button3.Text == "O" && button6.Text == "O" && button9.Text == "O" ||
            button1.Text == "O" && button5.Text == "O" && button9.Text == "O" ||
            button3.Text == "O" && button5.Text == "O" && button7.Text == "O"
                )
            {
                winnerPlayerO = 0;
                return winnerPlayerO;
            }

            return gameInProgress;
        }
        public gameForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            boardComplete = boardCheck();
            if (boardComplete == 1) 
            {
                MessageBox.Show($"{player1.toString()} is the winner");
            }
            else if (boardComplete == 0)
            {
                MessageBox.Show($"{player2.toString()} is the winner");
            }
            else if(boardComplete == -1)
            {
                if (player1.isActivePlayer())
                {
                    button1.Text = "X";
                    player1.setNotActive();
                    player2.setActive();
                }
                else if (player2.isActivePlayer())
                {
                    button1.Text = "O";
                    player2.setNotActive();
                    player1.setActive();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            boardComplete = boardCheck();
            if (boardComplete == 1)
            {
                MessageBox.Show($"{player1.toString()} is the winner");
            }
            else if (boardComplete == 0)
            {
                MessageBox.Show($"{player2.toString()} is the winner");
            }
            else if (boardComplete == -1)
            {
                if (player1.isActivePlayer())
                {
                    button2.Text = "X";
                    player1.setNotActive();
                    player2.setActive();
                }
                else if (player2.isActivePlayer())
                {
                    button2.Text = "O";
                    player2.setNotActive();
                    player1.setActive();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            boardComplete = boardCheck();
            if (boardComplete == 1)
            {
                MessageBox.Show($"{player1.toString()} is the winner");
            }
            else if (boardComplete == 0)
            {
                MessageBox.Show($"{player2.toString()} is the winner");
            }
            else if (boardComplete == -1)
            {
                if (player1.isActivePlayer())
                {
                    button3.Text = "X";
                    player1.setNotActive();
                    player2.setActive();
                }
                else if (player2.isActivePlayer())
                {
                    button3.Text = "O";
                    player2.setNotActive();
                    player1.setActive();
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            boardComplete = boardCheck();
            if (boardComplete == 1)
            {
                MessageBox.Show($"{player1.toString()} is the winner");
            }
            else if (boardComplete == 0)
            {
                MessageBox.Show($"{player2.toString()} is the winner");
            }
            else if (boardComplete == -1)
            {
                if (player1.isActivePlayer())
                {
                    button4.Text = "X";
                    player1.setNotActive();
                    player2.setActive();
                }
                else if (player2.isActivePlayer())
                {
                    button4.Text = "O";
                    player2.setNotActive();
                    player1.setActive();
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            boardComplete = boardCheck();
            if (boardComplete == 1)
            {
                MessageBox.Show($"{player1.toString()} is the winner");
            }
            else if (boardComplete == 0)
            {
                MessageBox.Show($"{player2.toString()} is the winner");
            }
            else if (boardComplete == -1)
            {
                if (player1.isActivePlayer())
                {
                    button5.Text = "X";
                    player1.setNotActive();
                    player2.setActive();
                }
                else if (player2.isActivePlayer())
                {
                    button5.Text = "O";
                    player2.setNotActive();
                    player1.setActive();
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            boardComplete = boardCheck();
            if (boardComplete == 1)
            {
                MessageBox.Show($"{player1.toString()} is the winner");
            }
            else if (boardComplete == 0)
            {
                MessageBox.Show($"{player2.toString()} is the winner");
            }
            else if (boardComplete == -1)
            {
                if (player1.isActivePlayer())
                {
                    button6.Text = "X";
                    player1.setNotActive();
                    player2.setActive();
                }
                else if (player2.isActivePlayer())
                {
                    button6.Text = "O";
                    player2.setNotActive();
                    player1.setActive();
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            boardComplete = boardCheck();
            if (boardComplete == 1)
            {
                MessageBox.Show($"{player1.toString()} is the winner");
            }
            else if (boardComplete == 0)
            {
                MessageBox.Show($"{player2.toString()} is the winner");
            }
            else if (boardComplete == -1)
            {
                if (player1.isActivePlayer())
                {
                    button7.Text = "X";
                    player1.setNotActive();
                    player2.setActive();
                }
                else if (player2.isActivePlayer())
                {
                    button7.Text = "O";
                    player2.setNotActive();
                    player1.setActive();
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            boardComplete = boardCheck();
            if (boardComplete == 1)
            {
                MessageBox.Show($"{player1.toString()} is the winner");
            }
            else if (boardComplete == 0)
            {
                MessageBox.Show($"{player2.toString()} is the winner");
            }
            else if (boardComplete == -1)
            {
                if (player1.isActivePlayer())
                {
                    button8.Text = "X";
                    player1.setNotActive();
                    player2.setActive();
                }
                else if (player2.isActivePlayer())
                {
                    button8.Text = "O";
                    player2.setNotActive();
                    player1.setActive();
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            boardComplete = boardCheck();
            if (boardComplete == 1)
            {
                MessageBox.Show($"{player1.toString()} is the winner");
            }
            else if (boardComplete == 0)
            {
                MessageBox.Show($"{player2.toString()} is the winner");
            }
            else if (boardComplete == -1)
            {
                if (player1.isActivePlayer())
                {
                    button9.Text = "X";
                    player1.setNotActive();
                    player2.setActive();
                }
                else if (player2.isActivePlayer())
                {
                    button9.Text = "O";
                    player2.setNotActive();
                    player1.setActive();
                }
            }
        }

        private void restartButton_Click(object sender, EventArgs e)
        {
            button1.Text = "?";
            button2.Text = "?";
            button3.Text = "?";
            button4.Text = "?";
            button5.Text = "?";
            button6.Text = "?";
            button7.Text = "?";
            button8.Text = "?";
            button9.Text = "?";
            player1.setActive();
            player2.setNotActive();
        }
    }
}
