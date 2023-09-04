// See https://aka.ms/new-console-template for more information
int numA = int.Parse(Console.ReadLine()??"0");
int numB = int.Parse(Console.ReadLine()??"0");
if (numA*numA == numB)
{
    Console.WriteLine("1 число — квадрат второго");

}
else
{
    Console.WriteLine("1 число — не квадрат второго");
}