using System.Diagnostics.CodeAnalysis;

namespace Palindrome
{
    internal class Program
    {
        static int scoreString(String str)
        {
            int sum = 0;
            for(int i=0;i<str.Length; i++)
            {
                if (i + 5 <= str.Length) 
                {
                    string temp1 = str.Substring(i, 5);
                    char[] temp2=temp1.Reverse().ToArray();
                    if(temp1.SequenceEqual(temp2))
                    {
                        sum = sum + 10;
                    }
                }
                if(i+4<= str.Length)
                {
                    string temp1=str.Substring(i, 4);
                    char[] temp2=temp1.Reverse().ToArray();
                    if (temp1.SequenceEqual(temp2))
                    {
                        sum = sum + 5;
                    }
                }
            }
           return sum;
        }
            static void Main(string[] args)
        {
            string str;
            str = Console.ReadLine();
            int result;
            result = scoreString(str);
            Console.Write(result);

        }
    }
}