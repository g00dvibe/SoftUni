using System;

namespace RhombusOfStars
{
    class Rhombus
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            // top side
            for (int row = 1; row <= n; row++)
            {
                 for (int col = 1; col <= (n-row); col++)
                 {
                    Console.Write(" ");
                 }
                 Console.Write("*");
                for (int stars = 1; stars <= (row-1); stars++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();               
            }
            //bottom
            for (int row = n-1; row >= 1; row--)
            {
                for (int col = 1; col <= (n - row); col++)
                {
                    Console.Write(" ");
                }
                Console.Write("*");
                for (int stars = 1; stars <= (row - 1); stars++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }


        }
    }
}
