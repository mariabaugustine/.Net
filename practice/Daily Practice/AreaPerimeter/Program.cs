namespace AreaPerimeter
{
    internal class Program
    {
        static int absoluteDifferenceTypeATypeB(int array_length, List<int> arr)
        {
            int A = 0;
            int B = 0;
            for(int i = 0; i < array_length-1; i++) 
            { 
                int Length = arr[i];
                int width = arr[i+1];
                int area = Length * width;
                int perimeter = 2 * (Length + width);
                if(area>perimeter)
                {
                    A++;
                }
                else if(area<perimeter)
                {
                    B++;
                }
               
            }
            int difference = Math.Abs(A - B);
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