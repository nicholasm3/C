using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace Miller_MagicPCApp
{
    class MagicPCUI
    {
        private String userMagic;

        public void UserInstructions()
        {
            Console.WriteLine("\tWelcome my friend welcome. Come closer. Thats right\n");
            Console.WriteLine("\tThis is the magic PC screen. All your questions will be answered!");
            Console.WriteLine("\tJust enter a question and the magic PC screen will give you the answer!\n");
            Console.WriteLine("\tHowever, it must be a question that can be answered with a yes or a no");
            Console.WriteLine("\tTo exit the program, just hit the Enter key.\n");
            Console.WriteLine("**********************************************************************************");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("\n Hit any key to continue");
            Console.ReadKey();
            Console.Clear();
            WriteLine("Enter your question if you dare...");

        }

        public void GetUserQuestion()
        {
            userMagic = ReadLine();

            if (userMagic == "")
            {
                WriteLine("You didn't ask anything! Please ask a yes or no question Now!");
                userMagic = ReadLine();

            }
        }

        public void Start() // I assume this should start the problem
            {

            }

        public void RespondToQuestion() //I assume this should print out he response to the console?
        {

        }



        }
    }

