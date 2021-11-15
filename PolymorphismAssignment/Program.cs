using System;

namespace PolymorphismAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();//Inside the Main() method, instantiate an Employee object
            {
                employee.FirstName = "Sample";//with firstName “Sample”
                employee.LastName = "Student";// and lastName “Student”. 
                employee.SayName();//Call the SayName() method on the object.
            }
            Console.ReadLine();
        }
    }
}
