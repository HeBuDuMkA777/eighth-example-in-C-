using System;
using static System.Console;

Clear();
WriteLine("Введите количество строк в матрицах: ");
int rowsValue = int.Parse(ReadLine());
WriteLine("Введите количество столбцов в матрицах: ");
int columnsValue = int.Parse(ReadLine());
int[,] matrixOne = GreatMatrix(rowsValue, columnsValue, 1, 10);
int[,] matrixTwo = GreatMatrix(rowsValue, columnsValue, 1, 10);
PrintMatrix(matrixOne); //печать массива для проверки
WriteLine();
PrintMatrix(matrixTwo); //печать второго массива для проверки
WriteLine();
PrintMatrix(MultiplyMatrix(matrixOne, matrixTwo));





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

int[,] MultiplyMatrix(int[,] matrixFirst, int[,] matrixSecond)
{
    int[,] multiply = new int[matrixFirst.GetLength(0), matrixFirst.GetLength(1)];
    for (int i = 0; i < multiply.GetLength(0);i++)
    {
        for (int j = 0; j < multiply.GetLength(1); j++)
        {
            multiply[i,j] = matrixFirst[i,j] * matrixSecond[i,j];
        }
    }
    return multiply;
}