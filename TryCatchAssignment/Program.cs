using System;

namespace TryCatchAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("How old are you?");//Ask the user for their age.
            int age = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine(DateTime.Now - age);//Display the year the user was born.
            try
            {

            }
            catch
            {

            }
        //Exceptions must be handled using “try/catch.”
        //Display appropriate error messages if the user enters zero or negative numbers.
        //Display a general message if an exception was caused by anything else.
        //Add comments to each line or block of your code to explain what it does exactly, so that another developer could read and understand your code.
        //Upload your code to GitHub.
        }
    }
}
