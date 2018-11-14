// A1212
// Program 2
// CIS 199-01 Due March 7,2017
// This program takes a student's last name and class standing and 
// determines what is the earliest date and time that student can register for classes. 


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void goBtn_Click(object sender, EventArgs e) //Determines earliest time of registration when clicked.
        {
            char letter; //first letter of last name
            string day; //Variable for day
            string time; // Variable for time
            string day1 = "Wednesday, March 29 "; // Senior registration day
            string day2 = "Thursday, March 30 "; // Junior reg. day
            string day3 = "Friday, March 31 "; // Sophmore reg. day
            string day4 = "Monday, April 3 "; // Sophmore reg. day
            string day5 = "Tuesday, April 4 "; // Freshman reg. day
            string day6 = "Wednesday, April 5 "; //Freshman reg. day
            string time1 = "at 8:30";
            string time2 = "at 10:00";
            string time3 = "at 11:30"; // string time1-time5 are the earliest times to register for different last names.
            string time4 = "at 2:00";
            string time5 = "at 4:00";

            letter = nameTxtBox.Text[0]; // Gets the first letter from the textbox
            letter = char.ToLower(letter); // Sets the first letter to lowercase

            if (char.IsLetter(letter)) // Checks if the character is a letter
            {
                if (seniorBtn.Checked || juniorBtn.Checked) //Checks if the Senior or Junior buttons are checked since jr and sr have same time pattern, they can be grouped together
                {                                           // and sets the time for each range of letters.
                    if (letter <= 'd')
                    {
                        time = time3;
                    }
                    else if (letter <= 'i') 
                    {
                        time = time4;
                    }
                    else if (letter <= 'o') 
                    {
                        time = time5;
                    }
                    else if (letter <= 's')
                    {
                        time = time1;
                    }
                    else
                    {
                        time = time2;
                    }

                        if (seniorBtn.Checked) //Determines which day to use
                        {
                            dateDisplayLbl.Text = day1 + time; //Senior day and time
                        }
                        else
                        {
                            dateDisplayLbl.Text = day2 + time; //Junior day and time
                        }

                }
                else //Checks if the Sophomore or Freshman and determines time for registration.
                    {
                        if (letter <= 'b') 
                        {
                            time = time5;
                        }
                        else if (letter <= 'd') 
                        {
                            time = time1;
                        }
                        else if (letter <= 'f')
                        {
                            time = time2;
                        }
                        else if (letter <= 'i') 
                        {
                            time = time3; 
                        }
                        else if (letter <= 'l') 
                        {
                            time = time4;
                        }
                        else if (letter <= 'o') 
                        {
                            time = time5;
                        }
                        else if (letter <= 'q') 
                        {
                            time = time1;
                        }
                        else if (letter <= 's') 
                        {
                            time = time2;
                        }
                        else if (letter <= 'v')
                        {
                            time = time3;
                        }
                        else 
                        {
                            time = time4;
                        }
                     if (letter >= 'c' && letter <= 'o') //Since students from 'c' to 'o' go only days 4 and 6, we can use that statement to separate sophomore and freshman days (since there are two days each).
                    {
                        if(sophBtn.Checked) { dateDisplayLbl.Text = day4 + time; } //Displays sophomore's time and date for one of its days.
                        else { dateDisplayLbl.Text = day6 + time; } //Displays freshman time and date for one of its days.
                    }
                    else
                    {
                        if(sophBtn.Checked) { dateDisplayLbl.Text = day3 + time; } //Displays sophomore's other day.
                        else { dateDisplayLbl.Text = day5 + time; } //Displays freshman's other day.
                    }
                    }
                }
                else
                {
                    MessageBox.Show("Please enter last name or letter"); //Shows messagebox if a letter is not used.
                }

            }
        }
    
}
