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
int SimpleMult(int numA)
{

    int sumOfNumber = 1;
    for (int i = 1; i <= numA; i++)
    {
        sumOfNumber *= i;
    }
    return sumOfNumber;
}

//int GaussSum(int numA)
/*{
    int sumOfNumber = 0;
    sumOfNumber = (numA*(numA+1))/2;
    return sumOfNumber;
}*/
int Recurs(int n)
{
    if(n==1) return 1;
    else
    {
        return Recurs(n*(n-1));
    }


}

int numA = ReadData("введите число");
DateTime d1 = DateTime.Now;
int res1 = SimpleMult(numA);
Console.WriteLine(DateTime.Now - d1);
DateTime d2 = DateTime.Now;
int res2 = Recurs(numA);
Console.WriteLine(DateTime.Now - d2);
PrintResult("Sum = " + $"{res1}");
PrintResult("Sum = " + $"{res2}");