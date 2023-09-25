//Задача №45
//Напишите программу, которая будет создавать копию заданного одномерного массива с помощью поэлементного копирования

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

int[] CopyArray(int[] array)
{
    int[] copyArr = new int[array.Length];
    for (int i=0;i<array.Length;i++)
    {
        copyArr[i] = array[i];
    }
    return copyArr;
}

void PrintArray(int[] arr) //печатаем результат
{
    Console.Write("[ ");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ",");
    }
    Console.Write(arr[arr.Length - 1] + " ]");
    Console.WriteLine();
}

int[] ar = GenArray(20,0,100);
int[] copar = CopyArray(ar);
PrintArray(ar);
PrintArray(copar);