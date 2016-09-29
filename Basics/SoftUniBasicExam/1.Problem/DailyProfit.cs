using System;

namespace _1.Problem
{
    class DailyProfit
    {
        static void Main(string[] args)
        {

            var workdays = int.Parse(Console.ReadLine());
            double wage = double.Parse(Console.ReadLine());
            double rate = double.Parse(Console.ReadLine());

            double monthlyUSD = wage * workdays;
            double yearlyUSD = monthlyUSD * 12 + 2.5 * monthlyUSD;            
            double taxedUSD = yearlyUSD - (yearlyUSD * 0.25);            
            double clearProfitBGN = taxedUSD * rate;
            double daily = clearProfitBGN / 365;
            Console.WriteLine("{0:f2}", daily);

        }
    }
}
