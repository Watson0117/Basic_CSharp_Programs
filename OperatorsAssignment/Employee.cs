using System;
using System.Collections.Generic;
using System.Text;

namespace OperatorsAssignment
{
    class Employee : Person
    {
        public static int EmployeeId { get; set; }

        public override void SayName()
        {
            string FullName = FirstName + " " + LastName;
            Console.WriteLine("Name: " + FullName);

        }

        public static Employee operator ==(Employee EmployeeId, Person person)
        {
            EmployeeId.Equals(EmployeeId);
            Console.WriteLine("Employee 0117 Active");
        }
        public static Employee operator !=(Employee EmployeeId, Person person)
        {
            EmployeeId !=  EmployeeId;
            Console.WriteLine("Employee 0117 NOT Active");
        }

    }
}
