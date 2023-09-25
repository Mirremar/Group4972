//№41 Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//-1, -7, 567, 89, 223-> 3

string[] ReadData(string msg)
{
    Console.WriteLine(msg);
    string initialString = Console.ReadLine() ?? "0";
    initialString = (initialString.TrimEnd()).TrimStart(); //Удаляем пробелы в начале и конце строки,если они есть.
    string[] points = initialString.Split(' '); //Разбиваем входящую строку по пробелу на несколько строк.
    points = Array.FindAll(points, isNotEmpty).ToArray(); //Если случайно ввели лишний пробел — исправляем.
    return points;
    
}

bool isNotEmpty(string n) //Вспомогательный метод для нахождения непустых элементов массива строк
{
    return !n.Equals(String.Empty);
}

int GetPositiveNumbersCount(string[] numbers) //подсчёт положительных чисел
{
    int count = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (double.TryParse(numbers[i],out var toparse)) //На случай,если были введены не числа,то пропускаем итерацию
        {  
            if (double.Parse(numbers[i])>0) //В общем случае могут быть вещественные числа
            {
                count++;
            }
        }
        else { continue; }
    }
    return count;

}

void PrintResult(string msg,int result) //вывод результата
{
    Console.WriteLine(msg + " " + result);

}

string[] initialStrings = ReadData("Ввведите числа через пробел ");
int count = GetPositiveNumbersCount(initialStrings);
PrintResult("Количество положительных числел в этой последовательности: ", count);