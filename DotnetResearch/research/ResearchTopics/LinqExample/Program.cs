
using System.Linq; 
namespace LinqExample

{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] number = new int[] { 0, 1, 2 };
            var result = from item in number where item< 3 select item;
            foreach (int item in result)
                Console.WriteLine(item);
        }
    }
}