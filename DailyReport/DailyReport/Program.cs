using System;

namespace DailyReport
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");
            Console.WriteLine("What is your name ?");
            string yourName = Console.ReadLine();// This line sets the value of yourName as a string.

            Console.WriteLine("What course are you on?");
            string CourseName = Console.ReadLine(); // This line sets a string value.

            Console.WriteLine("What page number?");
            string PageNumber = Console.ReadLine(); // This line sets a string value.
            int currentPageNumber = Convert.ToInt32(PageNumber);// this line converts the string to a int value.

            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false.\"");
            string NeedHelp = Console.ReadLine(); // This line sets a string value.
            bool DoseNeedHelp = Convert.ToBoolean(NeedHelp);
            if(DoseNeedHelp)
            {
                Console.WriteLine("You have indicated you need assistance. We will contact you shortly");
            }

            Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
            string Experiences = Console.ReadLine(); // This line sets a string value.

            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
            string Feedback = Console.ReadLine(); // This line sets a string value.

            Console.WriteLine("How many hours did you study today?");
            string HoursOn = Console.ReadLine(); // This line sets the value of HoursOn as a string.
            int StudyHours = Convert.ToInt32(HoursOn); // This line changes the string value of HoursOn to an int value.

            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
            
            //Console.WriteLine("Thank you for your answers " + yourName + "\n You have been doing well on your " 
            //    + CourseName + " course by getting to page " + currentPageNumber + ". Keep up the good work!" 
            //    + "\n Try to maintain at least " + StudyHours + " hours every day to stay on track!");
            // The line above should concatinate several of the inputs to give a massage to the user.


        }
    }
}

