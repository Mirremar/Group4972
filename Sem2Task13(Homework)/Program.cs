// See https://aka.ms/new-console-template for more information
//№13 Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.WriteLine("Введите число");
int Number = int.Parse(Console.ReadLine()??"0");
char[] digits = Number.ToString().ToCharArray();
if (digits.Length < 3)
{
    Console.WriteLine("В числе нет третьей цифры");
}
else
{
    Console.WriteLine(digits[2]);
}