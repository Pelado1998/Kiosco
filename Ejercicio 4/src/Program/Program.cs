using System;
using System.Threading;

namespace PII_Game_Of_Life
{
    class Program
    {
        static void Main(string[] args)
        {
            bool[,] boardData=EstadoInicial.Init("..\\..\\assets\\board.txt");
            Tablero board = new Tablero(boardData);
            while(true)
            {
                ImprimirTablero.PrintBoard(board);
                board.NextGen();
                Thread.Sleep(500);
            }
        }
    }
}
