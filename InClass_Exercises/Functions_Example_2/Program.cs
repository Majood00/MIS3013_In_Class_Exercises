using System;
using System.Collections.Generic;

namespace Functions_Example_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> mis3013Grades = new List<double>();
            List<double> mis3033Grades = new List<double>();

            mis3013Grades = PopulateDataIntoList(50);
            mis3033Grades = PopulateDataIntoList(90);

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("MIS 3013 Grades");
            OutPutLetterGrade(mis3013Grades);

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("MIS 3033 Grades");
            OutPutLetterGrade(mis3033Grades);

            Random rand = new Random();
            int randomIndexOfGrade = rand.Next(0, mis3013Grades.Count);
            double randomGrade = mis3013Grades[randomIndexOfGrade];
            char letter = ConvertGradeToLetterGrade(randomGrade);

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"\n{randomGrade} is a {letter}.");
            Console.ForegroundColor = ConsoleColor.White;

        }

        static List<double> PopulateDataIntoList(int number)
        {
            List<double> values = new List<double>();
            Random rand = new Random();

            for (int i = 0; i < number; i++)
            {
                values.Add(rand.NextDouble());
            }

            return values;
        }

        static void OutPutLetterGrade(List<double> values)
        {
            foreach (double value in values)
            {
                char letter = ConvertGradeToLetterGrade(value);
                Console.WriteLine($"{value.ToString("p")} is a(n) {letter}");
            }
        }

        static char ConvertGradeToLetterGrade(double value)
        {
            char letter;
            if (value >= 0.9)
            {
                letter = 'A';
            }
            else if (value >= 0.8)
            {
                letter = 'B';
            }
            else if (value >= 0.7)
            {
                letter = 'C';
            }
            else if (value >= 0.6)
            {
                letter = 'D';
            }
            else
            {
                letter = 'F';
            }

            return letter;
        }
    }
}
