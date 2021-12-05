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
            string HourlyRate = Console.ReadLine(); // This gets input form the user
            Console.WriteLine("Input Hours worked per week: "); //Prints text
            string HoursPerWeek = Console.ReadLine();// This gets input form the user
            
            decimal HourlyRateInt = Convert.ToDecimal(HourlyRate); // convert to integer
            decimal HoursPerWeekInt = Convert.ToDecimal(HoursPerWeek); // convert to integer

            Console.WriteLine("Person2"); //Prints text
            Console.WriteLine("Input Hourly Rate: "); //Prints text
            string HourlyRate2 = Console.ReadLine();// This gets input form the user
            Console.WriteLine("Input Hours worked per week: "); //Prints text
            string HourPerWeek2 = Console.ReadLine();// This gets input form the user
            decimal HourlyRateInt2 = Convert.ToInt32(HourlyRate2); // convert to integer
            decimal HoursPerWeekInt2 = Convert.ToInt32(HourPerWeek2); // convert to integer

            decimal BaseSalary1 = HourlyRateInt * HoursPerWeekInt;
            Console.WriteLine("Annual salary of Person 1:"); //Prints text
            decimal AnnualSaleryPerson1 = BaseSalary1 * 52;
            Console.WriteLine(AnnualSaleryPerson1); //Prints anual salary

            decimal baseSalary2 = HourlyRateInt2 * HoursPerWeekInt2; // creates a weekly total
            Console.WriteLine("Annual salary of Person 2:"); //Prints text
            decimal AnnualSalaryPerson2 = baseSalary2 * 52; // creates a weekly total
            Console.WriteLine(AnnualSalaryPerson2); //Prints anual salary
            Console.WriteLine("Does Person 1 make more money than Person 2 ?");// prints text
            bool trueOrFalse = AnnualSaleryPerson1 > AnnualSalaryPerson2; // compare the annual salarys for eche person and returns T or F
            Console.Write(trueOrFalse.ToString());//then prints 
            Console.Read();// keeps the console from closing auto.

        }
    }
}
