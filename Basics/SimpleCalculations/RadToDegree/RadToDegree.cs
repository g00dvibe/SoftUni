using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadToDegree
{
    class RadToDegree
    {
        static void Main(string[] args)
        {
            var rad = double.Parse(Console.ReadLine());
            var degrees = Math.Round(rad * 180 / Math.PI);
            Console.WriteLine(degrees);
        }
    }
}
