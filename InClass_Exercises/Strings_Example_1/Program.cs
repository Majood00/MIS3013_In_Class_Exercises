using System;

namespace Strings_Example_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence = "The quick brown fox jumps over the lazy dog";

            Console.WriteLine($"There are {sentence.Length.ToString("n0")} characters in the sentence.");

            Console.WriteLine();
            for (int i = 0; i < sentence.Length; i++)
            {
                if (sentence[i] == ' ')
                {
                    Console.WriteLine();
                    continue;
                }   
                Console.Write(sentence[i]);
            }

            Console.WriteLine("\nWhich letter do you want to know the count of?");
            string letter = Console.ReadLine();
            letter = letter.Trim();

            Console.WriteLine();
            int count = 0;
            for (int i = 0; i < sentence.Length; i++)
            {
                if (sentence[i] == Convert.ToChar(letter))
                {
                    count += 1;
                }
            }

            Console.WriteLine($"There were {count} occurences of the letter '{letter}'");
        }
    }
}
