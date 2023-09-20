//№29 Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
void PrintArray(int[] arr) //Вывод массива.Ввод длины не нужен,так как задан условием задачи
{
    Console.Write("[ ");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ",");
    }
    Console.Write(arr[arr.Length - 1] + " ]");
}

int[] GenArray() //Генерация массива
{
    int length = 8;//по условию задачи
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(0, 100);
    }
    return array;
}

int[] res = GenArray();
PrintArray(res);