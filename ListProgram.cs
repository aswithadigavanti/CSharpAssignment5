using System;
using System.Collections.Generic;
namespace Assignment5
{
    class Employee
    {
        public int ID;
        public string Name;
        public Employee(int ID, string Name)
        {
            this.ID = ID;
            this.Name = Name;
        }

    }
    class ListProgram
    {
        static void Main(string[] args)
        {
            List<Employee> details = new List<Employee>();
            Console.WriteLine("Enter Employee ID");
            int Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Employee Name");
            string Name = Console.ReadLine();
            Employee emp = new Employee(Id, Name);
            details.Add(emp);
            //{
            //    new Employee{ID=100,Name = "Leela"},
            //    new Employee{ID=101,Name = "Satya"},
            //    new Employee{ID=102,Name = "Sri"}
            // };
            foreach (var em in details)
            {
                Console.Write(em.ID + " ");
                Console.WriteLine(em.Name);
            }
            Console.WriteLine("Number of Employees={0}", details.Count);
        }
    }
}