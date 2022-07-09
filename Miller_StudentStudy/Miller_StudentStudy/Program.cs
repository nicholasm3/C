using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Miller_StudentStudy
{
    class Program
    {
        static void Main(string[] args)
        {

            Info myInfo = new Info();

            myInfo.DisplayInfo("Student Study App");

            StudentUI currentStudent = new StudentUI();
            currentStudent.MainMethod();
            

            ReadKey();
        }
    }
}
