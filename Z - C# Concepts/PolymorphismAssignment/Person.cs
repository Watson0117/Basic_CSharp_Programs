using System;
using System.Collections.Generic;
using System.Text;

namespace PolymorphismAssignment
{
    //Create an abstract class called Person with two properties: string firstName and string lastName.


    public abstract class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public abstract void SayName();//Give it the method SayName(). This should take the first and last names and concatinate them into one string called FullName
    }
}
