//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
//Например, даны 2 матрицы:
//2 4 | 3 4
//3 2 | 3 3
//Результирующая матрица будет:
//18 20
//15 18

int ReadData(string msg) //Чтение данных
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

//Заполнение массива
int[,] Fill2DArray(int countRow, int countColumn,int lowLimit,int highLimit)
{
    System.Random rnd = new System.Random();
    int[,] array2D = new int[countRow, countColumn];
    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            array2D[i, j] = new Random().Next(lowLimit, highLimit+1);
        }
    }
    return array2D;
}

//Вывод массива
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

bool IsMultipliable(int[,] matrix1, int[,] matrix2) //Количество столбцов в первой матрице должно быть равно количеству
    //строк во второй
{
    return (matrix1.GetLength(1) == matrix2.GetLength(0));
}


int[,] MultiplyMatrix(int[,] A, int[,] B) //Перемножение матриц
{
    int rowsA = A.GetLength(0);
    int colsA = A.GetLength(1);
    int rowsB = B.GetLength(0);
    int colsB = B.GetLength(1);

    int[,] result = new int[rowsA, colsB];
    int temp = 0;
        for (int i = 0; i < rowsA; i++)
        {
            for (int j = 0; j < colsB; j++)
            {
                temp = 0;
                for (int k = 0; k < colsA; k++)
                {
                    temp += A[i, k] * B[k, j];
                }
                result[i, j] = temp;
            }
        }

    return result;
}



int rows1 = ReadData("Введите количество строк в массиве 1");
int cols1 = ReadData("Введите количество столбцов в массиве 1");
int lowLim1 = ReadData("Введите количество нижний предел значений в массиве 1");
int highLim1 = ReadData("Введите верхний предел значений в массиве 1");
int rows2 = ReadData("Введите количество строк в массиве 2");
int cols2 = ReadData("Введите количество столбцов в массиве 2");
int lowLim2 = ReadData("Введите количество нижний предел значений в массиве 2");
int highLim2 = ReadData("Введите верхний предел значений в массиве 2");
int[,] matrix1 = Fill2DArray(rows1, cols1, lowLim1, highLim1);
int[,] matrix2 = Fill2DArray(rows2, cols2, lowLim2, highLim2);
if (!IsMultipliable(matrix1,matrix2)) {
    Console.WriteLine("Количество строк первой матрицы должно быть" +
"равно количеству столбцов второй,чтобы перемножение матриц было возможно");
    Environment.Exit(0);
}
Print2DArray(matrix1);
Console.WriteLine("******************************");
Print2DArray(matrix2);
int[,] result = MultiplyMatrix(matrix1, matrix2);
Console.WriteLine("==============================");
Print2DArray(result);