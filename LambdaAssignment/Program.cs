using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            List<string> Employees = new List<string>()
            {
                new Employee(){ ID = 1, FirstName ="Bill", LastName="Murry"},

            };

            foreach (Employee name in Employees)
            {
                if (FirstName == "Joe")
                {
                    Console.WriteLine(name);
                }
            }


        }

    }

}

//
//foreach(var in Employees)
//Console.WriteLine(student.Id + ", " + student.Name);

//In the Main() method, create a list of at least 10 employees.
//Each employee should have a first and last name, as well as an Id.
//At least two employees should have the first name “Joe”.

//Using a foreach loop, create a new list of all employees with the first name “Joe”.

//Perform the same action again, but this time with a lambda expression.

//Using a lambda expression, make a list of all employees with an Id number greater than 5.

