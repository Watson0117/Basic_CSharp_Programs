using System;

namespace AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            Employee Nemp = new Employee();//Inside the Main() method, instantiate an Employee object
            {
                Nemp.FirstName = "Sample";//with firstName “Sample”
                Nemp.LastName = "Student";// and lastName “Student”. 
                Nemp.SayName();//Call the SayName() method on the object.
            }
            Console.ReadLine();
        }
        
    }
}
