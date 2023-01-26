using System;
using static System.Console;

Clear();
int size = 4;

int[,] matrixFourOnFour = new int[size, size];

int num = 1;
int i = 0;
int j = 0;

while (num <= size * size)
{
    matrixFourOnFour[i, j] = num;
    if (i <= j + 1 && i + j < size - 1) j++;
    else if (i < j && i + j >= size - 1) i++;
    else if (i >= j && i + j > size - 1) j--;
    else i--;
    num++;
}


PrintArray(matrixFourOnFour);


void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Write(array[i, j] + " ");
        }
        Write("]");
        WriteLine("");
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


int InputInt(string output)
{
    Write(output);
    return int.Parse(ReadLine());
}