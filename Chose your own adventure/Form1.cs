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
        public Form1()
        {
            InitializeComponent();
        }

        private void optionButtonOne_Click(object sender, EventArgs e)
        {
            if (page == 1)
            {
                page = 2; 
            }
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
                if (luggage = 2 || snake = 1)
                {
                    page = 13;
                }
                else
                {
                    page = 24; 
                }
            }
            else if (page == 11) { }
            else if (page == 12) { }
            else if (page == 13) { }
            else if (page == 14) { }
            else if (page == 15) { }
            else if (page == 16) { }
            else if (page == 17) { }
            else if (page == 18) { }
            else if (page == 19) { }
            else if (page == 20) { }
            else if (page == 21) { }
            else if (page == 22) { }
            else if (page == 23) { }
            else if (page == 24) { }
            else if (page == 99) { }
        }

        private void optionButtonTwo_Click(object sender, EventArgs e)
        {

        }
    }
}
