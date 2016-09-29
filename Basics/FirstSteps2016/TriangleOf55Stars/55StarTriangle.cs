using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleOf55Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i=1; i < 11; i++)
            {
                for (int u=1; u<= i; u++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
