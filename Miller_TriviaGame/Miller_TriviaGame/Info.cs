using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miller_TriviaGame
{
    class Info
    {

        public void DisplayInfo(string assignment)
        {
            const string barrior = "**********************************************************************************";

            Console.WriteLine(barrior);
            Console.WriteLine();
            Console.WriteLine("Name: \t\tNicholas Miller");
            Console.WriteLine("Course: \tITDEV-115");
            Console.WriteLine("Instructor: \tJanese Christine");
            Console.WriteLine("Assignment: \t" + assignment);
            Console.WriteLine("Date: \t\t" + DateTime.Today.ToShortDateString());
            Console.WriteLine();
            Console.WriteLine("**********************************************************************************");
            Console.WriteLine("**********************************************************************************");
            Console.WriteLine();
        }
    }
}
