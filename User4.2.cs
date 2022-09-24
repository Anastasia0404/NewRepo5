namespace Application;

public class Date
{
    public int Day { get; private set; }
    public int Month { get; private set; }
    public int Year { get; private set; }

    public Date(int day, int month, int year)
    {
        Day = day;
        Month = month;
        Year = year;
    }

    public void PrintInfo()
    {
        Console.WriteLine($"{Day}/{Month}/{Year}");
    }
}

public class User
{
    public string Login { get; set; }
    public string Name { get; set; }
    public string Lastname { get; set; }
    public int Age { get; set; }
    public Date Date { get; private set; }

    public User(string login, string name, string lastname, int age, Date date)
    {
        Login = login;
        Name = name;
        Lastname = lastname;
        Age = age;
        Date = date;
    }

    public void PrintInfo()
    {
        Console.WriteLine($"Login: {Login}");
        Console.WriteLine($"Name: {Name} {Lastname}");
        Console.WriteLine($"Age: {Age}");
        Console.Write($"Date:");
        Date.PrintInfo();
        Console.WriteLine();
    }
}