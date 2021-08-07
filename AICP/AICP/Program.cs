using System;

namespace AICP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program"); //Prints text
            Console.WriteLine("Person1"); //Prints text
            Console.WriteLine("Input Hourly Rate: "); //Prints text
            string HR1 = Console.ReadLine(); // This gets input form the user
            Console.WriteLine("Input Hours worked per week: "); //Prints text
            string HPW1 = Console.ReadLine();// This gets input form the user
            int HR2 = Convert.ToInt32(HR1); // convert to integer
            int HPW2 = Convert.ToInt32(HPW1); // convert to integer

            Console.WriteLine("Person2"); //Prints text
            Console.WriteLine("Input Hourly Rate: "); //Prints text
            string HR3 = Console.ReadLine();// This gets input form the user
            Console.WriteLine("Input Hours worked per week: "); //Prints text
            string HPW3 = Console.ReadLine();// This gets input form the user
            int HR4 = Convert.ToInt32(HR3); // convert to integer
            int HPW4 = Convert.ToInt32(HPW3); // convert to integer

            int BS1 = HR2 * HPW2;
            Console.WriteLine("Annual salary of Person 1:"); //Prints text
            int ASP1 = BS1 * 52;
            Console.WriteLine(ASP1); //Prints anual salary

            int BS2 = HR4 * HPW4; // creates a weekly total
            Console.WriteLine("Annual salary of Person 2:"); //Prints text
            int ASP2 = BS2 * 52; // creates a weekly total
            Console.WriteLine(ASP2); //Prints anual salary
            Console.WriteLine("Does Person 1 make more money than Person 2 ?");// prints text
            bool trueOrFalse = ASP1 > ASP2; // compare the annual salarys for eche person and returns T or F
            Console.Write(trueOrFalse.ToString());//then prints 
            Console.Read();// keeps the console from closing auto.

        }
    }
}
