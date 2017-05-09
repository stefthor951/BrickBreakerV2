
//Copy of brick breaker game
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BrickBreaker.Screens;
using System.Xml;
using System.Media;
using SuperSnakeGame;
using BrickBreaker;

/// <summary>
///  Long paddle 
///  More balls
///  Backup floor
///  additional life
///  double point
///  isMagnet
/// strongball
/// another comment   
/// another comment again
/// </summary>
namespace BrickBreaker
{
    public partial class Form1 : Form
    {
        // add a global value here

        //sound library       
        public static SoundPlayer appearPlayer = new SoundPlayer(Properties.Resources.Alert_Appear);
        public static SoundPlayer disappearPlayer = new SoundPlayer(Properties.Resources.Alert_Dissappear);
        public static SoundPlayer errorPlayer = new SoundPlayer(Properties.Resources.Alert_Error);
        public static SoundPlayer back_A_Player = new SoundPlayer(Properties.Resources.Back_A);
        public static SoundPlayer select_A_Player = new SoundPlayer(Properties.Resources.Select_A);
        public static SoundPlayer back_B_Player = new SoundPlayer(Properties.Resources.Back_B);
        public static SoundPlayer select_B_Player = new SoundPlayer(Properties.Resources.Select_B);
        public static SoundPlayer brickPlayer = new SoundPlayer(Properties.Resources.brickBounce);
        public static SoundPlayer paddlePlayer = new SoundPlayer(Properties.Resources.paddleBounce);
        public static SoundPlayer wallPlayer = new SoundPlayer(Properties.Resources.wallBounce);
        public static SoundPlayer pickPlayer = new SoundPlayer(Properties.Resources.Pick);
        
        //public static SoundPlayer player = new SoundPlayer(Properties.)

        public static List<Highscore> highscoreList = new List<Highscore>();
        public static int currentScore;
        // add a new comment
        
        //test comment

        public Form1()
        {
            InitializeComponent();
            SoundPlayer appearPlayer = new SoundPlayer(Properties.Resources.Alert_Appear);
    }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Start the program centred on the Menu Screen
            MenuScreen ps = new MenuScreen();
            this.Controls.Add(ps);
            
            ps.Location = new Point((this.Width - ps.Width) / 2, (this.Height - ps.Height) /2);
            //loadHighscores();
        }

        private void loadHighscores() //method for loading any saved highscores in the highscoreDB xml file
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("highscoreDB.xml");

            XmlNode parent;
            parent = doc.DocumentElement;
            foreach (XmlNode child in parent.ChildNodes)
            {
                Highscore hs = new Highscore(null, null);
                foreach (XmlNode grandChild in child.ChildNodes)
                {
                    if (grandChild.Name == "name")
                    {
                        hs.name = grandChild.InnerText;
                    }
                    if (grandChild.Name == "score")
                    {
                        hs.score = grandChild.InnerText;
                        //scores.Add(Convert.ToInt16(child.InnerText));
                    }
                }
                highscoreList.Add(hs);
            }
        }
    }
}
