using System;

namespace TryCatchAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How old are you?");//Ask the user for their age.
            int age = Convert.ToInt32(Console.ReadLine());
            try
            { 
                DateTime now = DateTime.Now;
                int yearN = now.Year;
                int dOb = yearN - age;
                DateTime yearOfBirth = new DateTime(dOb, 1, 13, 3, 57, 32, 11);
                int yearOB = yearOfBirth.Year;
                Console.WriteLine(yearOB);//Display the year the user was born.
            }
            catch (Exception ex)//Exceptions must be handled using “try/catch.”
            {
                if (age <= 0)//Display appropriate error messages if the user enters zero or negative numbers.
                {
                    Console.WriteLine("You must enter a number above 0");
                }
                else //Display a general message if an exception was caused by anything else.
                {
                    Console.WriteLine(ex.Message); 
                }
            }
        }
    }
}
