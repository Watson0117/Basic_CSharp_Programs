using System;

namespace _6PartConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Jesse", "Erik", "Daniel", "Adam" };
            

            for (int j = 0; j < names.Length; j++) ;
            {
                names[j] = j + Console.ReadLine();
            }
            Console.ReadLine();
        }
    }
}
