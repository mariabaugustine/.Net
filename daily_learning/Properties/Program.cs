namespace Properties
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Student student = new Student();
            student.StudentId= 1;
            Class1 class1= new Class1();
            int id= student.StudentId;
            class1.Display(id);
           // var id=Console.WriteLine(student.StudentId);
           // student.StudentName = "";
        }
    }
}