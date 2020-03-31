/*
Team: Alex Drogo & Sean Fuller
Due-Date: 04/02/2020
CIS 3309-001
Game Play Class - Keeps track of everything that has to do with the players in the game. It will calculate and save the 
scores that the players currently have, and check after each turn to see if the two banks at the end of the board add 
up to 48. If they do the game will end and a messageBox will be promoted stating who won the game and the score of each 
player.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mancala
{
    class GamePlayClass
    {
        //Private variables and object instatiation
        InternalBoardClass currentBoard = new InternalBoardClass();
        PlayerClass player = new PlayerClass();
        private bool player1Turn;
        private bool player2Turn;

        //Constructor
        public GamePlayClass()
        {
            player1Turn = true;
            player2Turn = false;
        }

        //Method that switches turns to the other player
        public void switchTurns()
        {
            if (this.player1Turn == true)
            {
                this.player1Turn = false;
            }
            else if (this.player2Turn == false)
            {
                this.player2Turn = true;
            }
        }

        //Method that will calculate which player has a higher score at the end of the game and print that message to the user.
        public bool printWinner()
        {
            if (currentBoard.getvalue(6) + currentBoard.getvalue(13) == 48)
            {
                if (currentBoard.getvalue(6) > currentBoard.getvalue(13))
                {
                    MessageBox.Show(player.getName() + " Wins!");
                    return true;
                }
                else
                {
                    MessageBox.Show(player.getName() + " Wins!");
                    return true;
                }
            }
            return false;
        }
    }
}