using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BrickBreaker; 

namespace BrickBreaker
{
    public partial class OptionScreen : UserControl
    {
        public static int difficulty = 0;
        
        public OptionScreen()
        {
            InitializeComponent();
        }

        private void easyButton_Click(object sender, EventArgs e)
        {
            difficultyLabel.Text = " -5 lives \n\n -Slower ball speed \n\n -faster paddle speed ";
            easyButton.BackColor = Color.Yellow;
            mediumButton.BackColor = Color.White;
            hardButton.BackColor = Color.White;
            impossibleButton.BackColor = Color.White;
            difficulty = 1;
        }

        private void mediumButton_Click(object sender, EventArgs e)
        {
            difficultyLabel.Text = " -3 lives \n\n -Medium ball speed \n\n -medium paddle speed";
            
            mediumButton.BackColor = Color.Orange;
            easyButton.BackColor = Color.White;
            hardButton.BackColor = Color.White;
            impossibleButton.BackColor = Color.White;
            difficulty = 2;
            
        }

        private void hardButton_Click(object sender, EventArgs e)
        {
         
            difficultyLabel.Text = " -2 life \n\n -fast ball speed \n\n -slow paddle speed";
            hardButton.BackColor = Color.Red;
            easyButton.BackColor = Color.White;
            mediumButton.BackColor = Color.White;
            impossibleButton.BackColor = Color.White;
            difficulty = 3;
        }

        private void impossibleButton_Click(object sender, EventArgs e)
        {
            difficultyLabel.Text = " -1 life \n\n -fastest ball speed \n\n -slowest paddle speed";
            impossibleButton.BackColor = Color.Purple;
            easyButton.BackColor = Color.White;
            mediumButton.BackColor = Color.White;
            hardButton.BackColor = Color.White;
            
            difficulty = 4;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            BrickBreaker.Screens.MenuScreen ms = new BrickBreaker.Screens.MenuScreen();
            f.Controls.Add(ms);
        }
        public static void Easy()
        {
            Form1.lives = 5;
            Form1.paddleSpeed = 12;
            Form1.xSpeed = 4;
            Form1.ySpeed = 4;
        }
        public static void Medium()
        {
            Form1.lives = 3;
            Form1.paddleSpeed = 8;
            Form1.xSpeed = 6;
            Form1.ySpeed = 6;
        }
        public static void Hard()
        {
            Form1.lives = 2;
            Form1.paddleSpeed = 6;
            Form1.xSpeed = 8;
            Form1.ySpeed = 8;
        }
        public static void Impossible()
        {
            Form1.lives = 1;
            Form1.paddleSpeed = 4;
            Form1.xSpeed = 10;
            Form1.ySpeed = 10;
        }


        private void acceptButton_Click(object sender, EventArgs e)
        {   
            switch (difficulty)
            {
                case 0:
                    break;
                case 1:
                    Easy();
                    break;
                case 2:
                    Medium();
                    break;
                case 3:
                    Hard();
                    break;
                case 4:
                    Impossible();
                    break;
            }

            Form f = this.FindForm();
            f.Controls.Remove(this);

            BrickBreaker.Screens.MenuScreen ms = new BrickBreaker.Screens.MenuScreen();
            f.Controls.Add(ms);
        }

        
    }
}