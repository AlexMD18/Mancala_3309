/*
Team: Alex Drogo & Sean Fuller
Due-Date: 04/02/2020
CIS 3309-001
Player Class - This class simply holds the information necessary to save the information that they player inserts into the 
player 1 and player 2 text boxes at the beginning of the game. 
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mancala
{
    class PlayerClass
    {
        //Private variables for player names
        private string playerOneName;
        private string playerTwoName;

        //Parameterless Constructor
        public PlayerClass()
        {

        }

        //Parameterized Constructor
        public PlayerClass(string playerOneName, string playerTwoName)
        {
            this.playerOneName = playerOneName;
            this.playerTwoName = playerTwoName;
        }

        //Start of getter methods
        public string getPlayerOneName
        {
            get
            {
                return (playerOneName);
            }
        }

        public string getPlayerTwoName
        {
            get
            {
                return (playerTwoName);
            }
        }//end getters
    }
}
