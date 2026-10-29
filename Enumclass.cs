using System;
using System.Diagnostics;

enum Days
{
    Sunday,
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Staurday
}

class Enumclass
{
    public static void Main()
    {
        for(int i =0; i<=7; i++)
        {
            Console.WriteLine($"Days {i} : {(Days)i}");
        }
        Console.WriteLine((Days)4);
    }
}