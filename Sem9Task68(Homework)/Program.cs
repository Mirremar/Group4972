//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
//Даны два неотрицательных числа m и n.
//m = 2, n = 3->A(m, n) = 9
//m = 3, n = 2->A(m, n) = 29

int ReadData(string msg) //Чтение данных
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

//Функция Аккермана
int Ack(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if ((m > 0) && (n == 0))
    {
        return Ack(m - 1, 1);
    }
    else if ((m > 0) && (n > 0))
    {
        return Ack(m - 1, Ack(m, n - 1));
    }
        else
            return n + 1;
}

int m = ReadData("Введите M: ");
int n = ReadData("Введите N: ");
int ack = Ack(m, n);
Console.WriteLine("Ackermann for m=" + $"{m}" + " and n=" + $"{n}" + " is " + ack);