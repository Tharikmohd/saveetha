using System;

struct  Furniture
{
    public string Model {get; set;}
    public double Price{get; set;}

    public string Material{get; set;}

    public Furniture(string model, double price, string material)
    {
        Model=model;
        Price = price;
        Material = material;
    }

    public void Display()
    {
        Console.WriteLine(Model);
        Console.WriteLine(Price);
        Console.WriteLine(Material);
    }
}

  


class Sales 
{
    public static void Main()
    {
        Furniture furniture = new Furniture("king size bed", 75000, "teak wood");

        

        furniture.Display();
    }
}