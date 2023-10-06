int[,] Fill2DArray(int countRow, int countColumn)
{
    System.Random rnd = new System.Random();
    int[,] array2D = new int[countRow, countColumn];
    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            array2D[i, j] = new Random().Next(0,11);
        }
    }
    return array2D;
}

void Print2DArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
           Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void Change2DArray(int[,] matrix)
{
    int temp = 0;
    for(int i = 0;i<matrix.GetLength(1);i++)
    {
        temp = matrix[0,i];
        matrix[0,i] = matrix[matrix.GetLength(0)-1,i];
        matrix[matrix.GetLength(0)-1,i] = temp;
    }
}

int[,] arr2d = Fill2DArray(10,10);
Print2DArray(arr2d);
Console.WriteLine("----------------------------------------------");
Change2DArray(arr2d);
Print2DArray(arr2d);