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
        public Form1()
        {
            InitializeComponent();
        }

        private void optionButtonOne_Click(object sender, EventArgs e)
        {
            if (page == 1)
            {
                //Player gets to chose item of choice
                luggage = 1;
                page = 2; 
            }
                //Player choses there path
            else if (page == 2) {page = 3;}
            else if (page == 3) {page = 1;}
            else if (page == 4) {page = 5;}
            else if (page == 5) {page = 6;}
            else if (page == 6) {page = 1;}
            else if (page == 7) {page = 1;}
            else if (page == 8) 
            {
                page = 10; 
                //using snake as a latter gameplay element
               snake = 1;
            }
            else if (page == 9) {page = 1;}
            else if (page == 10)
            {
                //gameplay element including food
                if (luggage == 2 || snake == 1)
                {
                    page = 11;
                }
                else
                {
                    page = 23; 
                }
            }
            else if (page == 11) {page = 1;}
            else if (page == 12) {page = 13;}
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
            //Player chos
            else if (page == 14) {page = 1;}
            else if (page == 15) {page = 1;}
            else if (page == 16) {page = 1;}
            else if (page == 17) {page = 13;}
            else if (page == 18) {page = 1;}
            else if (page == 19) 
            { 
                if (luggage == 1)
                {
                    page = 22; 
                }
                else
                {
                    page = 21; 
                }
            }
            else if (page == 20) {page = 1;}
            else if (page == 21) {page = 1;}
            else if (page == 22) {page = 1;}
            else if (page == 23) {page = 1;}
        }

        private void optionButtonTwo_Click(object sender, EventArgs e)
        {
            if (page == 1)
            {
                //Player gets to chose item of choice
                luggage = 2;
                page = 2;
            }
            else if (page == 2) { page = 4; }
            else if (page == 3) { page = 99; }
            else if (page == 4) 
            {
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
                    page = 99;
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
            else if (page == 6) {page = 99;}
            else if (page == 7) {page = 99;}
            else if (page == 8)
            {
                page = 10;
            }
            else if (page == 9) {page = 99;}
            else if (page == 10)
            {
                page = 11;
            }
            else if (page == 11) {page = 99;}
            else if (page == 12) {page = 19;}
            else if (page == 13) {page = 14;}
            else if (page == 14) {page = 99;}
            else if (page == 15) {page = 99;}
            else if (page == 16) {page = 99;}
            else if (page == 17) {page = 18;}
            else if (page == 18) {page = 99;}
            else if (page == 19) {page = 20;}
            else if (page == 20) {page = 99;}
            else if (page == 21) {page = 99;}
            else if (page == 22) {page = 99;}
            else if (page == 23) {page = 99;}
        }
    }
}
