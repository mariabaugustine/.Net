namespace PyramidSum
{
    internal class Program
    {
        static int FindPyramidSum(List<int> arr) { while (arr.Count > 1) { List<int> temp = new List<int>(arr.Count - 1); for (int i = 0; i < arr.Count - 1; i++) { temp.Add(arr[i] + arr[i + 1]); } arr = temp; } return arr[0]; }
        static int pyramidSum(int array_length, List<int> arr) { int pyramidSum = FindPyramidSum(arr); return pyramidSum; }
        static void Main(string[] args) { int array_length = Int32.Parse(Console.ReadLine().Trim()); List<int> arr = new List<int>(); for (int j = 0; j < array_length; j++) { arr.Add(Int32.Parse(Console.ReadLine().Trim())); } int result = pyramidSum(array_length, arr); Console.WriteLine(result); }
    }
}