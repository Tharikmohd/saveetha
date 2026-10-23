using System;

class Arraysdemo
{
    public static void Main()
    {
        Console.Write("Enter the size of the array : ");
        int size = Convert.ToInt32(Console.ReadLine());

        int [] datas = new int [size];

        for(int i=0; i<size; ++i)
        {
            Console.Write($"Enter the element of {i} : ");
            datas[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("1 Dimensional Array");

        for(int i =0; i<size; i++)
        {
            Console.Write(datas[i] + " ");
        }

        Console.WriteLine();

        int sum =0;

        for(int i=0; i<datas.Length; i++)
        {
            sum += datas[i];
        }

        Console.WriteLine($"Sum of the index value : {sum}");

        int max = datas[0];  //32

        for(int i =0; i<datas.Length; i++)
        {
            if(datas[i]>max)
            {
                max = datas[i];
            }

            
        }
        Console.WriteLine("Maximum value in given elements : " + max);

        int min = datas[0];  //32

        for(int i =0; i<datas.Length; i++)
        {
            if(datas[i]<max)
            {
                min = datas[i];
            }

            
        }
        Console.WriteLine("Maximum value in given elements : " + min);

    }
}