using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinNumbers
{
    class MinNumbers
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            int min, input;

            if (n == 1)
            {
                min = int.Parse(Console.ReadLine());
            }
            else
            {
                min = int.Parse(Console.ReadLine());
                for (int i = 2; i <= n; i++)
                {
                    input = int.Parse(Console.ReadLine());
                    if (input < min)
                    {
                        min = input;
                    }
                }
            }
            Console.WriteLine(min);
        }
    }
}
