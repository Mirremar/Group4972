// See https://aka.ms/new-console-template for more information
//Задача №30
//Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.

int ReadData(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

void PrintArray(int[] arr)
{
    Console.Write("[ ");
    for(int i=0;i<arr.Length-1;i++ )
    {
        Console.Write(arr[i]+ ",");
    }
    Console.Write(arr[arr.Length-1]+" ]");
}

int[] GenArray(int num)
{
    int[] array = new int[num];
    for (int i = 0; i < num; i++)
    {
        array[i] = new Random().Next(0, 2);
    }
    return array;
}

int len = ReadData("Enter length");
int[] res = GenArray(len);
PrintArray(res);