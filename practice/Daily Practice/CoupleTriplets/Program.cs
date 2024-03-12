using System.Security;

namespace CoupleTriplets
{
    internal class Program
    {
        static int score(int array_length, List<int> arr)
        {
            int sum = 0;
            int product = 0;
            int score = 0;
            for(int i=0; i<array_length-1; i++)
            {
                sum = arr[i]+arr[i+1];
                if (sum % 2 == 0)
                    score = score + 5;
            }
            for(int  j=0; j<array_length-2; j++)
            {
                sum = arr[j] + arr[j + 1] + arr[j+2];
                product = arr[j] * arr[j+1]*arr[j+2];
                if(sum %2!=0 && product%2==0)
                    score = score + 10;
            }
            return score;
        }
            static void Main(string[] args)
        {
            int array_length = Int32.Parse(Console.ReadLine().Trim());

            List<int> arr = new List<int>();
            for (int j = 0; j < array_length; j++)
            {
                arr.Add(Int32.Parse(Console.ReadLine().Trim()));
            }
            int result = score(array_length, arr);

            Console.WriteLine(result);
        }
    }
}