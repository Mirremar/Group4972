//№36 Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[3, 7, -2, 1]-> 8
//[-4, -6, 89, 6]-> 0

int[] GenArray(int length) //Генерируем массив
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(-100, 100); //Верхней и нижней границы в условии задачи нет,
        //для примера генерируются значения от -100 до 100
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

int SumElementsNotEvenIndex(int[] arr)//Суммируем элементы на нечётных позициях
{
    int Sum = 0;
    for (int i = 1; i < arr.Length; i+=2)
    {
        Sum += arr[i];
    }
    return Sum;
}

int[] array = GenArray(20);
PrintArray(array);
int Sum = SumElementsNotEvenIndex(array);
Console.WriteLine("Сумма элементов на нечётных позициях равна " + Sum);
