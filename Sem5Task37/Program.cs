//Задача №37
//Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, 
//второй и предпоследний и т.д. Результат запишите в новом массиве.

int[] GenArray(int num, int lowBorder, int highBorder) //Заполняем одномерный массив
{
    int[] array = new int[num];
    for (int i = 0; i < num; i++)
    {
        array[i] = new Random().Next(lowBorder, highBorder + 1); //+1,потому что создаём Random.Next(),верхняя граница 
                                                                 // не включается в отрезок по умолчанию

    }
    return array;
}

void PrintArray(int[] arr) //печатаем результат
{
    Console.Write("[ ");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ",");
    }
    Console.Write(arr[arr.Length - 1] + " ]");
}

int[] Multiplication(int[] arr)
{
    int[] pairsmultiplied = new int[arr.Length/2];
    for (int i= 0;i<arr.Length/2;i++)
    {
        pairsmultiplied[i] = arr[i]*arr[arr.Length-1-i];
    }
    return pairsmultiplied;
}

int[] array = GenArray(9,-10,10);
PrintArray(array);
int[] result = Multiplication(array);
Console.WriteLine();
PrintArray(result);