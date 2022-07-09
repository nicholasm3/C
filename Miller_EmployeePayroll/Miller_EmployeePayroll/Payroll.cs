using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miller_EmployeePayroll
{
    class Payroll
    {
        public static void Main(string[] args)
        {
            {
                

                Info myInfo = new Info();
                myInfo.DisplayInfo("Employee Payroll Assignment");


                Employees emp = new Employees();


                Console.WriteLine("Please enter the employees first name: ");

                emp.setFName(Console.ReadLine());

                Console.WriteLine("Please enter the employees last name: ");

                emp.setLName(Console.ReadLine());

                Console.WriteLine("Please enter the employees total sales for the month: ");

                emp.setSales(Convert.ToInt32(Console.ReadLine()));

                Console.WriteLine("First Name: " + emp.getfName());

                Console.WriteLine("Last Name: " + emp.getlName());

                Console.WriteLine("Employee Gross Income: $" + emp.getGross().ToString());

                Console.WriteLine("Federal Tax Withheld: $" + emp.getGross().ToString());

                Console.WriteLine("Social Secuirty Tax Withheld: $" + emp.getGross().ToString());

                Console.WriteLine("Retirement Contributions: $" + emp.getGross().ToString());



                Console.ReadKey();



            }
        }
    }
}
