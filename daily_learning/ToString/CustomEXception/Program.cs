namespace CustomEXception
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Number1, Number2, Result;
            try
            {
                Console.WriteLine("Enter First Number:");
                Number1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Second Number:");
                Number2 = int.Parse(Console.ReadLine());
                if (Number2 % 2 > 0)
                {
                    //OddNumberException ONE = new OddNumberException();
                    //throw ONE;
                    throw Custom();
                }
                Result = Number1 / Number2;
                Console.WriteLine(Result);
            }
            catch (Custom one)
            {
                Console.WriteLine($"Message: {one.Message}");
               
            }
            Console.WriteLine("End of the Program");
            Console.ReadKey();
        }
    }
}