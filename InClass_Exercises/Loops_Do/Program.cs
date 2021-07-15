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
                double grade = Convert.ToDouble(Console.ReadLine()) / 100;

                sum += grade;

                counter++;
                Console.WriteLine("Do you have another grade to enter? yes or no?");
                answer = Console.ReadLine();
            
            } while (answer == "yes");

            double average = sum / counter;

            Console.WriteLine($"Your average score on homework is {average.ToString("P2")}");

        }
    }
}
