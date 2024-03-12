namespace DynamicExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DynamicExample example = new DynamicExample();
            example.GetDataType();
            dynamic result = example.Add(5, 5);
            Console.WriteLine("***************************************");
            Console.WriteLine($"Result:{ result}");
        }
    }
}