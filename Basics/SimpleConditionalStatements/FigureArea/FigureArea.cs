using System;

namespace FigureArea
{
    class FigureArea
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();
            double a, b, area;
            switch (figure)
            {
                case "square":
                    a = double.Parse(Console.ReadLine());
                    area = a * a;
                    Console.WriteLine(Math.Round(area, 3));
                    break;
                case "rectangle":
                    a = double.Parse(Console.ReadLine());
                    b = double.Parse(Console.ReadLine());
                    area = a * b;
                    Console.WriteLine(Math.Round(area, 3));
                    break;
                case "circle":
                    a = double.Parse(Console.ReadLine());
                    area = Math.PI * a * a;
                    Console.WriteLine(Math.Round(area, 3));
                    break;
                case "triangle":
                    a = double.Parse(Console.ReadLine());
                    b = double.Parse(Console.ReadLine());
                    area = a * b /2;
                    Console.WriteLine(Math.Round(area, 3));
                    break;
                default:
                    break;
            }
        }
    }
}
