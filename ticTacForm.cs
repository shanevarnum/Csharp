using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToeSimulatorVarnum
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void newGameButton_Click(object sender, EventArgs e)
        {

            const int ROW = 3;
            const int COL = 3;
            int[,] game = new int[ROW, COL];

            Random rand = new Random();

            for (int row = 0; row < ROW; row++)
            {
                for (int col = 0; col < COL; col++)
                {
                    game[row, col] = rand.Next(2);

                    char[] charvalues = new char[2];
                    charvalues[0] = 'O';
                    charvalues[1] = 'X';

                    labelOne.Text = charvalues[game[0, 0]].ToString();
                    labelTwo.Text = charvalues[game[0, 1]].ToString();
                    labelThree.Text = charvalues[game[0, 2]].ToString();

                    labelFour.Text = charvalues[game[1, 0]].ToString();
                    labelFive.Text = charvalues[game[1, 1]].ToString();
                    labelSix.Text = charvalues[game[1, 2]].ToString();

                    labelSeven.Text = charvalues[game[2, 0]].ToString();
                    labelEight.Text = charvalues[game[2, 1]].ToString();
                    labelNine.Text = charvalues[game[2, 2]].ToString();

                    if (game[0, 0] == 0 && game[0, 1] == 0 && game[0, 2] == 0)
                    {
                        winnerLabel.Text = "O Wins";
                    }
                    else if (game[0, 0] == 1 && game[0, 1] == 1 && game[0, 2] == 1)
                    {
                        winnerLabel.Text = "X Wins";
                    }
                    else if (game[1, 0] == 0 && game[1, 1] == 0 && game[1, 2] == 0)
                    {
                        winnerLabel.Text = "O Wins";
                    }
                    else if (game[1, 0] == 1 && game[1, 1] == 1 && game[1, 2] == 1)
                    {
                        winnerLabel.Text = "X Wins";
                    }
                    else if (game[2, 0] == 0 && game[2, 1] == 0 && game[2, 2] == 0)
                    {
                        winnerLabel.Text = "O Wins";
                    }
                    else if (game[2, 0] == 1 && game[2, 1] == 1 && game[2, 2] == 1)
                    {
                        winnerLabel.Text = "X Wins";
                    }
                    else if (game[0, 0] == 0 && game[1, 0] == 0 && game[2, 0] == 0)
                    {
                        winnerLabel.Text = "O Wins";
                    }
                    else if (game[0, 0] == 1 && game[1, 0] == 1 && game[2, 0] == 1)
                    {
                        winnerLabel.Text = "X Wins";
                    }
                    else if (game[0, 1] == 0 && game[1, 1] == 0 && game[2, 1] == 0)
                    {
                        winnerLabel.Text = "O Wins";
                    }
                    else if (game[0, 1] == 1 && game[1, 1] == 1 && game[2, 1] == 1)
                    {
                        winnerLabel.Text = "X Wins";
                    }
                    else if (game[0, 2] == 0 && game[1, 2] == 0 && game[2, 2] == 0)
                    {
                        winnerLabel.Text = "O Wins";
                    }
                    else if (game[0, 2] == 1 && game[1, 2] == 1 && game[2, 2] == 1)
                    {
                        winnerLabel.Text = "X Wins";
                    }
                    else if (game[0, 0] == 0 && game[1, 1] == 0 && game[2, 2] == 0)
                    {
                        winnerLabel.Text = "O Wins";
                    }
                    else if (game[0, 0] == 1 && game[1, 1] == 1 && game[2, 2] == 1)
                    {
                        winnerLabel.Text = "X Wins";
                    }
                    else if (game[0, 2] == 0 && game[1, 1] == 0 && game[2, 0] == 0)
                    {
                        winnerLabel.Text = "O Wins";
                    }
                    else if (game[0, 2] == 1 && game[1, 1] == 1 && game[2, 0] == 1)
                    {
                        winnerLabel.Text = "X Wins";
                    }
                    else
                    {
                        winnerLabel.Text = "Tie";
                    }



                }


            }

        }


        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}

        


 
    










    



            



    

        
 

 
  


