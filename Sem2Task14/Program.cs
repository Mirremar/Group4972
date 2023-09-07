// See https://aka.ms/new-console-template for more information
//Задача №14 Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
Console.WriteLine("Введите число");
int Number = int.Parse(Console.ReadLine()??"0");
if ((Number%7==0) && (Number%23==0))
{
    Console.WriteLine("Число кратно 7 и 23");
}
else
{
    Console.WriteLine("Число НЕ кратно 7 и 23");
}