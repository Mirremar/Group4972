//Задача №32 Напишите программу замена элементов массива: положительные элементы замените 
//на соответствующие отрицательные, и наоборот.

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

void ReplaceArray(int[] arr)
{
    for (int i=0;i<arr.Length;i++)
    {
        arr[i] = -arr[i];        
    }
   // return arr;
}

int[] demoarray = GenArray(20,-50,50);
PrintArray(demoarray);
ReplaceArray(demoarray);
PrintArray(demoarray);