// See https://aka.ms/new-console-template for more information
// See https://aka.ms/new-console-template for more information
//№24. Напишите программу,которая принимает на вход число А и выдаёт сумму чисел от 1 до А

int ReadData(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

void PrintResult(string msg)
{
    Console.WriteLine(msg);
}

//Вводим число->ReadData
//Считаем произв
//Выводим результат->PrintResult
long SimpleMult(int numA)
{

    int sumOfNumber = 1;
    for (int i = 2; i <= numA; i++)
    {
        sumOfNumber *= i;
    }
    return sumOfNumber;
}

long Recurs(int n)
{
    if(n==1) return 1;
    else
    {
        return n*Recurs(n-1);
    }


}

int numA = ReadData("введите число");
DateTime d1 = DateTime.Now;
long res1 = SimpleMult(numA);
Console.WriteLine(DateTime.Now - d1);
DateTime d2 = DateTime.Now;
long res2 = Recurs(numA);
Console.WriteLine(DateTime.Now - d2);
PrintResult("Mult = " + $"{res1}");
PrintResult("Mult = " + $"{res2}");