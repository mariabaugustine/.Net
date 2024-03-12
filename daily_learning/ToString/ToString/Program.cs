using Microsoft.VisualBasic;

namespace ToString
{
    internal class Program
    {  
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
           // int x = Convert.ToString(null);

            //String data = null;
           // Console.WriteLine(data.ToString());
           Person person = new Person { Id = 1 , Name="Maya"};
            Console.WriteLine(person);
          
        }
    }
}