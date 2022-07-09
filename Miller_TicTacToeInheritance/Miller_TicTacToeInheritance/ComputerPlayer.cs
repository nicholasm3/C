using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miller_TicTacToeInheritance
{
    class ComputerPlayer : Player
    {
        public ComputerPlayer(string s) : base(s) { }

        public override int MakeMove(string[] currentBoard)
        {
            Board board = new Board();
            int move = -1;
            // Number list reversed so that the last picked is the first desired.
            int[] moveNext = { 7, 5, 3, 1, 8, 6, 2, 0, 4 };

            
            string[] tempBoard = new string[currentBoard.Length];
            for (int i = 0; i < currentBoard.Length; i++)
            {
                tempBoard[i] = currentBoard[i];
            }

            // Player Winning Move
            for (int i = 0; i < 9; i++)
            {
                if (currentBoard[i] != "X" && currentBoard[i] != "O")
                {
                    tempBoard[i] = "X";
                    if (board.IsWinner(tempBoard, playerType.X))
                        move = i;
                    for (int i2 = 0; i2 < currentBoard.Length; i2++)
                    {
                        tempBoard[i2] = currentBoard[i2];
                    }
                }
            }

            // Computer Winning Move
            // Will over-write a Player Winning Move if valid.
            for (int i = 0; i < 9; i++)
            {
                if (currentBoard[i] != "X" && currentBoard[i] != "O")
                {
                    tempBoard[i] = "O";
                    if (board.IsWinner(tempBoard, playerType.O))
                        move = i;
                    for (int i2 = 0; i2 < currentBoard.Length; i2++)
                    {
                        tempBoard[i2] = currentBoard[i2];
                    }
                }
            }

            // If neither are winning moves, move in the given order.
            if (move < 0)
            {
                for (int i = 0; i < moveNext.Length; i++)
                {
                    if (currentBoard[i] != "X" && currentBoard[i] != "O")
                        move = i;
                }
            }

            return move;
        }
    }
}