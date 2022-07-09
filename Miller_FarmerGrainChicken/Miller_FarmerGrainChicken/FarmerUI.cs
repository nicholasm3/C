using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using System.Collections;

 namespace Miller_FarmerGrainChicken
{
    class FarmerUI
    {
        //Instantiate the farmer object
        Farmer theFarmer = new Farmer();


        //Displays the welcome message in color
        public void DisplayWelcome()
        {
            ForegroundColor = ConsoleColor.Red;
            WriteLine();
            WriteLine("This is the Farmer Game.  The object of the game is to get the farmer, chicken and grain" +
                "\n to the other side of the river.  But hold on, not so fast." +
                "\nIf the farmer leaves the chicken and the grain alone on either side of the river, the chicken will eat " +
                "\nthe grain and that is not good. If the farmer leaves the fox and chicken on any side of the river alone, " +
                "\n the fox will eat the chicken. That is also not good. In either case you lose the game. farmer across the river." +
                "\n If you get the farmer, the chicken, the fox, and the gtain safely across the river and intact, you win ");
            ForegroundColor = ConsoleColor.White;
            WriteLine();
            WriteLine();
            WriteLine("Press any key when you are ready to start this thought provoking game");
            ReadKey();
            Clear();
        }

        //This displays the state of the game
        public void DisplayGameState()
        {
            DisplayNorthBank();
            DisplayRiver();
            DisplaySouthBank();
            WriteLine("The farmer is on the {0} bank of the river", theFarmer.TheFarmer);
        }

        //This displays the south bank
        public void DisplayNorthBank()
        {
            BackgroundColor = ConsoleColor.Green;

            WriteLine("VVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVV");
            WriteLine("VVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVV");
            WriteLine("VVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVV");
            WriteLine("*********************North Bank****************************************");
            ResetColor();
            for (int i = 0; i < theFarmer.NorthBank.Count; i++)
            {
                Write(theFarmer.NorthBank[i] + "  ");

            }


        }

        //This displays the southbank
        public void DisplaySouthBank()
        {

            for (int i = 0; i < theFarmer.SouthBank.Count; i++)
            {
                Write(theFarmer.SouthBank[i] + "  ");
            }

            BackgroundColor = ConsoleColor.Green;
            WriteLine();
            WriteLine("********************South Bank*****************************************");
            WriteLine("VVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVV");
            WriteLine("VVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVV");
            WriteLine("VVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVV");
            ResetColor();
        }

        //This method displays the river
        public void DisplayRiver()
        {
            BackgroundColor = ConsoleColor.Blue;

            WriteLine();
            WriteLine("^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^");
            WriteLine("^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^");
            WriteLine("^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^");
            WriteLine("^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^");
            WriteLine();

            ResetColor();
        }

        //Method that takes in the int and returns the boolean
        public bool Play(int intro)
        {
            if (intro < 1)
            {
                DisplayWelcome();
            }
            DisplayGameState();
            return PromptForMove();
        }

        //Method for that plays the game 
        public void PlayGame()
        {
            bool RunGame = true;
            int count = 0;

            while (RunGame)
            {
                RunGame = Play(count);
                count++;
            }
        }

        //Method that determines if the game should continue
        public bool PromptForMove()
        {
            string inString = "";
            string choice = "";
            bool choiceError = true;

            int outcome = 0;

            Write("\nChoose next item for the farmer.  If you choose nothing, just hit the enter key ");
            choice = Console.ReadLine();
            if (choice == "")
            {
                outcome = theFarmer.Move(choice);
                choiceError = false;
            }
            else if (theFarmer.TheFarmer == Direction.NORTH)
            {
                for (int i = 0; i < theFarmer.NorthBank.Count; i++)
                {
                    if (choice.ToUpper() == theFarmer.NorthBank[i])
                    {
                        outcome = theFarmer.Move(choice.ToUpper());
                        choiceError = false;
                        choice = "";
                    }
                }
            }
            else if (theFarmer.TheFarmer == Direction.SOUTH)
            {
                for (int i = 0; i < theFarmer.SouthBank.Count; i++)
                {
                    if (choice.ToUpper() == theFarmer.SouthBank[i])
                    {
                        outcome = theFarmer.Move(choice.ToUpper());
                        choiceError = false;
                        choice = "";
                    }
                }
            }

            Console.Clear();
            if (choiceError)
            {
                Console.WriteLine("\nThat item is not on this side of the river");
                Console.WriteLine("Please try again");
                return true;
            }
            else if (outcome == 1)
            {
                Console.WriteLine("You have successfully completed the game!!");
                Console.WriteLine("CONGRATULATIONS");
                Console.Write("\n\nWould you like to play again? ");
                inString = Console.ReadLine();

                if (inString != "" && inString.ToUpper()[0] == 'Y')
                {
                    Console.Clear();
                    return true;
                }
                else { return false; }
            }
            else if (outcome == 4)
            {
                Console.WriteLine("Oh No! The Fox Ate the Chicken!!");
                Console.WriteLine("YOU LOSE");
                Console.Write("\n\nWould you like to play again? ");
                inString = Console.ReadLine();

                if (inString != "" && inString.ToUpper()[0] == 'Y')
                {
                    Console.Clear();
                    return true;
                }
                else { return false; }
            }
            else if (outcome == 8)
            {
                Console.WriteLine("Oh No! The Chicken Ate the Grain!!");
                Console.WriteLine("YOU LOSE");
                Console.Write("\n\nWould you like to play again? ");
                inString = Console.ReadLine();

                if (inString != "" && inString.ToUpper()[0] == 'Y')
                {
                    Console.Clear();
                    return true;
                }
                else { return false; }
            }
            else { return true; }
        }
    }
}