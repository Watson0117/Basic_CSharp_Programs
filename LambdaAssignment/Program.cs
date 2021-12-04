using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaAssignment
{
    class Program: Employee
    {
        public static void Main(string[] args)
        {
            Employee employee = new Employee();
            //In the Main() method, create a list of at least 10 employees.
            //Each employee should have a first and last name, as well as an Id.
            //At least two employees should have the first name “Joe”.
            List<Employee> Employees = new List<Employee>()
            {
                new Employee(){ ID = 1, FirstName ="Bill", LastName="Murry"},
                new Employee(){ ID = 2, FirstName ="Joe", LastName="Revits"},
                new Employee(){ ID = 3, FirstName ="Joe", LastName="Briath"},
                new Employee(){ ID = 4, FirstName ="Vlad", LastName="Therussian"},
                new Employee(){ ID = 5, FirstName ="Burt", LastName="Crisler"},
                new Employee(){ ID = 6, FirstName ="Gery", LastName="Cris"},
                new Employee(){ ID = 7, FirstName ="Greg", LastName="isler"},
                new Employee(){ ID = 8, FirstName ="Bary", LastName="Allen"},
                new Employee(){ ID = 9, FirstName ="Bruce", LastName="Walles"},
                new Employee(){ ID = 10, FirstName ="Kirk", LastName="Green"}

            };

            foreach (Employee name in Employees)//Using a foreach loop, 
            {
                List<Employee> Employees2 = new List<Employee>();

                

                if (Employees.FirstName == "Joe")
                {
                    Employees2.Add(employee FirstName);//create a new list of all employees with the first name “Joe”.
                    Console.WriteLine(name);
                }
            }
        }
    }
}

//
//foreach(var in Employees)
//Console.WriteLine(student.Id + ", " + student.Name);





//Perform the same action again, but this time with a lambda expression.

//Using a lambda expression, make a list of all employees with an Id number greater than 5.

