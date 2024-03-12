namespace TotalCouples
{
    internal class Program
    {
        static int numDivisible(int N, List<int> arr)
        {
            int count = 0;
            for(int i=0; i <arr.Count-1; i++) 
            { 
                int sum = arr[i] + arr[i+1];
                if(sum%N == 0)
                {
                    count = count + 1;
                }
            }
            return count;
        }
            static void Main(string[] args) { int N; N = Convert.ToInt32(Console.ReadLine()); int array_length; array_length = Convert.ToInt32(Console.ReadLine()); List<int> arr = new List<int>(); for (int j = 0; j < array_length; ++j) { int arrItem = Convert.ToInt32(Console.ReadLine()); arr.Add(arrItem); } int result; result = numDivisible(N, arr); Console.Write(result); }
    }
}