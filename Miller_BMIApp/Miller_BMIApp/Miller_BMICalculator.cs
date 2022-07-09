using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miller_BMIApp
{
    class Miller_BMICalculator
    {
        static void Main(string[] args)
        {
            Display myInfo = new Display();
            myInfo.DisplayInfo("BMI Application Assignment");
            Console.ReadKey();
            

            BMIUI Ask = new BMIUI();

            Ask.UserDirections();
            Ask.RequestUserData();


            BMIUI view = new BMIUI();
            view.DisplayResults();


            Console.ReadKey();

        }
    }
}
