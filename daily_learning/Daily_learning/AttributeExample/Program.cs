namespace AttributeExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            s.setDetails(1, "Taylor", 92.5);

            Console.WriteLine("Student Details");
            Console.WriteLine("Roll Number : " + s.getRollNo());
            Console.WriteLine("Name : " + s.getStudentName());
            Console.WriteLine("Marks : " + s.getMarks());
        }
    }
}