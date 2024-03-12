namespace NearlyLucky
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N;
            N = Convert.ToInt32(Console.ReadLine());
            List<int> Arr = new List<int>();
            for (int j = 0; j < N; ++j)
            {
                int ArrItem = Convert.ToInt32(Console.ReadLine());
                Arr.Add(ArrItem);
            }

            int result;
            result = nearlyLucky(Arr);
            Console.WriteLine(result);
        }
        static int nearlyLucky(List<int> Arr)
        {
            int tcount = 0;
           for(int i=0;i<Arr.Count;i++)
            {
                int count = 0;
                while (Arr[i]>0)
                {
                    
                    int result = Arr[i] % 10;
                    if(result==3||result==4||result==7)
                    {
                        count++;
                    }
                    Arr[i] = Arr[i] / 10;
                }
                if(count==3||count==4||count==7)
                {
                    tcount++;
                }
            }
           return tcount;
        }
    }
}