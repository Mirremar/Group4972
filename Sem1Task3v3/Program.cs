// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите число");
int DayOfWeek = int.Parse(Console.ReadLine());

string outDayOfWeek = System.Globalization.CultureInfo.GetCultureInfo("ru-RU").DateTimeFormat.GetDayName((DayOfWeek)Enum.GetValues(typeof(DayOfWeek)).GetValue(DayOfWeek));
Console.WriteLine(outDayOfWeek);