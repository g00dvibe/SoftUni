﻿using System;

namespace SumNumbers
{
    class SumNumbers
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i =1; i <=n; i++)
            {
                sum = sum + int.Parse(Console.ReadLine());
            }
            Console.WriteLine(sum);
        }
    }
}
