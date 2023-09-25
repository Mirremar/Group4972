//№41* Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//(Задание со звездочкой) Пользователь вводит число нажатий,
//затем программа следит за нажатиями и выдает сколько чисел больше 0 было введено.
using System.Text.RegularExpressions;

int ReadLimitation(string msg) //Получаем ограничение по условию задачи
{
    Console.WriteLine(msg);
    int limit = int.Parse(Console.ReadLine() ?? "0");
    return limit;
}

string ReadData(string msg,int limit) //Составляем строку из того,что введём с клавиатуры
{
    char[] newstr = new char[limit];
    string inputString = String.Empty;
    int i = 0;
    Console.WriteLine(msg);
    while (i < limit)
    {
        newstr[i] = Console.ReadKey().KeyChar;
        inputString += newstr[i];
        i++;
    }
    return inputString;
}

int CountPositiveNumbers(string inputString) //Основной метод определения количества положительных чисел
{
    int count = 0;
    Regex regex = new Regex(@"[-+]?[0-9]\d*(?:\,?\d+)?"); // + или -,1 знак,цифры от 0 до 9 любое кол-во раз
    //остальное определяет дробную часть если вдруг есть после запятой.Таким образом ищем любые double числа
    MatchCollection matches = regex.Matches(inputString); //специфика работы regex
    foreach(var m in matches)
    {
        //Console.WriteLine(m.ToString()); можно вывести найденные совпадения,если потребуется
        if (Convert.ToDouble(m.ToString())>0)
        {
            count++;
        }
    }
    return count;
}


int limit = ReadLimitation("Введите количество нажатий");
string example = ReadData("Введите строку",limit);
Console.WriteLine();
int count = CountPositiveNumbers(example);
Console.WriteLine("Количество положительных чисел в строке " + count);