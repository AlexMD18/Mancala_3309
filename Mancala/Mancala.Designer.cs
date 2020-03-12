﻿namespace Mancala
{
    partial class Mancala
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblPlayerOneName = new System.Windows.Forms.Label();
            this.txtPlayerOneName = new System.Windows.Forms.TextBox();
            this.lblPlayerTwoName = new System.Windows.Forms.Label();
            this.txtPlayerTwoName = new System.Windows.Forms.TextBox();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblPlayer1 = new System.Windows.Forms.Label();
            this.txtBoardPlayer1Name = new System.Windows.Forms.TextBox();
            this.pnlBoard = new System.Windows.Forms.Panel();
            this.btnStorePocket2 = new System.Windows.Forms.Button();
            this.btnStorePocket1 = new System.Windows.Forms.Button();
            this.btnPocket12 = new System.Windows.Forms.Button();
            this.btnPocket11 = new System.Windows.Forms.Button();
            this.btnPocket10 = new System.Windows.Forms.Button();
            this.btnPocket9 = new System.Windows.Forms.Button();
            this.btnPocket8 = new System.Windows.Forms.Button();
            this.btnPocket7 = new System.Windows.Forms.Button();
            this.btnPocket6 = new System.Windows.Forms.Button();
            this.btnPocket5 = new System.Windows.Forms.Button();
            this.btnPocket4 = new System.Windows.Forms.Button();
            this.btnPocket3 = new System.Windows.Forms.Button();
            this.btnPocket2 = new System.Windows.Forms.Button();
            this.btnPocket1 = new System.Windows.Forms.Button();
            this.txtBoardPlayer2Name = new System.Windows.Forms.TextBox();
            this.pnlBoard.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Algerian", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(295, 25);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(702, 66);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome To Mancala!";
            // 
            // lblPlayerOneName
            // 
            this.lblPlayerOneName.AutoSize = true;
            this.lblPlayerOneName.Font = new System.Drawing.Font("Elephant", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerOneName.Location = new System.Drawing.Point(96, 132);
            this.lblPlayerOneName.Name = "lblPlayerOneName";
            this.lblPlayerOneName.Size = new System.Drawing.Size(278, 37);
            this.lblPlayerOneName.TabIndex = 1;
            this.lblPlayerOneName.Text = "Player One Name: ";
            // 
            // txtPlayerOneName
            // 
            this.txtPlayerOneName.Font = new System.Drawing.Font("Elephant", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlayerOneName.Location = new System.Drawing.Point(371, 131);
            this.txtPlayerOneName.Name = "txtPlayerOneName";
            this.txtPlayerOneName.Size = new System.Drawing.Size(219, 37);
            this.txtPlayerOneName.TabIndex = 2;
            //this.txtPlayerOneName.TextChanged += new System.EventHandler(this.txtPlayerOneName_TextChanged);
            // 
            // lblPlayerTwoName
            // 
            this.lblPlayerTwoName.AutoSize = true;
            this.lblPlayerTwoName.Font = new System.Drawing.Font("Elephant", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerTwoName.Location = new System.Drawing.Point(646, 132);
            this.lblPlayerTwoName.Name = "lblPlayerTwoName";
            this.lblPlayerTwoName.Size = new System.Drawing.Size(274, 37);
            this.lblPlayerTwoName.TabIndex = 3;
            this.lblPlayerTwoName.Text = "Player Two Name:";
            // 
            // txtPlayerTwoName
            // 
            this.txtPlayerTwoName.Font = new System.Drawing.Font("Elephant", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlayerTwoName.Location = new System.Drawing.Point(917, 131);
            this.txtPlayerTwoName.Name = "txtPlayerTwoName";
            this.txtPlayerTwoName.Size = new System.Drawing.Size(219, 37);
            this.txtPlayerTwoName.TabIndex = 4;
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.Chartreuse;
            this.btnPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlay.Font = new System.Drawing.Font("Algerian", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.Location = new System.Drawing.Point(529, 187);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(206, 50);
            this.btnPlay.TabIndex = 6;
            this.btnPlay.Text = "Play!";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Font = new System.Drawing.Font("Algerian", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(529, 740);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(164, 55);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblPlayer1
            // 
            this.lblPlayer1.AutoSize = true;
            this.lblPlayer1.Location = new System.Drawing.Point(44, 272);
            this.lblPlayer1.Name = "lblPlayer1";
            this.lblPlayer1.Size = new System.Drawing.Size(0, 17);
            this.lblPlayer1.TabIndex = 8;
            // 
            // txtBoardPlayer1Name
            // 
            this.txtBoardPlayer1Name.BackColor = System.Drawing.Color.DimGray;
            this.txtBoardPlayer1Name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoardPlayer1Name.Font = new System.Drawing.Font("Elephant", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoardPlayer1Name.ForeColor = System.Drawing.SystemColors.Window;
            this.txtBoardPlayer1Name.Location = new System.Drawing.Point(12, 266);
            this.txtBoardPlayer1Name.Name = "txtBoardPlayer1Name";
            this.txtBoardPlayer1Name.Size = new System.Drawing.Size(148, 35);
            this.txtBoardPlayer1Name.TabIndex = 9;
            this.txtBoardPlayer1Name.Visible = false;
            //this.txtBoardPlayer1Name.TextChanged += new System.EventHandler(this.txtBoardPlayer1Name_TextChanged);
            // 
            // pnlBoard
            // 
            this.pnlBoard.BackgroundImage = global::Mancala.Properties.Resources.mancalaBoard;
            this.pnlBoard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlBoard.Controls.Add(this.btnStorePocket2);
            this.pnlBoard.Controls.Add(this.btnStorePocket1);
            this.pnlBoard.Controls.Add(this.btnPocket12);
            this.pnlBoard.Controls.Add(this.btnPocket11);
            this.pnlBoard.Controls.Add(this.btnPocket10);
            this.pnlBoard.Controls.Add(this.btnPocket9);
            this.pnlBoard.Controls.Add(this.btnPocket8);
            this.pnlBoard.Controls.Add(this.btnPocket7);
            this.pnlBoard.Controls.Add(this.btnPocket6);
            this.pnlBoard.Controls.Add(this.btnPocket5);
            this.pnlBoard.Controls.Add(this.btnPocket4);
            this.pnlBoard.Controls.Add(this.btnPocket3);
            this.pnlBoard.Controls.Add(this.btnPocket2);
            this.pnlBoard.Controls.Add(this.btnPocket1);
            this.pnlBoard.Location = new System.Drawing.Point(12, 307);
            this.pnlBoard.Name = "pnlBoard";
            this.pnlBoard.Size = new System.Drawing.Size(1198, 388);
            this.pnlBoard.TabIndex = 5;
            this.pnlBoard.Visible = false;
            // 
            // btnStorePocket2
            // 
            this.btnStorePocket2.BackgroundImage = global::Mancala.Properties.Resources.StorePocket;
            this.btnStorePocket2.Location = new System.Drawing.Point(1052, 28);
            this.btnStorePocket2.Name = "btnStorePocket2";
            this.btnStorePocket2.Size = new System.Drawing.Size(123, 334);
            this.btnStorePocket2.TabIndex = 13;
            this.btnStorePocket2.UseVisualStyleBackColor = true;
            // 
            // btnStorePocket1
            // 
            this.btnStorePocket1.BackgroundImage = global::Mancala.Properties.Resources.StorePocket;
            this.btnStorePocket1.Location = new System.Drawing.Point(25, 28);
            this.btnStorePocket1.Name = "btnStorePocket1";
            this.btnStorePocket1.Size = new System.Drawing.Size(123, 334);
            this.btnStorePocket1.TabIndex = 12;
            this.btnStorePocket1.UseVisualStyleBackColor = true;
            // 
            // btnPocket12
            // 
            this.btnPocket12.BackColor = System.Drawing.Color.Black;
            this.btnPocket12.BackgroundImage = global::Mancala.Properties.Resources.Button;
            this.btnPocket12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPocket12.Location = new System.Drawing.Point(154, 229);
            this.btnPocket12.Name = "btnPocket12";
            this.btnPocket12.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnPocket12.Size = new System.Drawing.Size(132, 133);
            this.btnPocket12.TabIndex = 11;
            this.btnPocket12.UseVisualStyleBackColor = false;
            // 
            // btnPocket11
            // 
            this.btnPocket11.BackColor = System.Drawing.Color.Black;
            this.btnPocket11.BackgroundImage = global::Mancala.Properties.Resources.Button;
            this.btnPocket11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPocket11.Location = new System.Drawing.Point(294, 229);
            this.btnPocket11.Name = "btnPocket11";
            this.btnPocket11.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnPocket11.Size = new System.Drawing.Size(132, 133);
            this.btnPocket11.TabIndex = 10;
            this.btnPocket11.UseVisualStyleBackColor = false;
            // 
            // btnPocket10
            // 
            this.btnPocket10.BackColor = System.Drawing.Color.Black;
            this.btnPocket10.BackgroundImage = global::Mancala.Properties.Resources.Button;
            this.btnPocket10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPocket10.Location = new System.Drawing.Point(430, 229);
            this.btnPocket10.Name = "btnPocket10";
            this.btnPocket10.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnPocket10.Size = new System.Drawing.Size(132, 133);
            this.btnPocket10.TabIndex = 9;
            this.btnPocket10.UseVisualStyleBackColor = false;
            // 
            // btnPocket9
            // 
            this.btnPocket9.BackColor = System.Drawing.Color.Black;
            this.btnPocket9.BackgroundImage = global::Mancala.Properties.Resources.Button;
            this.btnPocket9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPocket9.Location = new System.Drawing.Point(638, 229);
            this.btnPocket9.Name = "btnPocket9";
            this.btnPocket9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnPocket9.Size = new System.Drawing.Size(132, 133);
            this.btnPocket9.TabIndex = 8;
            this.btnPocket9.UseVisualStyleBackColor = false;
            // 
            // btnPocket8
            // 
            this.btnPocket8.BackColor = System.Drawing.Color.Black;
            this.btnPocket8.BackgroundImage = global::Mancala.Properties.Resources.Button;
            this.btnPocket8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPocket8.Location = new System.Drawing.Point(776, 229);
            this.btnPocket8.Name = "btnPocket8";
            this.btnPocket8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnPocket8.Size = new System.Drawing.Size(132, 133);
            this.btnPocket8.TabIndex = 7;
            this.btnPocket8.UseVisualStyleBackColor = false;
            // 
            // btnPocket7
            // 
            this.btnPocket7.BackColor = System.Drawing.Color.Black;
            this.btnPocket7.BackgroundImage = global::Mancala.Properties.Resources.Button;
            this.btnPocket7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPocket7.Location = new System.Drawing.Point(914, 229);
            this.btnPocket7.Name = "btnPocket7";
            this.btnPocket7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnPocket7.Size = new System.Drawing.Size(132, 133);
            this.btnPocket7.TabIndex = 6;
            this.btnPocket7.UseVisualStyleBackColor = false;
            // 
            // btnPocket6
            // 
            this.btnPocket6.BackColor = System.Drawing.Color.Black;
            this.btnPocket6.BackgroundImage = global::Mancala.Properties.Resources.Button;
            this.btnPocket6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPocket6.Location = new System.Drawing.Point(914, 28);
            this.btnPocket6.Name = "btnPocket6";
            this.btnPocket6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnPocket6.Size = new System.Drawing.Size(132, 133);
            this.btnPocket6.TabIndex = 5;
            this.btnPocket6.UseVisualStyleBackColor = false;
            // 
            // btnPocket5
            // 
            this.btnPocket5.BackColor = System.Drawing.Color.Black;
            this.btnPocket5.BackgroundImage = global::Mancala.Properties.Resources.Button;
            this.btnPocket5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPocket5.Location = new System.Drawing.Point(776, 28);
            this.btnPocket5.Name = "btnPocket5";
            this.btnPocket5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnPocket5.Size = new System.Drawing.Size(132, 133);
            this.btnPocket5.TabIndex = 4;
            this.btnPocket5.UseVisualStyleBackColor = false;
            // 
            // btnPocket4
            // 
            this.btnPocket4.BackColor = System.Drawing.Color.Black;
            this.btnPocket4.BackgroundImage = global::Mancala.Properties.Resources.Button;
            this.btnPocket4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPocket4.Location = new System.Drawing.Point(641, 28);
            this.btnPocket4.Name = "btnPocket4";
            this.btnPocket4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnPocket4.Size = new System.Drawing.Size(132, 133);
            this.btnPocket4.TabIndex = 3;
            this.btnPocket4.UseVisualStyleBackColor = false;
            // 
            // btnPocket3
            // 
            this.btnPocket3.BackColor = System.Drawing.Color.Black;
            this.btnPocket3.BackgroundImage = global::Mancala.Properties.Resources.Button;
            this.btnPocket3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPocket3.Location = new System.Drawing.Point(430, 28);
            this.btnPocket3.Name = "btnPocket3";
            this.btnPocket3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnPocket3.Size = new System.Drawing.Size(132, 133);
            this.btnPocket3.TabIndex = 2;
            this.btnPocket3.UseVisualStyleBackColor = false;
            // 
            // btnPocket2
            // 
            this.btnPocket2.BackColor = System.Drawing.Color.Black;
            this.btnPocket2.BackgroundImage = global::Mancala.Properties.Resources.Button;
            this.btnPocket2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPocket2.Location = new System.Drawing.Point(292, 28);
            this.btnPocket2.Name = "btnPocket2";
            this.btnPocket2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnPocket2.Size = new System.Drawing.Size(132, 133);
            this.btnPocket2.TabIndex = 1;
            this.btnPocket2.UseVisualStyleBackColor = false;
            // 
            // btnPocket1
            // 
            this.btnPocket1.BackColor = System.Drawing.Color.Black;
            this.btnPocket1.BackgroundImage = global::Mancala.Properties.Resources.Button;
            this.btnPocket1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPocket1.Location = new System.Drawing.Point(154, 28);
            this.btnPocket1.Name = "btnPocket1";
            this.btnPocket1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnPocket1.Size = new System.Drawing.Size(132, 133);
            this.btnPocket1.TabIndex = 0;
            this.btnPocket1.UseVisualStyleBackColor = false;
            // 
            // txtBoardPlayer2Name
            // 
            this.txtBoardPlayer2Name.BackColor = System.Drawing.Color.DimGray;
            this.txtBoardPlayer2Name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoardPlayer2Name.Font = new System.Drawing.Font("Elephant", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoardPlayer2Name.ForeColor = System.Drawing.SystemColors.Window;
            this.txtBoardPlayer2Name.Location = new System.Drawing.Point(1062, 266);
            this.txtBoardPlayer2Name.Name = "txtBoardPlayer2Name";
            this.txtBoardPlayer2Name.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtBoardPlayer2Name.Size = new System.Drawing.Size(148, 35);
            this.txtBoardPlayer2Name.TabIndex = 10;
            this.txtBoardPlayer2Name.Visible = false;
            // 
            // Mancala
            // 
            this.AcceptButton = this.btnPlay;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(1241, 807);
            this.Controls.Add(this.txtBoardPlayer2Name);
            this.Controls.Add(this.txtBoardPlayer1Name);
            this.Controls.Add(this.lblPlayer1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.pnlBoard);
            this.Controls.Add(this.txtPlayerTwoName);
            this.Controls.Add(this.lblPlayerTwoName);
            this.Controls.Add(this.txtPlayerOneName);
            this.Controls.Add(this.lblPlayerOneName);
            this.Controls.Add(this.lblWelcome);
            this.Name = "Mancala";
            this.Text = "Mancala";
            //this.Load += new System.EventHandler(this.Mancala_Load_1);
            this.pnlBoard.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblPlayerOneName;
        private System.Windows.Forms.TextBox txtPlayerOneName;
        private System.Windows.Forms.Label lblPlayerTwoName;
        private System.Windows.Forms.TextBox txtPlayerTwoName;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Panel pnlBoard;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnPocket1;
        private System.Windows.Forms.Button btnPocket3;
        private System.Windows.Forms.Button btnPocket2;
        private System.Windows.Forms.Button btnPocket12;
        private System.Windows.Forms.Button btnPocket11;
        private System.Windows.Forms.Button btnPocket10;
        private System.Windows.Forms.Button btnPocket9;
        private System.Windows.Forms.Button btnPocket8;
        private System.Windows.Forms.Button btnPocket7;
        private System.Windows.Forms.Button btnPocket6;
        private System.Windows.Forms.Button btnPocket5;
        private System.Windows.Forms.Button btnPocket4;
        private System.Windows.Forms.Button btnStorePocket2;
        private System.Windows.Forms.Button btnStorePocket1;
        private System.Windows.Forms.Label lblPlayer1;
        private System.Windows.Forms.TextBox txtBoardPlayer1Name;
        private System.Windows.Forms.TextBox txtBoardPlayer2Name;
    }
}

