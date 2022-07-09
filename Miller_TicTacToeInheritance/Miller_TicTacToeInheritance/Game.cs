using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miller_TicTacToeInheritance
{
    public enum playerType { X, O }

    class Game
    {
        

        private string[] gameArray = { "7", "8", "9", "4", "5", "6", "1", "2", "3" };

        Board gameBoard = new Board();

        private playerType gamePlayer = playerType.X;

        private Player playerX = new HumanPlayer("X");

        private Player playerO = new ComputerPlayer("O");

        public void AnnounceWinner(playerType player)
        {
            string piece = "";

            if (player == playerType.X)
                piece = "X";
            else if (player == playerType.O)
                piece = "O";

            Console.SetCursorPosition(10, 18);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Player " + piece + " won!");
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(0, 0);
        }


        public void DisplayBoardGrid(string[] b)
        {
            Console.SetCursorPosition(15, 5);
            Console.Write(" " + b[0] + " | " + b[1] + " | " + b[2]);
            Console.SetCursorPosition(15, 6);
            Console.Write("----------");
            Console.SetCursorPosition(15, 7);
            Console.Write(" " + b[3] + " | " + b[4] + " | " + b[5]);
            Console.SetCursorPosition(15, 8);
            Console.Write("----------");
            Console.SetCursorPosition(15, 9);
            Console.Write(" " + b[6] + " | " + b[7] + " | " + b[8]);
            Console.SetCursorPosition(0, 0);
        }

        public void DisplayGrid(playerType player)
        {
            string piece = "";

            if (player == playerType.X)
                piece = "X";
            else if (player == playerType.O)
                piece = "O";

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(12, 3);
            Console.Write("TIC TAC TOE GAME!");
            Console.SetCursorPosition(10, 15);
            Console.Write("Player " + piece + "'s turn!");
            Console.SetCursorPosition(10, 16);
            Console.Write("Press a number shown above to occupy that space!");
            Console.SetCursorPosition(0, 0);
        }

        public void DisplayWelcome()
        {
            Console.WriteLine("\n\n\nReady to have a rousing game of Tic Tac toe?  The object");
            Console.WriteLine("of the game is to get three of your pieces either across, up and down,");
            Console.WriteLine("or diagonally.  If you do, before your opponent, you win the game!");
            Console.WriteLine("\n\nHit any key when you are ready to begin");
            Console.ReadKey();
        }
    


        public playerType IsPlaying(playerType pt)
        {
        if (pt == playerType.X)
            pt = playerType.O;
        else
            pt = playerType.X;

        return pt;
        }


        public bool IsTie(bool full, bool x, bool o)
        {
        bool isTie = false;

        if (full && !x && !o)
        {
            isTie = true;
            Console.SetCursorPosition(10, 18);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("The game is a tie!");
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(0, 0);
        }

        return isTie;
    }

    public void Play()
        {
            string[] resetGameArray = { "7", "8", "9", "4", "5", "6", "1", "2", "3" };
            bool runGame = true;
            int move = 0;

            DisplayWelcome();

            do
            {
                DisplayGrid(gamePlayer);
                DisplayBoardGrid(gameArray);

                switch (gamePlayer)
                {
                    case playerType.X:
                        move = playerX.MakeMove(gameArray);
                        if (move >= 0)
                        {
                            gameArray[move] = "X";
                            gamePlayer = IsPlaying(playerType.X);
                        }
                        break;

                    case playerType.O:
                        move = playerO.MakeMove(gameArray);
                        if (move >= 0)
                        {
                            gameArray[move] = "O";
                            gamePlayer = IsPlaying(playerType.O);
                        }
                        break;

                    default:
                        break;
                }

                // Player X wins.
                if (gameBoard.IsWinner(gameArray, playerType.X))
                {
                    AnnounceWinner(playerType.X);
                    runGame = false;
                }
                // Player Y wins.
                else if (gameBoard.IsWinner(gameArray, playerType.O))
                {
                    AnnounceWinner(playerType.O);
                    runGame = false;
                }
                // Tie.
                else if (IsTie(gameBoard.IsFull(gameArray),
                    gameBoard.IsWinner(gameArray, gamePlayer),
                    gameBoard.IsWinner(gameArray, gamePlayer)))
                    runGame = false;

                // Resets within the method to prevent recursion.  When the
                // method finishes, so does the app.
                if (!runGame)
                {
                    DisplayBoardGrid(gameArray);
                    gameArray = resetGameArray;
                    gamePlayer = playerType.X;
                    runGame = PlayAgain();
                }

            } while (runGame);
        }

        private bool PlayAgain()
        {
            bool playAgain = true;
            bool inMenu = true;
            ConsoleKeyInfo key = new ConsoleKeyInfo();

            Console.SetCursorPosition(10, 20);
            Console.Write("Play again?(y/n)");
            Console.SetCursorPosition(0, 0);

            do
            {
                key = Console.ReadKey(true);
                switch (key.Key)
                {
                    case ConsoleKey.Y:
                        playAgain = true;
                        inMenu = false;
                        break;

                    case ConsoleKey.N:
                        playAgain = false;
                        inMenu = false;
                        break;

                    default:
                        break;
                }
            } while (inMenu);

            return playAgain;
        }


    }
}