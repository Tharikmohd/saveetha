using System;

class NormalObject
{
    public string name {get; set;}
    public int id {get; set;}
    public string dept {get; set;}

    public static void Main()
    {
        NormalObject no = new NormalObject
        {
            name = "Arjun",
            id = 45,
            dept = "CSE"
        };

        List<string> list = new List<string>
        {
            "Mech", "Mct", "EEE","ECE","AIDS","AIML","CSE"
        };

        foreach(string i in list)
        {
            Console.Write(i +" ");
        }
        Console.WriteLine();
        Dictionary<int, string> dt = new Dictionary<int, string>
        {
            {18, "Virat"},
            {45, "Rohit"},
            {07, "Dhoni"}
        };

        foreach(var i in dt)
        {
            Console.WriteLine(i +" ");
        }

    }
}