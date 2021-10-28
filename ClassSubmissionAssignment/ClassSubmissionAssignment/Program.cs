using System;

namespace ClassSubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please pick a number that will be divided by 2.");
            string UserInput1 = Console.ReadLine();
            
            int Number1 = Convert.ToInt32(UserInput1);
            

            Class1 Class1 = new Class1();

            try
            {
                Class1.Method1(Number1);// this line calls the method   
            }
            catch
            {
                Console.WriteLine("There seems to be an error");
            }
        }
    }
}
