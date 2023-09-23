//№34 Задайте массив заполненный случайными положительными трёхзначными числами.
//Напишите программу, которая покажет количество чётных чисел в массиве.
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

int[] testArray = GenArray(20); //В условии задачи не сказано,сколько конкретно элементов нужно
//сгенерировать в массиве.Для примера взял 20
PrintArray(testArray);
Console.WriteLine("В массиве присутствует " + $"{CountEven(testArray)}" + " чётных чисел");

