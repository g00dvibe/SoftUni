using System;

namespace SumSeconds
{
    class SumSeconds
    {
        static void Main(string[] args)
        {
            var time1 = int.Parse(Console.ReadLine());
            var time2 = int.Parse(Console.ReadLine());
            var time3 = int.Parse(Console.ReadLine());
            var total = time1 + time2 + time3;
            if (total <= 59)
            {
                if (total < 10)
                {
                    Console.WriteLine("0:0{0}", total);
                }
                else
                {
                    Console.WriteLine("0:{0}", total);
                }
            }
            else if(total >= 60 && total <= 119)
            {
                if (total - 60 < 10)
                {
                    Console.WriteLine("1:0{0}", total - 60);
                }
                else
                {
                    Console.WriteLine("1:{0}", total - 60);
                }
            }
            else if (total >= 120 && total <= 179)
            {
                if (total - 120 < 10)
                {
                    Console.WriteLine("2:0{0}", total - 120);
                }
                else
                {
                    Console.WriteLine("2:{0}", total - 120);
                }
            }
        }
    }
}
