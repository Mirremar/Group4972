// See https://aka.ms/new-console-template for more information
//Задача №18
//Напишите программу, которая по заданному номеру четверти, 
//показывает диапазон возможных координат точек в этой четверти (x и y).

int ReadData(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

string FindPoints(int temp)
{
    if (temp == 1) return ("x:(0,+infinity); y:(0, +infinity)");
    if (temp == 2) return ("x:(-infinity,0); y:(0, +infinity)");
    if (temp == 3) return ("x:(-infinity,0); y:(-infinity, 0)");
    if (temp == 4) return ("x:(0,+infinity); y:(-infinity, 0)");
    return "0";

}

void PrintResult(string msg)
{
    Console.WriteLine(msg);
}

int temp = ReadData("Enter quarter num");
//string res = FindPoints(temp);
PrintResult(FindPoints(temp));