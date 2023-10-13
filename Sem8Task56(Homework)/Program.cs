//Задача 56: Задайте прямоугольный двумерный массив.
//Напишите программу, которая будет находить строку с наименьшей суммой элементов.


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

//Поиск минимальных сумм
List<int> LeastSum(int[,] matrix)
{
    int[] sums = new int[matrix.GetLength(0)]; //Вспомогательный массив
    //int k = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sums[i]+= matrix[i, j];
        }
    }
    int minSum = sums.Min();
    List<int> indexesOfMin = new List<int>(); //минимальных сумм может быть несколько.
    for (int i = 0; i < sums.Length; i++) //Колекция состоит из индексов минимальных сумм строк
    {
        if (sums[i] == minSum) { indexesOfMin.Add(i); }
    }
    return indexesOfMin;
}

void PrintCollection(List<int> col) //вывод коллекции
{
    foreach(var element in col) { Console.Write(element + " | "); }
}

int rows = ReadData("Введите количество строк в массиве");
int cols = ReadData("Введите количество столбцов в массиве");
int lowLim = ReadData("Введите количество нижний предел значений в массиве");
int highLim = ReadData("Введите верхний предел значений в массиве");
int[,] matrix = Fill2DArray(rows, cols, lowLim, highLim);
Print2DArray(matrix);
List<int> minSum = LeastSum(matrix);
Console.WriteLine("Строки с наименьшей суммой в массиве: ");
PrintCollection(minSum);