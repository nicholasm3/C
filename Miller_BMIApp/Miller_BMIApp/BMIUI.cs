using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miller_BMIApp
{
    class BMIUI
    {

        public void RequestUserData()
        {
            double heightInInches;
            double weightInPounds;

            Console.Write("Please enter your height in inches: ");
            heightInInches = Convert.ToDouble(Console.ReadLine());

            Console.Write("Please enter your weight in pounds: ");
            weightInPounds = Convert.ToDouble(Console.ReadLine());

            BMI overload = new BMI();
            overload.BMIoverload(heightInInches, weightInPounds);

        }
    


        public void UserDirections()
        {
            Console.WriteLine("This program will calculate your Body Mass Index (BMI) using your height and weight");
        }

        public void DisplayResults()
        {
            BMI view = new BMI();

            Console.WriteLine("For your height of " + view.HeightInInches + "\tinches");
            Console.WriteLine("and your weight of " + view.WeightInPounds + "\tpounds");
            Console.WriteLine("your BMI is" + view.BodyMassIndex);
        }
    }
}
