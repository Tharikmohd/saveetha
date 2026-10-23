using System;
using System.Collections.Generic;

class Genericcollection
{
    public static void Main()
    {
        //List

        /*List<int> list = new List<int>();

        list.Add(23);
        list.Add(43);
        list.Add(213);
        list.Add(345);

        foreach(int item in list)
        {
            Console.Write(item + " ");
        }

        Console.WriteLine();

        Console.WriteLine("Add with addrange");

        int [] num = {34,87,99,11,12,34,54};

        list.AddRange(num);
        foreach(int item in list)
        {
            Console.Write(item + " ");
        }

        Console.WriteLine();

        Console.WriteLine("Removing elements");

        list.Remove(34);
        foreach(int item in list)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();

        list.RemoveAt(2);
        foreach(int item in list)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
        list.RemoveRange(2,3);
        foreach(int item in list)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();

        LinkedList<int> lklist = new LinkedList<int>();

        lklist.AddFirst(23);
        lklist.AddLast(45);
        lklist.AddFirst(43);
        lklist.AddFirst(456);

        foreach(int items in lklist)
        {
            Console.Write(items +" ");
        }

        Console.WriteLine();

        LinkedListNode<int> node = lklist.Find(456);

        if(node != null)
        {
            lklist.AddAfter(node, 90);
        }

        foreach(int i in lklist)
        {
            Console.WriteLine(i);
        }

        lklist.Remove(456);
        foreach(int i in lklist)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine("remove");
        lklist.RemoveFirst();
        foreach(int i in lklist)
        {
            Console.WriteLine(i);
        }

        lklist.RemoveLast();
        foreach(int i in lklist)
        {
            Console.WriteLine(i);
        }

        Dictionary<int, string> dct = new Dictionary<int, string>();

        dct.Add(102,"chennai");
        dct.Add(109,"mango");
        dct.Add(10,"orange");

        foreach(object item in dct)
        {
            Console.WriteLine(item);
        }

        dct.Remove(10);
        foreach(object item in dct)
        {
            Console.WriteLine(item);
        }

        dct.TryAdd(12,"val");
        foreach(object item in dct)
        {
            Console.WriteLine(item);
        }

        SortedList<int, string> fruit = new SortedList<int, string>();

        fruit.Add(87,"kiwi");
        fruit.Add(3,"orange");
        fruit.Add(1,"mango");
        fruit.Add(45,"grapes");
        fruit.Add(23,"kiwi");

        foreach(object obj in fruit)
        {
            Console.WriteLine(obj);
        }

        Console.WriteLine("Remove");
        fruit.Remove(23);
        foreach(object obj in fruit)
        {
            Console.WriteLine(obj);
        }

        fruit.RemoveAt(2);
         foreach(object obj in fruit)
        {
            Console.WriteLine(obj);
        }

        HashSet<string> hset = new HashSet<string>();

        hset.Add("blue");
        hset.Add("black");
        hset.Add("orange");
        hset.Add("green");
        hset.Add("blue");
        hset.Add("pink");
        hset.Add("orange");

        foreach(string item in hset)
        {
            Console.WriteLine(item);
        }

        hset.Remove("blue");
        foreach(string item in hset)
        {
            Console.WriteLine(item);
        }


        Stack<string> book = new Stack<string>();

        book.Push("DSP");
        book.Push("Automobile");
        book.Push("OOp");
        book.Push("PE");

        foreach(string books in book)
        {
            Console.WriteLine(books);
        }

        Console.WriteLine(book.Pop());
        Console.WriteLine(book.Peek());*/

        Queue <string> qts = new Queue<string>();

        qts.Enqueue("Honda");
        qts.Enqueue("bajaj");
        qts.Enqueue("Hero");
        qts.Enqueue("tvs");

        foreach(string item in qts)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine(qts.Dequeue());
    




        






    }
}