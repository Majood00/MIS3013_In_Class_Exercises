using System;

namespace Flow_Control_Exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int number = rand.Next(1, 101);

            Console.WriteLine(number);

            if (number % 3 == 0 && number % 5 == 0)
            {
                Console.WriteLine("Fizz Buzz");
            }

            else if (number % 3 == 0) 
            {
                Console.WriteLine("Fizz");
            }

            else if (number % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }

            else
            {
                Console.WriteLine(number);
            }
        }
    }
}
