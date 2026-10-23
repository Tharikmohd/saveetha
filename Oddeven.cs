using System;

class Oddeven
{
    public static void Main()
    {
        Console.Write("Enter the size of Layer : ");
        int layer = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the size of row : ");
        int row = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the size of column : ");
        int col = Convert.ToInt32(Console.ReadLine());

        int [,,] oddevn = new int[layer,row,col];

        int values;
        for(int i=0; i < layer; i++)
        {
            for(int j =0; j < row; j++)
            {
                for(int k = 0; k < col; k++)
                {
                    Console.Write($"Enter the element {i},{j},{k} : ");
                    oddevn[i,j,k]= Convert.ToInt32(Console.ReadLine());
                }
                
            }
        }

        for(int i =0; i< layer; i++)
        {
            {
                for(int j =0; j<row; j++)
                {
                    for(int k =0; k< col; k++)
                    {
                        if(oddevn[i,j,k] %2 ==0 )
                        {
                            Console.Write(oddevn[i,j,k] + "\t");
                        }

                        
                    }

                    Console.WriteLine();
                }
            }

        }


        Console.WriteLine();

        
        Console.WriteLine();
    }
}