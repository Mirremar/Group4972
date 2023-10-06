//Задача №55 Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
//В случае, если это невозможно, программа должна вывести сообщение для пользователя.

int[,] Fill2DArray(int countRow, int countColumn)
{
    System.Random rnd = new System.Random();
    int[,] array2D = new int[countRow, countColumn];
    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            array2D[i, j] = new Random().Next(0, 11);
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

void RowToColReplace(int[,] matrix)
{
    int temp = 0;
    for (int i = 0;i<matrix.GetLength(0);i++)
    {
        for (int j = 1+i; i < matrix.GetLength(1); i++)
        {
            temp = matrix[i, j];
            matrix[i, j] = matrix[j,i];
            matrix[j, i] = temp; 

        }
    }
}

bool isRotateble(int[,] matrix)
{
    return (matrix.GetLength(0) == matrix.GetLength(1));
}

int[,] arr2d = Fill2DArray(10, 10);
Print2DArray(arr2d);
if (isRotateble(arr2d)==false) {Console.WriteLine("Эту матрицу нельзя транспонировать"); Environment.Exit(0);}
Console.WriteLine("--------------------");
RowToColReplace(arr2d);
Print2DArray(arr2d);