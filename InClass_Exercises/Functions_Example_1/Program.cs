using System;

namespace Functions_Example_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Please enter your exam 1 score");
            string input = Console.ReadLine();
            double exam1;

            while (double.TryParse(input, out exam1) == false)
            {
                Console.WriteLine("Please enter a valid score");
                input = Console.ReadLine();
            }

            Console.WriteLine("Please enter your exam 2 score");
            input = Console.ReadLine();
            double exam2;

            while (double.TryParse(input, out exam2) == false)
            {
                Console.WriteLine("Please enter a valid score");
                input = Console.ReadLine();
            }*/
            string msg = "Please enter a valid exam grade";
            double exam1 = GetDoubleFromUser("Please enter your Exam 1 score", msg);
            double exam2 = GetDoubleFromUser("Please enter your Exam 2 score", msg);

            Console.WriteLine($"You got a {exam1.ToString("N2")} on exam 1. Which is an :");
            ConvertScoreToLetterGrade(exam1);
            Console.WriteLine($"You got a {exam2.ToString("N")} on exam 2.  Which is an :");
            ConvertScoreToLetterGrade(exam2);
        }

        static double GetDoubleFromUser (string msg, string repromptMsg)
        {
            Console.WriteLine(msg);
            string input = Console.ReadLine();
            double score;

            while (double.TryParse(input, out score) == false)
            {
                Console.WriteLine(repromptMsg);
                input = Console.ReadLine();
            }
            return score;
        }
        static void ConvertScoreToLetterGrade(double score)
        {
            if (score >= 90)
            {
                Console.WriteLine("A");
            }
            else if (score >= 80)
            {
                Console.WriteLine("B");
            }
            else if (score >= 70)
            {
                Console.WriteLine("C");
            }
            else if (score >= 60)
            {
                Console.WriteLine("D");
            }
            else
            {
                Console.WriteLine("F");
            }
        }
    }
}
