//Задача №59bЗадайте двумерный массив из целых чисел. 
//Напишите программу, которая удалит строку и столбец, 
//на пересечении которых расположен наименьший элемент массива.
int x = 0;
int y = 0;

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

int FindMinInMatrix(int[,] matrix, ref int x, ref int y)
{
    int min = matrix[0, 0];
    x = 0; y = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < min) { min = matrix[i, j]; x = i; y = j; }
        }
    }
    return min;
}

int[,] Update2DArray(int[,] matrix, int x, int y)
{
    int[,] res = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
    int m = 0;
    int n = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        if (i != x)
        {
            n = 0;
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (j != y)
                {
                    res[m, n] = matrix[i, j];
                    n++;
                    
                }
            }
            // n = 0;
            m++;
        }
        
        //n=0;        
    }
    return res;
}

int[,] matr = Fill2DArray(5, 5);
Print2DArray(matr);
FindMinInMatrix(matr, ref x, ref y);
int[,] res = Update2DArray(matr, x, y);
Console.WriteLine("-------------------------------");
Print2DArray(res);