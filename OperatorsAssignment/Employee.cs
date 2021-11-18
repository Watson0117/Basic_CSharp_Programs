using System;
using System.Collections.Generic;
using System.Text;

namespace OperatorsAssignment
{
    class Employee : Person
    {
        public int EmployeeId { get; set; }

        public override void SayName()
        {
            string FullName = FirstName + " " + LastName;
            Console.WriteLine("Name: " + FullName);

        }


        public static bool operator ==(Employee emp1, Employee emp2)
        {

            return emp1.EmployeeId == emp2.EmployeeId;

        }

        public static bool operator !=(Employee emp1, Employee emp2)
        {

            return emp1.EmployeeId == emp2.EmployeeId;

        }
    }
}
