using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miller_BMIApp
{
    class BMI
    {
        public double bodyMassIndex;
        public double heightInInches;
        public double weightInPounds;


        public BMI()
        {

        }

        public double BodyMassIndex
        {
            get { return bodyMassIndex; }
            set { bodyMassIndex = value; }
        }

        public double HeightInInches
        {
            get { return heightInInches; }
            set { heightInInches = value; }
        }


        public double WeightInPounds
        {
            get { return weightInPounds; }
            set { weightInPounds = value; }
        }

        public void BMIoverload(double heightInInches, double weightInPounds)
        {
            HeightInInches = heightInInches;
            WeightInPounds = weightInPounds;
        }


        public void CalculateBMI()
        {

            bodyMassIndex = WeightInPounds / (HeightInInches * HeightInInches) * 703.0;
            bodyMassIndex = BodyMassIndex;
        }



        public void ObtainWeightStatus()
        {
            if (BodyMassIndex < 18.5)

                Console.WriteLine("Underweight");

            else if (BodyMassIndex >= 18.5 && BodyMassIndex <= 24.9)

                Console.WriteLine("Normal");

            else if (BodyMassIndex >= 25 && BodyMassIndex <= 29.9)

                Console.WriteLine("Overweight");

            else if (BodyMassIndex >= 30)

                Console.WriteLine("Obese");
        }
    }
}

