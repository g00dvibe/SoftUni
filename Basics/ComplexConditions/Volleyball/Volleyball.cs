using System;

namespace Volleyball
{
    class Volleyball
    {
        static void Main(string[] args)
        {
            var year = Console.ReadLine().ToLower();
            var holidays = double.Parse(Console.ReadLine());
            var homecomings = double.Parse(Console.ReadLine());
            var sofiaweekends = 48 - homecomings;

            var sofiaplaytime = sofiaweekends * (3.0 / 4);
            var homeplays = homecomings;
            var holidayplays = holidays * (2.0 / 3);
            var totalplaytime = homeplays + sofiaplaytime + holidayplays;

            if (year == "leap")
            {
                totalplaytime = totalplaytime + (totalplaytime * 0.15);
            }

            Console.WriteLine(Math.Truncate(totalplaytime));
        }
    }
}
