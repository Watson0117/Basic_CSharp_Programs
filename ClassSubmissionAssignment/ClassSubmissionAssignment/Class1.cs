using System;
using System.Collections.Generic;
using System.Text;

namespace ClassSubmissionAssignment
{
    public class Class1
    {
        public void Method1(int Number1)  // takes in int and outputs an int
        {
 
        // Declaring variable
        // without assigning value
        int Num1 = Number1;
 
        // Pass variable i to the method
        // using out keyword
        Division(out Num1);
 
        // Display the value i
        Console.WriteLine("The Division of the value is: {0}", Num1);
        }
 
        // Method in which out parameter is passed
        // and this method returns the value of
        // the passed parameter
        public static void Division(out int Number1)
        {
            int Num1;
            Number1 = Num1 / 2;
            Console.WriteLine(Number1);
        }

    }
}
