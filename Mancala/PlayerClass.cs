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
        private string Name;

        //Parameterless Constructor
        public PlayerClass()
        {

        }

        //Parameterized Constructor
        public PlayerClass(string playerName)
        {
            this.Name = playerName;
        }

        //Start of getter methods
        public string getName()
        {
            return Name;
        }
    }
}
