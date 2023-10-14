//Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
//Выполнить с помощью рекурсии.
//N = 5 -> "5, 4, 3, 2, 1"
//N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int ReadData(string msg) //Чтение данных
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

void RecursOutput(int N) //Рекурсивный метод вывода
{

    if (N == 1) { Console.Write("1"); } //Выход из рекурсии
    else
    {
        Console.Write(N + " ");
        RecursOutput(N - 1);
    }               
}

int N = ReadData("Введите N: ");
RecursOutput(N);