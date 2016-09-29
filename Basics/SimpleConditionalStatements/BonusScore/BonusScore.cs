using System;

namespace BonusScore
{
    class BonusScore
    {
        static void Main()
        {
            var score = double.Parse(Console.ReadLine());
            var bonus = 0.0;

            if (score < 100)
            {
                bonus = bonus + 5;
            }

            else if (1000 > score && score > 100)
            {
                bonus = bonus + score * 0.2;
            }

            else if (score > 1000)
            { 
                bonus = bonus + score * 0.1;
            }

            var even = (score % 2 == 0);
            if (even == true)
            {
                bonus++;
            }
            else if (score % 5 == 0 && score % 10 != 0)
            {
                bonus = bonus + 2;
            }

            Console.WriteLine(bonus);
            Console.WriteLine(score + bonus);
        }
    } 
}
