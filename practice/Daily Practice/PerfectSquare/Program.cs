namespace PerfectSquare
{
    internal class Program
    {
        static int numPerfectSquares(int array_length, List<int> arr)
        {
            int count = 0;
            for(int i=0; i<array_length; i++)
            {
                int a =(int) Math.Sqrt(arr[i]);
                double product=a*a;
                if (product== arr[i])
                {
                    count = count + 1;
                }
            }
            return count;
        }
        static void Main(string[] args)
        {
            int array_length = Int32.Parse(Console.ReadLine().Trim());

            List<int> arr = new List<int>();
            for (int j = 0; j < array_length; j++)
            {
                arr.Add(Int32.Parse(Console.ReadLine().Trim()));
            }
            int result = numPerfectSquares(array_length, arr);

            Console.WriteLine(result);
        }
    }
}