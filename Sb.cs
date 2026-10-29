using System;
using System.Diagnostics;
using System.Text;

class Sb
{
    public static void Main()
    {
        string s = "";
        StringBuilder sbuilder = new StringBuilder("");
        Stopwatch sw1 = new Stopwatch();
        Stopwatch sw2 = new Stopwatch();

        sw1.Start();
        for(int i=0; i<1000; i++)
        {
            s+=i;
        }
        sw1.Stop();

        sw2.Start();
        for(int i=0; i<1000; i++)
        {
            sbuilder.Append(i);
        }
        sw2.Stop();
            

        Console.WriteLine("String  : " +sw1.ElapsedMilliseconds);
        Console.WriteLine("Stringbuilder  : " +sw1.ElapsedMilliseconds);
        Console.WriteLine(s.Length);
        Console.WriteLine(sbuilder.Capacity);

        var sbs = new StringBuilder(capacity: 1000);  // pre-size if you know roughly how big it'll get
        sbs.AppendLine("First line");
        sbs.Append("Name: ").Append("mohammad").Append(", Age: ").Append(20);  // chaining works
        sbs.Insert(0, "Header: ");
        sbs.Replace("old", "new");
        Console.WriteLine(sbs.ToString());
    }
}