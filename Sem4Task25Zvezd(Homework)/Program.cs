//№25* Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//(задание со *) Написать калькулятор с операциями +, -, /, * и возведение в степень
using System;
double ReadData(string msg) //чтение данных
{
    Console.WriteLine(msg);
    double num = double.Parse(Console.ReadLine() ?? "0");
    return num;
}

void PrintResult(string msg) //вывод результата
{
    Console.WriteLine(msg);
}
string op = String.Empty; //переменная оператора
double ReadOper(string msg, double a, double b) //Основной метод вычислений
{
    Console.WriteLine(msg);
    op = Console.ReadLine();
    switch (op)
    {
        case "+":
            return (double)(a + b);
        case "-":
            return (double)(a - b);
        case "*":
            return (double)(a * b);
        case "/": //обработка деления на 0
            if (b == 0)
            {
                Console.WriteLine("Error:Division by zero");
                Environment.Exit(0);
            }
            return (double)(a / b);
        case "^":
            return Power(a, b);
        default:
            return 0;
    }
}

double Power(double a, double b) //Вспомогательный метод возведения в степень
//По условию задачи должен быть реализован в виде цикла
{
    double powered = 1;
    if ((b - Math.Floor(b) != 0)) //На случай если число b является дробным и был выбран оператор возведения
    //в степень — округляем до ближайшего целого
    {
        Console.WriteLine("Sorry,non integer powers are not allowed in this version of calculator");
        Console.Write("Your power " + b + " will be rounded to ");
        b = (int)Math.Round(b);
        Console.WriteLine(b);
    }
    for (int i = 1; i <= Math.Abs(b); i++)
    {
        powered *= a;

    }
    if (b < 0)
    {
        return 1 / powered;
    }
    return powered;
}
Console.WriteLine("Welcome to the Calculator.Enter two numbers and an operation:");
double numA = ReadData("Enter number A");
double numB = ReadData("Enter number B");
double result = ReadOper("Enter operation: +,-,*,/,^ are the possible choice", numA, numB);
if (op.Equals("^")) //Так обеспечивается корректный вывод,если степень дробная
{
    PrintResult($"{numA} " + $"{op}" + $" {Math.Round(numB)}" + " = " + result);
}
else
{
    PrintResult($"{numA} " + $"{op}" + $" {numB}" + " = " + result);
}

