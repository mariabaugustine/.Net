using System.Security.Cryptography.X509Certificates;

namespace staticexample; 

internal class Program
{
    public string student;
    public string college;
    public void SetDetails(string studentn, string collegeN)
    {
        student = studentn;
        college = collegeN;
    }
    public void display()
    {
        Console.WriteLine(student);
        Console.WriteLine(college);
    }
    public static int age;
    static void get(int agee)
    {
        age = agee;
    }
    public static void print()
    {
        Console.WriteLine(age);

    }

    static void Main(string[] args)
    {
        Program p=new Program();
        p.SetDetails("aa", "b");
        p.display();
        get(12);
        print();
        
    }
}

