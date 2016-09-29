using System;

namespace LeftRightSum
{
    class LeftRightSum
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            int leftTotal = 0;
            int rightTotal = 0;

            for (int i =1; i <= n; i++)
            {
                leftTotal += int.Parse(Console.ReadLine());
            }
            for (int i = 1; i <= n; i++)
            {
                rightTotal += int.Parse(Console.ReadLine());
            }

            var difference = Math.Abs(leftTotal - rightTotal);
           
            if (difference == 0)
            {
                Console.WriteLine("Yes, sum = {0}", rightTotal);
            }
            else
            {
                Console.WriteLine("No, diff = {0}", difference);
            }
        }
    }
}
