using System;

namespace SquareFrame
{
    class SquareFrame
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if ((i == 1 && j == 1) || (i == 1 && j == n) || (i == n && j ==1) || (i == n && j == n))
                    {
                        Console.Write("+ ");
                    }
                    else if ((i != 1 && j == 1 && i != n) || (i != 1 && j == n && i != n))
                    {
                        Console.Write("| ");
                    }
                    else if (j != 1 && j != n)
                    {
                        Console.Write("- ");
                    }

                }
                Console.WriteLine();
            }
        }
    }
}
