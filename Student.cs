using System;
using System.Dynamic;
using System.Security.Cryptography;

class Studentsss
{
    /*//field
    public string name;
    public int marks;

    //property - Auto property

    public string Name{get; set;}
    public int Marks{get; set;}

    public Student(string name, int marks)
    {
        this.name = name;
        this.marks = marks;

        Name = name;
        Marks = marks;
    }

    public void Display()
    {
        Console.WriteLine(this.name);
        Console.WriteLine(this.marks);
    }*/

    private string name;
    private int marks;

    public string Name
    {
        get
        {
            return this.name;
        }
        set
        {
            this.name = value;
        }
    }

    public int Marks
    {
        get
        {
            return this.marks;
        }
        set
        {
            if(value >=0 && value <=100)
            {
                this.marks = value;
            }

        }
    }

    public Studentsss(string name, int marks)
    {
        this.name = name;
        this.marks = marks;
    }

    public void Display()
    {
        Console.WriteLine("Name = " +this.name);
        Console.WriteLine("Marks = "+this.marks);
    }

    public static void Main()
    {
        Studentsss student = new Studentsss("Arun", 90);

        student.Name = "Karthi";
        student.Marks = 99;

        student.Display();
    }


}