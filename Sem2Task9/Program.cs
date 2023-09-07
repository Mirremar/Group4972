// See https://aka.ms/new-console-template for more information
//Задача №9 Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
 
/* Void Variant4()
 {

 int Number = new Random().Next(10,100);
Console.WriteLine(Number);
 int[] digits = new int[];
 while ((Number - Number%10)>=0)
 {
    digits[i] = Number%10;
    max = digits[0];
    Number = (Number - Number%10);
    i++;
 }
}*/


void Variant1()
{
 System.Random numberGenerator = new System.Random();
 int Number = numberGenerator.Next(10,100);
 int firstDigit = Number/10;
 int secondDigit = Number%10;
  Console.WriteLine(Number);
 if (firstDigit > secondDigit)
 {
    Console.WriteLine(firstDigit);
 }
 else
 {
    Console.WriteLine(secondDigit);
 }
}

void Variant3()
{
 System.Random numberGenerator = new System.Random();
 int Number = numberGenerator.Next(10,100);
 Console.WriteLine(Number);
 char[] digitChar = Number.ToString().ToCharArray();
 Console.WriteLine((int)digitChar[0]>(int)digitChar[1]?digitChar[0]:digitChar[1]); //Тернарный оператор.Условие?вариант 1(да):вариант 2(нет)
}


Variant3();