namespace reverse
{
    internal class Program
    {
        static int reverseNum(int num)
        {
            // Write your code here
            int reverse = 0;
            while(num > 0)
            {
                int remainder= num % 10;
                reverse=reverse*10+remainder;
                num /= 10;
            }
            return reverse;
        } 
            static void Main(string[] args)
        { 
            int num;
            num = Convert.ToInt32(Console.ReadLine()); 
            
            int result; result = reverseNum(num);
            Console.Write(result); }
    }
}