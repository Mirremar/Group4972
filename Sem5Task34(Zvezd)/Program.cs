//№34 Задайте массив заполненный случайными положительными трёхзначными числами.
//Напишите программу, которая покажет количество чётных чисел в массиве.
//(со звездочкой) Отсортировать массив методом пузырька
//[345, 897, 568, 234] -> 2
//[845, 222, 367, 123-> 1

int[] GenArray(int length) //Генерируем массив
{
    int[] array = new int[length];
    for (int i = 0;i<length;i++)
    {
        array[i] = new Random().Next(100, 1000); //Трёхзначные числа по условию задачи
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

int CountEven(int[] arr)//подсчёт чётных
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i]%2==0) { count++; }
    }
    return count;
}

void BubbleArraySort(int[] arr) //Сортировка пузырьком
{
    for (int j = 0; j < arr.Length; j++)
    {
        for (int i = 0; i < arr.Length-1; i++)
        {
            int temp = 0;
            if (arr[i + 1] < arr[i])
            {
                temp = arr[i];
                arr[i] = arr[i + 1];
                arr[i + 1] = temp;
            }
        }
    }
}


int[] testArray = GenArray(20); //В условии задачи не сказано,сколько конкретно элементов нужно
//сгенерировать в массиве.Дя примера взял 20
PrintArray(testArray);
Console.WriteLine("В массиве присутствует " + $"{CountEven(testArray)}" + " чётных чисел");
BubbleArraySort(testArray);
Console.WriteLine("Отсортированный массив:");
PrintArray(testArray);

