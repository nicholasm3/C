using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Miller_FarmerGrainChicken
{
    class Program
    {
        static void Main(string[] args)
        {
            Info myInfo = new Info();

            myInfo.DisplayInfo("Farmer Grain Chicken");

            FarmerUI newFarmer = new FarmerUI();
            newFarmer.PlayGame();

            ReadKey();
        }
    }
}
