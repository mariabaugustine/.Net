namespace ToStringExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 10;
           // string numbertostring = number.ToString();
           string numbertostring=Convert.ToString(number);
            Console.WriteLine(numbertostring);

        }

    }
}