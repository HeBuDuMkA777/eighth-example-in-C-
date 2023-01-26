using System;
using static System.Console;

Clear();


WriteLine("Введите длину массива: ");
int deep1 = int.Parse(ReadLine());
WriteLine("Введите ширину массива: ");
int deep2 = int.Parse(ReadLine());
WriteLine("Введите глубину массива: ");
int deep3 = int.Parse(ReadLine());
int border = 89;

if (deep1 * deep2 * deep3 > border)
{
    Write("Массив слишком большой");
}

int[,,] resultNums = Create3DMassive(deep1, deep2, deep3);
for (int i = 0; i < resultNums.GetLength(0); i++)
{
    for (int j = 0; j < resultNums.GetLength(1); j++)
    {
        for (int k = 0; k < resultNums.GetLength(2); k++)
        {
            Console.WriteLine($"{resultNums[i, j, k]}({i},{j},{k})");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}


int[,,] Create3DMassive(int size1, int size2, int size3)
{
    int[,,] array = new int[size1, size2, size3];
    int[] values = new int[border];
    int num
     = 10;
    for (int i = 0; i < values.Length; i++)
        values[i] = num
        ++;

    for (int i = 0; i < values.Length; i++)
    {
        int randomInd = new Random().Next(0, values.Length);
        int temp = values[i];
        values[i] = values[randomInd];
        values[randomInd] = temp;
    }

    int valueIndex = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = values[valueIndex++];
            }
        }
    }
    return array;
}
