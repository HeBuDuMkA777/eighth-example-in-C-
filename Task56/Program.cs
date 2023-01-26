using System;
using static System.Console;

Clear();

int[,] matrix = GreatMatrix(new Random().Next(1, 10), new Random().Next(1, 10), 1, 10);
PrintMatrix(matrix); //печать массива для проверки
WriteLine();
int[] listSum = GetSumRows(matrix);
WriteLine($"Индекс строки с минимальной суммой равен {GetMinimum(listSum)}");






int[,] GreatMatrix(int rows, int columns, int min, int max)
{
    int[,] result = new int[rows, columns];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i,j] = new Random().Next(min, max + 1);
        }
    }
    return result;
}


void PrintMatrix(int[,] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            Write($"{Array[i,j]} ");
        }
        WriteLine();
    }
}

int[] GetSumRows(int[,] array)
{
    int[] sum = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum[i] += array[i,j];
        }
    }
    return sum;
}

int GetMinimum(int[] list)
{
    int min = list[0];
    int indexSum = 0;
    for (int i = 1; i < list.Length; i++)
    {
        if (min > list[i])
        { 
            min = list[i];
            indexSum = i;
        }
    }
    return indexSum;
}