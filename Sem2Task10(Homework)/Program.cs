// See https://aka.ms/new-console-template for more information
//№10 Напишите программу, которая принимает на вход трёхзначное число 
//и на выходе показывает вторую цифру этого числа.

string SecondDigit(int arg)
{   
    char[] digits = (arg.ToString()).ToCharArray();
    if (digits.Length != 3) //Проверка соответствия условию.На вход должно подаваться трёхзначное число.
    {
        return ("Число не трёхзначное");
    }
    return digits[1].ToString();
}

Console.WriteLine("Введите трёхзначное число");
int Number = int.Parse(Console.ReadLine()??"0");
Console.WriteLine(SecondDigit(Number));