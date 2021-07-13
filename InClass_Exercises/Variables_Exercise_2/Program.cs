using System;

namespace Variables_Exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a lower-bound number.");
            string response = Console.ReadLine();
            int lower = Convert.ToInt32(response);

            Console.WriteLine("Please enter an upper-bound number.");
            string response1 = Console.ReadLine();
            int upper = Convert.ToInt32(response1);

            Random rand = new Random();
            int number = rand.Next(lower, upper);

            Console.WriteLine(number.ToString("n0"));
        }
    }
}
