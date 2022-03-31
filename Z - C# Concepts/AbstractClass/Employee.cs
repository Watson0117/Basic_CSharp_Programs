using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClass//Create another class called Employee and have it inherit from the Person class.

//Implement the SayName() method inside of the Employee class.
{
    class Employee: Person
    {
        public override void SayName()
        {
            string FullName = FirstName + " " + LastName;
            Console.WriteLine("Name: " + FullName);
        }
    }
}
