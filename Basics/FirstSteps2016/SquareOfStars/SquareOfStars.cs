﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareOfStars
{
    class SquareOfStars
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if (j == 1 || j == n || i==0 || i== n-1)
                    {
                        Console.Write("*");
                    }

                    else
                    {
                        Console.Write(" ");
                    }
                    
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
