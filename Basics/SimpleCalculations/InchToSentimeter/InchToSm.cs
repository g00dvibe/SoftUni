using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InchToSentimeter
{
    class InchToSm
    {
        static void Main(string[] args)
        {
            var inches = double.Parse(Console.ReadLine());
            var centimeters = inches * 2.54;
            Console.WriteLine("Centimeters = {0}", centimeters);
            Console.ReadLine();
        }
    }
}
