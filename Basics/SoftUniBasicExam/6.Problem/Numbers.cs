using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Problem
{
    class Numbers
    {
        static void Main(string[] args)
        {
            var input = int.Parse(Console.ReadLine());
            int number = input;

            string expression = number.ToString();
            byte[] refract = expression.ToCharArray().Select(c => byte.Parse(c.ToString())).ToArray();

            int num1 = refract[0];
            int num2 = refract[1];
            int num3 = refract[2];

            int row = num1 + num2;
            int col = num1 + num3;

            for (int i = 1; i <= row; i++)
            {
                for (int j = 1; j <= col; j++)
                {
                    if (number % 5 == 0)
                    {
                        number -= num1;
                        Console.Write(number + " ");
                    }
                    else if (number % 3 == 0)
                    {
                        number -= num2;
                        Console.Write(number + " ");
                    }
                    else
                    {
                        number += num3;
                        Console.Write(number + " ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
