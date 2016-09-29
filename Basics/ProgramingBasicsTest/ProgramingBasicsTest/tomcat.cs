using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tomcat
{
    class tomcat
    {
        static void Main(string[] args)
        {
            double playnorm = 30000;
            double leisuredays = double.Parse(Console.ReadLine());
            double workdays = 365 - leisuredays;
            double playtime = (workdays * 63) + (leisuredays * 127);

            var difference = playtime - playnorm;
            var hours = Math.Abs(difference / 60);
            var minutes = Math.Abs(difference % 60);

            if (playtime > playnorm)
            {
                Console.WriteLine("Tom will run away");
                Console.WriteLine("{ 0} hours and { 1} minutes more for play", hours, minutes);
            }
            else
            {
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine("{0} hours and {1} minutes less for play", hours, minutes);
            }
        }
    }
}
