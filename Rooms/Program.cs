using System;

namespace Rooms
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
    public class Room
    {
        
       public void Kamer(int x, int y)
        {
            int[][] coordinaten = new int[10][];
            for (int i = 2; i < coordinaten.Length; i++)
            {
                coordinaten[i] = new int[4];

                for (int coordI = 2; coordI < coordinaten[i].Length; coordI++)
                {
                    coordinaten[i][coordI] = 2;
                }
            }
            
        }
    }
}
