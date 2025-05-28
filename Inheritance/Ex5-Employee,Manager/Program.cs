using System;

class Employee
{
    public string Name { get; set; }
    public int EmployeeID { get; set; }

    public Employee(string name, int id)
    {
        Name = name;
        EmployeeID = id;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}, EmployeeID: {EmployeeID}");
    }
}

class Manager : Employee
{
    public string Department { get; set; }

    public Manager(string name, int id, string department)
        : base(name, id)
    {
        Department = department;
    }

    public void DisplayManagerInfo()
    {
        DisplayInfo();
        Console.WriteLine($"Department: {Department}");
    }
}

class SalesRepresentative : Employee
{
    public int SalesTarget { get; set; }

    public SalesRepresentative(string name, int id, int target)
        : base(name, id)
    {
        SalesTarget = target;
    }

    public void DisplaySalesInfo()
    {
        DisplayInfo();
        Console.WriteLine($"Sales Target: {SalesTarget}");
    }
}

class Intern : Employee
{
    public string University { get; set; }

    public Intern(string name, int id, string university)
        : base(name, id)
    {
        University = university;
    }

    public void DisplayInternInfo()
    {
        DisplayInfo();
        Console.WriteLine($"University: {University}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Manager manager = new Manager("Alice", 101, "HR");
        SalesRepresentative salesRep = new SalesRepresentative("Bob", 102, 50);
        Intern intern = new Intern("Charlie", 103, "XYZ University");

        Console.WriteLine("Manager Information:");
        manager.DisplayManagerInfo();

        Console.WriteLine("\nSales Representative Information:");
        salesRep.DisplaySalesInfo();

        Console.WriteLine("\nIntern Information:");
        intern.DisplayInternInfo();

        Console.ReadKey();
    }
}
