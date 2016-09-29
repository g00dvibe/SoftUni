using System;

namespace MaxNumber
{
    class MaxNumber
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            int max, input;

            if (n == 1)
            {
                max = int.Parse(Console.ReadLine());
            }
            else
            {
                max = int.Parse(Console.ReadLine());
                for (int i = 2; i <= n; i++)
                {
                    input = int.Parse(Console.ReadLine());
                    if (input > max)
                    {
                        max = input;
                    }
                }
            }
            Console.WriteLine(max);
        }
    }
}
