using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Miller_StudentStudy
{
    class StudentUI
    {

        String[] days = new string[7] { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };

        //Create a student object
        Student student = new Student();

        //Method to enter basic student info
        public void MainMethod()
        {
            Write("Please enter your name:  ");
            student.Name = ReadLine();

            Write("Please enter your student ID number:  ");
            student.ID = ReadLine(); 
            WriteLine();

            FillHours();
            DisplayData();
            DisplayAverage();
        }

        //Method to get each days study amount and pass that amount to Student class
        public void FillHours()
        {
            for (int i = 0; i < 7; i++)
            {
                string inValue;
                double number;

                Write("Please enter the number of hours studied for ITDEV-115 on {0}: ", days[i]);
                inValue = ReadLine();

                if (!double.TryParse(inValue, out number))
                {
                    Write("Invalid input, please enter a vald number: ");
                    inValue = ReadLine();
                }

                number = double.Parse(inValue);
                student.EnterHours(number, i);
            }
            WriteLine();
            WriteLine();
        }

        //Method to display data entered by the user for study hours
        public void DisplayData()
        {
            WriteLine("Name:        {0}", student.Name);
            WriteLine("ID Number:   {0}", student.ID);
            WriteLine();
            WriteLine("The number of hours of study you did for the week are as follows: ");

            for (int i = 0; i < 7; i++)
            {
                WriteLine("{0}     {1:N2}", days[i] + ":", student.Hours[i]);
            }
            WriteLine();
            WriteLine();
        }


        //Method to display the average amount of studying done per day
        public void DisplayAverage()
        {
            WriteLine("The average number of hours studied per day is {0:N2}", student.CalculateAverage());
        }
    }
}