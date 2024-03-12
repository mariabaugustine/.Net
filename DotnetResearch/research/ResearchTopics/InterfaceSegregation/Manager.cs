using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation
{
    internal class Manager : ILead
    {
        public void AssignTask()
        {
            Console.WriteLine("Lead Assigning Task");
        }

        public void CreateSubTask()
        {
            Console.WriteLine("Lead creating subtask");
        }
    }
}
