using System;

namespace Loops_Do
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            double sum = 0;
            string answer;

            do
            {
                Console.WriteLine("Enter your homework grade.");
                double grade;
                answer = Console.ReadLine();

                while (double.TryParse(answer, out grade) == false)
                {
                    Console.WriteLine($"{answer} is an invalid grade. Enter your homework grade.");
                    answer = Console.ReadLine();
                }

                sum += grade;

                counter++;

                Console.WriteLine("Do you have another grade to enter? yes or no?");
                answer = Console.ReadLine();
            } while (answer == "yes");

            double average = sum / counter;

            average /= 100;

            Console.WriteLine($"Your average score on homework is {average.ToString("P2")}!");

        }
    }
}
