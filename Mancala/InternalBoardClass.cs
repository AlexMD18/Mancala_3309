/*
Team: Alex Drogo & Sean Fuller
Due-Date: 04/02/2020
CIS 3309-001
Internal Board Class - 
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mancala
{
    class InternalBoardClass
    {
        GamePlayClass gpc;

        private int[] pocketArray;


        //Constructor
        public InternalBoardClass()
        {
            pocketArray = new int[14];
        }

        public void initalizeBoard()
        {
            
        }

        public bool gameOver()
        {
            return true;
        }
    }
}
