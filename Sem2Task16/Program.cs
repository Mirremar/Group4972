// See https://aka.ms/new-console-template for more information
/*Задача №16
Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.*/

Console.WriteLine("Введите числа");
int numA = int.Parse(Console.ReadLine()??"0");
int numB = int.Parse(Console.ReadLine()??"0");
bool test1 = (numA==numB*numB);//Так можно.Язык воспинимает сравнение как результат действия.
bool test2 = (numB==numA*numA);
if (test1)
{
    Console.WriteLine("Первое число является квадратом второго");
}
else if (test2)
    {
    Console.WriteLine("Второе число является квадратом первого");
    }
    else
    {
        Console.WriteLine("Числа не являются квадратами друг друга");
    }