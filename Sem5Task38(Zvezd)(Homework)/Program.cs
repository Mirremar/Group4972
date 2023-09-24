//№38 Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76
//[2 0, 4 9 7, 2 78]-> 77,6
//(со звездочкой) Отсортируйте массив методом вставки и методом подсчета,
//а затем найдите разницу между первым и последним элементом.
//Для задачи со звездочкой использовать заполнение массива целыми числами.

int[] GenArray(int length) //Генерируем массив
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(0, 100); //должен быть от 0 для сортировки подсчётом
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

int FindMinMaxDifference(int[] arr) //Разница между максимальным и минимальным значением 
{
    int max = arr[0];
    int min = arr[0];
    for (int i=1;i<arr.Length;i++)
    {
        if (arr[i] > max) { max = arr[i]; }
        if (arr[i] < min) { min = arr[i]; }
    }
    return (max - min);
    
}

int FindMax(int[] arr) //Отдельно поиск максимального,нужен для сортировки
{
    int max = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] > max) { max = arr[i]; }
    }
    return max;
}



void InsertSort(int[] arr) //Сортировка вставкой
{
    int temp = 0;
    for (int i = 1; i < arr.Length; i++)
    {
        for (int j = i; j > 0 && arr[j - 1] > arr[j]; j--) // пока j>0 и элемент j-1 > j
        {
           temp = arr[j - 1]; // меняем местами элементы j и j-1
            arr[j - 1] = arr[j];
            arr[j] = temp;
        }
    }
}

void CountSort(int[] arr) //Сортировка подсчётом
{
    int[] additionalArray = new int[FindMax(arr)+1]; //Создаём вспомогательный массив
    for (int i = 0; i < additionalArray.Length; i++) { additionalArray[i] = 0; } //Заполняем вспомогательный массив
                                                                                 //нулями
    for (int i = 0; i < arr.Length; i++) { additionalArray[arr[i]]++; } //Запоминаем,сколько раз какой элемент
                                                                        //встречается и записываем во вспомогательный
                                                                        //массив
    int k = 0;
    for (int i=0;i<additionalArray.Length;i++) //В основной массив записываем номера ячеек вспомогательного
                                               //Столько раз подряд,какое значение находится в этой ячейке
    {
        if (additionalArray[i] > 0)
        {
            for(int j = 0;j < additionalArray[i];j++)
            {
                arr[k+j] = i;
            }
            k = k + additionalArray[i];
        }
    }

}


int[] array = GenArray(20);
PrintArray(array);
int[] array2 = new int[array.Length]; 
Array.Copy(array, array2,array.Length);//копируем сгенерированный массив,чтоб продемонстрировать обе сортировки 
Console.WriteLine();
Console.WriteLine("Разница между максимальным и минимальным элементами массива: " + FindMinMaxDifference(array));
InsertSort(array);
Console.WriteLine("Сотировка вставкой: ");
PrintArray(array);
Console.WriteLine();
Console.WriteLine("Сортировка подсчётом: ");
CountSort(array2);
PrintArray(array2);
Console.WriteLine();
Console.WriteLine("Разница между первым и последним элементом равна " + (array2[array2.Length-1] - array2[0]));