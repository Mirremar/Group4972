// See https://aka.ms/new-console-template for more information
//№15* Напишите программу, которая принимает на вход цифру,
 //обозначающую день недели, и проверяет, является ли этот день выходным.
 //* Сделать вариант с использованием конструкции Dictionary

Dictionary<int, string> dayOfWeek = new Dictionary<int, string>();
dayOfWeek.Add(1, "Не выходной");
dayOfWeek.Add(2, "Не выходной");
dayOfWeek.Add(3, "Не выходной");
dayOfWeek.Add(4, "Не выходной");
dayOfWeek.Add(5, "Не выходной");
dayOfWeek.Add(6, "Выходной");
dayOfWeek.Add(7, "Выходной");
Console.WriteLine("Введите число,обозначающее день недели");
int Number = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine(dayOfWeek[Number]);     