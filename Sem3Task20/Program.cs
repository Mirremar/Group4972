// See https://aka.ms/new-console-template for more information

int ReadData(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

double Distance(int x, int y)
{
    double distance = Math.Sqrt(x * x + y * y);
    return distance;
}

void PrintResult(string msg)
{
    Console.WriteLine(msg);
}

int x1 = ReadData("Введите координату x1: ");
int y1 = ReadData("Введите координату y1: ");
int x2 = ReadData("Введите координату x2: ");
int y2 = ReadData("Введите координату y2: ");
double res = Distance((x2 - x1), (y2 - y1));
PrintResult("Расстояние равно " + $"{res}");