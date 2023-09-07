// See https://aka.ms/new-console-template for more information
//№13* Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//* Сделать вариант для числа длиной до 10 цифр не используя char или string

Console.WriteLine("Введите число");
long Number = Convert.ToInt64(Console.ReadLine() ?? "0");
//Проверяем границы числа,т.к. по условию до 10 цифр,а в числах меньше 100 нет третьей цифры.
   if ((Number < 100)||(Number > 999999999))
   {
      Console.WriteLine("В числе нет третьей цифры либо оно слишком большое");
      System.Environment.Exit(0); //Останавливаем выполнение программы,если условия ввода не выполнены.
   }
int counter = 1; //Количество "делений" введённого числа и размер будущего массива цифр.
//Присвоена единица для удобства
long temp = Number;
int index = 0;

while (temp - temp % 10 > 0) //Делим число,пока последняя цифра числа не вычтет саму себя и не получится 0
{
    temp = (temp - temp % 10) / 10;
    counter++; //подсчёт количества делений
   // Console.WriteLine(temp);
   // Console.WriteLine(counter);
}

long[] digits = new long[counter];//Количество делений числа = количество элементов массива
temp = Number;
for (index = digits.Length-1; index > 0; index--) //заполнение массива.Не доходим до последнего деления на 10,так как
//тогда в нулевом элементе массива всегда будет 0.
{
    digits[index] = temp % 10;
    temp = (temp - temp % 10) / 10;
}
digits[0] = temp; //В нулевом элементе оставшаяся цифра первого разряда числа
/*Console.Write("Преобразованное число ");
while (index < digits.Length)
{
    Console.Write(digits[index]);
    index++;
}*/
Console.WriteLine("Третья цифра " + digits[2]);