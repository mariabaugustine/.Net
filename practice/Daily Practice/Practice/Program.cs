namespace Practice
{
    internal class Program
    {
        static int MostSpecialNumber(int n, List<int> arr)
        {
            // Write your code here
            int max = 0;
            int count = 1;
            List<int> newList = new List<int>();
            for (int i = 0; i < arr.Count; i++)
            {
                string temp = arr[i].ToString();
                for (int j = 0; j < arr.Count; j++)
                {
                    for (int k = j + 1; k < arr.Count; k++)
                    {
                        if (arr[j] == arr[k])
                        {

                            count = count + 1;
                        }
                    }
                }
                if (count != 0)
                {
                    newList.Add(arr[i]);
                }
                max = newList.Max();
            }

            return max;
        }

        static void Main(string[] args)
        {
            int n;
            n = Convert.ToInt32(Console.ReadLine());
            List<int> arr = new List<int>();
            for (int j = 0; j < n; ++j)
            {
                int arrItem = Convert.ToInt32(Console.ReadLine());
                arr.Add(arrItem);
            }

            int result;
            result = MostSpecialNumber(n, arr);
            Console.Write(result);
        }
    }
}