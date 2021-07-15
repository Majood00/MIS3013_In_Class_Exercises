using System;

namespace Loop_For_Loop
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int i = 2; i < 101; i = i +2)
            {
               Console.WriteLine(i);
            }

            int sum = 0;

            for (int i = 1; i <= 100; i++)
            {
                sum = sum + i;
            }

            Console.WriteLine($"The summation from 1 to 100 is {sum.ToString("N0")}");
        }
    }
}
