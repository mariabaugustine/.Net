namespace reverse_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            int reverse=0;
            int value;
            Console.WriteLine("Enter the number");
            number = Convert.ToInt32(Console.ReadLine());
            while (number > 0) 
            {
                value = number % 10;
                reverse = reverse * 10 + value;
                number = number / 10;

            }
            Console.WriteLine("REVERSE:{0}", reverse);
        }
    }
}