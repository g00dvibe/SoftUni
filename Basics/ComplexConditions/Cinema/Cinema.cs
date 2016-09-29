using System;

namespace Cinema
{
    class Cinema
    {
        static void Main(string[] args)
        {
            var type = Console.ReadLine().ToLower();
            var rows = double.Parse(Console.ReadLine());
            var columns = double.Parse(Console.ReadLine());
            var size = rows * columns;
            double profit;

            switch (type)
            {
                case "premiere":
                    profit = size * 12.00;
                    Console.WriteLine("{0:f2} leva", profit);
                    break;
                case "normal":
                    profit = size * 7.50;
                    Console.WriteLine("{0:f2} leva", profit);
                    break;
                case "discount":
                    profit = size * 5.00;
                    Console.WriteLine("{0:f2} leva", profit);
                    break;

            }
        }
    }
}
