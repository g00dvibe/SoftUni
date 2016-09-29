using System;

namespace OddEvenSum
{
    class OddEvenSum
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            int oddSum = 0;
            int evenSum = 0;
            
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    evenSum += int.Parse(Console.ReadLine());
                }
                else
                {
                    oddSum += int.Parse(Console.ReadLine());
                }
                
            }

            int diff = Math.Abs(oddSum - evenSum);

            if (diff == 0)
            {
                Console.WriteLine("Yes Sum = {0}", evenSum);
            }
            else
            {
                Console.WriteLine("No Diff = {0}", diff);
            }

        }
    }
}
