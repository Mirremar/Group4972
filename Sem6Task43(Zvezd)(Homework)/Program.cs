//№43* Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
//1 0,-1 2,0 0 — Должно получиться ~1
//(Задание со звездочкой) Найдите площадь треугольника образованного пересечением 3 прямых 

Line ReadParameters(string msg) //На вход принимаем коэффициенты k и b — они образуют объект класса Line(описан внизу)
{
    Console.WriteLine(msg);
    string initialString = Console.ReadLine() ?? "0";
    initialString = (initialString.TrimEnd()).TrimStart(); //Удаляем пробелы в начале и конце строки,если они есть.
    string[] points = initialString.Split(' '); //Разбиваем входящую строку по пробелу на несколько строк.
    points = Array.FindAll(points, isNotEmpty).ToArray(); //Если случайно ввели лишний пробел — исправляем.
    Line line = new Line();
    line.k = Convert.ToDouble(points[0]);
    line.b = Convert.ToDouble(points[1]);
    return line;
}

bool isNotEmpty(string n) //Вспомогательный метод для нахождения непустых элементов массива строк
{
    return !n.Equals(String.Empty);
}

Line lineA = ReadParameters("Введите коэффициенты первой прямой через пробел"); //читаем коэффициенты
Line lineB = ReadParameters("Введите коэффициенты второй прямой через пробел");
Line lineC = ReadParameters("Введите коэффициенты третьей прямой через пробел");
Triangle triangle = new Triangle(); //"Создаём" треугольник и ниже проверяем,не являются ли какие-либо из 
                                    //прямых параллельными
if (triangle.IsNotPossible(lineA, lineB, lineC)) { Console.WriteLine("Такой треугольник невозможен"); Environment.Exit(0); }
Point intersectAB = triangle.CrossPoint(lineA, lineB); //point B на плоскости
Point intersectAC = triangle.CrossPoint(lineA, lineC); //point A на плоскости
Point intersectBC = triangle.CrossPoint(lineB, lineC); //point C на плоскости
double sideAB = triangle.SideLength(intersectAB, intersectAC); //Вычисляем длины сторон
double sideAC = triangle.SideLength(intersectAC, intersectBC);
double sideBC = triangle.SideLength(intersectAB, intersectBC);
double sq = triangle.Square(sideAB, sideBC, sideAC); //Считаем площадь через 3 стороны и полупериметр
Console.WriteLine("Площадь треугольника равна " + sq);

public class Triangle //Все вычисления проводятся в этом классе
{
    //Проверка,что нет параллельных прямых 
    public bool IsNotPossible(Line lineone, Line linetwo, Line linethree)
    {
        return (lineone.k == linetwo.k) || (lineone.k == linethree.k) || (linetwo.k == linethree.k);
    }
    //Считаем точки пересечения
    public Point CrossPoint(Line lineone, Line linetwo)
    {
        Point crspoint = new Point();
        crspoint.x = (linetwo.b - lineone.b) / (lineone.k - linetwo.k); // 
        crspoint.y = lineone.k * crspoint.x + lineone.b;
        return crspoint;
    }

    //Считаем стороны треугольника
    public double SideLength(Point crspointA, Point crspointB)
    {
        return Math.Sqrt(Math.Pow((crspointB.x - crspointA.x), 2) + Math.Pow((crspointB.y - crspointA.y), 2));
    }
    //Считаем площадь через полупериметр
    public double Square(double sideA, double sideB, double sideC)
    {
        double perimeter = 0;
        double square = 0;
        perimeter = (sideA + sideB + sideC) / 2;
        square = Math.Sqrt(perimeter * (perimeter - sideA) * (perimeter - sideB) * (perimeter - sideC));
        return square;
    }
}
public class Line //Прямые линии (kx+b)
{
    public double k, b = 0; //Коэффициенты прямой
}

public class Point 
{
    public double x, y = 0; //Точка на плоскости
}




