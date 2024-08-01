/* Lindsey DeDecker
 * CST-150 Part 2
 * August 1st 2024
 */


using System.Drawing.Text;
using System.Security.Policy;

namespace CST_150_TicTacToe
{
    public partial class TicTacToe : Form
    {
        public TicTacToe()
        {
          
        InitializeComponent();
        }

          private void Form1_Load(object sender, EventArgs e)
          {
            //Hide board and winner label
            lblWinner.Visible = false;
            square1.Visible = false;
            square2.Visible = false;
            square3.Visible = false;
            square4.Visible = false;
            square5.Visible = false;
            square6.Visible = false;
            square7.Visible = false;
            square8.Visible = false;
            square9.Visible = false;
        }

         private void newGame_Click(object sender, EventArgs e)
         {
            //Creating a radom number generator
            Random rand = new Random();

            //Show the board and winner
            lblWinner.Visible = true;
            square1.Visible = true;
            square2.Visible = true;
            square3.Visible = true;
            square4.Visible = true;
            square5.Visible = true;
            square6.Visible = true;
            square7.Visible = true;
            square8.Visible = true;
            square9.Visible = true;

            //initialize the 2D array that will hold the values of the board
            int[,] game = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

            //Loop throught the array randomizing each spot a 0 or 1.
            for(int k = 0; k <game.GetLength(0); k++)
            {
                for (int l = 0; l < game.GetLength(1); l++)
                {
                    game[k, l] = rand.Next(0, 2);
                }
            }
            //Set the squares to display o or X using the ternary operator
            square1.Text = game[0, 0] == 0 ? "O" : "X";
            square2.Text = game[0, 1] == 0 ? "O" : "X";
            square3.Text = game[0, 2] == 0 ? "O" : "X";
            square4.Text = game[1, 0] == 0 ? "O" : "X";
            square5.Text = game[1, 1] == 0 ? "O" : "X";
            square6.Text = game[1, 2] == 0 ? "O" : "X";
            square7.Text = game[2, 0] == 0 ? "O" : "X";
            square8.Text = game[2, 1] == 0 ? "O" : "X";
            square9.Text = game[2, 2] == 0 ? "O" : "X";

            //Check to see if O wins
            if (game[0, 0] == 0 && game[0, 1] == 0 && game[0, 2] == 0)
            {
                lblWinner.Text = " O has won the game!";
            }
            else if (game[1, 0] == 0 && game[1, 1] == 0 && game[1, 2] == 0)
            {
                lblWinner.Text = " O has won the game!";
            }
            else if (game[2, 0] == 0 && game[2, 1] == 0 && game[2, 2] == 0)
            {
                lblWinner.Text = " O has won the game!";
            }
            else if (game[0, 0] == 0 && game[1, 0] == 0 && game[2, 0] == 0)
            {
                lblWinner.Text = " O has won the game!";
            }
            else if (game[0, 1] == 0 && game[1,1] == 0 && game[2,1] == 0)
            {
                lblWinner.Text = " O has won the game!";
            }
            else if (game[0,2] == 0 && game[1,2] == 0 && game[2,2] == 0)
            {
                lblWinner.Text = " O has won the game!";
            }
            else if (game[0,0] == 0 && game[1, 1] == 0 && game[2, 2] == 0)
            {
                lblWinner.Text = " O has won the game!";
            }
            else if (game[0, 2] == 0 && game[1, 1] == 0 && game[2,0] == 0)
            {
                lblWinner.Text = " O has won the game!";
            }


            //Now looop to see if X is the winner
            else if (game[0, 0] == 1 && game[0, 1] == 1 && game[0, 2] == 0)
            {
                lblWinner.Text = " X has won the game!";
            }
            else if (game[1, 0] == 1 && game[1, 1] == 1 && game[1, 2] == 1)
            {
                lblWinner.Text = " X has won the game!";
            }
            else if (game[2, 0] == 1 && game[2, 1] == 1 && game[2, 2] == 1)
            {
                lblWinner.Text = " X has won the game!";
            }
            else if (game[0, 0] == 1 && game[1, 0] == 1 && game[2, 0] == 1)
            {
                lblWinner.Text = " X has won the game!";
            }
            else if (game[0, 1] == 1 && game[1, 1] == 1 && game[2, 1] == 1)
            {
                lblWinner.Text = " X has won the game!";
            }
            else if (game[0, 2] == 1 && game[1, 2] == 1 && game[2, 2] == 1)
            {
                lblWinner.Text = " X has won the game!";
            }
            else if (game[0, 0] == 1 && game[1, 1] == 1 && game[2, 2] == 1)
            {
                lblWinner.Text = " X has won the game!";
            }
            else if (game[0, 2] == 1 && game[1, 1] == 1 && game[2, 0] == 1)
            {
                lblWinner.Text = " X has won the game!";
            }
            else
            {
                lblWinner.Text = "Game ends in a tie!";
            }





        }

         private void exit_Click(object sender, EventArgs e)
         {
              //Close the form when the user wants to exit the game
               this.Close();
         }

        
    }
}


