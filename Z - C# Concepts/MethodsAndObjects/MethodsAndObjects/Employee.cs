using System;
using System.Collections.Generic;
using System.Text;

namespace MethodsAndObjects
{
    //Create another class called Employee and have it inherit from the Person class.
    //Give the Employee class a property called Id and have it be of data type int.

    class Employee: Person
    {  
        public static int Id { get; set; }
    }
}
