//Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
/*Массив размером 2 x 2 x 2
66(0,0,0) 25(0, 1, 0)
34(1, 0, 0) 41(1, 1, 0)
27(0, 0, 1) 90(0, 1, 1)
26(1, 0, 1) 55(1, 1, 1)*/

int ReadData(string msg) //Чтение данных
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

//Заполнение массива
int[,,] Fill3DArray(int dimA, int dimB,int dimC)
{
    System.Random rnd = new System.Random();
    int[,,] array3D = new int[dimA,dimB,dimC];
    for (int i = 0; i < dimA; i++)
    {
        for (int j = 0; j < dimB; j++)
        {
            for (int k = 0; k < dimC; k++)
            {
                array3D[i, j, k] = new Random().Next(0, 101);
            }
        }
    }
    return array3D;
}

//Вывод массива
void Print3DArray(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.Write(matrix[i, j, k] + $"({ i},{ j},{ k})" + " ");
            }
        }
        Console.WriteLine();
    }
}

int dimensionA = ReadData("Введите количество элементов измерения 1: ");
int dimensionB = ReadData("Введите количество элементов измерения 2: ");
int dimensionC = ReadData("Введите количество элементов измерения 3: ");
int[,,] array3d = Fill3DArray(dimensionA,dimensionB,dimensionC);
Print3DArray(array3d);


