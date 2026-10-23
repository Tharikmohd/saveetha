using System;
using System.Collections;

class Nongenericcollection
{
    public static void Main()
    {
        //ArrayList

        /*ArrayList list = new ArrayList();

        list.Add(23);
        list.Add("Hello");
        list.Add("Saveetha");
        list.Add(23.45);
        list.Add(true);
        list.Add(4500.89);

        foreach(object item in list ) //dynamic loop
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("add elements using addrange");
        int [] arr = {23,56,78,90,100,125,76,98};


        list.AddRange(arr);

        foreach(object item in list ) //dynamic loop
        {
            Console.Write(item +" ");
        }

        Console.WriteLine();
        string [] val = {"chennai","madurai","kovai","Delhi"};

        list.AddRange(val);
        foreach(object item in list ) //dynamic loop
        {
            Console.Write(item +" ");
        }
        Console.WriteLine();
        Console.WriteLine("Remove elements : ");
        list.Remove(true);
        foreach(object item in list ) //dynamic loop
        {
            Console.Write(item +" ");
        }
        Console.WriteLine();

        list.RemoveAt(6);
        foreach(object item in list ) //dynamic loop
        {
            Console.Write(item +" ");
        }
        Console.WriteLine();
        list.RemoveRange(2,6); //2 -- staring index, 6-- how many no of value delete from starting  index
        foreach(object item in list ) //dynamic loop
        {
            Console.Write(item +" ");
        }

        Console.WriteLine("Count : " + list.Count);
        Console.WriteLine("Capacity : " + list.Capacity);
        Console.WriteLine("Fixed size : " +list.IsFixedSize);
        Console.WriteLine("Is this Readable : " +list.IsReadOnly);
        Console.WriteLine("Is this sync : " +list.IsSynchronized);*/

        //Hashtable --- Key value - pair like dictionary

       /* Hashtable val = new Hashtable();

        val.Add(101,"Henry");
        val.Add(102,"james");
        val.Add(104,"Kiran");
        val.Add(103,"Daavid");
        val.Add(105, "Gabby");

        foreach(object item in val)
        {
            Console.WriteLine(item);
        }
        foreach(object item in val.Keys)
        {
            Console.WriteLine(item);
        }
        foreach(object item in val.Values)
        {
            Console.WriteLine(item);
        }

        val.Remove(101);

        foreach(object item in val)
        {
            Console.WriteLine(item);
        }

        SortedList slt = new SortedList();

        slt.Add(123,"CSharp");
        slt.Add(1,"Python");
        slt.Add(45,"Java");
        slt.Add(3,"R");
        slt.Add(43,"C++");

        foreach(object obj in slt)
        {
            Console.WriteLine(obj);
        }

        slt.Remove(45);
        foreach(object obj in slt)
        {
            Console.WriteLine(obj);
        }

        slt.RemoveAt(2);
        foreach(object obj in slt)
        {
            Console.WriteLine(obj);
        }

        Console.WriteLine(slt.GetByIndex(1));


        Stack sst = new Stack();

        sst.Push(45);
        sst.Push("Chennai");
        sst.Push("Programming");
        sst.Push("Dotnet");

        foreach(object obj in sst)
        {
            Console.WriteLine(obj);
        }

        Console.WriteLine("POP : " +sst.Pop() );
        Console.WriteLine("Peek : " +sst.Peek());*/

        Queue qt = new Queue();

        qt.Enqueue("movie");
        qt.Enqueue("magic");
        qt.Enqueue("ticket");
        qt.Enqueue("Cricket");

        foreach(object onj in qt)
        {
            Console.WriteLine(onj);
        }

        Console.WriteLine("Remove " +qt.Dequeue());


        


    }
}