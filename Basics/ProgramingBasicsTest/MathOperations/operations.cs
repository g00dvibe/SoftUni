using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathOperations
{
    class operations
    {
        static void Main(string[] args)
        {
            double n1 = double.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine());
            string symbol = (Console.ReadLine());



            if (symbol == "+")
            {
                Console.Write($"{n1} + {n2} = {n1 + n2} - ");
                Console.WriteLine((n1 + n2) % 2 == 0 ? "even" : "odd");
            }
            else if (symbol == "-")
            {
                Console.Write($"{n1} - {n2} = {n1 - n2} - ");
                Console.WriteLine((n1 - n2) % 2 == 0 ? "even" : "odd");
            }
            else if (symbol == "*")
            {
                Console.Write($"{n1} * {n2} = {n1 * n2} - ");
                Console.WriteLine((n1 * n2) % 2 == 0 ? "even" : "odd");
            }
            else if (symbol == "/")
            {
                Console.WriteLine(n2 == 0
                    ? $"Cannot divide {n1} by zero"
                    : $"{n1} / {n2} = {(double)n1 / n2}");
            }
            else if (symbol == "%")
            {
                Console.WriteLine(n2 == 0
                    ? $"Cannot divide {n1} by zero"
                    : $"{n1} % {n2} = {n1 % n2}");
            }

            Console.ReadLine();
        }
    }
}
