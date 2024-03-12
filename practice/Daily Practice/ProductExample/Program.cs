namespace ProductExample
{
    internal class Program
    {
        static int check(List<int> A)
        {
            int N=A.Count;
            int sum = 0;
            for(int i=0;i<N;i++) 
            {
                sum = sum + A[i];
            }
            int product = sum * N;
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