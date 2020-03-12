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
