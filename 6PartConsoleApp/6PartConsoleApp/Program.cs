using System;
using System.Collections.Generic;

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

            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }
            Console.ReadLine();

            //------------------------------------------------infinite loop
            Console.WriteLine("infinite Loop");
            int[] numbers = { 1, 2, 3, 4 };
            while (numbers[1] < 5)
            {
                Console.WriteLine(numbers[3]);
                break;// withiout this line the code will create an infinite loop
            }
            Console.ReadLine();
            //------------------------------------------------< loop
            Console.WriteLine("< Loop");
            int[] numbers2 = { 1, 2, 3, 66 };
            while (numbers2[1] < 5)
            {
                Console.WriteLine(numbers2[3]);
                break;// withiout this line the code will create an infinite loop
            }
            Console.ReadLine();
            //------------------------------------------------<= loop
            Console.WriteLine("<= Loop");
            int[] numbers3 = { 1, 2, 3, 77 };
            while (numbers3[1] <= 2)
            {
                Console.WriteLine(numbers3[3]);
                break;// withiout this line the code will create an infinite loop
            }


            //---------------------------------------------------------List
            Console.WriteLine("List of names section");
            List<string> Snames = new List<string>() { "Jesse", "Eric", "Adam", "Daniel"};

            foreach (string Sname in Snames)
            {
                if (Sname == "Jesse")
                {
                    Console.WriteLine(Sname);
                }
                if (Sname == "Eric")
                {
                    Console.WriteLine(Sname);
                }
                if (Sname == "Adam")
                {
                    Console.WriteLine(Sname);
                }
                if (Sname == "Daniel")
                {
                    Console.WriteLine(Sname);
                }
                else
                {
                    Console.WriteLine("Invalid");
                }
            }

            Console.ReadLine();
        }
    }
}
