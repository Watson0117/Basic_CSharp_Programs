 using System;

namespace InsuranceApprovalApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Whats your age? Use numbers");// this line print a question to the console
            string yourAge = Console.ReadLine(); // this line get use input
            int currentAge = Convert.ToInt32(yourAge); // this line converts the string yourAge to an int value save as currentAge


            Console.WriteLine("Have you ever had a DUI? answer true or false");// this line print a question to the console
            string HadDUI = Console.ReadLine();// this line get use input
            bool DoseHaveDUI = Convert.ToBoolean(HadDUI); // this line converts the string HadDUI to an bool value saved as DoseHaveDUI

            Console.WriteLine("How many speeding tickets do you have? Use numbers"); // this line print a question to the console
            string SPT = Console.ReadLine();// this line get use input
            int HasSPT = Convert.ToInt32(SPT); // this line converts the string SPT to an int value saved as HasSPT

            if (currentAge >= 15 && DoseHaveDUI == false && HasSPT <= 3) // This line makes sure they are above 15, have no DUI, and Has less that 3 Speeding tickets
            {
                Console.WriteLine("Qualified \ntrue"); // If they meet all the above requierments then it will print Qualified 
            }

            if (currentAge <= 15 || DoseHaveDUI == true || HasSPT >= 3) // This line makes sure they are above 15, have no DUI, and Has less that 3 Speeding tickets
            {
                Console.WriteLine("Qualified \nfalse"); // if they dont meet one of the requierments it will print this line
            }
        }

    }
}
