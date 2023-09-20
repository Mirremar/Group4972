//№27 Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

int ReadData(string msg) //чтение данных
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

void PrintResult(string msg) //вывод результата
{
    Console.WriteLine(msg);
}

int Calc(int number) //подсчёт суммы по остаткам от деления на 10,пока само число не станет равно 0;
{
    int res = 0;
    while (number>0)
    {
        res += number % 10;
        number /= 10;
    }
    return res;
}

int numtocalc = ReadData("Введите число");
int result = Calc(numtocalc);
PrintResult("Сумма цифр в числе " + $"{numtocalc}" + " равна " + $"{result}");