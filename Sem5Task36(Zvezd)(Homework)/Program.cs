//№36 Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//(со звездочкой) Найдите все пары в массиве и выведите пользователю

int[] GenArray(int length) //Генерируем массив
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(0, 10); //Для удобства,чтоб было больше пар
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
    for (int i = 1; i < arr.Length; i += 2)
    {
        Sum += arr[i];
    }
    return Sum;
}

List<Pair> GetPairsFromArray(int[] arr) //Коллекция собственного типа данных Pair.Класс Pair объявлен в самом низу кода
{
    List<Pair> pairsCollection = new List<Pair>(); //Сюда будем добавлять пары чисел
    List<int> arrayConverted = new List<int>(); 
    arrayConverted = arr.ToList(); //конвертируем массив в коллекцию для удобства работы
    int lookUpIndex = 0; //"Одинаковость" этого элемента будем определять в цикле ниже
    //int i = 0;
    for (lookUpIndex = 0; lookUpIndex < arrayConverted.Count; lookUpIndex++)
    {
        for (int i = 0; i < arrayConverted.Count; i++)
        {   
            if (i == lookUpIndex) //Пропускаем итерацию цикла,если индекс искомого элемента совпадает с индексом 
            //просматриваемого в данный момент,чтобы исключить некорректную работу программы
            { continue; }
            if (arrayConverted.ElementAt(i).Equals(arrayConverted.ElementAt(lookUpIndex)))
            {
                Pair somePair = new Pair();
                somePair.one = arrayConverted.ElementAt(lookUpIndex);
                somePair.two = arrayConverted.ElementAt(i); //Из совпадающих пар чисел составляем элементы вида
                                                            //(x,y) и отправляем их в коллекцию пар
                pairsCollection.Add(somePair);
                arrayConverted.RemoveAt(i);                 //Совпадающие числа убираем из просматриваемой коллекции
                arrayConverted.RemoveAt(lookUpIndex);
                lookUpIndex = 0;                            //Поскольку в случае совпадений лишние числа
                                                            //были удалены,нужно начинать поиск снова с 0 элемента

            }
        }
    }
   return pairsCollection; //Возвращаем коллекцию пар чисел
}


void PrintPairsCollection(List<Pair> listofpairs) //Метод для вывода коллекции пар чисел
{
    Console.WriteLine("Пары в массиве: ");
    foreach(var pair in listofpairs)
    {
        Console.WriteLine(pair.one + " , " + pair.two);
    }
}


int[] array = GenArray(10);
PrintArray(array);
int Sum = SumElementsNotEvenIndex(array);
Console.WriteLine("Сумма элементов на нечётных позициях равна " + Sum);
List<Pair> resultingPairList = GetPairsFromArray(array);
if (resultingPairList.Count == 0) //Если в коллекции пар ничего не оказалось - сообщаем об этом
{
    Console.WriteLine("В массиве не оказалось парных значений");
}
else { PrintPairsCollection(resultingPairList); }
class Pair //для пар чисел создаём собственный тип данных Pair.
{
    public int one;
    public int two;
}