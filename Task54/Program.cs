using System;
using static System.Console;

Clear();

int[,] matrix = GreatMatrix(new Random().Next(1, 10), new Random().Next(1, 10), 1, 10);
PrintMatrix(matrix); //печать массива для проверки
WriteLine();
SortMatrix(matrix);
PrintMatrix(matrix);




void SortMatrix(int[,] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1) - 1; j++)
        {
            for (int k = 0; k < Array.GetLength(1) - 1; k++)
            {
                if (Array[i, k] > Array[i, k + 1]) 
                {
                    int temp = 0;
                    temp = Array[i, k];
                    Array[i, k] = Array[i, k + 1];
                    Array[i, k + 1] = temp;
                }
            }
        }
    }
}



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