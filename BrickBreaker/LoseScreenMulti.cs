using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BrickBreaker.Screens;
//multiplayer lose screen by Daniel C
namespace BrickBreaker
{
    public partial class LoseScreenMulti : UserControl
    {
        Boolean leftArrowDown, downArrowDown, rightArrowDown, upArrowDown, spaceDown, vDown, bDown, nDown;

        int selected, lastSelected;

        public LoseScreenMulti()
        {
            InitializeComponent();
            onStart();
        }

        public void onStart()
        {
            if (GameScreenMulti.player1Won)
            {
                winnerLabel.Text = "Player 1 wins";
            }
            if (GameScreenMulti.player2Won)
            {
                winnerLabel.Text = "Player 2 wins";
            }
        }

        private void LoseScreenMulti_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            lastSelected = selected;

            switch (e.KeyCode)
            {
                case Keys.Left:
                    leftArrowDown = true;
                    break;
                case Keys.Down:
                    downArrowDown = true;
                    break;
                case Keys.Right:
                    rightArrowDown = true;
                    break;
                case Keys.Up:
                    upArrowDown = true;
                    break;
                case Keys.Space:
                    spaceDown = true;
                    break;
                case Keys.V:
                    vDown = true;
                    break;
                case Keys.B:
                    bDown = true;
                    break;
                case Keys.N:
                    nDown = true;
                    break;
                default:
                    break;
            }

            if (rightArrowDown == true)
            {
                if (selected == 2)
                {
                    selected = 1;
                }
                else
                {
                    selected++;
                }
            }

            if (leftArrowDown == true)
            {
                if (selected == 1)
                {
                    selected = 2;
                }
                else
                {
                    selected--;
                }
            }

            switch (selected)
            {
                case 1:
                    playAgainLabel.ForeColor = Color.White;
                    returnToMenuLabel.ForeColor = Color.Red;

                    if (spaceDown == true)
                    {
                        // Goes to the game screen
                        Form form = this.FindForm();
                        GameScreenMulti gsm = new GameScreenMulti();

                        gsm.Location = new Point((form.Width - gsm.Width) / 2, (form.Height - gsm.Height) / 2);

                        form.Controls.Add(gsm);
                        form.Controls.Remove(this);
                    }
                    break;

                case 2:
                    returnToMenuLabel.ForeColor = Color.White;
                    playAgainLabel.ForeColor = Color.Red;

                    if (spaceDown == true)
                    {
                        // Goes to the main menu screen
                        Form form = this.FindForm();
                        MenuScreen ms = new MenuScreen();

                        ms.Location = new Point((form.Width - ms.Width) / 2, (form.Height - ms.Height) / 2);

                        form.Controls.Add(ms);
                        form.Controls.Remove(this);
                    }
                    break;
            }

        }


        private void LoseScreenMulti_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    leftArrowDown = false;
                    break;
                case Keys.Down:
                    downArrowDown = false;
                    break;
                case Keys.Right:
                    rightArrowDown = false;
                    break;
                case Keys.Up:
                    upArrowDown = false;
                    break;
                case Keys.Space:
                    spaceDown = false;
                    break;
                case Keys.V:
                    vDown = false;
                    break;
                case Keys.B:
                    bDown = false;
                    break;
                case Keys.N:
                    nDown = false;
                    break;
                default:
                    break;
            }
        }
    }
}
