using System;

namespace Collections_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstNames = new string[3];

            firstNames[0] = "Darby";
            firstNames[1] = "Shelby";
            firstNames[2] = "Tim";

            string[] lastNames = { "Shepard", "Williams", "Davis" };

            Console.WriteLine($"We have {firstNames.Length} first names");
            Console.WriteLine($"We have {lastNames.Length} last names");

            for (int i = 0; i < firstNames.Length; i++)
            {
                string firstName = firstNames[i];
                string lastName = lastNames[i];
                Console.WriteLine($"{lastName}, {firstName}");
            }

            /*foreach (string firstName in firstNames)
            {
                Console.WriteLine(firstName);
            }*/
        }
    }
}
