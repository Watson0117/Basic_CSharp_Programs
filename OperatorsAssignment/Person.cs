using System;
using System.Collections.Generic;
using System.Text;

namespace OperatorsAssignment
{
    public abstract class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public abstract void SayName();//Give it the method SayName(). This should take the first and last names and concatinate them into one string called FullName
    }
}
