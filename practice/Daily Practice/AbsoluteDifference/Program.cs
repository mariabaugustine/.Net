namespace AbsoluteDifference
{
    internal class Program
    {
        static int absoluteDifferenceTypeATypeB(int array_length, List<int> arr)
        {
            int aCount = 0;
            int bCount = 0;
            //int area = 0;
            //int perimeter = 0;
            for (int i = 0; i < array_length - 1; i++)
            {
                int l = arr[i];
                int w = arr[i + 1];
                int area = l * w;
                int perimeter = 2 * (l + w);


                if (area > perimeter)
                {
                    aCount++;
                }
                if (area < perimeter)
                {
                    bCount++;
                }
            }
            int difference = Math.Abs(bCount - aCount);
            return difference;
        }
        static void Main(string[] args)
        {
            int array_length = Int32.Parse(Console.ReadLine().Trim());

            List<int> arr = new List<int>();
            for (int j = 0; j < array_length; j++)
            {
                arr.Add(Int32.Parse(Console.ReadLine().Trim()));
            }
            int result = absoluteDifferenceTypeATypeB(array_length, arr);

            Console.WriteLine(result);
        } 
    }
}