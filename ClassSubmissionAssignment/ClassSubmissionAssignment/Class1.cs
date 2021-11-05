using System;
using System.Collections.Generic;
using System.Text;

namespace ClassSubmissionAssignment
{
    public class Class1// Create a class.
    {

        //---------------------------Method for overloading-----------------------------------------------
        public void Method1(int Number1)  // In that class, create a void method that outputs an integer.
        {
            int Answer1 = Number1 / 2; // Have the method divide the data passed to it by 2.


            Console.WriteLine(Answer1);//  Display the output to the screen.
        }
        //---------------------overloaded method.--------------------------------------------
        public void Method1(int Number1, int Number2)  // In that class, create a void method that outputs an integer.
        {
            int Answer = Number1 + Number2; // overload the method to have it add two numbers.


            Console.WriteLine(Answer);//  Display the output to the screen.
        }
        

        //--------Create a method with output parameters.-------------------------------------------------------
        public void NumMan(out int x)  // In that class, create a void method that outputs an integer.
        {
            int temp = 5;
            x = temp;
        }


    }
    //--------------------------static class---------------------------------------------------------------------------
    public static class Class2// Create a class - Declare a class to be static.
    {
        public static void Method2(int Number1, int Number2)  // In that class, create a void method that outputs an integer.
        {
            int Answer = Number1 * Number2; // Have the method divide the data passed to it by 2.


            Console.WriteLine(Answer);//  Display the output to the screen.
        }
    }

}
