using System;
using System.Text;

namespace PII_Game_Of_Life
{
    public class ImprimirTablero
    {
        public static void PrintBoard(Tablero b){
            int width = b.Data.GetLength(0);  // variabe que representa el ancho del tablero
            int height = b.Data.GetLength(1); // variabe que representa altura del tablero
            while (true)
            {
                Console.Clear();
                StringBuilder s = new StringBuilder();
                for (int y = 0; y<height;y++)
                {
                    for (int x = 0; x<width; x++)
                    {
                        if(b.Data[x,y])
                        {
                            s.Append("|X|");
                        }
                        else
                        {
                            s.Append("___");
                        }
                    }
                    s.Append("\n");
                }
                Console.WriteLine(s.ToString());
            }
        }
    }
}
