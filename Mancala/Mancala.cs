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
        private Button[] pocketButtons = new Button[11];


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
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
