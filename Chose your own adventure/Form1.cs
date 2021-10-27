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

namespace Chose_your_own_adventure
{
    public partial class Form1 : Form
    {
        // The page of the story the user is currently at
        int page = 1;
        int snake = 0;
        int luggage = 0;
        int randomNumber = 0;
        Random randGen = new Random();
        public Form1()
        {

            InitializeComponent();
            //picks random number when program starts
            randomNumber = randGen.Next(1, 11);
            outputLabel.Text = $"your tour gide announces that you will be going on a jungle adventure, you only have 10 minutes to pack. do you take an axe, food or machete";
            optionOneLabel.Text = $"Axe";
            optionTwoLabel.Text = $"Food";
            optionThreeLabel.Text = $"Machete";
            pictureBox1.BackgroundImage = Properties.Resources.Axe;
            pictureBox2.BackgroundImage = Properties.Resources.Food;
            pictureBox3.BackgroundImage = Properties.Resources.Machete;
            this.Size = new Size(792, 424);

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (page == 1)
            {
                //Player gets to chose item of choice
                luggage = 1;
                page = 2;
            }
            //Player choses their path
            else if (page == 2) { page = 3; }
            else if (page == 3) { page = 1; }
            else if (page == 4) { page = 5; }
            else if (page == 5) { page = 6; }
            else if (page == 6) { page = 1; }
            else if (page == 7) { page = 1; }
            else if (page == 8)
            {
                page = 10;
                //using snake as a latter gameplay element
                snake = 1;
            }
            else if (page == 9) { page = 1; }
            else if (page == 10)
            {
                //gameplay element including food
                if (luggage == 2 || snake == 1)
                {
                    page = 12;
                }
                else
                {
                    page = 23;
                }
            }
            else if (page == 11) { page = 1; }
            else if (page == 12) { page = 13; }
            else if (page == 13)
            {
                //decididng if the chimps attack
                if (luggage == 1)
                {
                    page = 15;
                }
                else
                {
                    page = 16;
                }

            }
            //Player choses their path
            else if (page == 14) { page = 1; }
            else if (page == 15) { page = 1; }
            else if (page == 16) { page = 1; }
            else if (page == 17) { page = 13; }
            else if (page == 18) { page = 1; }
            else if (page == 19)
            {
                //if player choses axe then they can with through this path 
                if (luggage == 1)
                {
                    page = 22;
                }
                else
                {
                    page = 21;
                }
            }
            //Player choses their path
            else if (page == 20) { page = 1; }
            else if (page == 21) { page = 1; }
            else if (page == 22) { page = 1; }
            else if (page == 23) { page = 1; }
            DisplayPage();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (page == 1)
            {
                //Player gets to chose item of choice
                luggage = 2;
                page = 2;
            }
            //Player choses their path
            else if (page == 2) { page = 4; }
            else if (page == 3) { page = 99; }
            else if (page == 4)
            {
                //Random encounter 
                if (randomNumber > 3)
                {
                    if (luggage == 1)
                    {
                        page = 17;
                    }
                    else
                    {
                        page = 10;
                    }
                }
                else if (randomNumber <= 3)
                {
                    page = 9;
                }
            }
            else if (page == 5)
            {
                if (luggage == 3)
                {
                    page = 8;
                }
                else
                {
                    page = 7;
                }
            }
            //Player choses their path
            else if (page == 6) { page = 99; }
            else if (page == 7) { page = 99; }
            else if (page == 8) { page = 10; }
            else if (page == 9) { page = 99; }
            else if (page == 10) { page = 11; }
            else if (page == 11) { page = 99; }
            else if (page == 12) { page = 19; }
            else if (page == 13) { page = 14; }
            else if (page == 14) { page = 99; }
            else if (page == 15) { page = 99; }
            else if (page == 16) { page = 99; }
            else if (page == 17) { page = 18; }
            else if (page == 18) { page = 99; }
            else if (page == 19) { page = 20; }
            else if (page == 20) { page = 99; }
            else if (page == 21) { page = 99; }
            else if (page == 22) { page = 99; }
            else if (page == 23) { page = 99; }
            DisplayPage();
        }
        private void optionTheeButton_Click(object sender, EventArgs e)
        {
            if (page == 1)
            {
                //Player gets to chose item of choice
                luggage = 3;
                page = 2;
            }
            DisplayPage();
        }

        public void DisplayPage()
        {
            switch (page)
            {
                case 1:
                    outputLabel.Text = $"your tour gide announces that you will be going on a jungle adventure, you only have 10 minutes to pack. do you take an axe, food or machete";
                    optionOneLabel.Text = $"Axe";
                    optionTwoLabel.Text = $"Food";
                    optionThreeLabel.Text = $"Machete";
                    this.Size = new Size(792, 424);
                    pictureBox1.BackgroundImage = Properties.Resources.Axe;
                    pictureBox2.BackgroundImage = Properties.Resources.Food;
                    pictureBox3.BackgroundImage = Properties.Resources.Machete; 
                    break;
                case 2:
                    outputLabel.Text = $"You enter the jungle with an exited feeling, after a while you come across a river. your guide falls in do you save them ? ";
                    optionOneLabel.Text = $"Yes";
                    optionTwoLabel.Text = $"No";
                    this.Size = new Size(536, 424);
                    pictureBox1.BackgroundImage = Properties.Resources.Life_Jacket;
                    pictureBox2.BackgroundImage = Properties.Resources.River;
                    pictureBox3.BackgroundImage = Properties.Resources.Machete;
                    break;
                case 3:
                    outputLabel.Text = $"You slip well trying to save them and drown... Play again?";
                    optionOneLabel.Text = $"Yes";
                    optionTwoLabel.Text = $"No";
                    pictureBox1.BackgroundImage = Properties.Resources.restart;
                    pictureBox2.BackgroundImage = Properties.Resources.Under_water;
                    pictureBox3.BackgroundImage = Properties.Resources.Machete;
                    break;
                case 4:
                    outputLabel.Text = $"They couldnt be helped... Now all alone, lost and its getting dark. you decide to set up a shelter. Do you build in the trees or on the ground?  ";
                    optionOneLabel.Text = $"Ground";
                    optionTwoLabel.Text = $"Trees";
                    pictureBox1.BackgroundImage = Properties.Resources.Ground;
                    pictureBox2.BackgroundImage = Properties.Resources.Trees1;
                    pictureBox3.BackgroundImage = Properties.Resources.Machete;
                    break;
                case 5:
                    outputLabel.Text = $"You wake up in the dark to a snake preparing to strike.. do you flee or fight?";
                    optionOneLabel.Text = $"Flee";
                    optionTwoLabel.Text = $"Fight";
                    pictureBox1.BackgroundImage = Properties.Resources.Flee;
                    pictureBox2.BackgroundImage = Properties.Resources.Fight;
                    pictureBox3.BackgroundImage = Properties.Resources.Machete;
                    break;
                case 6:
                    outputLabel.Text = $"You trip over a log and smack your head off a tree... Play again?";
                    optionOneLabel.Text = $"Yes";
                    optionTwoLabel.Text = $"No";
                    pictureBox1.BackgroundImage = Properties.Resources.restart;
                    pictureBox2.BackgroundImage = Properties.Resources.Log;
                    pictureBox3.BackgroundImage = Properties.Resources.Machete;
                    break;
                case 7:
                    outputLabel.Text = $"You swing you arm like a club at the snake but it doges you and grasses your skin with its fangs.. Play again?";
                    optionOneLabel.Text = $"Yes";
                    optionTwoLabel.Text = $"No";
                    pictureBox1.BackgroundImage = Properties.Resources.restart;
                    pictureBox2.BackgroundImage = Properties.Resources.biting1;
                    pictureBox3.BackgroundImage = Properties.Resources.Machete;
                    break;
                case 8:
                    outputLabel.Text = $"You swing your machete at the snake and its head comes clean off. Do you leave the snake or do you save it for food?";
                    optionOneLabel.Text = $"Save for food";
                    optionTwoLabel.Text = $"Leave";
                    pictureBox1.BackgroundImage = Properties.Resources.Snake_Meat1;
                    pictureBox2.BackgroundImage = Properties.Resources.Snake_dead;
                    pictureBox3.BackgroundImage = Properties.Resources.Machete;
                    break;
                case 9:
                    outputLabel.Text = $"You fall out of the tree and die... Play again?";
                    optionOneLabel.Text = $"Yes";
                    optionTwoLabel.Text = $"No";
                    pictureBox1.BackgroundImage = Properties.Resources.restart;
                    pictureBox2.BackgroundImage = Properties.Resources.TreeDrawing;
                    pictureBox3.BackgroundImage = Properties.Resources.Machete;
                    break;
                case 10:
                    outputLabel.Text = $"although it was rough you made it through the night however, Your starting to feel hungry do you eat your food ? ";
                    optionOneLabel.Text = $"Eat";
                    optionTwoLabel.Text = $"Dont Eat";
                    pictureBox1.BackgroundImage = Properties.Resources.ForkAndKnife;
                    pictureBox2.BackgroundImage = Properties.Resources.NoEating;
                    pictureBox3.BackgroundImage = Properties.Resources.Machete;
                    break;
                case 11:
                    outputLabel.Text = $"You start to feel weak and fall to the ground. In a matter of hours you starved... Play again?";
                    optionOneLabel.Text = $"Yes";
                    optionTwoLabel.Text = $"No";
                    pictureBox1.BackgroundImage = Properties.Resources.restart;
                    pictureBox2.BackgroundImage = Properties.Resources.Cannopie;
                    pictureBox3.BackgroundImage = Properties.Resources.Machete;
                    break;
                case 12:
                    outputLabel.Text = $"You feel replenished and ready to escape this place. there is a mountain in the distance do you climb it or try to leave the way you came?";
                    optionOneLabel.Text = $"Leave";
                    optionTwoLabel.Text = $"Climb";
                    pictureBox1.BackgroundImage = Properties.Resources.Leave;
                    pictureBox2.BackgroundImage = Properties.Resources.Mountain;
                    pictureBox3.BackgroundImage = Properties.Resources.Machete;
                    break;
                case 13:
                    outputLabel.Text = $"On your search for the exit you come across a band of orangutan. Do you attack or try to make friends?";
                    optionOneLabel.Text = $"Freind";
                    optionTwoLabel.Text = $"Foe";
                    pictureBox1.BackgroundImage = Properties.Resources.OrangutanFriend;
                    pictureBox2.BackgroundImage = Properties.Resources.OrangutanFight;
                    pictureBox3.BackgroundImage = Properties.Resources.Machete;
                    break;
                case 14:
                    outputLabel.Text = $"the orangutans rip you down regardless of how hard you try. Play again?";
                    optionOneLabel.Text = $"Yes";
                    optionTwoLabel.Text = $"No";
                    pictureBox1.BackgroundImage = Properties.Resources.restart;
                    pictureBox2.BackgroundImage = Properties.Resources.OrangutanLoseOne;
                    pictureBox3.BackgroundImage = Properties.Resources.Machete;
                    break;
                case 15:
                    outputLabel.Text = $"The orangutans spot the axe upon your back they view you as their foe and they tear you to bits.... Play again?";
                    optionOneLabel.Text = $"Yes";
                    optionTwoLabel.Text = $"No";
                    pictureBox1.BackgroundImage = Properties.Resources.restart;
                    pictureBox2.BackgroundImage = Properties.Resources.OranutanLoseTwo;
                    pictureBox3.BackgroundImage = Properties.Resources.Machete;
                    break;
                case 16:
                    outputLabel.Text = $"Congratulations, you make friends with the orangutan's and they lead you to your escape! after you leave, you and the orangutan's become best buds! Play again?";
                    optionOneLabel.Text = $"Yes";
                    optionTwoLabel.Text = $"No";
                    pictureBox1.BackgroundImage = Properties.Resources.restart;
                    pictureBox2.BackgroundImage = Properties.Resources.Monkey_Win;
                    pictureBox3.BackgroundImage = Properties.Resources.Machete;
                    break;
                case 17:
                    outputLabel.Text = $"Although you made it through the night you start to feel hungry. After some time you stumble across a tree of mysterious fruit do you eat the fruit?  ";
                    optionOneLabel.Text = $"Yes";
                    optionTwoLabel.Text = $"No";
                    pictureBox1.BackgroundImage = Properties.Resources.Fruit;
                    pictureBox2.BackgroundImage = Properties.Resources.Dont_eat;
                    pictureBox3.BackgroundImage = Properties.Resources.Machete;
                    break;
                case 18:
                    outputLabel.Text = $"You start to feel weak and fall to the ground. In a matter of hours you starve... Play again?";
                    optionOneLabel.Text = $"Yes";
                    optionTwoLabel.Text = $"No";
                    pictureBox1.BackgroundImage = Properties.Resources.restart;
                    pictureBox2.BackgroundImage = Properties.Resources.StarveThree;
                    pictureBox3.BackgroundImage = Properties.Resources.Machete;
                    break;
                case 19:
                    outputLabel.Text = $"You climb the mountain. at the top do you build a smoke signal or try to see the exit.  ";
                    optionOneLabel.Text = $"Sight";
                    optionTwoLabel.Text = $"Smoke signal";
                    pictureBox1.BackgroundImage = Properties.Resources.Signal;
                    pictureBox2.BackgroundImage = Properties.Resources.MountainVeiw;
                    pictureBox3.BackgroundImage = Properties.Resources.Machete;
                    break;
                case 20:
                    outputLabel.Text = $"You climb onto a tall rock that sits upon on the mountain however you slip and tumble all the way down the mountain resulting in death... Play again?";
                    optionOneLabel.Text = $"Yes";
                    optionTwoLabel.Text = $"No";
                    pictureBox1.BackgroundImage = Properties.Resources.restart;
                    pictureBox2.BackgroundImage = Properties.Resources.Cliff;
                    pictureBox3.BackgroundImage = Properties.Resources.Machete;
                    break;
                case 21:
                    outputLabel.Text = $"You try to collect fire wood with your bare hands but you end up giving yourself a splinter this results in infection and death... Play again?";
                    optionOneLabel.Text = $"Yes";
                    optionTwoLabel.Text = $"No";
                    pictureBox1.BackgroundImage = Properties.Resources.restart;
                    pictureBox2.BackgroundImage = Properties.Resources.Splinter;
                    pictureBox3.BackgroundImage = Properties.Resources.Machete;
                    break;
                case 22:
                    outputLabel.Text = $"Congratulations, thanks to your axe you chop fire wood and a helicopter spots and saves you. Play again?";
                    optionOneLabel.Text = $"Yes";
                    optionTwoLabel.Text = $"No";
                    pictureBox1.BackgroundImage = Properties.Resources.restart;
                    pictureBox2.BackgroundImage = Properties.Resources.Helicopter1;
                    pictureBox3.BackgroundImage = Properties.Resources.Machete;
                    break;
                case 23:
                    outputLabel.Text = $"you realize you don't have any food! after a while you start to feel weak and fall to the ground. In a matter of hours you starve... Play again?";
                    optionOneLabel.Text = $"Yes";
                    optionTwoLabel.Text = $"No";
                    pictureBox1.BackgroundImage = Properties.Resources.restart;
                    pictureBox2.BackgroundImage = Properties.Resources.StarveSix;
                    pictureBox3.BackgroundImage = Properties.Resources.Machete;
                    break;
                case 99:
                    outputLabel.Text = $"Thanks for playing!";
                    optionOneLabel.Text = $"";
                    optionTwoLabel.Text = $"";
                    Refresh();
                    Thread.Sleep(2500);
                    Application.Exit();
                    break;
                default:
                    break;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
    }

