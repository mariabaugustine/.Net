namespace Anonymous
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<string, string> func = delegate (string name)
            {
                return name;
            };
            
            Console.WriteLine(func("Maria"));
        }
    }
}