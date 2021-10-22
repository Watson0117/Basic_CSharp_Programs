using System;
using System.Collections.Generic;
using System.Text;
using static MainMethodApp.MathOps;

namespace MainMethodApp
{
    public static class Program
    {
        static void Main(string[] args)// Is this not the Main()?
        {
            Console.WriteLine("Welcome, Please pick a number!");// this line help me keep track of where the program is at
            string UIS = Console.ReadLine();// this gets the users input as a string.
            decimal UID = Convert.ToDecimal(UIS);
            int UII = Convert.ToInt32(UIS);// this converts the string enetered by rhe user as a integer

            MathOps mathops = new MathOps();

            //In the Main() method of the console app, instantiate the class and call the one method,
            //passing in an integer. Display the result to the screen.
            int IntOutPut = MathOps.MoFun(UII);// this line calls the method mathops and take in an int
            Console.WriteLine(IntOutPut);
            //-------------------------------------------------------------------------------------------------------


            // In the Main() method of the console app, instantiate the class and call the second method,
            // passing in a decimal. Display the result to the screen.
            int DecOutPut = (int)MathOps.MoFun(UID);// this line calls the method mathops and take in a decimal
            Console.WriteLine(DecOutPut);
            //-------------------------------------------------------------------------------------------------------


            //In the Main() method of the console app, instantiate the class and call the third
            //method, passing in a string that equates to an integer.Display the result to the screen.

            int StrOutPut = MathOps.MoFun(UII);// this line calls the method mathops and returns a string
            Console.WriteLine(StrOutPut);
            //-------------------------------------------------------------------------------------------------------

        }
    }
}
