using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChristmasTere
{
    class ChristmasTree
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i <=n; i++)
            {
                for (int j =0; j < n-i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <=i; k++)
                {
                    Console.Write("*");
                }
                Console.Write(" | ");
                for (int k = 1; k <= i; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
