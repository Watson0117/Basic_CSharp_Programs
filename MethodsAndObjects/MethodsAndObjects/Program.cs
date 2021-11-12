using System;

namespace MethodsAndObjects
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Inside of the Main method, instantiate and initialize an Employee object with
            //a first name of “Sample” and a last name of “Student”.

            Employee A = new Employee();
            {
                A.FirstName = "Sample";
                A.LastName = "Student";
                Employee.Id = 0117;
                //Call the superclass method SayName() on the Employee object.
                A.SayName();
            }

            Console.ReadLine();
        }   
    }
}



