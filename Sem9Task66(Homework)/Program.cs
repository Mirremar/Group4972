//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных
//элементов в промежутке от M до N.
//M = 1; N = 15-> 120
//M = 4; N = 8. -> 30

int ReadData(string msg) //Чтение данных
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

long RecursSum(int M,int N) //Рекурсивный метод вывода
{
    if (M > N) { return 0; }
    else
    {
        return M + RecursSum(M + 1, N);
    }
}

int M = ReadData("Введите M: ");
int N = ReadData("Введите N: ");
long Sum = RecursSum(M,N);
Console.WriteLine("Sum from M to N is " + Sum);