using System;

namespace OperatorsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();//Inside the Main() method, instantiate an Employee object
            Employee emp1 = new Employee() { EmployeeId = 1 };
            Employee emp2 = new Employee() { EmployeeId = 2 };
            {
                employee.FirstName = "Sample";//with firstName “Sample”
                employee.LastName = "Student";// and lastName “Student”. 


                Console.WriteLine("Dose emp1 equal emp2");
                Console.WriteLine(emp1 == emp2);
                Console.ReadLine();

                Console.WriteLine("Dose emp1 equal emp1");
                Console.WriteLine(emp1 == emp1);
                Console.ReadLine();

                Console.WriteLine("Dose emp2 equal emp2");
                Console.WriteLine(emp2 == emp2);
                Console.ReadLine();
            }

            Console.ReadLine();
        }
    }
}
