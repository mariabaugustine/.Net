using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5_FindFctors
{
    internal class FindFactors
    {
        public void FindFacors(int number)
        {
            Console.WriteLine("The factors are:");
            for(int i=1; i<=number; i++)
            {
                if(number%i==0)
                {
                    Console.Write($"{i},");
                }
            }
            
        }
    }
}
