using System;

class Abstraction
{
    public static void Main()
    {
        Customer customer = new Customer();
        customer.Menu();
        customer.Price();
        customer.Serve();
    
    }
}

abstract class Hotel
{
     
    public abstract void Price();

    public abstract void Serve();

    public abstract void Menu();
}

abstract class Kitchen : Hotel
{
    protected abstract void Ingredients();

    protected abstract void CookingMethod();
}

class Owner : Kitchen
{
     protected override void Ingredients()
    {
        Console.WriteLine("Ingredients using for cooking");
    }
    private void Purchasevendor()
    {
        Console.WriteLine("Vendor for materials");
    }

    protected override void CookingMethod()
    {
        Console.WriteLine("Cooking method for soup");
    }

    public override void Menu()
    {
        Console.WriteLine("Available menu");
    }

    public override void Price()
    {
        Console.WriteLine("Price for dishes");
    }

    public override void Serve()
    {
        Console.WriteLine("Waiter serve the dish");
    }
    
}

class CookingMaster : Owner
{
     protected override void Ingredients()
    {
        Console.WriteLine("Ingredients for specific dishes");
    }

    protected override void CookingMethod()
    {
        Console.WriteLine("Cooking method for specific dishes");
    }

    public override void Menu()
    {
        Console.WriteLine("Available Menu");
    }

    
}

class Server : CookingMaster
{
    public override void Menu()
    {
        base.Menu();
        Console.WriteLine("Available Menu");

    }
    public override void Price()
    {
        base.Price();
        Console.WriteLine("Prices for specific dieshes");
    }

    public override void Serve()
    {
        base.Serve();
        Console.WriteLine("Serve dishes for customer");
    }
    

    
}

class Cashier : Server
{
    public override void Menu()
    {
        Console.WriteLine("Available Menu");

    }
    public override void Price()
    {
        Console.WriteLine("Prices for specific dieshes");
    }
}

class Customer : Server
{
    public override void Menu()
    {
        Console.WriteLine("Available Menu");

    }
    public override void Price()
    {
        Console.WriteLine("Prices for specific dieshes");
    }
}