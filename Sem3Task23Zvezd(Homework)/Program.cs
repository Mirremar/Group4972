//23* вывести таблицу с границами и значениями, которые находятся друг над другом.
//Задача №22
//Напишите программу, которая принимает на вход число (N) 
//и выдаёт таблицу степеней чисел от 1 до N.

int ReadData(string msg) //Чтение данных
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

void PrintLine(int tableWidth) //Горизонтальные границы таблицы
{
    Console.WriteLine(new string('-', tableWidth));
}


string BuildLine(int num, int pow) //Расчёт степеней числа и постройка строки
{
    string res = String.Empty;
    for (int i = 1; i <= num; i++)
    {
        res = res + Math.Pow(i, pow) + " ";

    }

    return res;
}

void PrintResult(string msg) //вывод данных
{
    Console.WriteLine(msg);
}

string Realign(Dictionary<int,double> toalign,string strfromalign) //Переформатирование строки под выравнивание
{
    string resrealigned = String.Empty;
    string spaceInsert = String.Empty;
    int insertIndex = 0;
    insertIndex = 0;
    while (insertIndex < toalign.Count)
    {
        //int numSpaceToAdd = spaceindexes[insertIndex+1] - spaceindexes[insertIndex]-2;
        int numSpaceToAdd = NumSpaceToAdd(toalign,insertIndex);
        spaceInsert = String.Concat(Enumerable.Repeat(" ", numSpaceToAdd)) + "|";//составляем строку пробелов с
                                                                                   //вертикальной границей таблицы
        resrealigned = resrealigned + toalign.ElementAt(insertIndex).Key + spaceInsert;//запись обновлённой строки
        //в ключе хранятся числа от 1 до N
        insertIndex++;
    }

    return resrealigned;
}

int NumSpaceToAdd(Dictionary<int,double> somedict,int searchindex) //Вспомогательный метод:рассчитывает
    //количество пробелов,которые надо добавить после числа,чтоб всё было ровно
    //в общем случае это количество разрядов степени числа - количество разрядов самого числа,если оно двузначное или
    //больше и -1 "компенсация" вывода самого числа.
{
   
        int numSpaceToAdd = Convert.ToInt32(somedict.ElementAt(searchindex).Value) -
                   Convert.ToInt32(Math.Floor(Math.Log10(Convert.ToDouble(somedict.ElementAt(searchindex).Key)))) - 1;
        return numSpaceToAdd;

}

Dictionary<int,double> GetRidOfSpaces(string str,int pow) //Преобразование строки в вид
    //число в степени 1(ключ) <-> количество разрядов числа степени 1(значение) — необходимо для выравнивания
{
    Dictionary<int, double> pow1CharCollection = new Dictionary<int, double>();
    str = (str.TrimEnd()).TrimStart(); //Избавляемся от пробела в конце и в начале,если он есть
    string[] strtochar = str.Split(' '); //Для того,чтоб записать в словарь,разбиваем строку на 
    //подстроки с разделителем пробелом

    for (int i = 0; i < strtochar.Length; i++)
    {
        pow1CharCollection.Add(int.Parse(strtochar[i]), Math.Floor(Math.Log10(
            Math.Pow(double.Parse(strtochar[i]), Convert.ToDouble(pow))))+1);
        //количество разрядов в числе = округлённый вниз десятичный логарифм + 1.Нам нужны
        //как сами числа в качестве ключа,так и логарифм их степени N,чтоб посмотреть количество разрядов
        //Это необходимо для выравнивания
    }
    return pow1CharCollection;
}

string OutNoSpaces(string str)//меняем пробелы на вертикальные границы таблицы
{
    str = str.Replace(' ', '|');
    return str;
}

int Num = ReadData("Введите число");
int pow = ReadData("Введите степень");
PrintResult("Таблица " + $"{pow}" + " степени чисел до " + $"{Num}");
string respow1 = BuildLine(Num, 1);
string respowN = BuildLine(Num, pow);
int Width = respowN.Length;
respow1 = Realign(GetRidOfSpaces(respow1,pow), respowN);
PrintLine(Width);
PrintResult("|" + respow1);
PrintLine(Width);
PrintResult(OutNoSpaces("|"+respowN));
PrintLine(Width);