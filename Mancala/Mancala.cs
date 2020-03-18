﻿/*
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
            pocketButtons[0] = btnPocket13;
            pocketButtons[1] = btnPocket12;
            pocketButtons[2] = btnPocket11;
            pocketButtons[3] = btnPocket10;
            pocketButtons[4] = btnPocket9;
            pocketButtons[5] = btnPocket8;
            pocketButtons[6] = btnStorePocket14;
            pocketButtons[7] = btnPocket6;
            pocketButtons[8] = btnPocket5;
            pocketButtons[9] = btnPocket4;
            pocketButtons[10] = btnPocket3;
            pocketButtons[11] = btnPocket2;
            pocketButtons[12] = btnPocket1;
            pocketButtons[13] = btnStorePocket7;
        }

        private void btnPocket1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
