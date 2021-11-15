using System;
using System.Collections.Generic;
using System.Text;

namespace PolymorphismAssignment//Create another class called Employee and have it inherit from the Person class.

//Implement the SayName() method inside of the Employee class.
{
    class Employee : Person, IQuittable //Have your Employee class from the previous drill inherit that interface
    {
        public override void SayName()
        {
            string FullName = FirstName + " " + LastName;
            Console.WriteLine("Name: " + FullName);

        }
        public void Quit(Employee employee)// implement the Quit() method in any way you choose.
        {
            throw new NotImplementedException();
            //Use polymorphism to create an object of type IQuittable and call the Quit() method on it.
            //Hint: an object can be of an interface type if it implements that specific interface.
        }
    }
}
