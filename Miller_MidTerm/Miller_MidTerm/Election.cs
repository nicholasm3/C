using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace Miller_MidTerm
{
    class Election
    {

        const int NUMCANDIDATES = 5;                                   // Constant - Holds the total number of candidates
        private string[] candidateNames = new string[NUMCANDIDATES];   // String array - Holds candidate names
        private int[] votes = new int[NUMCANDIDATES];                  // Int array - Holds candidate votes


        // Returns the number of candidates in the array
        public int NumberOfCandidates()
           {
             int numCandidates = candidateNames.Length;

             return numCandidates;
           }

            // Sets candidate name
        public void SetCandidateName(string name, int i)
            {
                candidateNames[i] = name;
            }

            // Set method for candidates vote count
        public void SetVote(int voteAmount, int i)
            {
                votes[i] = voteAmount;
            }

            // Set method to get candidates name
        public string GetCandidateName(int i)
            {
                return candidateNames[i];
            }

            // Gets candidates vote
        public int GetCandidateVotes(int i)
            {
                return votes[i];
            }

            

        // Method that takes in the array of vote totals and loops through to find the highest valued
        // Index number stored in a local variable
        public string FindWinner()
            {
                int highestVotes = votes[0];
                string candidate = "";

                for (int i = 1; i < NUMCANDIDATES; i++)
                {
                    if (highestVotes < votes[i])
                    {
                        highestVotes = votes[i];
                        candidate = candidateNames[i];
                    }
                }
                return candidate;
            }

        // Takes vote array and adds them together
        public int TotalVotes()
            {
                int total = 0;

                for (int i = 0; i < votes.Length; i++)
                {
                    total += votes[i];
                }

                return total;
            }
        }
    }
