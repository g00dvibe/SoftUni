using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Problem
{
    class HotelMotel
    {
        static void Main(string[] args)
        {
            var month = Console.ReadLine();
            var stayDuration = int.Parse(Console.ReadLine());
            double priceFlat, priceStudio, stayTotal;

            if (month == "May" || month == "October")
            {
                priceFlat = stayDuration * 65.00;
                priceStudio = stayDuration * 50.00;
                if (stayDuration > 7 && stayDuration < 14)
                {
                    priceStudio = priceStudio - priceStudio * 0.05;
                }
                if (stayDuration > 14)
                {
                    priceStudio = priceStudio - priceStudio * 0.30;
                }
                if (stayDuration > 14)
                {
                    priceFlat = priceFlat - priceFlat * 0.10;
                }
                Console.WriteLine("Apartment: {0:f2} lv.", priceFlat);
                Console.WriteLine("Studio: {0:f2} lv.", priceStudio);
            }
            if (month == "June" || month == "September")
            {
                priceFlat = stayDuration * 68.70;
                priceStudio = stayDuration * 75.20;
                if (stayDuration > 14)
                {
                    priceStudio = priceStudio - priceStudio * 0.20;
                }
                if (stayDuration > 14)
                {
                    priceFlat = priceFlat - priceFlat * 0.10;
                }
                Console.WriteLine("Apartment: {0:f2} lv.", priceFlat);
                Console.WriteLine("Studio: {0:f2} lv.", priceStudio);
            }
            if (month == "July" || month == "August")
            {
                priceFlat = stayDuration * 77.00;
                priceStudio = stayDuration * 76.00;
                if (stayDuration > 14)
                {
                    priceFlat = priceFlat - priceFlat * 0.10;
                }
                Console.WriteLine("Apartment: {0:f2} lv.", priceFlat);
                Console.WriteLine("Studio: {0:f2} lv.", priceStudio);
            }

        }
    }
}
