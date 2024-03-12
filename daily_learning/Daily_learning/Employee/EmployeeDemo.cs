using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    internal class EmployeeDemo
    {
        public delegate bool IsEligiblePromotion(EmployeeDemo employee);
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public int Experience { get; set; }
        
        public void PromotedEmployee(EmployeeDemo[] employees,IsEligiblePromotion isEligiblePromotion)
        {
            foreach (EmployeeDemo employee in employees) 
            { 
                if(isEligiblePromotion(employee))
                {
                    Console.WriteLine($"{employee.Id},{ employee.Name} eligible for promotion");
                }
            }

        }
    }
}
