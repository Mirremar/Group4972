//№43 Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
//y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9-> (-0, 5; -0,5)

(double,double) ReadParameters(string msg)
{
    double k = 0;//Коэффициенты
    double b = 0;
    Console.WriteLine(msg);
    string initialString = Console.ReadLine() ?? "0";
    initialString = (initialString.TrimEnd()).TrimStart(); //Удаляем пробелы в начале и конце строки,если они есть.
    string[] points = initialString.Split(' '); //Разбиваем входящую строку по пробелу на несколько строк.
    points = Array.FindAll(points, isNotEmpty).ToArray(); //Если случайно ввели лишний пробел — исправляем.
    (k,b) = (Convert.ToDouble(points[0]), Convert.ToDouble(points[1]));
    return (k,b);
}

bool isNotEmpty(string n) //Вспомогательный метод для нахождения непустых элементов массива строк
{
    return !n.Equals(String.Empty);
}

(double,double)CrossPoint((double,double) lineone, (double, double) linetwo)
{
    //y = k1x+b1 and k2x+b2
    //Сначала проверим на параллельность
    if (lineone.Item1 == linetwo.Item1) { Console.WriteLine("Прямые параллельны");Environment.Exit(0); }
    //Потом рассчитаем точку пересечения
    double crossPointX = (linetwo.Item2 - lineone.Item2) / (lineone.Item1 - linetwo.Item1);
    double crossPointY = lineone.Item1 * crossPointX + lineone.Item2;
    return (crossPointX, crossPointY);

}

void PrintResult((double, double) intersection)
{
    Console.WriteLine("Прямые пересекаются в точке " + intersection);
}

Console.WriteLine("Уравнение прямой: kx+b");
(double, double) lineA = ReadParameters("Введите через проблел числа k1 и b1");
(double, double) lineB = ReadParameters("Введите через проблел числа k2 и b2");
(double, double) result = CrossPoint(lineA, lineB);
PrintResult(result);

