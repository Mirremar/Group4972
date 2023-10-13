//Задача 54: Задайте двумерный массив. Напишите программу,
//которая упорядочит по убыванию элементы каждой строки двумерного массива.
/*Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2*/
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

//Проход по строкам
void SortRows(int[,] matrix)
{
    int[] row = new int[matrix.GetLength(1)]; //Вспомогательный массив
   // int temp = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            row[j] = matrix[i, j];
        }
        BubbleSort(row); //каждая строка сортируется пузырьком
        for (int j =0;j<matrix.GetLength(1);j++) //и заменяется на отсортированную
        {
            matrix[i, j] = row[j];
        }
    }
}

//Метод сортировки
void BubbleSort(int[] array)
{
    int len = array.Length;
    for (int i = 1; i < len; i++)
    {
        for (int j = 0; j < len - i; j++)
        {
            if (array[j] < array[j + 1])
            {
                Swap(ref array[j], ref array[j + 1]);
            }
        }
    }
}

//метод обмена элементов
void Swap(ref int element1, ref int element2)
{
  int temp = element1;
  element1 = element2;
  element2 = temp;
}


int rows = ReadData("Введите количество строк в массиве");
int cols = ReadData("Введите количество столбцов в массиве");
int lowLim = ReadData("Введите количество нижний предел значений в массиве");
int highLim = ReadData("Введите верхний предел значений в массиве");
int[,] matrix = Fill2DArray(rows, cols, lowLim, highLim);
Print2DArray(matrix);
SortRows(matrix);
Console.WriteLine("-------------------");
Print2DArray(matrix);