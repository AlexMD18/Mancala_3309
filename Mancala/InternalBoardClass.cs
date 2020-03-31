/*
Team: Alex Drogo & Sean Fuller
Due-Date: 04/02/2020
CIS 3309-001
Internal Board Class - Holds arrays to represent pockets, methods for moving pieces when selected, Board initialization, 
and the update of the board when the players move.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mancala
{
    class InternalBoardClass
    {

        private int[] pocketValues = new int[14];
        private int position;

        //Constructor
        public InternalBoardClass()
        {

        }

        //Attaches the array to the board
        public bool createBoard()
        {
            position = 0;
            while (position < 14)
            {
                pocketValues[position] = 4;
                position++;
            }
            pocketValues[6] = 0;
            pocketValues[13] = 0;
            return true;
        }

        //moves the "pieces" on the board when the user presses on a button.
        public bool move(int position)
        {
            if (pocketValues[position] == 0)
            {
                if (position > 0 && position < 6)
                {
                    if (pocketValues[0] + pocketValues[1] + pocketValues[2] + pocketValues[3] + pocketValues[4] + pocketValues[5] == 0)
                    {
                        return false;
                    }
                }
                if (position > 6 && position < 13)
                {
                    if (pocketValues[7] + pocketValues[8] + pocketValues[9] + pocketValues[10] + pocketValues[11] + pocketValues[12] == 0)
                    {
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("Pocket is Empty!");
                    return true;
                }

            }
            int value = pocketValues[position];
            pocketValues[position] = 0;
            bool pass = false;
            while (value > 0)
            {
                if (value == 1 && position == 5 && pass == false)
                {
                    position = position + 1;
                    pocketValues[position] += 1;
                    value--;
                    return true;
                }
                if (value == 1 && position == 12 && pass == false)
                {
                    position = position + 1;
                    pocketValues[position] += 1;
                    value--;
                    return true;
                }
                else if (position == 13)
                {
                    position = 0;
                    pocketValues[position] += 1;
                    value--;
                    pass = true;
                }
                else if (position == 6)
                {
                    position = position + 1;
                    pocketValues[position] += 1;
                    value--;
                    pass = true;
                }
                else
                {
                    position = position + 1;
                    pocketValues[position] += 1;
                    value--;
                }
            }

            return false;
        }

        //Returns the number of pieces in each pocket 
        public int getvalue(int position)
        {
            int value = pocketValues[position];
            return value;
        }
    }
}