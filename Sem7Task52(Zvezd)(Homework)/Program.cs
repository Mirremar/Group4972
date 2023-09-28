//№52* Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом 
//столбце.
//Например, задан массив: 
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
//* Дополнительно вывести среднее арифметическое по диагоналям и диагональ выделить разным 
//цветом


int ReadData(string msg) //Чтение данных
{
    Console.WriteLine(msg);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

int[,] Fill2DArray(int countRow, int countColumn)//Заполнение массива
{
    int[,] array2D = new int[countRow, countColumn];
    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            array2D[i, j] = new Random().Next(0, 101);
        }
    }
    return array2D;
}

void Print2DArray(int[,] matrix) //Вывод массива на экран.Красим диагональный элемент
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {     
            if (i==j)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write(matrix[i, j] + "\t");
                Console.ResetColor();
                continue;
                
            }
            Console.Write(matrix[i, j] + "\t");   
        }
        Console.WriteLine();
    }
}

double[] AvgColumn(int[,] matrix) //Среднее по столбцам
{
    int f = 0;
    double[] result = new double[matrix.GetLength(1)];

    for (int j = 0; j < matrix.GetLength(1); j++) //Проходим по столбцам,внутри — по строкам
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            result[f] += matrix[i, j];
        }
        result[f] /= matrix.GetLength(0);
        f++;
    }
    return result;
}

string AvgDiagonal(int[,] matrix) //Среднее по диагонали
{
    double avg = 0;
    int count = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if(i==j) { avg += matrix[i, j]; count++; }
        }
    }
    avg /= count;
    return String.Format("{0:F2}",avg);
}

static void PrintListAvr(double[] list) //Вывод средних по столбцам
{
    string check = String.Empty;
    Console.WriteLine("Средние по столбцам равны: ");
    for (int i = 0; i < list.Length; i++)
    {
        check = String.Format("{0:F2}", Math.Round(list[i], 2));
        Console.Write(check + "\t");
    }


}



int rows = ReadData("Введите количество строк: ");
int cols = ReadData("Введите количество столбцов: ");
Console.WriteLine();
int[,] testArray = Fill2DArray(rows, cols);
Print2DArray(testArray);
double[] avgColumns = AvgColumn(testArray);
PrintListAvr(avgColumns);
string avgDiag = AvgDiagonal(testArray);
Console.WriteLine();
Console.WriteLine($"Среднее по диагонали равно {avgDiag}");



