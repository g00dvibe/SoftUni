using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Problem
{
    class Corporation
    {
        static void Main(string[] args)
        {
            var hours = int.Parse(Console.ReadLine());
            var days = int.Parse(Console.ReadLine());
            var overduers = int.Parse(Console.ReadLine());            

            var offtime = days * 0.1;
            var worktime = (days - offtime)*8;
            
            var totalOvertime = overduers * (days* 2);
            var totalTime = Math.Truncate((worktime + totalOvertime));
            var hoursLeft =  totalTime - hours;
            var hoursNeeded = hours - totalTime;
            if (hoursLeft >= 0)
            {
                Console.WriteLine("Yes!{0} hours left.", hoursLeft);
            }
            else
            {
                Console.WriteLine("Not enough time!{0} hours needed.", hoursNeeded);
            }
             

        }
    }
}
