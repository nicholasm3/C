using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miller_TicTacToeInheritance
{
    class Program
    {
            static void Main(string[] args)
            {
                Game tttGame = new Game();
                Info info = new Info();

                info.DisplayInfo("Assignment 8 - Tic Tac Toe Inheritance");

                tttGame.Play();
            }
        }
    }