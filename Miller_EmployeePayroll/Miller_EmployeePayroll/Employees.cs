using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miller_EmployeePayroll
{
    class Employees
    {



        private String emp_fName;

        private String emp_lName;

        private double total_Gross = 0.07;

        public const double FedTaxRate = 0.18;

        public const double RetCont = 0.06;

        public const double SocialSecTaxRate = 0.10;

        


        public Employees()

        {

            
            emp_fName = "";

            emp_lName = "";

            total_Gross = 0;

        }



        public Employees(String efName, String elName, double sales)

        {


            emp_fName = efName;

            emp_lName = elName;

            total_Gross = sales;

        }



        public void setFName(String efName)

        {

            emp_fName = efName;

        }



        public void setLName(String elName)

        {

            emp_lName = elName;

        }






        public void setSales(double sales)

        {

            total_Gross = sales;


        }

      


        public String getfName()

        {

            return emp_fName;

        }



        public String getlName()

        {

            return emp_lName;

        }



        public double getGross()

        {

            return total_Gross;

        }

        public double computeNetPay()

        {

            double pay;

            pay = (9 / 100.0) * total_Gross;

            pay = pay - (pay * (FedTaxRate / 100.0));

            pay = pay - (pay * (RetCont / 100.0));

            pay = pay - (pay * (SocialSecTaxRate / 100.0));

            return pay;

           

            

        }

    }

}