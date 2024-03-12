using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionPrinciple
{
    internal class DatabaseService:IDataService
    {
        public void Save(string message)
        {
            Console.WriteLine("Save the message into the database");
        }
    }
}
