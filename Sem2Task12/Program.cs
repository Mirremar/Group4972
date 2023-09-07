// See https://aka.ms/new-console-template for more information
//Задача №12 Напишите программу, которая будет 
//принимать на вход два числа и выводить, является ли второе число кратным первому.
// Если второе число некратно первому, то программа выводит остаток от деления.

Console.WriteLine("Введите два числа");
Console.WriteLine("Введите первое число");
int firstNumber = int.Parse(Console.ReadLine()??"0");
Console.WriteLine("Введите второе число");
int secondNumber = int.Parse(Console.ReadLine()??"0");
if (secondNumber%firstNumber == 0)
{
    Console.WriteLine("Второе число кратно первому");
}
else  
{
    Console.WriteLine("Не делится.Остаток от деления равен " + secondNumber%firstNumber);
}