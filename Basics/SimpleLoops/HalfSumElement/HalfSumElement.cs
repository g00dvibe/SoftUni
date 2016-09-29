using System;

namespace HalfSumElement
{
    class HalfSumElement
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            int input, biggest = 0, sum = 0; 
            
            for (int i = 1; i <= n; i++)
            {
                input = int.Parse(Console.ReadLine());
                sum += input;
                if (input > biggest)
                {
                    biggest = input;
                }
            }
            if (biggest == (sum - biggest))
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = {0}", biggest);
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine("Diff = {0}", Math.Abs(biggest - (sum - biggest)));
            }

        }
    }
}
