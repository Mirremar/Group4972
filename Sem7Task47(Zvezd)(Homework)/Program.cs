//№47* Задайте двумерный массив размером m×n, заполненный случайными числами.
//* При выводе матрицы показывать каждую цифру разного цвета(цветов всего 16)

int ReadData(string msg) //Чтение данных
{
    Console.WriteLine(msg);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

int[,] Fill2DArray(int countRow, int countColumn, int topBorder, int downBorder) //Заполнение массива
{
    System.Random rnd = new System.Random();
    int[,] array2D = new int[countRow, countColumn];
    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            array2D[i, j] = rnd.Next(downBorder, topBorder); //заполнение случайными числами,пределы вводятся 
                                                            //с клавиатуры
        }
    }
    return array2D;
}

void Print2DArray(int[,] matrix) //Вывод массива на экран
{
    ConsoleColor[] colors = new ConsoleColor[]{ConsoleColor.Black,ConsoleColor.Blue,ConsoleColor.Cyan,
                                                ConsoleColor.DarkBlue,ConsoleColor.DarkCyan,ConsoleColor.DarkGray,
                                                ConsoleColor.DarkGreen,ConsoleColor.DarkMagenta,ConsoleColor.DarkRed,
                                                ConsoleColor.DarkYellow,ConsoleColor.Gray,ConsoleColor.Green,
                                                ConsoleColor.Magenta,ConsoleColor.Red,ConsoleColor.White,
                                                ConsoleColor.Yellow}; //массив цветов
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int m =0;m<matrix[i,j].ToString().Length;m++)
            {
                Console.ForegroundColor = colors[new System.Random().Next(0, 16)]; //каким цветом печатать текст
                Console.Write((matrix[i, j].ToString())[m]);
                Console.ResetColor(); //Сбросить цвет
            }
            
            Console.Write("\t");
            
        }
        Console.WriteLine();
    }
}

int rows = ReadData("Введите количество строк: ");
int cols = ReadData("Введите количество столбцов: ");
int topBorder = ReadData("Введите верхний предел генерации чисел в массиве: ");
int lowBorder = ReadData("Введите верхний предел генерации чисел в массиве: ");
int[,] testArray = Fill2DArray(rows, cols, topBorder, lowBorder);
Print2DArray(testArray);