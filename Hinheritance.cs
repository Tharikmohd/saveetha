using System;

class Hinheritance
{
    public static void Main()
    {
        Manager manager = new Manager();
        Payroll payroll = new Payroll();
        Console.WriteLine("Manager Inherit from Employee");
        manager.Getdetails();
        manager.Allocate();
        Console.WriteLine("--------------------");
        Console.WriteLine("Payroll Inherit from Employee");
        payroll.Getdetails();
        payroll.Confirmation();

        
    }
}

class Employee
{
    public string name = "Gowtham";

    public int experience = 3;

    public void Getdetails()
    {
        Console.WriteLine("Employee basic info updated...");
    }
}

class Manager : Employee
{
    public string pname = "ABC Funding";

    public string role = "Frontend";

    public void Allocate()
    {
        Console.WriteLine($"Project has been allocated to {name}");
        Console.WriteLine($"Alocated Project : {pname}");
        Console.WriteLine("Role : " +role);
    }
}


class Payroll : Employee
{
    public double salary = 45000;

    public void Confirmation()
    {
        Console.WriteLine("Salary has been updated for Employee");
        Console.WriteLine("Employee Name : "+name);
        Console.WriteLine("Experience : " +experience);
        Console.WriteLine("Salary : "+salary);
    }
}