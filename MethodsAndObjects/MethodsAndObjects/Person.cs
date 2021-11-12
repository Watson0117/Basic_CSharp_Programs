using System;
using System.Collections.Generic;
using System.Text;

namespace MethodsAndObjects
{

    //Create a class called Person and give it two properties, each of data type string. One called FirstName, the other LastName.

    public class Person
    {
        public static string FirstName  { get; set;}
        public static string LastName { get; set ; }
        public string FullName = FirstName + LastName;

        ///------------------------------------------------------------------------------------------------------------------------
        //Give this class a void method called SayName() that takes no parameters and simply writes the person's
        //full name to the console in the format of: “Name: [full name]”.
        public void SayName(string FullName)
        {
            Console.WriteLine("Name: " + FullName);

        }
        internal static void SayName(Employee a)
        {
            throw new NotImplementedException();
        }

    }
}
