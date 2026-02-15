using MyTic_Tac_ToeGameProject.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyTic_Tac_ToeGameProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        stGameStatuce Gamestatuce;

        enPlayer PlayTurn = enPlayer.Player1; 

        enum enPlayer
        {
            Player1,
            Player2
        }

        enum enWinner
        {
            Player1,
            Player2,
            Inprogress,
            Draw
        }

        struct stGameStatuce
        {
          public  enWinner Winner;

            public bool GameOver;

            public short PlayCount; 
        }

        void EndGame()
        {
            switch(Gamestatuce.Winner)
            {
                case enWinner.Player1:
                    lblTurn.Text = "Player1";
                    break;

                case enWinner.Player2:
                    lblTurn.Text = "Player2";
                    break;

                default:
                    lblTurn.Text = "Draw";
                    break; 
            }

            MessageBox.Show("Game Over", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information); 
        }

       public bool CheckValues(Button btn1 , Button btn2 , Button btn3)
        {
            if(btn1.Tag.ToString() != "?" && btn1.Tag.ToString() == btn2.Tag.ToString() && btn1.Tag.ToString() == btn3.Tag.ToString())
            {
                btn1.BackColor = Color.GreenYellow;
                btn2.BackColor = Color.GreenYellow;
                btn3.BackColor = Color.GreenYellow; 

                if(btn1.Tag.ToString() == "X")
                {
                    Gamestatuce.Winner = enWinner.Player1;

                    Gamestatuce.GameOver = true;

                    lblinprogress.Text = "Player1"; 

                    EndGame();

                    return true; 

                }
                else
                {
                    Gamestatuce.Winner = enWinner.Player2;
                    Gamestatuce.GameOver = true;
                    lblinprogress.Text = "Player2";
                    EndGame();
                    return true; 
                }
            }

            Gamestatuce.GameOver = false;
            return false;
        }

        public void CheckWinner()
        {
            if(CheckValues(button10, button2, button3))
            {
                return; 
            }

            if (CheckValues(button4, button5, button6))
            {
                return;
            }

            if (CheckValues(button7, button8, button9))
            {
                return;
            }

            if (CheckValues(button10, button4, button7))
            {
                return;
            }

            if (CheckValues(button2, button5, button8))
            {
                return;
            }

            if (CheckValues(button3, button6, button9))
            {
                return;
            }

            if (CheckValues(button3, button5, button7))
            {
                return;
            }

            if (CheckValues(button10, button5, button9))
            {
                return;
            }


        }

        public void ChangeImage(Button btn)
        {
            if (string.Equals(btn.Tag as string, "?", StringComparison.Ordinal))
            {
                switch(PlayTurn)
                {
                    case enPlayer.Player1:
                        btn.Image = Resources.X;
                        PlayTurn = enPlayer.Player2;
                        lblTurn.Text = "Player2";
                        Gamestatuce.PlayCount++;
                        btn.Tag = "X";
                        CheckWinner();
                        break;

                    case enPlayer.Player2:
                        btn.Image = Resources.O;
                        PlayTurn = enPlayer.Player1;
                        lblTurn.Text = "Player1";
                        Gamestatuce.PlayCount++;
                        btn.Tag = "O";
                        CheckWinner();
                        break; 
                }
            }
            else
            {
                MessageBox.Show("Wrong choice", "wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if(Gamestatuce.PlayCount == 9 && !Gamestatuce.GameOver)
            {
                Gamestatuce.GameOver = true;

                Gamestatuce.Winner = enWinner.Draw;

                EndGame(); 
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Color White = Color.FromArgb(255, 255, 255, 255);

            Pen WhitePen = new Pen(White);

            WhitePen.Width = 15;

            WhitePen.StartCap = System.Drawing.Drawing2D.LineCap.Round;

            WhitePen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            e.Graphics.DrawLine(WhitePen, 400, 300, 1050, 300);

            e.Graphics.DrawLine(WhitePen, 400, 460, 1050, 460);

            e.Graphics.DrawLine(WhitePen, 610, 140, 610, 620);

            e.Graphics.DrawLine(WhitePen, 840, 140, 840, 620);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var boxes = new[] { button10, button2, button3, button4, button5, button6, button7, button8, button9 };
            foreach (var b in boxes)
            {
                b.Tag = "?";
                b.Image = Properties.Resources.question_mark_96;
            }
        }
        private void button_Click(object sender, EventArgs e)
        {
            ChangeImage((Button) sender);
        }
       

        private void ResetButton(Button btn)
        {
            btn.Image = Resources.question_mark_96;
            btn.Tag = "?";
            btn.BackColor = Color.Transparent;

            PlayTurn = enPlayer.Player1;
            lblTurn.Text = "Player1";
            Gamestatuce.PlayCount = 0;
            Gamestatuce.GameOver = false;
            Gamestatuce.Winner = enWinner.Inprogress; 
            lblinprogress.Text = "In progress"; 
        }

        private void RestartGame()
        {
            ResetButton(button10);

            ResetButton(button2);

            ResetButton(button3);

            ResetButton(button4);

            ResetButton(button5);

            ResetButton(button6);

            ResetButton(button7);

            ResetButton(button8);

            ResetButton(button9);
        }

        private void btnRestartGame_Click(object sender, EventArgs e)
        {
            RestartGame();
        }
    }
}
