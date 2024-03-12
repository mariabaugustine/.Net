namespace ProductOfNandS
{
    internal class Program
    {
        static int check(List<int> A)
        {
            int sum = 0;
            int product = 1;
            for(int i=0; i<A.Count; i++)
            {
                sum = sum + A[i];
            }
            product = A.Count*sum; 
            return product;
        }
        static void Main(string[] args)
        {
            int N;
            N = Convert.ToInt32(Console.ReadLine());
            List<int> A = new List<int>();
            for (int j = 0; j < N; ++j)
            {
                int AItem = Convert.ToInt32(Console.ReadLine());
                A.Add(AItem);
            }
            int result;
            result = check(A);
            Console.Write(result);
        }
    }
}