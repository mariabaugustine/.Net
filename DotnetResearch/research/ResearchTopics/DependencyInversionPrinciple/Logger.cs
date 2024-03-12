using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionPrinciple
{
    internal class Logger
    {
        private readonly IDataService _dataService;



        public Logger(IDataService dataService)
        {
            _dataService = dataService;
        }



        public void Log(string message)
        {
            _dataService.Save(message);
        }
    }
}
