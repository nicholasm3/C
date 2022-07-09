using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miller_TicTacToeInheritance
{
    abstract class Player
    {
        private string pieces = " ";
        public string Pieces { get { return pieces; } set { pieces = value; } }

        public Player(string s) { Pieces = s; }

        public abstract int MakeMove(string[] currentBoard);
    }
}