/*
Team: Alex Drogo & Sean Fuller
Due-Date: 04/02/2020
CIS 3309-001
Game Play Class - 
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mancala
{
    class GamePlayClass
    {
        private bool player1Turn;
        private bool player2Turn;
        private bool playerTurn;

        public GamePlayClass()
        {
            player1Turn = true;
            player2Turn = false;
        }

        public bool switchTurns()
        {
            return false;
        }

        public void printWinner()
        {
            
        }
    }
}
