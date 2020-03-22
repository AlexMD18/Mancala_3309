/*
Team: Alex Drogo & Sean Fuller
Due-Date: 04/02/2020
CIS 3309-001
Mancala Main Form Class - This class takes care of all the back end functionality of the mancala board form. It itializes the
buttons at the beginning of the game and handles all the vaidation associated with the form. It hides and shows the different
elements of the board as needed and prints things such as instructions to the user.
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mancala
{
    public partial class Mancala : Form
    {
        //Private Variables
        private Button[] pocketButtons = new Button[14];
        private int[] pocketValues = new int[14];
        private int position;

        public Mancala()
        {
            InitializeComponent();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if(txtPlayerOneName.Text == "" || txtPlayerTwoName.Text == "")
            {
                MessageBox.Show("One or more player names blank. Please enter both player names!");
            }
            else
            {
                pnlBoard.Visible = true;
                txtBoardPlayer1Name.Visible = true;
                txtBoardPlayer2Name.Visible = true;
                txtBoardPlayer1Name.Text = txtPlayerOneName.Text;
                txtBoardPlayer2Name.Text = txtPlayerTwoName.Text;
                MessageBox.Show("Directions: \n\n" +
                                "Set Up: The Mancala board is made up of two rows of six pockets(also called “holes,” or “pits”) each. " +
                                "Four pieces are placed in each of the 12 pockets initally." +
                                "Each player has a “store” (also called a “Mancala”) where his/her name is placed on the Mancala board. " +
                                "\n\nObject: The object of the game is to collect the most pieces in the players store." +
                                "\n\nGame Play: " +
                                "\n1. The game begins with a player clicking any one of the pockets on his / her side." +
                                "\n2. Moving counter - clockwise, the game will deposit one of the stones in each pocket until the stones run out." +
                                "\n3. If the pieces run into your own store, one piece is deposited in it. " +
                                "If you run into your opponent's store, it is skiped and your pieces continue moving to the next pocket." +
                                "\n4. If the last piece you drop is in your own store, you take another turn." +
                                "\n5. After each move, the game will check to see if there are any pieces left in the 12 pockets. " +
                                "If there are pieces left in the pockets, the game will continue and the other player will begin their turn. " +
                                "If there are not any pieces left, the game will calulate who has more pieces in their store and print the winner", "Mancala - How To Play");
            }
        }

        //Closes the game
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Sets all the buttons on the board to indexes in the array.
        private void Mancala_Load(object sender, EventArgs e)
        {
            pocketButtons[0] = btnPocket1;
            pocketButtons[1] = btnPocket2;
            pocketButtons[2] = btnPocket3;
            pocketButtons[3] = btnPocket4;
            pocketButtons[4] = btnPocket5;
            pocketButtons[5] = btnPocket6;
            pocketButtons[6] = btnStorePocket7;
            pocketButtons[7] = btnPocket8;
            pocketButtons[8] = btnPocket9;
            pocketButtons[9] = btnPocket10;
            pocketButtons[10] = btnPocket11;
            pocketButtons[11] = btnPocket12;
            pocketButtons[12] = btnPocket13;
            pocketButtons[13] = btnStorePocket14;
            btnStorePocket14.Enabled = false;
            btnStorePocket7.Enabled = false;
            p1turn();

            position = 0;
            while (position < 14)
            {
                pocketButtons[position].Text = "4";
                pocketValues[position] = 4;
                position++;
            }
            pocketValues[6] = 0;
            pocketValues[13] = 0;
            pocketButtons[6].Text = "0";
            pocketButtons[13].Text = "0";
            //InternalBoardClass currentboard = new InternalBoardClass();

        }
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
                if(position > 6 && position < 13)
                { 
                    if(pocketValues[7] + pocketValues[8] + pocketValues[9] + pocketValues[10] + pocketValues[11] + pocketValues[12] == 0)
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
                if(value == 1 && position == 5 && pass == false)
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

        public void displaymove()
        {
            position = 0;
            while (position < 14)
            {
                pocketButtons[position].Text = Convert.ToString(pocketValues[position]);
                position++;
            }
        }

        public void p1turn()
        {
            btnPocket8.Enabled = false;
            btnPocket9.Enabled = false;
            btnPocket10.Enabled = false;
            btnPocket11.Enabled = false;
            btnPocket12.Enabled = false;
            btnPocket13.Enabled = false;

            btnPocket1.Enabled = true;
            btnPocket2.Enabled = true;
            btnPocket3.Enabled = true;
            btnPocket4.Enabled = true;
            btnPocket5.Enabled = true;
            btnPocket6.Enabled = true;
        }
        public void p2turn()
        {
            btnPocket8.Enabled = true;
            btnPocket9.Enabled = true;
            btnPocket10.Enabled = true;
            btnPocket11.Enabled = true;
            btnPocket12.Enabled = true;
            btnPocket13.Enabled = true;

            btnPocket1.Enabled = false;
            btnPocket2.Enabled = false;
            btnPocket3.Enabled = false;
            btnPocket4.Enabled = false;
            btnPocket5.Enabled = false;
            btnPocket6.Enabled = false;
        }

        public bool checkWin()
        {
            if (pocketValues[6] + pocketValues[13] == 48)
            {
                if (pocketValues[6] > pocketValues[13]) {
                    MessageBox.Show(txtBoardPlayer1Name.Text + " Wins!");
                    return true;
                }
                else
                {
                    MessageBox.Show(txtBoardPlayer2Name.Text + " Wins!");
                    return true;
                }
            }
            return false;
        }


        private void btnPocket1_Click(object sender, EventArgs e)
        {
            bool goagain = move(0);
            if(goagain != true)
            {
                p2turn();
            }
            displaymove();
            checkWin();
        }

        private void btnPocket2_Click(object sender, EventArgs e)
        {
            bool goagain = move(1);
            if (goagain != true)
            {
                p2turn();
            }
            displaymove();
            checkWin();
        }

        private void btnPocket3_Click(object sender, EventArgs e)
        {
            bool goagain = move(2);
            if (goagain != true)
            {
                p2turn();
            }
            displaymove();
            checkWin();
        }

        private void btnPocket4_Click(object sender, EventArgs e)
        {
            bool goagain = move(3);
            if (goagain != true)
            {
                p2turn();
            }
            displaymove();
            checkWin();
        }

        private void btnPocket5_Click(object sender, EventArgs e)
        {
            bool goagain = move(4);
            if (goagain != true)
            {
                p2turn();
            }
            displaymove();
            checkWin();
        }

        private void btnPocket6_Click(object sender, EventArgs e)
        {
            bool goagain = move(5);
            if (goagain != true)
            {
                p2turn();
            }
            displaymove();
            checkWin();
        }

        private void btnPocket8_Click(object sender, EventArgs e)
        {
            bool goagain = move(7);
            if (goagain != true)
            {
                p1turn();
            }
            displaymove();
            checkWin();
        }

        private void btnPocket9_Click(object sender, EventArgs e)
        {
            bool goagain = move(8);
            if (goagain != true)
            {
                p1turn();
            }
            displaymove();
            checkWin();
        }

        private void btnPocket10_Click(object sender, EventArgs e)
        {
            bool goagain = move(9);
            if (goagain != true)
            {
                p1turn();
            }
            displaymove();
            checkWin();
        }

        private void btnPocket11_Click(object sender, EventArgs e)
        {
            bool goagain = move(10);
            if (goagain != true)
            {
                p1turn();
            }
            displaymove();
            checkWin();
        }

        private void btnPocket12_Click(object sender, EventArgs e)
        {
            bool goagain = move(11);
            if (goagain != true)
            {
                p1turn();
            }
            displaymove();
            checkWin();
        }

        private void btnPocket13_Click(object sender, EventArgs e)
        {
            bool goagain = move(12);
            if (goagain != true)
            {
                p1turn();
            }
            displaymove();
            checkWin();
        }
    }
}
