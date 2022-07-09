using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace Miller_MidTerm
{
    class Program
    {
        static void Main(string[] args)
        {

            Info myInfo = new Info();

            myInfo.DisplayInfo("Election Midterm");

            ElectionUI election = new ElectionUI();
            election.MainMethod();
            election.DisplayResults();

            ReadKey();


        }
    }
}
