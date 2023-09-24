//№38 Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76
//[2 0, 4 9 7, 2 78]-> 77,6

double[] GenArray(int length) //Генерируем массив
{
    double[] array = new double[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = Math.Round((new Random().Next(0, 10) + new Random().NextDouble()),4); //Вещественные числа делаем
        //с 4 знаками после запятой для удобства
    }
    return array;

}

void PrintArray(double[] arr) //печатаем результат
{
    Console.Write("[ ");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + "|"); 
    }
    Console.Write(arr[arr.Length - 1] + " ]");
}

double FindMinMaxDifference(double[] arr) //поиск разницы между максимумом и минимумом
{
    double max = arr[0];
    double min = arr[0];
    for (int i=1;i<arr.Length;i++)
    {
        if (arr[i] > max) { max = arr[i]; }
        if (arr[i] < min) { min = arr[i]; }
    }
    return (max - min);
    
}

double[] array = GenArray(20);
PrintArray(array);
Console.WriteLine("Разница между максимальным и минимальным элементами массива: " + FindMinMaxDifference(array));