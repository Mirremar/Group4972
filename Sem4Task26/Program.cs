// See https://aka.ms/new-console-template for more information
//Задача №26
//Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.

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

int NumQuant(int num)
{
    int quant = (int)Math.Floor(Math.Log10((double)num))+1;
    return quant;


}


int numA = ReadData("введите число");
int res = NumQuant(numA);
PrintResult("res"+res);