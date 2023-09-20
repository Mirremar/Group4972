// See https://aka.ms/new-console-template for more information
//№25 Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4-> 16

long ReadData(string msg) //Чтение данных
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

void PrintResult(string msg) //Вывод данных
{
    Console.WriteLine(msg);
}

long Calc(long numA,long numB)//Подсчёт степени
{
    long res = 1;
    for (int i = 1; i <= numB; i++) //Умножаем число на само себя,пока не достигнем значения степени
    {
        res *= numA;
    }
    return res;
}

long numA = ReadData("Enter a number");
long numB = ReadData("Enter a power");
long res = Calc(numA, numB);
PrintResult("The result is "+res);
