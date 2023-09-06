// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter 3digit number");
int Number = int.Parse(Console.ReadLine()??"0");
if (Number >= 100 && Number <= 1000)
{
    int Result = Number%10;
    Console.WriteLine("Result is " + Result);
}
else
{
    Console.WriteLine("number is not a 3digit or it is negative");
}