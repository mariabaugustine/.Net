namespace LuckyNumber
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
            int sumcount = 0;
            for (int i = 0; i < Arr.Count; i++)
            {
                int count = 0;
                string temp = Arr[i].ToString();
                for (int j = 0; j < temp.Length; j++)
                {
                    if (temp[j] == '3' || temp[j] == '4' || temp[j] == '7')
                    {
                        count++;
                    }
                }
                if (count == 3 || count == 4 || count == 7)
                {
                    sumcount++;
                }
            }
            return sumcount;
        }
        

    }

}