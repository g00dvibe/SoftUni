using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoolPipes
{
    class PoolPipes
    {
        static void Main(string[] args)
        {
            var poolsize = double.Parse(Console.ReadLine());
            var pipe1 = double.Parse(Console.ReadLine());
            var pipe2 = double.Parse(Console.ReadLine());
            var hours = double.Parse(Console.ReadLine());
            var watertotal = pipe1 * hours + pipe2 * hours;
            var p1percent = Math.Round((pipe1 * hours) / watertotal * 100);
            var p2percent = Math.Round((pipe2 * hours) / watertotal * 100);
            var poolpercent = Math.Round((watertotal / poolsize) * 100);
            var overflow = 0.0;
            if (watertotal > poolsize)
            {
                overflow = watertotal - poolsize;
            }

            if (poolpercent < 100)
            {
                Console.WriteLine("The pool is {0}% full. Pipe 1: {1}%. Pipe 2: {2}%.",poolpercent,p1percent,p2percent);
            }                   //програмата прави точен сбор (до 100%) от 2те тръби, няма загуба на проценти.
            else
            {
                Console.WriteLine("For {0} hours the pool overflows with {1} liters.",hours, overflow);
            }
            Console.ReadLine();
        }
    }
}
