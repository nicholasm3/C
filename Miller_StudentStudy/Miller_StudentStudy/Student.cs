using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miller_StudentStudy
{
    class Student
    {

        private double[] hours = new double[7];           //Hold number of hours student studies
        private string id;                                   //Hold student ID number
        private String name;                              //Hold students name

        //ID property
        public string ID
        {
            get { return id; }      //get method
            set { id = value; }     //set method
        }

        //Name property
        public string Name
        {
            get { return name; }        //get method
            set { name = value; }       //set method
        }

        //Hours array property
        public double[] Hours
        {
            get { return hours; }
        }


        //Calculate average method returns the average study hours per day for a week
        public double CalculateAverage()
        {
            double total = 0;       //to hold total number of hours studieed
            double average;         //to hold average number of hours

            //for loop to add all hours together
            for (int i = 0; i < 7; i++)
            {
                total += hours[i];
            }

            average = total / 7;        //calculate average

            return average;
        }

        //Method that takes in hours for each day of studies
        public void EnterHours(double studyAmount, int dayNumber)
        {
            hours[dayNumber] = studyAmount;     //Assign hours to each day in array
        }

        public static void GetNumberHours()
        {
             Student.GetNumberHours();
        }

    }
    }
