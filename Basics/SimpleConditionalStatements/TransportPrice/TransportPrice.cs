using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportPrice
{
    class TransportPrice
    {
        static void Main(string[] args)
        {
            var kilometers = double.Parse(Console.ReadLine());
            string time = Console.ReadLine();
            double taxiday = 0.70 + 0.79 * kilometers;
            double taxinight = 0.70 + 0.9 * kilometers;
            double busprice = 0.09 * kilometers;
            double trainprice = 0.06 * kilometers;

            if (kilometers < 20)
            {
                switch (time)
                {
                    case "day":
                        Console.WriteLine(taxiday);
                        break;
                    case "night":
                        Console.WriteLine(taxinight);
                        break;
                    default:
                        break;
                }
            }
            else if (kilometers >= 20 && kilometers < 100)
            {
                Console.WriteLine(Math.Round(busprice,2));
            }
            else if (kilometers >= 100)
            {
                Console.WriteLine(Math.Round(trainprice,2));
            }


            
        }
    }
}
