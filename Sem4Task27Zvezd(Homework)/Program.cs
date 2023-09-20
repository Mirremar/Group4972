//№27* Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//(задание со *) Сделать оценку времени алгоритма через вещественные числа и строки

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

int RealNumbers(int number)//Расчёт суммы через вещественные числа
{
    int sum = 0;
    while (number > 0)
    {
        sum += number % 10;
        number /= 10;
    }
    return sum;
}

int Strings(int number) //Расчёт суммы через строки
{
    int sum = 0;
    string strnum = number.ToString();
    for (int i = 0;i<strnum.Length;i++)
    {
        sum += Convert.ToInt32(strnum[i]);
    }
    return sum;

}

int numA = ReadData("Введите число:");
DateTime d1 = DateTime.Now;
int res1 = RealNumbers(numA);
Console.Write(DateTime.Now - d1); //Подсчёт времени выполнения через числа
Console.WriteLine(" (время выполнения через арифметические операции)");
DateTime d2 = DateTime.Now;
int res2 = Strings(numA);
Console.Write(DateTime.Now - d2);//Подсчёт времени выполнения через строки
Console.WriteLine(" (время выполнения через строки)");
PrintResult("Сумма цифр числа через арифметику " + $"{numA}" + " равна " + $"{res1}");
PrintResult("Сумма цифр числа через строки " + $"{numA}" + " равна " + $"{res1}");