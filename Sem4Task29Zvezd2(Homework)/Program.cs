//№29 Напишите программу, которая задаёт массив и выводит их на экран.
//(задание со *) Дополнительно: Написать программу которая из имен через
//запятую выберет случайное имя и выведет в терминал

string ReadData(string msg) //чтение данных
{
    Console.WriteLine(msg);
    string names = (Console.ReadLine() ?? "0");
    return names;
}


void PrintResult(string msg) //Вывод массива.Ввод длины не нужен,так как задан условием задачи
{
    
    Console.WriteLine(msg);
}

string SelectRandomName(string names) //Генерация массива
{
    names = (names.TrimEnd()).TrimStart();
    string[] splitNames = names.Split(',');
    foreach (var s in splitNames)
    {
        (s.TrimEnd()).TrimStart();
    }
    int randomNameID = new Random().Next(0, splitNames.Length);
    return splitNames[randomNameID];
}

string names = ReadData("Введите имена через запятую");
string someName = SelectRandomName(names);
PrintResult("Случайное имя из списка: " + someName);