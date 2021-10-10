using System;
using System.Collections.Generic;

namespace StringsAndIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("The stored numbers are 3, 6, and 9 Pick a number to divide these by.");
                List<int> IL = new List<int>();//creates a new list to use later in program
                IL.Add(3);//adds a number to the list
                IL.Add(6);//adds a number to the list
                IL.Add(9);//adds a number to the list

                int UI = Convert.ToInt32(Console.ReadLine());//takes user input UI and converts it to a integer
                foreach (int num in IL)//this line gose through each number in the list
                {
                    Console.WriteLine(num + " Divided by " + UI + " Equals.");// this line splits things up so its not just a list of the quotients
                    Console.WriteLine(num / UI);// this line divides each number by the number entered by the user
                }
                
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);// this line will display an error message depending on what went wrong
                Console.WriteLine("Please enter a whole number");// This line should print when the trycatch block has been triggered and is now ready to continue
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);// this line will display an error message depending on what went wrong
                Console.WriteLine("Please dont divide by 0.");// This line should print when the trycatch block has been triggered and is now ready to continue
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);// this line will display an error message depending on what went wrong
            }
            finally
            {
                Console.WriteLine("Please run program again.");// This line should print when the trycatch block has been triggered and is now ready to continue
                Console.ReadLine();
            }
        }
    }
}
