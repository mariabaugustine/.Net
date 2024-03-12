using System.ComponentModel.Design;

namespace PalindromeExample
{
    internal class Program
    {
        static int scoreString(String str)
        {
            int score = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (i + 4 <= str.Length)
                {
                    string temp = str.Substring(i, 4);
                    char[] carray = temp.Reverse().ToArray();
                    if (temp.SequenceEqual(carray))
                    {
                        score = score + 5;
                    }


                }
                if (i + 5 <= str.Length)
                {
                    string temp = str.Substring(i, 5);
                    char[] carray = temp.Reverse().ToArray();
                    if (temp.SequenceEqual(carray))
                    {
                        score = score + 10;
                    }
                }

            }
            return score;
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
