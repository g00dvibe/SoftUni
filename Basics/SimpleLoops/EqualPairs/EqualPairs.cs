using System;

namespace EqualPairs
{
    class EqualPairs
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            double sum, diff, sum2 = 0,maxDiff = 0;

            sum = double.Parse(Console.ReadLine());
            sum += double.Parse(Console.ReadLine());

            for (int i = 2; i <=n; i++)
            {
                sum2 = double.Parse(Console.ReadLine());
                sum2 += double.Parse(Console.ReadLine());

                if (sum != sum2)
                {
                    diff = Math.Abs(sum - sum2);
                    if (maxDiff < diff)
                    {
                        maxDiff = diff;
                    }
                }
                
                    sum = sum2;
                
            }

            if (maxDiff == 0)
            {
                Console.WriteLine("Yes, value={0}", sum);
            }
            else
            {
                Console.WriteLine("No, maxdiff={0}", maxDiff);
            }
        }
    }
}
