namespace ListExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Student[] student = new Student[3];
            //student[0] = new Student { Id = 1 ,Name="Maria",Marks=50};
           // student[1]=new Student { }
;
            var  students = new List<Student>();
            // students[0] = new Student {Id=1,Name="maria",Marks=50};
            // students[1] = new Student {Id=2,Name ="Athira",Marks=100 };
            //students[2] = new Student {Id=3,Name="aleeana",Marks=200};
            students.Add(new Student() { Id=1,Name="maria",Marks=50});
            students.Add(new Student() { Id=2,Name="lizza",Marks=50});
            students.Add(new Student() { Id = 3, Name = "Allu", Marks = 60 });


                foreach (Student student in students) 
            { 
                Console.WriteLine($"Name:{student.Name},Marks:{student.Marks},Id:{student.Id}");
            }
            Console.WriteLine("Name mark<60");
     
          var failedStudentList=students.FindAll(student1 => student1.Marks<80);
            foreach (Student student in failedStudentList)
            {
                Console.WriteLine($"Name:{student.Name}");
            }
            Console.WriteLine("Name starts with a and mark<70");
            var nameStudent = students.FindAll(students => students.Name.StartsWith("A") && students.Marks < 70);
            foreach(Student student in nameStudent)
            {
                Console.WriteLine($"Name:{student.Name}");
            }




        }
    }
}