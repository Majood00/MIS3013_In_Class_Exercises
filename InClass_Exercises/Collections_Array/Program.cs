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

            for (int i = 0; i < firstNames.Length; i++)
            {
                string firstName = firstNames[i];
                Console.WriteLine(firstName);
            }
            
        }
    }
}
