//Задача №44
//Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.

void PrintFibNum(int num)
{
    int buffer = 0;
    string line = string.Empty;
    int first = 0;
    int second = 1;
    Console.Write(first + " " + second);
    for (int i=2;i<num;i++)
    {
        Console.Write(" " + (first + second));
        buffer = first + second;
        first = second;
        second = buffer;
    }
}

PrintFibNum(10);