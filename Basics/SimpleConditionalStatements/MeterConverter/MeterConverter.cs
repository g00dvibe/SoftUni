using System;

namespace mConverter
{
    class mConverter
    {
        static void Main(string[] args)
        {
            var value = double.Parse(Console.ReadLine());
            var type = Console.ReadLine();
            var output = Console.ReadLine();
            double m = 1.0;
            double mm = 1000.0;
            double cm = 100.0;
            double mi = 0.000621371192;
            double inch = 39.3700787;
            double km = 0.001;
            double ft = 3.2808399;
            double yd = 1.0936133; 

            switch (type)
            {
                case "m":
                    break;
                case "mm":
                    value = value / mm;
                    break;
                case "cm":
                    value = value / cm;
                    break;
                case "mi":
                    value = value / mi;
                    break;
                case "in":
                    value = value / inch;
                    break;
                case "km":
                    value = value / km;
                    break;
                case "ft":
                    value = value / ft;
                    break;
                case "yd":
                    value = value / yd;
                    break;
                default:
                    break;
            }
            switch (output)
            {
                case "m":
                    value = value * m;
                    break;
                case "mm":
                    value = value * mm;
                    break;
                case "cm":
                    value = value * cm;
                    break;
                case "mi":
                    value = value * mi;
                    break;
                case "in":
                    value = value * inch;
                    break;
                case "km":
                    value = value * km;
                    break;
                case "ft":
                    value = value * ft;
                    break;
                case "yd":
                    value = value * yd;
                    break;
                default:
                    break;
            }
            Console.WriteLine(value + " " + output);
        }
    }
}
