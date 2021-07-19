using System;

namespace Enum_Example_1
{
    class Program
    {
        enum Coin : int
        {
            HEADS = 1,
            TAILS = 2
        }
        static void Main(string[] args)
        {
            Coin x = Coin.TAILS;

            switch (x)
            {
                case Coin.HEADS:
                    break;
                case Coin.TAILS:
                    break;
                default:
                    break;
            }

            Random rand = new Random();
            int number = rand.Next(1, 3);

            Console.BackgroundColor = (ConsoleColor)3;

            Console.WriteLine("Heads or Tails? Please select one.");
            string response = Console.ReadLine();
            int guess = -1;


            if (response == "Heads")
            {
                guess = (int)Coin.HEADS;
            }
            else if (response == "Tails")
            {
                guess = (int)Coin.TAILS;
            }
            else
            {
                Console.WriteLine("Invalid input. Bye.");
                Environment.Exit(-1);
            }

            if (number == (int)Coin.HEADS)
            {
                Console.WriteLine("Heads");
            }
            else
            {
                Console.WriteLine("Tails");
            }

            if (number == guess)
            {
                Console.WriteLine("Your guess was correct.");
            }
            else
            {
                Console.WriteLine("Your guess was wrong!");
            }

            const string name = "Majood Haddad";
            Console.WriteLine(name);
        }
    }
}
