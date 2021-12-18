using System;

namespace DateTimeAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            DateTime dateTimeNow = DateTime.Now;
            Console.WriteLine(dateTimeNow);//Prints the current date and time to the console.
            Console.WriteLine("Press any key to continue.");//to keep track of program position. writes to console so i can see it ready to go to next step
            Console.ReadLine();//Keeps console open without activating next line
            Console.WriteLine("Please pick a number of Hours"); //Asks the user for a number.
            int Hours = Convert.ToInt32(Console.ReadLine());// takes the number enterd by the use and converts it to an int32
            DateTime dateTimeThen = dateTimeNow.AddHours(Hours);// creates a new datetime obj that is the current date with i days added.
            Console.WriteLine(dateTimeThen);//Prints to the console the exact time it will be in X hours, X being the number the user entered in step 2.
            Console.WriteLine("Press any key to continue.");//to keep track of program position. writes to console so i can see it ready to go to next step
            Console.ReadLine();//Keeps console open without activating next line
        }
    }
}
