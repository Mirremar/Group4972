//№29 Напишите программу, которая задаёт массив и выводит их на экран.
//(задание со *) Ввести с клавиатуры длину массива и диапазон значений элементов

int ReadData(string msg) //чтение данных
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}


void PrintArray(int[] arr) //Вывод массива.
{
    Console.Write("[ ");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ",");
    }
    Console.Write(arr[arr.Length - 1] + " ]");
}

int[] GenArray(int length,int lowLimit,int highLimit) //Генерация массива
{
    
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(lowLimit, highLimit);
    }
    return array;
}

int length = ReadData("Введите длину массива. Массив будет заполнен случайными числами");
int low = ReadData("Введите нижний предел значений элементов массива");
int ceil = ReadData("Введите верхний предел значений элементов массива");

int[] res = GenArray(length,low,ceil);
PrintArray(res);