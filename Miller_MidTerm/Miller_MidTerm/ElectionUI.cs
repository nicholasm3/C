using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace Miller_MidTerm
{
    class ElectionUI
    {

        Election theElection = new Election();      // Instantiates a new object(Election)



        // Gathers the names and vote counts by calling the methods within this class
        public void MainMethod()
        {
            for (int i = 0; i < theElection.NumberOfCandidates(); i++)
            {
                PromptForString(i);
                PromptForInt(i);
            }
            WriteLine();
            WriteLine();
        }

        // Prompts users to enter the candidates name
        public void PromptForString(int i)
        {
            string name;

            Write("Please enter candidate {0}'s name:  ", i + 1);
            name = ReadLine();
            theElection.SetCandidateName(name, i);

        }


        // Prompts users to enter candidates vote count
        public void PromptForInt(int i)
        {
            string inValue;
            int voteCount;
            Write("Please enter candidate {0}'s vote count:  ", i + 1);
            inValue = ReadLine();
            if (int.TryParse(inValue, out voteCount) == false)
            {
                Write("Invalid input...  Please enter a number: ");
                inValue = ReadLine();
                voteCount = int.Parse(inValue);
            }
            WriteLine();
            theElection.SetVote(voteCount, i);
        }

        // Displays the calculation and results
        public void DisplayResults()
        {

            WriteLine("Name\t\tVotes\t\tPercentage");
            WriteLine("__________________________________________________");
            WriteLine();


            for (int i = 0; i < theElection.NumberOfCandidates(); i++)
            {
                double percentage = (double)theElection.GetCandidateVotes(i) / theElection.TotalVotes();

                string results = String.Format("{0,-18}{1,-18}{2:P}", theElection.GetCandidateName(i), theElection.GetCandidateVotes(i),
                    percentage);

                WriteLine(results);
            }
            WriteLine();
            WriteLine("The winner of the election is {0}", theElection.FindWinner());
        }
    }
}

