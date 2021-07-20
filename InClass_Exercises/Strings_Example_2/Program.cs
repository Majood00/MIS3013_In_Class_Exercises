using System;

namespace Strings_Example_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string names = "Scooby Christina JENN clarke";

            /*string name1 = names.Substring(0, 6);
            string name2 = names.Substring(7, 9);
            string name3 = names.Substring(17, 4);

            Console.WriteLine($"{name1}\n{name2}\n{name3}");*/

            /*first way to solve the problem
            string name = "";
            for (int i = 0; i < names.Length; i++)
            {
                char currentLetter = names[i];

                if (currentLetter == ' ')
                {
                    Console.WriteLine(name);
                    name = "";
                }
                else
                {
                    name += currentLetter;
                }
            }

            Console.WriteLine(name);*/

            bool shouldContainIterating = true;
            int indexOfLastSpace = 0;

            while (shouldContainIterating)
            {
                string name;
                int startingPosition = indexOfLastSpace;
                indexOfLastSpace = names.IndexOf(' ', indexOfLastSpace + 1);

                if (indexOfLastSpace == -1)
                {
                    name = names.Substring(startingPosition + 1);
                }
                else
                {
                    int length = indexOfLastSpace - startingPosition;

                    name = names.Substring(startingPosition, length);
                    name = name.Trim();
                }

                /*Another way to do it
                 if (startingPosition == 0)
                {
                    name = names.Substring(startingPosition, length);
                }
                else
                {
                    name = names.Substring(startingPosition + 1, length);
                } */

                name = name.ToLower();
                name = name.ToUpper()[0] + name.Substring(1);

                Console.WriteLine(name);

                if (indexOfLastSpace == -1)
                {
                    shouldContainIterating = false;
                }

            }
        }
    }
}
