using System;
using System.ComponentModel.DataAnnotations;

class College
{   
    string? name;
    int? age;

    // public static string? collegename;

    //default constructor
    /*public College()
    {
        Console.WriteLine("Default Constructor intialized");
    }

    //Parameter Constructor

    public College(string n, int a)
    {
       name =  n;
       age = a;  

    //    Console.WriteLine($"{name} - {age}");
    }

    public College(College cg)
    {
        name = cg.name;
        age = cg.age;   

    }

    static College()
    {
        collegename = "Saveetha University"; 
    }*/

    //private Constructor

    /*private College()
    {
        Console.WriteLine("Private Constructor Intialized");
    }

    public static void Display()
    {
        College c2 = new College();
    }*/

    public College()
    {
        Console.WriteLine("Constructor overloading...");
    }
    public College(string n)
    {
        name = n;

        Console.WriteLine(name);
        
    }

    public College(string n, int a)
    {
      name = n;
      age =a;  

      Console.WriteLine(name);
      Console.WriteLine(age); 
    }

    public static void Main()
    {
        College c2 = new College();
        College college = new College("Kiran", 24);
        College c1 = new College("Saveetha");
         

        // Console.WriteLine($"{c1.name} - {c1.age}");

        
    }
}