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

namespace Chose_your_own_adventure
{
    public partial class Form1 : Form
    {
        // The page of the story the user is currently at
        int page = 1;
        //if the snake has been eaten 
        int snake = 0;
        //variable that holds the players descion at the start of the game 
        int luggage = 0;
        //variable that is used in the random encounter 
        int randomNumber = 0;
        string Text = "";
        Random randGen = new Random();
        public Form1()
        {
            //start up proccess 
            InitializeComponent();
            Text = $"your tour gide announces that you will be going on a jungle adventure, you only have 10 minutes to pack. do you take an axe, food or machete";
            optionOneButton.Text = $"Axe";
            optionTwoButton.Text = $"Food";
            optionTheeButton.Text = $"Machete";
            pictureBox1.BackgroundImage = Properties.Resources.Axe;
            pictureBox2.BackgroundImage = Properties.Resources.Food;
            pictureBox3.BackgroundImage = Properties.Resources.Machete;
            this.Size = new Size(792, 424);
            TextWriter();

        }
        //user input button for the first decsion
        private void button1_Click(object sender, EventArgs e)
        {
            //picks random number when program starts
            randomNumber = randGen.Next(1, 11);
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
            else if (page == 17) { page = 12; }
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
        //user input button for the second decsion
        private void button2_Click(object sender, EventArgs e)
        {
            //picks random number when program starts
            randomNumber = randGen.Next(1, 11);
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
        //user input button for the third decsion 
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
        //Holds what comes up on each page
        public void DisplayPage()
        {
            switch (page)
            {
                case 1:
                    //text variable is used to find the amount of text showing up on the screen
                    Text = "your tour gide announces that you will be going on a jungle adventure, you only have 10 minutes to pack. do you take an axe, food or machete";
                    optionTwoButton.Text = $"Food";
                    optionOneButton.Text = $"Axe";
                    optionTheeButton.Text = $"Machete";
                    //Changes box size to compansate for 3rd button
                    this.Size = new Size(792, 424);
                    pictureBox1.BackgroundImage = Properties.Resources.Axe;
                    pictureBox2.BackgroundImage = Properties.Resources.Food;
                    pictureBox3.BackgroundImage = Properties.Resources.Machete;
                    break;
                case 2:
                    Text = $"You enter the jungle with an exited feeling, after a while you come across a river. your guide falls in do you save them ? ";
                    optionOneButton.Text = $"Yes";
                    optionTwoButton.Text = $"No";
                    this.Size = new Size(536, 424);
                    pictureBox1.BackgroundImage = Properties.Resources.Life_Jacket;
                    pictureBox2.BackgroundImage = Properties.Resources.River;
                    pictureBox3.BackgroundImage = Properties.Resources.Machete;
                    //plays audio
                    SoundPlayer stream = new SoundPlayer(Properties.Resources.Stream);
                    stream.Play();
                    break;
                case 3:
                    Text = $"You slip well trying to save them and drown... Play again?";
                    optionOneButton.Text = $"Yes";
                    optionTwoButton.Text = $"No";
                    pictureBox1.BackgroundImage = Properties.Resources.restart;
                    pictureBox2.BackgroundImage = Properties.Resources.Under_water;
                    pictureBox3.BackgroundImage = Properties.Resources.Machete;
                    break;
                case 4:
                    Text = $"They couldnt be helped... Now all alone, lost and its getting dark. you decide to set up a shelter. Do you build in the trees or on the ground?  ";
                    optionOneButton.Text = $"Ground";
                    optionTwoButton.Text = $"Trees";
                    pictureBox1.BackgroundImage = Properties.Resources.Ground;
                    pictureBox2.BackgroundImage = Properties.Resources.Trees1;
                    pictureBox3.BackgroundImage = Properties.Resources.Machete;
                    break;
                case 5:
                    Text = $"You wake up in the dark to a snake preparing to strike.. do you flee or fight?";
                    optionOneButton.Text = $"Flee";
                    optionTwoButton.Text = $"Fight";
                    pictureBox1.BackgroundImage = Properties.Resources.Flee;
                    pictureBox2.BackgroundImage = Properties.Resources.Fight;
                    pictureBox3.BackgroundImage = Properties.Resources.Machete;
                    break;
                case 6:
                    Text = $"You trip over a log and smack your head off a tree... Play again?";
                    optionOneButton.Text = $"Yes";
                    optionTwoButton.Text = $"No";
                    pictureBox1.BackgroundImage = Properties.Resources.restart;
                    pictureBox2.BackgroundImage = Properties.Resources.Log;
                    pictureBox3.BackgroundImage = Properties.Resources.Machete;
                    break;
                case 7:
                    Text = $"You swing you arm like a club at the snake but it doges you and grasses your skin with its fangs.. Play again?";
                    optionOneButton.Text = $"Yes";
                    optionTwoButton.Text = $"No";
                    pictureBox1.BackgroundImage = Properties.Resources.restart;
                    pictureBox2.BackgroundImage = Properties.Resources.biting1;
                    pictureBox3.BackgroundImage = Properties.Resources.Machete;
                    break;
                case 8:
                    Text = $"You swing your machete at the snake and its head comes clean off. Do you leave the snake or do you save it for food?";
                    optionOneButton.Text = $"Save for food";
                    optionTwoButton.Text = $"Leave";
                    pictureBox1.BackgroundImage = Properties.Resources.Snake_Meat1;
                    pictureBox2.BackgroundImage = Properties.Resources.Snake_dead;
                    pictureBox3.BackgroundImage = Properties.Resources.Machete;
                    //Plays audio 
                    SoundPlayer sword = new SoundPlayer(Properties.Resources.Sword);
                    sword.Play();
                    break;
                case 9:
                    Text = $"You fall out of the tree and die... Play again?";
                    optionOneButton.Text = $"Yes";
                    optionTwoButton.Text = $"No";
                    pictureBox1.BackgroundImage = Properties.Resources.restart;
                    pictureBox2.BackgroundImage = Properties.Resources.TreeDrawing;
                    pictureBox3.BackgroundImage = Properties.Resources.Machete;
                    break;
                case 10:
                    Text = $"although it was rough you made it through the night however, Your starting to feel hungry do you eat your food ? ";
                    optionOneButton.Text = $"Eat";
                    optionTwoButton.Text = $"Dont Eat";
                    pictureBox1.BackgroundImage = Properties.Resources.ForkAndKnife;
                    pictureBox2.BackgroundImage = Properties.Resources.NoEating;
                    pictureBox3.BackgroundImage = Properties.Resources.Machete;
                    break;
                case 11:
                    Text = $"You start to feel weak and fall to the ground. In a matter of hours you starved... Play again?";
                    optionOneButton.Text = $"Yes";
                    optionTwoButton.Text = $"No";
                    pictureBox1.BackgroundImage = Properties.Resources.restart;
                    pictureBox2.BackgroundImage = Properties.Resources.Cannopie;
                    pictureBox3.BackgroundImage = Properties.Resources.Machete;
                    break;
                case 12:
                    Text = $"You feel replenished and ready to escape this place. there is a mountain in the distance do you climb it or try to leave the way you came?";
                    optionOneButton.Text = $"Leave";
                    optionTwoButton.Text = $"Climb";
                    pictureBox1.BackgroundImage = Properties.Resources.Leave;
                    pictureBox2.BackgroundImage = Properties.Resources.Mountain;
                    pictureBox3.BackgroundImage = Properties.Resources.Machete;
                    break;
                case 13:
                    Text = $"On your search for the exit you come across a band of orangutan. Do you attack or try to make friends?";
                    optionOneButton.Text = $"Freind";
                    optionTwoButton.Text = $"Foe";
                    pictureBox1.BackgroundImage = Properties.Resources.OrangutanFriend;
                    pictureBox2.BackgroundImage = Properties.Resources.OrangutanFight;
                    pictureBox3.BackgroundImage = Properties.Resources.Machete;
                    break;
                case 14:
                    Text = $"the orangutans rip you down regardless of how hard you try. Play again?";
                    optionOneButton.Text = $"Yes";
                    optionTwoButton.Text = $"No";
                    pictureBox1.BackgroundImage = Properties.Resources.restart;
                    pictureBox2.BackgroundImage = Properties.Resources.OrangutanLoseOne;
                    pictureBox3.BackgroundImage = Properties.Resources.Machete;
                    break;
                case 15:
                    Text = $"The orangutans spot the axe upon your back they view you as their foe and they tear you to bits.... Play again?";
                    optionOneButton.Text = $"Yes";
                    optionTwoButton.Text = $"No";
                    pictureBox1.BackgroundImage = Properties.Resources.restart;
                    pictureBox2.BackgroundImage = Properties.Resources.OranutanLoseTwo;
                    pictureBox3.BackgroundImage = Properties.Resources.Machete;
                    break;
                case 16:
                    Text = $"Congratulations, you make friends with the orangutan's and they lead you to your escape! after you leave, you and the orangutan's become best buds! Play again?";
                    optionOneButton.Text = $"Yes";
                    optionTwoButton.Text = $"No";
                    pictureBox1.BackgroundImage = Properties.Resources.restart;
                    pictureBox2.BackgroundImage = Properties.Resources.Monkey_Win;
                    pictureBox3.BackgroundImage = Properties.Resources.Machete;
                    //Plays audio
                    SoundPlayer monkey = new SoundPlayer(Properties.Resources.Monkey);
                    monkey.Play();
                    break;
                case 17:
                    Text = $"Although you made it through the night you start to feel hungry. After some time you stumble across a tree of mysterious fruit do you eat the fruit?  ";
                    optionOneButton.Text = $"Yes";
                    optionTwoButton.Text = $"No";
                    pictureBox1.BackgroundImage = Properties.Resources.Fruit;
                    pictureBox2.BackgroundImage = Properties.Resources.Dont_eat;
                    pictureBox3.BackgroundImage = Properties.Resources.Machete;
                    break;
                case 18:
                    Text = $"You start to feel weak and fall to the ground. In a matter of hours you starve... Play again?";
                    optionOneButton.Text = $"Yes";
                    optionTwoButton.Text = $"No";
                    pictureBox1.BackgroundImage = Properties.Resources.restart;
                    pictureBox2.BackgroundImage = Properties.Resources.StarveThree;
                    pictureBox3.BackgroundImage = Properties.Resources.Machete;
                    break;
                case 19:
                    Text = $"You climb the mountain. at the top do you build a smoke signal or try to see the exit.  ";
                    optionOneButton.Text = $"Smoke signal";
                    optionTwoButton.Text = $"Sight";
                    pictureBox1.BackgroundImage = Properties.Resources.Signal;
                    pictureBox2.BackgroundImage = Properties.Resources.MountainVeiw;
                    pictureBox3.BackgroundImage = Properties.Resources.Machete;
                    break;
                case 20:
                    Text = $"You climb onto a tall rock that sits upon on the mountain however you slip and tumble all the way down the mountain resulting in death... Play again?";
                    optionOneButton.Text = $"Yes";
                    optionTwoButton.Text = $"No";
                    pictureBox1.BackgroundImage = Properties.Resources.restart;
                    pictureBox2.BackgroundImage = Properties.Resources.Cliff;
                    pictureBox3.BackgroundImage = Properties.Resources.Machete;
                    break;
                case 21:
                    Text = $"You try to collect fire wood with your bare hands but you end up giving yourself a splinter this results in infection and death... Play again?";
                    optionOneButton.Text = $"Yes";
                    optionTwoButton.Text = $"No";
                    pictureBox1.BackgroundImage = Properties.Resources.restart;
                    pictureBox2.BackgroundImage = Properties.Resources.Splinter;
                    pictureBox3.BackgroundImage = Properties.Resources.Machete;
                    break;
                case 22:
                    Text = $"Congratulations, thanks to your axe you chop fire wood and a helicopter spots and saves you. Play again?";
                    optionOneButton.Text = $"Yes";
                    optionTwoButton.Text = $"No";
                    pictureBox1.BackgroundImage = Properties.Resources.restart;
                    pictureBox2.BackgroundImage = Properties.Resources.Helicopter1;
                    pictureBox3.BackgroundImage = Properties.Resources.Machete;
                    //Plays audio
                    SoundPlayer heli = new SoundPlayer(Properties.Resources.Heli);
                    heli.Play();
                    break;
                case 23:
                    Text = $"you realize you don't have any food! after a while you start to feel weak and fall to the ground. In a matter of hours you starve... Play again?";
                    optionOneButton.Text = $"Yes";
                    optionTwoButton.Text = $"No";
                    pictureBox1.BackgroundImage = Properties.Resources.restart;
                    pictureBox2.BackgroundImage = Properties.Resources.StarveSix;
                    pictureBox3.BackgroundImage = Properties.Resources.Machete;
                    break;
                case 99:
                    //Thanks the player, clears and closes the application 
                    Text = $"Thanks for playing!";
                    optionOneButton.Text = $"";
                    optionTwoButton.Text = $"";
                    Refresh();
                    Thread.Sleep(2500);
                    Application.Exit();
                    break;
                default:
                    break;
                    

            }
            TextWriter();
        }
        //used to make text appeared as its being typed on the screen 
            public void TextWriter()
            {
                Refresh();
                outputLabel.Text = "";
            //the for loop used to make text apear written across the screen
                for (int i = 0; i < Text.Length; i++)
                {
                    outputLabel.Text += Text.Substring(i, 1);
                    outputLabel.Refresh();
                    Thread.Sleep(1);
                }
            }
        }
    }

//
