﻿// Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

int ReadInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] GetFormulaMatrix(int rows, int columns, int leftRange = 0, int rightRange = 10)
{
    int[,] matr = new int[rows, columns];

    // var rand = new Random();
    for(int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = i+j;
        }
    }

    return matr;
}

void PrintMatrix(int[,] matr)
{
    for(int i = 0; i < matr.GetLength(0); i++)
    {
        Console.WriteLine();
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write(matr[i, j] + " ");
        }
    }
}

int rowsCount = ReadInt("Введите число строк");
int columnsCount = ReadInt("Введите число столбцов");
int[,] matrix = GetFormulaMatrix(rowsCount, columnsCount);
PrintMatrix(matrix);