// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter a number");
int N = int.Parse(Console.ReadLine()??"0");
int AntiN = -N;
for (int i = 0; i <= 2*N; i++)
{
    if  (AntiN == N)
    {
        Console.Write(AntiN);
        break;
    }
    Console.Write(AntiN + ", ");
    AntiN += 1;
    
}

//Можно сделать через цикл while,так проще и рациональнее.