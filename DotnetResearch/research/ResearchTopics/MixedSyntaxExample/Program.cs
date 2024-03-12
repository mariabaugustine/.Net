namespace MixedSyntaxExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> integerList = new List<int>()
            {
                1, 2, 3, 4, 5, 6, 7, 8, 9, 10
            };
           
            var mixedSyntax = (from obj in integerList
                                where obj > 5
                                select obj).Sum();
         
            Console.Write("Sum Is : " + mixedSyntax);
        }
    }
}