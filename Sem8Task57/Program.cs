//Задача №57 Составить частотный словарь элементов двумерного массива.
//Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.

int ReadData(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}


int[,] Fill2DArray(int countRow, int countColumn)
{
    System.Random rnd = new System.Random();
    int[,] array2D = new int[countRow, countColumn];
    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            array2D[i, j] = new Random().Next(0, 11);
        }
    }
    return array2D;
}

void Print2DArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int FreqDicLength(int[,] arr)
{
    int max = 0;
    for (int i = 0; i < arr.GetLength(0)-1; i++)
    {
        for (int j = 0; j < arr.GetLength(1)-1; j++)
        {
            if (arr[i,j] > max) {max = arr[i,j];}
        }
    }
    return max+1;
}

int[] FreqDic(int[,] arr,int len)
{
    int[] dic = new int[len];
    for (int i=0;i<arr.GetLength(0);i++)
    {
        for (int j=0;j<arr.GetLength(1);j++)
        {
            dic[arr[i,j]]++;
        }
    }
    return dic;
}


void Print1DArray(int[] freq) //печатаем результат
{
    Console.Write("[ ");
    for (int i = 0; i < freq.Length - 1; i++)
    {
        Console.Write(freq[i] + ",");
    }
    Console.Write(freq[freq.Length - 1] + " ]");
}

int row = ReadData("Введите количество строк");
int col = ReadData("Введите количество стобцов");
int[,] matrix = Fill2DArray(row,col);
Print2DArray(matrix);
int[] frequencyDic = FreqDic(matrix,FreqDicLength(matrix));
Console.WriteLine("-------------------------------------------------");
Print1DArray(frequencyDic);