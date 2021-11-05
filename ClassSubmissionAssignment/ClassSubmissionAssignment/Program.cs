using System;

namespace ClassSubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 C = new Class1();//In the Main() method, instantiate that class.
            Console.WriteLine("Please pick 1 number or 2 numbers.");


            string UserInput1 = Console.ReadLine();//Have the user enter a number.
            int Num1 = Convert.ToInt32(UserInput1);// the enterd number is converted to an int value.

            try
            {
               
                string UserInput2 = Console.ReadLine();
                int Num2 = Convert.ToInt32(UserInput2);

                Console.WriteLine(Num1 +" + "+ Num2 +" Equals");
                C.Method1(Number1: Num1, Number2: Num2);// Call the method on two numbers
                
                Console.WriteLine(Num1 + " Multiplyed by "+ Num2 + " Equals");
                Class2.Method2(Num1, Num2);
                Console.WriteLine("You entered 2 numbers.");
            }
            catch (Exception)
            {

                Console.WriteLine(Num1 + " Divided By 2 is");
                C.Method1(Number1: Num1);// Call the method on that number It should be the entered number, divided by two.
                Console.WriteLine("You entered 1 number.");
            }
            int a = 100;// the value of a is defined localy so that when i use the method with the out parameter it will be different.

            Console.WriteLine("Before method call, value of a : {0}", a);

            /* calling a function to get the value */
            C.NumMan(out a);// this calles the NumMan Number Manipulation method. that sets a temp value to 5 and then outputs that number
                            // By reseting the value of a it will return 5 after calling the method.

            Console.WriteLine("After method call, value of a : {0}", a);
            Console.ReadLine();
        }
    }
}
