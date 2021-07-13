using System;

namespace Variables_Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my application! What is your name?");
            string name = Console.ReadLine();

            Console.WriteLine(name + ", what is your monthly income?");
            string response = Console.ReadLine();
            double monthlyIncome = Convert.ToDouble(response);

            Console.WriteLine(name + ", what is your monthly expenses?");
            double monthlyExpense = Convert.ToDouble(Console.ReadLine());

            double netIncome = monthlyIncome - monthlyExpense;

            Console.WriteLine($"The difference between your income and expenses is {netIncome.ToString("c2")}.");

        }
    }
}
