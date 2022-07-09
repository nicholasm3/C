using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;


namespace Miller_MagicPCApp
{
    class MagicPC
    {
        public void GetUserAnswer()
        {
            Random random = new Random();

            switch (random.Next(8))
            {
                case 0:
                    WriteLine();
                    WriteLine("No way man!");
                    break;
                case 1:
                    WriteLine();
                    WriteLine("Lol I doubt it");
                    break;
                case 2:
                    WriteLine();
                    WriteLine("I believe so");
                    break;
                case 3:
                    WriteLine();
                    WriteLine("My senses say yes...");
                    break;
                case 4:
                    WriteLine();
                    WriteLine("I see a no...");
                    break;
                case 5:
                    WriteLine();
                    WriteLine("Of course, why not");
                    break;
                case 6:
                    WriteLine();
                    WriteLine("Nope");
                    break;
                case 7:
                    WriteLine();
                    WriteLine("You are on to something");
                    break;
            }
        }
    }
}
