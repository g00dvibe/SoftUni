using System;
using System.Globalization;

namespace _1000days
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = "dd-MM-yyyy";
            CultureInfo provider = CultureInfo.InvariantCulture;
            string date = Console.ReadLine();
            DateTime time = DateTime.ParseExact(date, pattern, null, DateTimeStyles.None);
            time = time.AddDays(999);            
            Console.WriteLine(time.ToString(pattern));
        }
    }
}
