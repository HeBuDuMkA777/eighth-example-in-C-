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