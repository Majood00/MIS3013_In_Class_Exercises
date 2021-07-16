using System;

namespace Loops_Exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What # do you want to count down from?");
            int startingPoint;

            if (int.TryParse(Console.ReadLine(), out startingPoint) == false)
            {
                Console.WriteLine("Sorry, that is invalid. Goodbye.");
                Environment.Exit(0);
            }

            for (int i = startingPoint; i >= 0; i--)
            {
                Console.WriteLine(i);
            }
        }
    }
}
