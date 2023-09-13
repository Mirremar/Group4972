// See https://aka.ms/new-console-template for more information
//Узнать четверть плоскости

// 2 1 
// 3 4

//1) Ввести х
//2) Ввести у
//3) Поиск ответа
//4) Результат пользователю

//Вводим данные
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

//По координатам точки определяем номер четверти.
int QuarterTest(int x, int y)
{
    if (x > 0 && y > 0) return 1;
    if (x < 0 && y > 0) return 2;
    if (x < 0 && y < 0) return 3;
    if (x > 0 && y < 0) return 4;
    return 0;
}

//Печатаем результат
void PrintResult(string msg)
{
    Console.WriteLine(msg);
}

int x = ReadData("Введите координату x: ");
int y = ReadData("Введите координату y: ");
int res = QuarterTest(x,y);
PrintResult("Точка находится в " + $"{res}" + " четверти");