using System;

namespace Loops_Exercise_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence = "The quick brown fox jumps over the lazy dog";

            // string sentence2 = "Hello";
            // Console.WriteLine(sentence2.Length); // output: 5

            for (int i = 0; i < sentence.Length; i++)
            {
                Console.WriteLine(sentence[i]);
            }
        }
    }
}
