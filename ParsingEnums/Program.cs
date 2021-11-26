using System;

namespace ParsingEnums
{
    class Program
    {
        enum Days { Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday }//Create an enum for the days of the week.
        static void Main(string[] args)
        {
            try//Wrap the above statement in a try/catch block and 
            {
            Console.WriteLine("Please enter the current day of the week. Use a capital letter at the begining");//Prompt the user to enter the current day of the week.
            string Day = Console.ReadLine();//Assign the value to a variable of that enum data type you just created.
          
            DateTime date = DateTime.Today;
            string Today = Convert.ToString(date.DayOfWeek);

            if (Day == Today)
                {
                    Console.WriteLine("Day Of The Week " + date.DayOfWeek);
                }
            else
                {
                    Console.WriteLine("Please enter an actual day of the week.");
                }
            
            }
            catch
            {
                Console.WriteLine("Please enter an actual day of the week.");//have it print "Please enter an actual day of the week.” to the console if an error occurs.
            }
            
        }
    }
}
