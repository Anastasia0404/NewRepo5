namespace Application;

public class Employee
{
    private string name;
    private string lastname;
    private string job;
    private int experience;

    public Employee(string name, string lastname)
    {
        this.name = name;
        this.lastname = lastname;
        job = "";
        experience = 0;
    }

    public string Name
    {
        get => name;
        set => name = value;
    }

    public string Lastname
    {
        get => lastname;
        set => lastname = value;
    }

    public string Job
    {
        get => job;
        set => job = value;
    }

    public int Experience
    {
        get => experience;
        set => experience = value;
    }

    public double Salary()
    {
        if (job == String.Empty)
            return 0;

        double extra = 100 * experience;
        
        switch (job.ToLower())
        {
            case "artist": return 1000 + extra;
            case "carwasher": return 1200 + extra;
            case "cheif": return 10000 + extra;
            case "operator": return 2000 + extra;
            case "programmist": return 3000 + extra;
        }

        return 500 + extra;
    }

    public double Tax()
    {
        return Salary() * 0.18;
    }
}
