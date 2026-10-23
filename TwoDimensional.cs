using System;

class TwoDimensional
{
    public static void Main()
    {
        Console.Write("Enter the size of row : ");
        int row = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the size of column : ");
        int col = Convert.ToInt32(Console.ReadLine());

        int[,] matrix = new int [row, col];

        for(int i =0; i<matrix.GetLength(0); i++) //0---row
        {
            for(int j =0; j<matrix.GetLength(1); j++) //1 --column
            {
                Console.Write($"Enter the elements {i}, {j} : ");

                matrix[i,j] = Convert.ToInt32(Console.ReadLine());

            }
        }

        Console.WriteLine("2 Dimensional Array");

        for(int i =0; i<row; i++)
        {
            for(int j=0; j<col; j++)
            {
                Console.Write(matrix[i,j] +"\t");
            }

            Console.WriteLine();
        }

        int sum = 0;

        for(int i =0; i<row; i++)
        {
            for(int j=0; j<col; j++)
            {
                sum += matrix[i,j];
            }

        }

        Console.WriteLine("Sum of the elements : " + sum);


        int max = matrix[0,0];

        for(int i =0; i<row; i++)
        {
            for(int j=0; j<col; j++)
            {
                if(matrix[i,j]>max)
                {
                    max = matrix[i,j];
                }
            }
        }

        Console.WriteLine("The maximum value of element : " + max);

        int upper = matrix.GetLowerBound(0);

        Console.WriteLine(upper);

    }
}