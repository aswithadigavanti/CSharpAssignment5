using System;
using System.Collections;
namespace Assignment5
{
    class ArrayListProgram
    {
        static void Main(string[] args)
        {
            ArrayList employee = new ArrayList();
            employee.Add(new Employee { ID = 101, Name = "Ashu", Department = "Developing" });
            employee.Add(new Employee { ID = 102, Name = "Reddy", Department = "Testing" });
            employee.Add(new Employee { ID = 103, Name = "Digavanti", Department = "Finance" });
            foreach (Employee emp in employee)
            {
                Console.Write(emp.ID + " ");
                Console.Write(emp.Name + " ");
                Console.WriteLine(emp.Department);
            }
        }
    }
}