// See https://aka.ms/new-console-template for more information
//Задача №11 Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
System.Random numberGenerator = new System.Random();
 int Number = numberGenerator.Next(10,1000);
 Console.WriteLine(Number);
 int firstDigit = Number/100;
 int lastDigit = Number%100;
 char[] digitChar = Number.ToString().ToCharArray();
 string NewNumber = ((string.Concat(digitChar[0].ToString(),digitChar[2].ToString()).ToString()));
 Console.WriteLine(NewNumber);
