using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Miller_FarmerGrainChickenForm
{
        public partial class Form1 : Form
        {

            //Instantiates a new farmer object to use
            Farmer farmer = new Farmer();


            public Form1()
            {
                InitializeComponent();
                ClassInfoDisplay();
                GameInfoDisplay();
                GameDisplay();
            }

            //Method that displays class info
            private void ClassInfoDisplay()
            {
                MessageBox.Show("Name:                    Nicholas Miller" +
                    "\nCourse:                  ITDEV-115" +
                    "\nInstructor:              Janese Christie" +
                    "\nAssignment:           Assignment 7 - GUI Farmer Game" +
                    "\nDate:                        Date: "+ DateTime.Today.ToShortDateString());
            }
            //Method that displays info about the game and how to play
            private void GameInfoDisplay()
            {
                MessageBox.Show("This is the Farmer Game.The object of the game is to get the farmer, chicken and grain" +
                "\n to the other side of the river.  But hold on, not so fast." +
                "\nIf the farmer leaves the chicken and the grain alone on either side of the river, the chicken will eat " +
                "\nthe grain and that is not good. If the farmer leaves the fox and chicken on any side of the river alone, " +
                "\n the fox will eat the chicken. That is also not good. In either case you lose the game. farmer across the river." +
                "\n If you get the farmer, the chicken, the fox, and the gtain safely across the river and intact, you win!");

        }

            //Method that sets up the display of the game based on where each item is currently located
            private void GameDisplay()
            {
                //Set all buttons to false initially
                chickenN.Visible = false;
                foxN.Visible = false;
                grainN.Visible = false;
                chickenS.Visible = false;
                foxS.Visible = false;
                grainS.Visible = false;
                farmerN.Visible = false;
                farmerS.Visible = false;

                if (farmer.TheFarmer == Direction.NORTH)
                {
                    farmerN.Visible = true;
                }
                else if (farmer.TheFarmer == Direction.SOUTH)
                {
                    farmerS.Visible = true;
                }

                for (int i = 0; i < farmer.NorthBank.Count; i++)
                {
                    if (farmer.NorthBank[i] == "FOX")
                    {
                        foxN.Visible = true;
                    }
                    if (farmer.NorthBank[i] == "CHICKEN")
                    {
                        chickenN.Visible = true;
                    }
                    if (farmer.NorthBank[i] == "GRAIN")
                    {
                        grainN.Visible = true;
                    }
                }

                for (int i = 0; i < farmer.SouthBank.Count; i++)
                {
                    if (farmer.SouthBank[i] == "FOX")
                    {
                        foxS.Visible = true;
                    }
                    if (farmer.SouthBank[i] == "CHICKEN")
                    {
                        chickenS.Visible = true;
                    }
                    if (farmer.SouthBank[i] == "GRAIN")
                    {
                        grainS.Visible = true;
                    }
                }
            }

            //Method that takes in an int from the Farmer class to determine if game has been won
            private void CheckForWin(int result)
            {
                if (result == 1)
                {
                    MessageBox.Show("Congratulations! You have won the game!");
                }
                else if (result == 4)
                {
                    MessageBox.Show("Oh no!The fox ate the chicken! YOU LOSE!");
                }
                else if (result == 8)
                {
                    MessageBox.Show("Oh no! The chicken ate the grain! YOU LOSE!");
                }
            }

            //Method for when user chooses to move farmer from North to South
            private void farmerN_Click(object sender, EventArgs e)
            {
                CheckForWin(farmer.Move(""));
                GameDisplay();
            }

            //Method for when user chooses to move fox from North to South
            private void foxN_Click(object sender, EventArgs e)
            {
                CheckForWin(farmer.Move("Fox"));
                GameDisplay();
            }

            //Method when user chooses to move chicken from North to South
            private void chickenN_Click(object sender, EventArgs e)
            {
                CheckForWin(farmer.Move("CHICKEN"));
                GameDisplay();
            }

            //Method when user chooses to move grain from north to south
            private void grainN_Click(object sender, EventArgs e)
            {
                CheckForWin(farmer.Move("GRAIN"));
                GameDisplay();
            }

            //Method for when user chooses to move farmer from South to North
            private void farmerS_Click(object sender, EventArgs e)
            {
                CheckForWin(farmer.Move(""));
                GameDisplay();
            }

            //Method for when user chooses to move fox from South to North
            private void foxS_Click(object sender, EventArgs e)
            {
                CheckForWin(farmer.Move("FOX"));
                GameDisplay();
            }

            //Method when user chooses to move chicken from South to North
            private void chickenS_Click(object sender, EventArgs e)
            {
                CheckForWin(farmer.Move("CHICKEN"));
                GameDisplay();
            }

            //Method when user chooses to move grain from South to North
            private void grainS_Click(object sender, EventArgs e)
            {
                CheckForWin(farmer.Move("GRAIN"));
                GameDisplay();
            }
        }

    }