using System;

// class Admisison<T>
// {
    
//     public T Value {get; set;}

//     public Admisison(T value)
//     {
        
//         this. Value = value;
//     }

//     public void Print()
//     {
//         Console.WriteLine($"Name : {0},  : Value : {Value}");
//     }
// }

public record class UPS(string destination, int routeid)
{
    public string transportmode{get; init;} = "By Road";

    public void Showdisplay()
    {
        Console.WriteLine($"End Point : {destination},   Route : {routeid},  Mode of Transport : {transportmode}");
    }
}


class Typesclasses
{
    public static void Main()
    {
        UPS ups = new UPS("Madurai", 2354)
        {
            transportmode = "By Train"
        };

        UPS ups1 = new UPS("Bangalore", 4356);

        


        ups.Showdisplay();
        ups1.Showdisplay();

        ups1 = ups1 with {transportmode = "By Air"};
        ups1.Showdisplay();

        ups = ups with {transportmode = "By Road"};

        Console.WriteLine(ups == ups1);

        Console.WriteLine(ups);

        var (destination, routeid) = ups;

        Console.WriteLine($"{destination}, {routeid}");
    }
}