//Задача 19* Написать метод, который принимает на вход
// число и проверяет, является ли оно палиндромом.Использовать при этом Dictionary
using System;

uint DataInput(string msg) //Ввод числа.uint для большего диапазона
{
    Console.WriteLine(msg);
    uint Number = uint.Parse(Console.ReadLine() ?? "0");
    return Number;
}

bool IsPalindrome(uint Number)
{
    bool result = true;
    Dictionary<int, int> digits = new Dictionary<int, int>();//словарь вида разряд(ключ)-цифра(значение)
    int digitsQuantity = Convert.ToInt32(Math.Floor(Math.Log10(Number))+1); //определяет количество разрядов
    //в числе.Их количество всегда на 1 больше,чем округлённый в меньшую сторону (или просто +1 в случае чисел,равных
    //степеням десятки) десятичный логарифм числа.
    for (int i=1;i<=digitsQuantity;i++) //наполняем коллекцию парами разряд-число,где каждое число вычисляется с 
        //помощью метода Division
    {
        digits.Add(i, Division(Number, i, digitsQuantity));
    }
    //12345
    for (int j=1;j<=digitsQuantity/2;j++) //проверка на "палиндромность".Если хотя бы одна пара не совпадает —
        //то число не палиндром
    {
        if (digits[j] != digits[digitsQuantity-j+1]) // перебор по ключам,нумерация ключей начинается с единицы
        {
            result = false;
            break;
        }
    }
   //result = true;
   return result;
}

int Division(uint Value,int i,int quant) //метод для разложения числа на цифры
{
    int currentDigit = Convert.ToInt32(Math.Floor(Value / Math.Pow(10,quant - i)))%10;
    return currentDigit;
}

void AnswerOut(bool res,uint num) //вывод результатов
{
    if (res == true)
    {
        Console.WriteLine("Число " + $"{num}" + " является палиндромом");
    }
    else
    {
        Console.WriteLine("Число " + $"{num}" + " не является палиндромом");
    }

}

uint temp = DataInput("Задайте число до 4 294 967 295:");
bool ispal = IsPalindrome(temp);
AnswerOut(ispal, temp);


