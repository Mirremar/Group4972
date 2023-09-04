//Задача:написать программу,принимающую на вход число и выдающую его квадрат
Console.WriteLine("Введите число");
//Считываем данные с консоли
string? inputNum = Console.ReadLine();//??"0";
//Проверяем,чтоб данные не были пустыми
if (inputNum != null)
{
    //парсим введённое число
    int num = int.Parse(inputNum);
    //находим квадрат числа
    int res = num * num;
    //Выводим данные в консоль
    Console.WriteLine(res);
}

Console.WriteLine("Квадрат числа: " + Math.Pow(int.Parse(inputNum),2));