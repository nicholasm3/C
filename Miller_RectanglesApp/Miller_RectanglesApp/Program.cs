using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Miller_RectanglesApp
{
    class Program
    {
        class Miller_RectanglesApp
        {


            //Main method
            static void Main()
            {

                WriteLine("Name: Nicholas Miller");
                WriteLine("Course: ITDEV-115");
                WriteLine("Instructor: J Christie");
                WriteLine("Assignment: Rectangle Assignment");
                WriteLine("Date: 08/26/2021\n");
                WriteLine("*****************************************************************\n");
                WriteLine("This program will calculate the area and the perimiter of a rectangle.");
                WriteLine("All you need to do is enter the rectangle's height and width.\n");


                //Variables
                double height;
                double width;
                double area;
                double perimeter;

                //Values
                ReadValues(out height, out width);

                //Calculating area
                area = CalcArea(height, width);

                //Calculating perimeter
                perimeter = CalcPerimeter(height, width);

                //Display results
                printResults(height, width, area, perimeter);
                ReadKey();


            }

            //Method that read's the values from user
            static void ReadValues(out double height, out double width)
            {

                //Reads height
                Write("Please enter the rectangles height in inches: ");
                height = double.Parse(Console.ReadLine());

                //Reads width
                Write("Please enter the rectangles width in inches: ");
                width = double.Parse(Console.ReadLine());
            }

            //Method that calculates area of rectangle
            static double CalcArea(double height, double width)
            {
                return (height * width);
            }

            //Method that calculates perimeter of rectangle
            static double CalcPerimeter(double height, double width)
            {
                return (2 * (height + width));
            }

            //Method that prints the results
            static void printResults(double height, double width, double area, double perimeter)
            {
                WriteLine("\n{0, -10}: {1,10:F1}", "The area of the rectangle is", area + " inches");
                WriteLine("{0, -10}: {1,10:F1}", "The perimeter of the rectangle is", perimeter + " inches");
            }
        }
    }
}