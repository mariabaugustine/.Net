using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee[] employees = new Employee[3];
            employees[0] = new Employee();
            employees[1] = new PartTime();
            employees[2] = new FullTime();
            foreach (Employee employee in employees)
            {
                employee.printName();
            }
            Console.ReadLine();
        }
    }
}
