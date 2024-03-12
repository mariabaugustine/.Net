namespace Assignment_4_palindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input,reversestring="";
            Console.WriteLine("Enter the string");
            input = Console.ReadLine();
            int length = input.Length;
            for (int i = length-1;i>=0;i--)
            {
                reversestring = reversestring + input[i];
            }
            if (input==reversestring)
            { 
                Console.WriteLine("{0} is a palindrome",input);
            }
            else
            {
                Console.WriteLine("{0} is not a palindrome", input);
            }
             
        }
    }
}