int ReadData(string msg)
{
    Console.WriteLine(msg);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

int[,] Fill2DArray(int countRow, int countColumn, int topBorder, int downBorder)
{
    System.Random rnd = new System.Random();
    int[,] array2D = new int[countRow, countColumn];
    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            array2D[i, j] = rnd.Next(downBorder, topBorder);
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

void Print2DArrayColor(int[,] matrix)
{
    ConsoleColor[] colors = new ConsoleColor[]{ConsoleColor.Black,ConsoleColor.Blue,ConsoleColor.Cyan,
                                                ConsoleColor.DarkBlue,ConsoleColor.DarkCyan,ConsoleColor.DarkGray,
                                                ConsoleColor.DarkGreen,ConsoleColor.DarkMagenta,ConsoleColor.DarkRed,
                                                ConsoleColor.DarkYellow,ConsoleColor.Gray,ConsoleColor.Green,
                                                ConsoleColor.Magenta,ConsoleColor.Red,ConsoleColor.White,
                                                ConsoleColor.Yellow};
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
           Console.ForegroundColor = colors[new System.Random().Next(0,16)]; //каким цветом печатать текст
           Console.Write(matrix[i, j] + " ");
           Console.ResetColor(); //Сбросить цвет
        }
        Console.WriteLine();
    }
}

int row = ReadData("Введите количество строк");
int column = ReadData("Введите количество столбцов");
int[,] arr2D = Fill2DArray(row,column,101,10);
Print2DArray(arr2D);
Print2DArrayColor(arr2D);