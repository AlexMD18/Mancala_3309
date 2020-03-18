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
        private int position;

        //Constructor
        public InternalBoardClass()
        {
            position = 0;
            pocketArray = new int[14];
            while (position < 14)
            {
                pocketArray[position] = 4;
            }
        }

        public bool move(int position)
        {
            if (pocketArray[position] == 0)
            {
                return false;
            }
            int value = pocketArray[position];
            pocketArray[position] = 0;
            while (value > 0)
            {
                if (position == 14)
                {
                    value--;
                    pocketArray[position] += 1;
                    position = 1;
                }
                else
                {
                    position = position + 1;
                    pocketArray[position] += 1;
                    value--;
                }
            }
            return true;
        }
        public int getvalue(int position)
        {
            int value = pocketArray[position];
            return value;
        }

        public bool gameOver()
        {
            return true;
        }
    }
}
