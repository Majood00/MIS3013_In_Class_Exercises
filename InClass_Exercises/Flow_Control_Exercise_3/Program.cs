using System;

namespace Flow_Control_Exercise_3
{
    class Program
    {
        static void Main(string[] args)
        {
            double weight, miles, quote, hazardousMaterialCost, discount;
            string response;

            Console.WriteLine("Welcome to the OU Shipping Store.");
            
            Console.WriteLine("\nHow many miles is your shipment\t?");
            response = Console.ReadLine();
            //miles = Convert.ToDouble(response);
            if (Double.TryParse(response, out miles) == false)
            {
                Console.WriteLine("Invalide miles. Goodbye.");
                Environment.Exit(3);
            }

            Console.WriteLine("What is the weight (in pounds) of your shipment?");
            response = Console.ReadLine();
            //weight = Convert.ToDouble(Console.ReadLine());
            if (Double.TryParse(response, out weight) == false)
            {
                Console.WriteLine("Invalide weight. Goodbye.");
                Environment.Exit(3);
            }

            Console.WriteLine("Does your shipment contain hazaedous material? Yes or No?");
            response = Console.ReadLine();

            switch (response)
            {
                case "yes":
                    hazardousMaterialCost = 0.15 * weight;
                    break;
                case "Yes":
                    hazardousMaterialCost = 0.15 * weight;
                    break;
                case "YES":
                    hazardousMaterialCost = 0.15 * weight;
                    break;
                case "no":
                    hazardousMaterialCost = 0;
                    break;
                case "No":
                    hazardousMaterialCost = 0;
                    break;
                case "NO":
                    hazardousMaterialCost = 0;
                    break;
                default:
                    Console.WriteLine("Invalid response. Time to terminate.");
                    Environment.Exit(0);
                    return;
                    break;
            }

            //if (response == "yes")
            //{
            //    hazardousMaterialCost = 0.15 * weight;
            //}
            //else if (response == "no")
            //{
            //    hazardousMaterialCost = 0;
            //}
            //else
           //{
           //    Console.WriteLine("Invalid response. Time to terminate.");
           //     Environment.Exit(0);
           //     return;
           //}

            quote = 0.55 * miles + 0.73 * weight;

            if(weight > 500 && miles < 150)
            {
                discount = 0.10 * quote;
            }
            else
            {
                discount = 0;
            }

            Console.WriteLine(quote);

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Your hazardous cost is {hazardousMaterialCost.ToString("C2")}");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write($"Your discout is {discount.ToString("C2")}");
            
            double total = quote + hazardousMaterialCost - discount;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"\nYour grand total is {total.ToString("C2")}");

        }
    }
}
