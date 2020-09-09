using System;

namespace PII_Game_Of_Life
{
    public class Tablero
    {
        public bool[,] Data {get;private set;}

        public Tablero(bool[,] boardData)
        {
            this.Data = boardData;
        }
        public void NextGen()
        {
            int boardWidth = this.Data.GetLength(0);
            int boardHeight = this.Data.GetLength(1);
            bool[,] cloneboard = new bool[boardWidth, boardHeight];
            for (int x = 0; x < boardWidth; x++)
            {
                for (int y = 0; y < boardHeight; y++)
                {
                    int aliveNeighbors = 0;
                    for (int i = x-1; i<=x+1;i++)
                    {
                        for (int j = y-1;j<=y+1;j++)
                        {
                            if(i>=0 && i<boardWidth && j>=0 && j < boardHeight && this.Data[i,j])
                            {
                                aliveNeighbors++;
                            }
                        }
                    }
                    if(this.Data[x,y])
                    {
                        aliveNeighbors--;
                    }
                    if (this.Data[x,y] && aliveNeighbors < 2) 
                    {
                        //Celula muere por baja población
                        cloneboard[x,y] = false; 
                    }
                    else if (this.Data[x,y] && aliveNeighbors > 3) 
                    {
                        //Celula muere por sobrepoblación
                        cloneboard[x,y] = false; 
                    }
                    else if (!this.Data[x,y] && aliveNeighbors == 3) 
                    {
                        //Celula nace por reproducción 
                        cloneboard[x,y] = true; 
                    }
                    else
                    {
                        //Celula mantiene el estado que tenía
                        cloneboard[x,y] = this.Data[x,y];
                    }
                }
            }
            this.Data = cloneboard;
            cloneboard = new bool[boardWidth, boardHeight];
        }
    }
}
