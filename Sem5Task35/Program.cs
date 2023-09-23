//Задача №35
//Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, 
//значения которых лежат в отрезке [10,99].

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

int Count(int[] arr)
{
    int count = 0;
   for (int i=0;i<arr.Length;i++)
   {
    if ((arr[i]>=10)&&(arr[i]<=99)) {count++;}
   }
   return count;
}

int[] array = GenArray(123,-100,200);
PrintArray(array);
int result = Count(array);
Console.WriteLine();
Console.WriteLine("В массиве " + $"{result}" + " элементов в диапазоне от 10 до 99");