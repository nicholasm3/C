using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Miller_TriviaGame
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Controller ctrl = new Controller();
            Info myInfo = new Info();

            myInfo.DisplayInfo("Trivia Game");
            ctrl.Play();
        }
    }
 }