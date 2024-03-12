using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovExample
{
    public class Apple : IFruit
    {
        public string GetColor()
        {
            return "red";
        }
    }
}
