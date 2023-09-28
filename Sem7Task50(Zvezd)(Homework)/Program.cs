//№50* Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и 
//возвращает значение этого элемента или же указание, что такого элемента нет.
//Например, задан массив: 
//1 4 7 2
//5 9 2 3
//8 4 2 4
//17->такого числа в массиве нет
//* Заполнить числами Фиббоначи и выделить цветом найденную цифру


int ReadData(string msg) //Чтение данных
{
    Console.WriteLine(msg);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

int[,] Fill2DArray(int countRow, int countColumn) //Заполнение массива
{
    string line = string.Empty;
    int first = 0;
    int second = 1;
    int[,] array2D = new int[countRow, countColumn];
    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            array2D[i, j] = first + second; //Вычисление чисел Фибоначчи
            first = second;
            second = array2D[i,j];      
        }
    }
    return array2D;
}

void Print2DArray(int[,] matrix) //Вывод массива на экран
{
    
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {     
                Console.Write(matrix[i, j] + "\t");   
        }
        Console.WriteLine();
    }
}

void Print2dArrayModified(int[,] matrix,int posRow,int posCol) //Вывод массива с перекрашенным элементом
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i==posRow&&j==posCol) //Ищем элемент с заданными индексами
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(matrix[i, j] + "\t");
                Console.ResetColor();
                continue;
            }
            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

int GetElement(int posRow,int posCol,int[,] matrix) //Находим элемент в матрице
{
   return (posRow<matrix.GetLength(0)&&posCol<matrix.GetLength(1)? matrix[posRow, posCol] : -1);
}

void PrintResult(int getElementResult, int posRow, int posCol) //Выводим информацию об элементе
{
        ConsoleColor[] colors = new ConsoleColor[]{ConsoleColor.Black,ConsoleColor.Blue,ConsoleColor.Cyan,
                                                ConsoleColor.DarkBlue,ConsoleColor.DarkCyan,ConsoleColor.DarkGray,
                                                ConsoleColor.DarkGreen,ConsoleColor.DarkMagenta,ConsoleColor.DarkRed,
                                                ConsoleColor.DarkYellow,ConsoleColor.Gray,ConsoleColor.Green,
                                                ConsoleColor.Magenta,ConsoleColor.Red,ConsoleColor.White,
                                                ConsoleColor.Yellow};
        if (getElementResult == -1) { Console.WriteLine("Такого элемента не существует"); }
        else
        {
            Console.Write("Элемент с индексами " + $"{posRow},{posCol}" + " равен ");
            Console.ForegroundColor = colors[new System.Random().Next(0, 16)]; //каким цветом печатать текст
            Console.WriteLine($"{getElementResult}"); 
            Console.ResetColor(); //Сбросить цвет
        }
}



int rows = ReadData("Введите количество строк: ");
int cols = ReadData("Введите количество столбцов: ");
int[,] testArray = Fill2DArray(rows, cols);
Print2DArray(testArray);
int posR = ReadData("Введите позицию интересующего элемента по строкам(нумерация от 0): ");
int posC = ReadData("Введите позицию интересующего элемента по столбцам(нумерация от 0): ");
PrintResult(GetElement(posR,posC, testArray),posR,posC);
if (GetElement(posR, posC, testArray) != -1)
{
    Console.WriteLine();
    Console.WriteLine("Этот элемент в массиве: ");
    Print2dArrayModified(testArray, posR, posC);
}


