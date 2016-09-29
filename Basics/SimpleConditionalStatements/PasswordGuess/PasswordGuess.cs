using System;

namespace PasswordGuess
{
    class PasswordGuess
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            string pass = "s3cr3t!P@ssw0rd";
            if (input == pass)
            {
                Console.WriteLine("Welcome");
            }
            else
            {
                Console.WriteLine("Wrong password!");
            }

        }
    }
}
