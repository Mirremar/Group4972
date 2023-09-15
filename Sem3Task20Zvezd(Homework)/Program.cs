//Задача 20* написать метод загрузки точек который принимает на вход строку
//координат двух точек,парсит её и возвращает расстояние между ними в 3D пространстве.



string[] Parse(string msg)
{
    Console.WriteLine(msg);
    string initialString = Console.ReadLine()??"0";
    initialString = (initialString.TrimEnd()).TrimStart(); //Удаляем пробелы в начале и конце строки,если они есть.
    string[] points = initialString.Split(' '); //Разбиваем входящую строку по пробелу на несколько строк.
    points = Array.FindAll(points, isNotEmpty).ToArray(); //Если случайно ввели лишний пробел — исправляем.
    return points;
}

bool isNotEmpty(string n) //Вспомогательный метод для нахождения непустых элементов массива строк
{
    return !n.Equals(String.Empty);
}

double Calculation(string[] points) //Основной метод расчёта расстояния в пространстве
{
    int[] dots = new int[points.Length]; //Сначала конвертируем координаты из строк в числа
    for (int i = 0;i<points.Length;i++) 
    {
        dots[i] = Convert.ToInt32(points[i]);    
    }
    int x1, y1, z1, x2, y2, z2 = 0; //распределяем по переменным для удобства
    x1 = dots[0];
    y1 = dots[1];
    z1 = dots[2];
    x2 = dots[3];
    y2 = dots[4];
    z2 = dots[5];
    double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
    return distance;
}


void PrintResult(string msg) //Вывод ответа
{
    Console.WriteLine(msg);
}

string[] str = Parse("Введите координаты двух точек через пробел в формате x1 y1 z1 x2 y2 z2");
double dis = Calculation(str);
PrintResult("Расстояние равно " + $"{dis}");