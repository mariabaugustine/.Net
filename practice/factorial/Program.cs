namespace factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number,fact=1;
            Console.WriteLine("Enter the number");
            number=Convert.ToInt32(Console.ReadLine());
            for(int i = 1; i <= number; i++)
            {
                fact = fact * i;
            }
            Console.WriteLine(fact);
        }
    }
}