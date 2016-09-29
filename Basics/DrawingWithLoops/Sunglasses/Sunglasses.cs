using System;

namespace Sunglasses
{
    class Sunglasses
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            for (int row = 1; row <= n; row++)
            {
                if (row == 1 || row == n)
                {
                    for (int i = 1; i <= 2 * n; i++)
                    {
                        Console.Write("*");
                    }
                    for (int i = 1; i <= n; i++)
                    {
                        Console.Write(" ");
                    }
                    for (int i = 1; i <= 2 * n; i++)
                    {
                        Console.Write("*");
                    }
                }
                else
                {
                    Console.Write("*");
                    for (int j = 1; j<= (2 * n - 2); j++)
                    {
                        Console.Write("/");
                    }
                    Console.Write("*");
                    if (row == ((n - 1) / 2 +1))
                    { 
                        for (int i = 1; i <= n; i++)
                        {
                            Console.Write("|");
                        }
                    }
                    else
                    {
                        for (int i = 1; i <= n; i++)
                        {
                            Console.Write(" ");
                        }
                    }
                    Console.Write("*");
                    for (int j = 1; j <= (2 * n - 2); j++)
                    {
                        Console.Write("/");
                    }
                    Console.Write("*");
                }
                Console.WriteLine();
            }

        }
    }
}
