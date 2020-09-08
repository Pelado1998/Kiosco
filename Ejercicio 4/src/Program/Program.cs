using System;

namespace PII_Game_Of_Life
{
    class Program
    {
        static void Main(string[] args)
        {
            bool[,] board=Init("path");
            PrintBoard(board);
            board = NextGen(board);
            Thread.Sleep(300);
            Tablero tablero = new Tablero(board);
        }
    }
}
