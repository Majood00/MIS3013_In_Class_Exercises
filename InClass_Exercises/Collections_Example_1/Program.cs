using System;

namespace Collections_Example_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string names = "Scooby Christina JENN clarke";

            string name1 = "Jenn";
            char[] name1AsArray = new char[4];
            name1AsArray[0] = 'J';
            name1AsArray[1] = 'e';
            name1AsArray[2] = 'n';
            name1AsArray[3] = 'n';

            string[] seperatedNames = names.Split(' ');

            for (int i = 0; i < seperatedNames.Length; i++)
            {
                string name = seperatedNames[i];
                name = name.ToLower();
                name = name.ToUpper()[0] + name.Substring(1);
                Console.WriteLine(name);
            }
        }
    }
}
