// See https://aka.ms/new-console-template for more information
using System;

Console.WriteLine("Enter day of week");
int a = int.Parse(Console.ReadLine());
Console.WriteLine((week)a);
enum week
{
    Monday = 1,
    Tuesday = 2,
    Wednesday = 3,

    Thursday = 4,
    Friday = 5,
    Saturday = 6,
    Sunday = 7
}
