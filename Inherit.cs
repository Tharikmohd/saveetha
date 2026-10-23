using System;

class Inherit
{
    public static void Main()
    {
        Finance finance = new Finance();

        finance.Idshow();
        finance.Deptshow();
        finance.Details();

    }
}

class Student
{
    public string name = "Gokul";
    public int age = 23;

    public void Idshow()
    {
        Console.WriteLine("Student Details are  Created...");
    }
}

class Department : Student
{
    public string department = "MCT";

    public void Deptshow()
    {
        Console.WriteLine("Department has been updated..");
    } 
}

class Finance : Department
{
    public double fee = 75000.00;

    public void Details()
    {
        Console.WriteLine("Student Name : " +name);
        Console.WriteLine("Department : " +department);
        Console.WriteLine("Age : " +age);
        Console.WriteLine("Fee : " +fee);
    }
}