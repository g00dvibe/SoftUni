using System;

namespace Diamond
{
    class Diamond
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var stars = 1;
            if (n % 2 == 0)
            {
                stars = 2;
            }

            Console.Write(new string('-', (n - stars) / 2));
            Console.Write(new string('*', stars));
            Console.WriteLine(new string('-', (n - stars) / 2));

            for (; stars <= n - 2; stars += 2)
            {
                var outer = new string('-', (n - stars) / 2 - 1);
                var middle = new string('-', stars);
                Console.WriteLine("{0}*{1}*{0}", outer, middle);
            }
            stars -= 4;
            for (; stars >= 0; stars -= 2)
            {
                var outer = new string('-', (n - stars) / 2 - 1);
                var middle = new string('-', stars);
                Console.WriteLine("{0}*{1}*{0}", outer, middle);
            }


            if (n > 1 && n % 2 == 1)
            {

                Console.Write(new string('-', (n - 1) / 2));
                Console.Write(new string('*', 1));
                Console.WriteLine(new string('-', (n - 1) / 2));
            }




        }
    }
}
