using System;

namespace Application
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Employee employee = new Employee("Natalia", "Kovalchenko");
            employee.Job = "programmist";
            employee.Experience = 5;
            
            Console.WriteLine("Employee");
            Console.WriteLine($"Name: {employee.Name} {employee.Lastname}");
            Console.WriteLine($"Job: {employee.Job}");
            Console.WriteLine($"Experience: {employee.Experience}");
            Console.WriteLine($"Salary: {employee.Salary()}");
            Console.WriteLine($"Tax: {employee.Tax()}");
        }
    }
}