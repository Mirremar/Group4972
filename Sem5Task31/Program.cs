//Задача №31:Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
//Найдите сумму отрицательных и положительных элементов массива.

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

(int, int) NegativePositiveSum(int[] arr)
{
    int positiveSum = 0;
    int negativeSum = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) { positiveSum += arr[i]; }
        else { negativeSum += arr[i]; }
    }
    return (positiveSum, negativeSum);
}

int[] array = GenArray(12, -9, 9);
PrintArray(array);
(int pos, int neg) sum = NegativePositiveSum(array);
Console.WriteLine("Сумма больше 0: " + sum.pos + " Сумма меньше 0: " + sum.neg);