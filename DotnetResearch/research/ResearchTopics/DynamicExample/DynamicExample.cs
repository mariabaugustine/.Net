using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicExample
{
    internal class DynamicExample
    {
        public void GetDataType()
        {
            dynamic val1 = "GeeksforGeeks";
            dynamic val2 = 3234;
            dynamic val3 = 32.55;
            dynamic val4 = true; Console.WriteLine("Get the actual type of val1: {0}",
                                  val1.GetType().ToString());

            Console.WriteLine("Get the actual type of val2: {0}",
                                      val2.GetType().ToString());

            Console.WriteLine("Get the actual type of val3: {0}",
                                      val3.GetType().ToString());

            Console.WriteLine("Get the actual type of val4: {0}",
                                      val4.GetType().ToString());

        }
        public dynamic Add(dynamic x,dynamic y)
        {
            return x + y;
        }
    }
}
