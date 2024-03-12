namespace ListSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> number = new List<int> { 5, 10, 4, 8, 6, 3, 1 };
            number.Sort();
            foreach (int numberr in number)
            {
            Console.WriteLine(numberr);
            }
            number.Reverse();
            Console.WriteLine("After reverse");
            foreach (int numberr in number)
            {
                Console.WriteLine(numberr);
            }
            List<Student> students = new List<Student>()
            {
                new Student() {Id = 1,Name="ABC",mark=50}
                ,new Student() {Id=2,Name="BCD" ,mark=30}
            };
            Console.WriteLine("Before Sorting");
            foreach (Student student in students) 
            {
                Console.WriteLine($"{student.Id},{student.Name},{student.mark}");
            }
           // students.Sort();
           students.Sort();
            Console.WriteLine("After sorting");
            foreach (Student student in students)
            {
                Console.WriteLine($"{student.Id},{student.Name},{student.mark}");
            }
          
        }
    }
}   