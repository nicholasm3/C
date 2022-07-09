using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;


namespace Miller_MagicPCApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Info myInfo = new Info();

            myInfo.DisplayInfo("Magic PC Application Assignment");


            MagicPCUI magic = new MagicPCUI();
            magic.UserInstructions();

            MagicPC answer = new MagicPC();

            String userContinue = "";  
            do
            {
                magic.GetUserQuestion();
                answer.GetUserAnswer();

                WriteLine();
                WriteLine("Would you like to ask another, Yes or No? ");
                userContinue = ReadLine();
                WriteLine();
                
            } 
            while (userContinue.Equals("Yes", StringComparison.CurrentCultureIgnoreCase));
            

            if (userContinue.Equals("No", StringComparison.CurrentCultureIgnoreCase));
            {
                WriteLine();
                WriteLine("Until we meet again, may you have good fortune.");

            }
        }
    }
}
