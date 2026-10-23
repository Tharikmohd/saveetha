using System;
using System.Security.Authentication;

class Methodfunc
{
    public static void Main()
    {
        Methodfunc methodfunc = new Methodfunc();
        Functions function = new Functions();
        /*Greet();
        methodfunc.Display();
        Add();
        Functions.Sub(3,4);
        Console.WriteLine(Mul());
        Console.WriteLine(Div(8,84));
        Console.WriteLine(Location("Madurai"));*/

        int a = 56;
        function.Updatevalue(a);
        Console.WriteLine(a);

        int b = 18;
        Console.WriteLine("Before ref value : " +b);
        function.refvalue(ref b);
        Console.WriteLine("After reference value : " +b);

        int c = 56;
        function.outvalue(out c);
        Console.WriteLine(c);

        Functions.callMethod(Functions.display );

        Functions.result(Functions.value1(),  Functions.value2());



    }

    //static Method
    public static void Greet()
    {
        Console.WriteLine("Lets start Method function class");
    }


    //Instance methos
    public void Display()
    {
        Console.WriteLine("Instance Method");
    }


    //Without parameter without returntype

    public static void Add()
    {
        Console.Write("Enter the value1 : ");
        int value1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the value2 : ");
        int value2 = Convert.ToInt32(Console.ReadLine());

        int result = value1 + value2;

        Console.WriteLine(result);
    }

    public static int Mul()
    {
        Console.Write("Enter the value1 : ");
        int value1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the value2 : ");
        int value2 = Convert.ToInt32(Console.ReadLine());

        int result = value1 * value2;

        return result;        
        
    }

    public static int Div(int a, int b)
    {
        int result = b/a;
        return result;
    }

    public static string Location(string city = "chennai")
    {
        return city;
    }

}

class Functions
{
    public static void Sub(int a, int b)
    {
        Console.Write("Enter the value1 : ");
        int value1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the value2 : ");
        int value2 = Convert.ToInt32(Console.ReadLine());

        int result = value1 - value2;

        Console.WriteLine(result);
        
    }


    //Call by value
    public void Updatevalue(int a)
    {
        a = 50;
    }

    //call by ref

    public  void refvalue (ref int b)
    {
        b = 45;
    }

    //call by out

    public void outvalue(out int c)
    {
        c = 33;
    }

    public static void display()
    {
        Console.WriteLine("Callback value");
    }

    public static void callMethod(Action callback)
    {
        callback();
    }

    public static int value1()
    {
        Console.Write("Enter the value 1 : ");
        return Convert.ToInt32(Console.ReadLine());

    }
    public static int value2()
    {
        Console.Write("Enter the value 2 : ");
        return Convert.ToInt32(Console.ReadLine());

    }

    public static void result (int a, int b)
    {
        int results = a +b;

        Console.WriteLine(results);

    }

    
}