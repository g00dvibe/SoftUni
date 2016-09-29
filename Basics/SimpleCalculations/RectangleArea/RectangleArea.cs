using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleArea
{
    class RectangleArea
    {
        static void Main(string[] args)
        {
            var x1 = double.Parse(Console.ReadLine());
            var y1 = double.Parse(Console.ReadLine());
            var x2 = double.Parse(Console.ReadLine());
            var y2 = double.Parse(Console.ReadLine());
            double height, lenght;
            if (y1 > y2){
                height = y1 - y2;
            }
            else
            {
                height = y2 - y1;
            }
            if (x2 < x1)
            {
                lenght = x1 - x2;
            }
            else
            {
                lenght = x2 - x1;
            }

            var area = height * lenght;
            var perimeter = 2 * (height + lenght);

            Console.WriteLine(area);

            Console.WriteLine(perimeter);
            Console.ReadLine();
        }
    }
}
