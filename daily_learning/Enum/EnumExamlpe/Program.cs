namespace EnumExamlpe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee[] employee = new Employee[3];
            employee[0]=new Employee { Id = 1, Name = "Bhagya", Gender = Gender.Female };
            employee[1] = new Employee { Id = 2, Name = "Arun", Gender = Gender.Male };
            employee[2] = new Employee { Id = 3, Name = "Malu", Gender = Gender.Female };
            foreach (Employee emp in employee) 
            {
                Console.WriteLine($"Id:{emp.Id},Name:{emp.Name}, Gender:{emp.Gender}");
            }
        }
    }
}