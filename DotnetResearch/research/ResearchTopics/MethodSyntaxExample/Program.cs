using System.Linq;
namespace MethodSyntaxExample

{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> integerList = new List<int>()
            {
                1, 2, 3, 4, 5, 6, 7, 8, 9, 10
            };
            var methodSyntax= integerList.Where(obj => obj > 5).ToList();
            foreach (var item in methodSyntax)
            {
                Console.Write(item + " ");
            }

        }
    }
}