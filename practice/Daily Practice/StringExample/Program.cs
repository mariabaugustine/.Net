namespace StringExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str1 = "Hello";
            string str2 = "World";
            int length = str1.Length;
            Console.WriteLine(length);
            string third=string.Concat(str1, str2);
            Console.WriteLine(third);
        }
    }
}