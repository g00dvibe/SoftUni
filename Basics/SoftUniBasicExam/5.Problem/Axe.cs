using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Problem
{
    class Axe
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var something = 0;
            var sekire = 0;
            //upper side
            for (int i = 1; i <= n; i++)
            {
                Console.Write(new string('-', (n * 3)));
                Console.Write('*');
                if (i < n)
                {
                    Console.Write(new string('-', i - 1));
                }
                else
                {
                    Console.Write(new string('-', n - 1));
                }

                Console.Write('*');
                Console.WriteLine(new string('-', (n * 2) - i - 1));
            }
            //mid

            for (int i = 1; i <= n / 2; i++)
            {
                Console.Write(new string('*', (n * 3)));
                Console.Write('*');
                Console.Write(new string('-', n - 1));
                Console.Write('*');
                Console.WriteLine(new string('-', (n - 1)));
            }
            //bottom
            for (int i = 1; i <= (n / 2)-1; i++)
            {
                Console.Write(new string('-', (n * 3) - i +1));
                Console.Write('*');
                Console.Write(new string('-', n + i +sekire -2));
                Console.Write("*");
                Console.WriteLine(new string('-', (n - sekire-1)));
                sekire++; 
                something ++;
            }
            //last one
            Console.WriteLine("{0}{1}{2}", new string('-', (n * 3) - something), new string('*', (n + something + sekire +1)), new string('-', (n - something-1)));

        }
    }
}
