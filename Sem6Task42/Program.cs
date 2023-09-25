//Задача №42
//Напишите программу, которая будет преобразовывать десятичное число в двоичное.


int ReadData(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

List<int> DecToBin(ref int num)
{
    List<int> residues = new List<int>();
    while (num > 0)
    {
        residues.Add(num % 2);
        num /= 2;
    }
    residues.Reverse();
    return residues;

}

void PrintResult(List<int> res)
{
    foreach (var r in res)
    {
        Console.Write(r.ToString());
    }
}

int num = ReadData("Enter num");
PrintResult(DecToBin(ref num));