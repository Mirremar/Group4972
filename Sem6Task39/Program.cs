//Задача №39 
//Напишите программу, которая перевернёт одномерный массив (последний элемент будет на 
//первом месте, а первый - на последнем и т.д.)

int[] GenArray(int length) //Генерируем массив
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(1, 100); //должен быть от 0 для сортировки подсчётом
    }
    return array;

}

void PrintArray(int[] arr) //печатаем массив
{
    Console.Write("[ ");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + "|");
    }
    Console.Write(arr[arr.Length - 1] + " ]");
}

int[] SwapNewArray(int[] arr)
{
    int[] outArray = new int[arr.Length];
    for (int i =0;i<arr.Length;i++) { outArray[arr.Length-1-i] = arr[i]; }
    return outArray;
}

void SwapArray(int[] arr)
{
    int bufferElement = 0;
    for (int i=0;i<arr.Length/2;i++)
    {
        (arr[arr.Length-1-i],arr[i])=(arr[i],arr[arr.Length-1-i]);
        //bufferElement = arr[arr.Length-1-i];
        //arr[arr.Length-1-i]=arr[i];
        //arr[i] = bufferElement;
    }

}

int[] array = GenArray(15);
PrintArray(array);
Console.WriteLine();
//int[] outArray = SwapNewArray(array);
//PrintArray(outArray);
SwapArray(array);
PrintArray(array);