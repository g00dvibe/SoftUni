using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeComissions
{
    class TradeComissions
    {
        static void Main(string[] args)
        {
            var city = Console.ReadLine().ToLower();
            var sale = double.Parse(Console.ReadLine());
            var comission = -1.00;

            switch (city)
            {
                case "sofia":
                    if (0 <= sale && sale <= 500)
                    {
                        comission = 0.05;
                    }
                    else if (500 <= sale && sale <= 1000)
                    {
                        comission = 0.07;
                    }
                    else if (1000 <= sale && sale <= 10000)
                    {
                        comission = 0.08;
                    }
                    else if (10000 <= sale )
                    {
                        comission = 0.12;
                    }
                    break;
                case "varna":
                    if (0 <= sale && sale <= 500)
                    {
                        comission = 0.045;
                    }
                    else if (500 <= sale && sale <= 1000)
                    {
                        comission = 0.075;
                    }
                    else if (1000 <= sale && sale <= 10000)
                    {
                        comission = 0.10;
                    }
                    else if (10000 <= sale)
                    {
                        comission = 0.13;
                    }
                    break;
                case "plovdiv":
                    if (0 <= sale && sale <= 500)
                    {
                        comission = 0.055;
                    }
                    else if (500 <= sale && sale <= 1000)
                    {
                        comission = 0.08;
                    }
                    else if (1000 <= sale && sale <= 10000)
                    {
                        comission = 0.12;
                    }
                    else if (10000 <= sale)
                    {
                        comission = 0.145;
                    }
                    break;
                default:
                    Console.WriteLine("error");
                    Environment.Exit(0);
                    break;

            }
            if (comission < 0)
            {
                Console.WriteLine("error");
            }
            else
            {
                Console.WriteLine("{0:f2}", sale * comission);
            }
        }
    }
}
