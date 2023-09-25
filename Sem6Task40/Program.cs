//Задача №40 Напишите программу, которая принимает на вход три числа и проверяет, 
//может ли существовать треугольник с сторонами такой длины.
//a+b > c 
//b+c > a
//a+c > b
//Неравенство треугольника

int ReadData(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

bool TriangleTest(int a, int b, int c)
{
    return ((a + b > c) && (b + c > a) && (a + c > b));
}

int a = ReadData("Введите сторону a треугольника: ");
int b = ReadData("Введите сторону b треугольника: ");
int c = ReadData("Введите сторону c треугольника: ");
Console.WriteLine((TriangleTest(a, b, c)) ? "Такой треугольник возможен" : "Такой треугольник невозможен");