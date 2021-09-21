using System;

namespace _6PartConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Jesse", "Erik", "Daniel", "Adam" };
            Console.WriteLine("enter text");
            string input = Console.ReadLine();

            for (int j = 0; j < names.Length; j++)
            {
                names[j] = names[j] + input;
            }
            Console.WriteLine(names);
            Console.ReadLine();
        }
    }
}
