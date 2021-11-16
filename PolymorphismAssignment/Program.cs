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

            //Use polymorphism to create an object of type IQuittable and call the Quit() method on it.
            //Hint: an object can be of an interface type if it implements that specific interface.
            IQuittable Done = new IQuittable();
            Done.Quit(Done);
            Console.ReadLine();
        }
    }
}
