// See https://aka.ms/new-console-template for more information
// See https://aka.ms/new-console-template for more information
//№15 Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели, и проверяет, является ли этот день выходным.
using System;

Console.WriteLine("Введите число,обозначающее день недели");
int a = int.Parse(Console.ReadLine()); 
//Проверка по значению элемента перечисления
Console.WriteLine(((week)a == week.Saturday || (week)a == week.Sunday)?"Это выходной":"Это не выходной");
enum week //Дни недели от 1 до 7
{
    Monday = 1,
    Tuesday = 2,
    Wednesday = 3,

    Thursday = 4,
    Friday = 5,
    Saturday = 6,
    Sunday = 7

}