using System;
using System.Collections.Generic;

class Studentmgmt
{
    public static void Main()
    {
        Console.WriteLine("Enter the count of Students : ");
        int count = Convert.ToInt32(Console.ReadLine());

        List<Person> people = new List<Person>();

        for(int i =0; i< count; i++)
        {
            Console.WriteLine("Enter the student name : ");
            String name = Console.ReadLine();
            Console.WriteLine($"Enter the Marks of {name} : ");
            int marks = Convert.ToInt32(Console.ReadLine());

            people.Add(new Students(name, marks));
        }

        foreach(Person person in people)
        {
            person.Display();
        }
        
    }
}

abstract class Person
{
    public string?  Name {get; set;}

    public Person(string name)
    {
        this.Name = name;
    }

    public abstract void Display();
    
}

class Students : Person
{
    private int score;

    public int Score
    {
        get
        {
            return score;
        }

        set
        {
            if(value >= 0 && value <= 100)
            {
                score = value;
            }
            else
            {
                Console.WriteLine("Invalid marks");
            }
        }
    }

    public Students(string name, int marks) : base(name)
    {
        Score = marks;
    }

    public override void Display()
    {
        Console.WriteLine($"Name : {Name},  Marks : {score}");
    }
}