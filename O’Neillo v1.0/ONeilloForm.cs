using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using GUIImageArray;
using System.IO;
using O_Neillo_v1._0.Classes;

namespace O_Neillo_v1._0
{
    public partial class ONeilloForm : Form
    {
        //We need to bring in the GUIImageArray class...
        GImageArray GUIOthelloGameBoard;

        //we need to create the array which we will imprint the image class onto
        public int[,] OthelloGameBoard = new int[8, 8];

        //make the images
        string pathImage = Directory.GetCurrentDirectory() + "\\images\\";
        int playerTurn = 0;
        bool isMovePossible;

        public ONeilloForm()
        {
            InitializeComponent();
        }


        private void ONeilloForm_Load(object sender, EventArgs e)
        {
            //where we actually create the form, displaying everything needed
            panelPlayers.Show();
            lblPlayer1Turn.Hide();
            lblPlayer2Turn.Hide();
        }



        /// <summary>
        /// where we actually make the board ready to start the game. We make most of the board '10'(green) and we add
        /// the starting positions of the players
        /// </summary>
        private void InitialiseArray()
        {
            //for each item in the array - make it green
            for (int row = 0; row <= 7; row++)
            {
                for (int column = 0; column <= 7; column++)
                {
                    OthelloGameBoard[row, column] = 10;
                }
            }
            OthelloGameBoard[3, 4] = 0; OthelloGameBoard[4, 3] = 0; OthelloGameBoard[3, 3] = 1; OthelloGameBoard[4, 4] = 1;
        }

        /// <summary>
        /// Method which is called whenever a counter image on the board is clicked
        /// What this does is it calls the validator method i have created eight times, running for each direction to be checked
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Which_Element_Clicked(object sender, EventArgs e)
        {
            int numOfWhite=0;
            int numOfBlack=0;
            //gets the individual item's row and column
            int row = GUIOthelloGameBoard.Get_Row(sender);
            int column = GUIOthelloGameBoard.Get_Col(sender);

            //link to function which validates if the move is possible
            if (OthelloGameBoard[row, column] == 10)
            {
                //calls method 8 times for all directions
                Validator(row, column, 0, 1);
                Validator(row, column, 1, -1);
                Validator(row, column, -1, 1);
                Validator(row, column, 0, -1);
                Validator(row, column, 1, 0);
                Validator(row, column, -1, 0);
                Validator(row, column, -1, -1);
                Validator(row, column, 1, 1);

                //changing player
                if (isMovePossible == true)
                {
                    //we will count the number of each counter in the grid here, and we will display this in labels on the screen
                    for (int xValCheck0 = 0; xValCheck0 <= 7; xValCheck0++)
                    {
                        for (int yValCheck0 = 0; yValCheck0 <= 7; yValCheck0++)
                        {
                            if (OthelloGameBoard[xValCheck0, yValCheck0] == 0)
                                numOfBlack++;
                            if (OthelloGameBoard[xValCheck0, yValCheck0] == 1)
                                numOfWhite++;
                        }
                    }
                    //prints the number of tokens each player has onto the screen
                    lblPlayer1Tokens.Text = numOfBlack.ToString() + "X";
                    lblPlayer2Tokens.Text = numOfWhite.ToString() + "X";

                    //this changes which player's turn it is and it also changes which label shows
                    if (playerTurn == 0)
                    {
                        playerTurn++;
                        lblPlayer1Turn.Hide();
                        lblPlayer2Turn.Show();
                    }
                        
                    else
                    {
                        playerTurn--;
                        lblPlayer2Turn.Hide();
                        lblPlayer1Turn.Show();
                    }

                    IsGameFinished(numOfBlack, numOfWhite);
                }
                //defaults back to false as we use a global
                isMovePossible = false;
            }
        }



        /// <summary>
        /// Method which checks whether the game is over or not - happens everytime a user makes a move
        /// </summary>
        /// <param name="numOfBlack"></param>
        /// <param name="numOfWhite"></param>
        private void IsGameFinished(int numOfBlack,int numOfWhite)
        {
            bool gameNotWonByFullBoard = false;
            bool gameNotWonByNoCounters = false;
            bool isAnyMovePossible = false;

            for (int xWinCheck = 0; xWinCheck <= 7; xWinCheck++)
            {
                for (int yWinCheck = 0; yWinCheck <= 7; yWinCheck++)
                {
                    //checks whether the board is full by counting the green squares
                    if (OthelloGameBoard[xWinCheck, yWinCheck] == 10)
                        gameNotWonByFullBoard = true;

                    //Here could I add something which checks whether both players have a counter on the board- use the numofcounters variable
                    if ((numOfBlack > 0) && (numOfWhite > 0))
                        gameNotWonByNoCounters = true;
                }
            }


            //checks whether any move on the board is possible... only runs the method for green squares as only they can be pressed
            for (int row = 0; row <= 7; row++)
            {
                for (int col = 0; col <= 7; col++)
                {
                    if (OthelloGameBoard[row, col] == 10)
                    {
                        isAnyMovePossible = IsAnyMoveValid(row, col, 0, 1, isAnyMovePossible);
                        isAnyMovePossible = IsAnyMoveValid(row, col, 1, -1, isAnyMovePossible);
                        isAnyMovePossible = IsAnyMoveValid(row, col, -1, 1, isAnyMovePossible);
                        isAnyMovePossible = IsAnyMoveValid(row, col, 0, -1, isAnyMovePossible);
                        isAnyMovePossible = IsAnyMoveValid(row, col, 1, 0, isAnyMovePossible);
                        isAnyMovePossible = IsAnyMoveValid(row, col, -1, 0, isAnyMovePossible);
                        isAnyMovePossible = IsAnyMoveValid(row, col, -1, -1, isAnyMovePossible);
                        isAnyMovePossible = IsAnyMoveValid(row, col, 1, 1, isAnyMovePossible);
                    }
                }
            }

            //if gameNotWon is not equal to true(IF THE GAME HAS BEEN WON)
            if ((gameNotWonByFullBoard != true) || (gameNotWonByNoCounters != true))
                CheckWinner(numOfBlack, numOfWhite);

            else if(isAnyMovePossible == false)
                ForfeitGame();

            else
                return;
        }

        

        /// <summary>
        /// What this method does is it counts who has more counters on the board and then displays winner based on result
        /// </summary>
        /// <param name="player1Counter"></param>
        /// <param name="player2Counter"></param>
        private void CheckWinner(int player1Counter, int player2Counter)
        {
            if (player1Counter > player2Counter)
                MessageBox.Show(txtBoxPlayer1Name.Text + " Is The Winner");
            else if (player1Counter < player2Counter)
                MessageBox.Show(txtBoxPlayer2Name.Text + " Is The Winner");
            else if (player1Counter == player2Counter)
                MessageBox.Show("The Game Is A Tie");
        }

        /// <summary>
        /// A method for when a user cannot possibly make a move so they have to forfeit the game
        /// </summary>
        private void ForfeitGame()
        {
            if (playerTurn == 0)
            {
                MessageBox.Show(txtBoxPlayer2Name.Text + " Is The Winner");
            }
            else
            {
                MessageBox.Show(txtBoxPlayer1Name.Text + " Is The Winner");
            }
        }




        /// <summary>
        /// Creates a New Game, and if the user is already in game, it replaces what is already on the screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool userSave;

            if (GUIOthelloGameBoard != null)
            {
                userSave =  YesNoBox.InputBox("Would You Like To Save The Game?");
                if (userSave == true)
                {
                    saveGameToolStripMenuItem_Click(sender, e);
                }
                
            }
            //here what we are doing is making/remaking the array
            InitialiseArray();
            //here what we are doing is making it so that the names of users cannot be changed midgame
            if ((txtBoxPlayer1Name.Text == "") || (txtBoxPlayer2Name.Text == ""))
            {
                MessageBox.Show("Please Enter In Name Values For Both Players! ");
                return;
            }

            txtBoxPlayer1Name.Enabled = false;
            txtBoxPlayer2Name.Enabled = false;
            //because black always starts, we reset the player to zero
            playerTurn = 0;
            lblPlayer1Turn.Show();

            //this if allows me to make new games happen...there was a bug which crashed the game everytime i started a new game
            //the problem was that I kept trying to make new image arrays
            if (GUIOthelloGameBoard == null)
            {
                //creates the Image array on the users screen
                GUIOthelloGameBoard = new GImageArray(this, OthelloGameBoard, 35, 25, 100, 25, 2, pathImage);
                GUIOthelloGameBoard.Which_Element_Clicked += new GImageArray.ImageClickedEventHandler(Which_Element_Clicked);
            }
            else
            {
                GUIOthelloGameBoard.UpDateImages(OthelloGameBoard);
            }
        }




        /// <summary>
        /// Where we are saving the current game being played
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string savePath = Directory.GetCurrentDirectory() + "\\";
            string player1Name = txtBoxPlayer1Name.Text;
            string player2Name = txtBoxPlayer2Name.Text;
            string saveFileName = MyDialogs.My_Dialogs.InputBox("Name TextFile", "Enter What You Would Like To Name Your File");
            if (saveFileName == "")
            {
                MessageBox.Show("If You Wish To Save, Please Enter A Name For Your Game");
                return;
            }
            else if (saveFileName == "asdfsasds12321223aaddvfb")
            {
                return;
            }

            StreamWriter writer = File.CreateText(savePath + saveFileName + ".txt");
            //writes down each item on a new line
            //the only flaw with this whole thing is that users can just change their scores
            writer.WriteLine(player1Name);
            writer.WriteLine(player2Name);
            writer.WriteLine(playerTurn);
            for (int row = 0; row <= 7; row++)
            {
                for (int column = 0; column <= 7; column++)
                {
                    writer.WriteLine(OthelloGameBoard[row, column]);
                }
            }
            writer.Close();
        }




        /// <summary>
        /// When players wish to resume a game they were playing earlier
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void restoreGameToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //where we open up a game that has already been played
            string restorePath = Directory.GetCurrentDirectory() + "\\";
            string restoreFileName = MyDialogs.My_Dialogs.InputBox("Open TextFile", "What Is The Name Of Your Saved Text File");
            if (restoreFileName == "")
                return;

            //makes it check whether the file exists-- if it doesnt it notifies the user
            if (!File.Exists(restorePath + restoreFileName + ".txt"))
            {
                MessageBox.Show("The File You Have Entered Does Not Exist");
                return;
            }
            //reads from the text file- the structure of the textfile is always the same
            StreamReader reader = File.OpenText(restorePath + restoreFileName + ".txt");

            string player1Name = reader.ReadLine();
            string player2Name = reader.ReadLine();
            playerTurn = Int32.Parse(reader.ReadLine());
            for (int row = 0; row <= 7; row++)
            {
                for (int column = 0; column <= 7; column++)
                {
                    //reads each line of the text file and fits it into the array
                    OthelloGameBoard[row, column] = Int32.Parse(reader.ReadLine());
                }
            }

            txtBoxPlayer1Name.Text = player1Name;
            txtBoxPlayer2Name.Text = player2Name;

            //this checks whos turn it is and then displays this information on screen to the player
            if (playerTurn == 0)
            {
                lblPlayer1Turn.Show();
                lblPlayer2Turn.Hide();
            }
            else if (playerTurn == 1)
            {
                lblPlayer2Turn.Show();
                lblPlayer1Turn.Hide();
            }

            if (GUIOthelloGameBoard == null)
            {
                //creates the Image array on the users screen
                GUIOthelloGameBoard = new GImageArray(this, OthelloGameBoard, 35, 25, 100, 25, 2, pathImage);
                GUIOthelloGameBoard.Which_Element_Clicked += new GImageArray.ImageClickedEventHandler(Which_Element_Clicked);
            }
            else
            {
                GUIOthelloGameBoard.UpDateImages(OthelloGameBoard);
            }
        }




        /// <summary>
        /// For Speak Icon--- making it tick
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void speakToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //checks whether it is already checked and changes it's state
            if (speakStripMenuItem.Checked == true)
                speakStripMenuItem.Checked = false;
            else
                speakStripMenuItem.Checked = true;
        }





        /// <summary>
        /// This is a Method which is ran for every possible square on the grid, and it checks if there are any valid moves
        /// that could be played and if so, then a bool is returned as true.
        /// </summary>
        /// <param name="row"></param>
        /// <param name="col"></param>
        /// <param name="changeInRow"></param>
        /// <param name="changeInCol"></param>
        /// <param name="isAnyMovePossible"></param>
        /// <returns>"isAnyMovePossible"</returns>
        private bool IsAnyMoveValid(int row, int col, int changeInRow, int changeInCol, bool isAnyMovePossible)
        {
            int trueCount = 0;
            //here we are making lists containing the rows and the columns that need colouring in
            List<int> validRow = new List<int>();
            List<int> validCol = new List<int>();

            validRow.Add(row);
            validCol.Add(col);
            //adding the change in direction to the row to be checked
            row += changeInRow;
            col += changeInCol;
            //a bool for if the same counter as the player is met - helps with the validation
            bool sameCounterFound;
            sameCounterFound = false;


            //we need to make a while in the bounds of the array so that an error isnt thrown
            while ((row >= 0) && (row < 8) && (col >= 0) && (col < 8))
            {
                //we need to go through each item in the row/col/diagonal in array but we
                //need to make sure they are not green or the colour of the player
                if (OthelloGameBoard[row, col] == playerTurn)
                {
                    sameCounterFound = true;
                    break;
                }
                if (OthelloGameBoard[row, col] == 10)
                {
                    break;
                }
                //adding to a list of valid moves which I can later go through-- ones that need colouring
                //the list will only be gone through if the move is valid
                validRow.Add(row);
                validCol.Add(col);

                row += changeInRow;
                col += changeInCol;
                trueCount++;
            }

            if ((trueCount >= 1) && (sameCounterFound == true))
            {
                isAnyMovePossible = true;
            }
            return isAnyMovePossible;
        }


        /// <summary>
        /// Opens up a new form giving the user a little bit of information about the program
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm form = new AboutForm();
            form.ShowDialog();
        }




        /// <summary>
        /// Closes the program - Does what pressing 'X' would do
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool userSave;

            if (GUIOthelloGameBoard != null)
            {
                userSave = YesNoBox.InputBox("Would You Like To Save The Game?");
                if (userSave == true)
                {
                    saveGameToolStripMenuItem_Click(sender, e);
                }

            }
            Application.Exit();
        }



        /// <summary>
        /// This is the method which is ran when we are checking if a user has entered a valid move. It is ran for each
        /// direction and we did this by passing through the change in each row/col we are using at the time. For example if we
        /// were to check in the North Direction we would pass through (1,0).
        /// </summary>
        /// <param name="row"></param>
        /// <param name="col"></param>
        /// <param name="changeInRow"></param>
        /// <param name="changeInCol"></param>
        private void Validator(int row, int col, int changeInRow, int changeInCol)
        {
            int trueCount = 0;
            //here we are making lists containing the rows and the columns that need colouring in
            List<int> validRow = new List<int>();
            List<int> validCol = new List<int>();

            validRow.Add(row);
            validCol.Add(col);
            //adding the change in direction to the row to be checked
            row += changeInRow;
            col += changeInCol;
            //a bool for if the same counter as the player is met - helps with the validation
            bool sameCounterFound;
            sameCounterFound = false;


            //we need to make a while in the bounds of the array so that an error isnt thrown
            while ((row >= 0) && (row < 8) && (col >= 0) && (col < 8))
            {
                //we need to go through each item in the row/col/diagonal in array but we
                //need to make sure they are not green or the colour of the player
                if (OthelloGameBoard[row, col] == playerTurn)
                {
                    sameCounterFound = true;
                    break;
                }
                if (OthelloGameBoard[row, col] == 10)
                {
                    break;
                }
                //adding to a list of valid moves which I can later go through-- ones that need colouring
                //the list will only be gone through if the move is valid
                validRow.Add(row);
                validCol.Add(col);

                row += changeInRow;
                col += changeInCol;
                trueCount++;
            }

            if ((trueCount >= 1) && (sameCounterFound == true))
            {
                for (int countNumber = 0; countNumber < validRow.Count; countNumber++)
                {
                    OthelloGameBoard[validRow[countNumber], validCol[countNumber]] = playerTurn;
                }
                GUIOthelloGameBoard.UpDateImages(OthelloGameBoard);
                isMovePossible = true;
            }
        }
    }
}
