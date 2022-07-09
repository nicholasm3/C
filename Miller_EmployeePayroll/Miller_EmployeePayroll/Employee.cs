using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miller_EmployeePayroll
{
    class Class1
    {
        //Constant for calculating payment
        const double GrossRate = 0.07;
        const double FederalRate = 0.18;
        const double RetireRate = 0.06;
        const double SocialRate = 0.10;


        //Calculate and print the take-home pay for a sales employee
        Write("Please enter the employees first name: ");
        string name = ReadLine();

        Write("Please enter the employees last name: ");
        string lastname = ReadLine();

        Write("Enter sales amount for the week: ");
        string line = ReadLine();

        //Convert the string line into an amount assuming it is a legal number
        double amount = double.Parse(line);

        //Calculate gross pay
        double gross = amount * GrossRate;

        //Calculate tax and contribution
        double federal_tax = gross * FederalRate;
        double retire_con = gross * RetireRate;
        double social_tax = gross * SocialRate;

        //Calculate the final net pay
        double deductions = federal_tax + retire_con + social_tax;
        double netpay = gross - deductions;

        //Display the result
        WriteLine("Name: " + name + lastname);
        WriteLine("Sales:    " + amount);
        WriteLine("Employee Gross Income: ${1}", GrossRate* 100, gross);
        WriteLine("Federal Tax Withheld: ${1}", FederalRate* 100, federal_tax);
        WriteLine("Social Security Tax Withheld: ${1}", RetireRate* 100, retire_con);
        WriteLine("Retirement contributions: ${1}", SocialRate* 100, social_tax);
        WriteLine("Employee net pay: $" + netpay);
        ReadLine();
    }
}
}
