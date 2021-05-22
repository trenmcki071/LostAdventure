using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;


namespace LostAdventure
{
    public partial class Form1 : Form
    {
        // Tracks what page of the story the user is at
        int page = 1;
        Random rnd = new Random();
        SoundPlayer musicPlayer;
        int randomNumber;
        int randomNumberModifyier = 0;
        public Form1()
        {
            InitializeComponent();

            // Display initial message and options
            DisplayPage();
        }

        private void option1Button_Click(object sender, EventArgs e)
        {
            /// Check what page we are currently on, and then flip
            /// to the page you need to go to if you selected option 1
            
            if (page == 1) 
            {
                page = 2;
            }
            else if (page == 2) { page = 1; }
            else if (page == 3) { page = 6; }
            else if (page == 4) { page = 2; }
            else if (page == 5) { page = 2; }
            else if (page == 6) { page = 8; }
            else if (page == 7) { page = 10; }
            else if (page == 8) { page = 1; }
            else if (page == 9) { page = 1; }
            else if (page == 10) { page = 1; }
            else if (page == 11) { page = 1; }


            /// Display text and game options to screen based on the 
            /// current page
            DisplayPage();
            
        }

        private void option2Button_Click(object sender, EventArgs e)
        {
            ///check what page we are currently on, and then flip
            ///to the page you need to go to if you selected option 2
            if (page == 1)
            {
                page = 3;
            }
            else if (page == 2) { page = 99; }
            else if (page == 3) { page = 7; }
            else if (page == 4) { page = 3; }
            else if (page == 5) { page = 3; }
            else if (page == 6) { page = 9; }
            else if (page == 7) { page = 11; }
            else if (page == 8) { page = 99; }
            else if (page == 9) { page = 99; }
            else if (page == 10) { page = 99; }
            else if (page == 11) { page = 99; }

            DisplayPage();
        }
        

        public void DisplayPage()
        {
            switch (page)
            {
                case 1:
                   musicPlayer = new SoundPlayer(Properties.Resources._567252__iwanplays__grab_gravel_2);
                   musicPlayer.Play();

                    imageBox.Image = Properties.Resources.Hole;
                    option3Button.Visible = true;
                    option3Label.Visible = true;
                    outputLabel.Text = "You Have Fallen Down A Hole.";
                    option1Label.Text = "Climb out";
                    option2Label.Text = "Explore the cave";
                    option3Label.Text = "Wait";

                    randomNumber = rnd.Next(1, 101);
                    break;
                case 2:
                   // musicPlayer = new SoundPlayer(Properties.Resources.);
                  //  musicPlayer.Play();

                    imageBox.Image = Properties.Resources.Sky;

                    outputLabel.Text = "You climbed out of the hole, it wasn't a very big hole anyway. Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    option3Button.Visible = false;
                    option3Label.Visible = false;
                    break;
                case 3:
                    imageBox.Image = Properties.Resources.Fork;
                    option3Button.Visible = false;
                    option3Label.Visible = false;
                    outputLabel.Text = "You come across a fork in the path";
                    option1Label.Text = "Go left";
                    option2Label.Text = "Go right";
                    break;
                case 4:
                    outputLabel.Text = "You waited...";
                    break;
                case 5:
                    outputLabel.Text = "You kept waiting...";
                    break;
                case 6:
                    imageBox.Image = Properties.Resources.Chicken;
                    outputLabel.Text = "You see a raw chicken on the ground";
                    option1Label.Text = "Eat it";
                    option2Label.Text = "Don't Eat it";
                    break;
                case 7:
                    imageBox.Image = Properties.Resources.Wolf;
                    outputLabel.Text = "You notice that there is a wolf at the end of a hallway";
                    option1Label.Text = "Say Hello";
                    option2Label.Text = "Run and punch it";
                    break;
                case 8:
                    imageBox.Image = Properties.Resources.Posion;
                    outputLabel.Text = "You die from food poisoning, its a raw chicken. Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 9:
                    imageBox.Image = Properties.Resources.Starve;
                    outputLabel.Text = "You starve to death from not eating the chicken. Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 10:
                    outputLabel.Text = "The wolf looks at you and says, 'I am impressed you recognized me as a talking wolf, in fact, I shall lead you out of this cave!' Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 11:
                    imageBox.Image = Properties.Resources.Pit;
                    outputLabel.Text = "The wolf was on the other side of a pit trap, you fell and died. Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 99:
                    outputLabel.Text = "Thank you for playing";
                    option1Label.Text = "";
                    option2Label.Text = "";

                    Refresh();
                    Thread.Sleep(2000);
                    Application.Exit();
                    break;
                default:
                    break;
            }
        }

        private void option3Button_Click(object sender, EventArgs e)
        {
                if (randomNumber + randomNumberModifyier > 75)
                {
                option3Label.Visible = false;
                option3Button.Visible = false;
                    page = 7;
                }
                else
                {
                randomNumberModifyier = randomNumberModifyier + 15;
                if (page == 4) { page = 5; }
                else { page = 4; }
                }
            DisplayPage();
        }
    }
}
