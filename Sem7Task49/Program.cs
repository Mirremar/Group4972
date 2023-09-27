//Задача №49
//Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, 
//и замените эти элементы на их квадраты.

int ReadData(string msg)
{
    Console.WriteLine(msg);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

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

void Square2DArray(int[,] arr2d)
{
    for (int i = 0; i < arr2d.GetLength(0); i+=2)
    {
        for (int j = 0; j < arr2d.GetLength(1); j+=2)
        {
            arr2d[i, j] = arr2d[i, j]*arr2d[i, j];
        }
    }
    //return array2D;
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

int row = ReadData("Строки");
int col = ReadData("Столбцы");
int[,] arr2D = Fill2DArray(row,col);
Print2DArray(arr2D);
Square2DArray(arr2D);
Console.WriteLine();
Print2DArray(arr2D);