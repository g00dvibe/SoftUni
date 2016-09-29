using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTimeForExam
{
    class OnTimeForExam
    {
        static void Main(string[] args)
        {
            var examHour = int.Parse(Console.ReadLine());
            var examMinutes = int.Parse(Console.ReadLine());
            var arrivalHour = int.Parse(Console.ReadLine());
            var arrivalMinute = int.Parse(Console.ReadLine());
            
            if (examHour == arrivalHour && examMinutes == arrivalMinute)
            {
                Console.WriteLine("On time");
                Environment.Exit(0);
            }

            if (examHour < arrivalHour || examMinutes < arrivalMinute)


        }
    }
}
