//Задача №33
//Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.


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

int NumberToCheck(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
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

bool IfExists(int[] arr,int num)
{
   for (int i=0;i<arr.Length;i++)
   {
    if (arr[i] == num) {return true;}
   }
   return false;
}

int numCheck = NumberToCheck("Введите число для проверки в массиве");
int[] array = GenArray(20,0,100);
PrintArray(array);
Console.WriteLine(IfExists(array,numCheck)); 