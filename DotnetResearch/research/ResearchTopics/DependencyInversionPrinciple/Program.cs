namespace DependencyInversionPrinciple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var logger = new Logger(new DatabaseService());
            logger.Log("Hello");
        }
    }
}