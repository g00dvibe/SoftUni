using System;

namespace OddEvenPositions
{
    class OddEvenPositions
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            double input, oddMax = double.MinValue, oddMin = double.MaxValue, oddSum = 0, evenMax = double.MinValue, evenMin = double.MaxValue, evenSum = 0;

            for (int i = 1; i <= n; i++)
            {
                input = double.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    evenSum += input;
                    if (input > evenMax)
                    {
                        evenMax = input;
                    }
                    if (input < evenMin)
                    {
                        evenMin = input;
                    }
                }
                else
                {
                    oddSum += input;
                    if (input > oddMax)
                    {
                        oddMax = input;
                    }
                    if (input < oddMin)
                    {
                        oddMin = input;
                    }
                }
            }

            Console.WriteLine("OddSum={0},",oddSum);
            if (oddMin != double.MaxValue)
            {
                Console.WriteLine("OddMin={0},", oddMin);
            }
            else
            {
                Console.WriteLine("OddMin=No,");
            }
            if (oddMax != double.MinValue)
            {
                Console.WriteLine("OddMax={0},", oddMax);
            }
            else
            {
                Console.WriteLine("OddMax=No,");
            }
            
            Console.WriteLine("EvenSum={0}", evenSum);
            if (evenMin != double.MaxValue)
            {
                Console.WriteLine("EvenMin={0},", evenMin);
            }
            else
            {
                Console.WriteLine("EvenMin=No,");
            }
            if (evenMax != double.MinValue)
            {
                Console.WriteLine("EvenMax={0}", evenMax);
            }
            else
            {
                Console.WriteLine("EvenMax=No");
            }
        }
    }
}
