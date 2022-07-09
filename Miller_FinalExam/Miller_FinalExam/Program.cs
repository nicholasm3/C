using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miller_FinalExam
{
    class Program
    {
        static void Main(string[] args)
        {
            GradesUI ui = new GradesUI();
            Info myInfo = new Info();

            myInfo.DisplayInfo("Final Exam");
            ui.MainMethod();
        }
    }
}