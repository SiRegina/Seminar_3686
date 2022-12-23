// Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

int ReadInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] GetRandomMatrix(int rows, int columns, int leftRange = 0, int rightRange = 10)
{
    int[,] matr = new int[rows, columns];

    var rand = new Random();
    for(int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = rand.Next(leftRange, rightRange + 1);
        }
    }

    return matr;
}

int [,] ReplaceStrings(int[,] matr)
{
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            int temp = matr[0,j];
            matr[0, j] = matr[matr.GetLength(0)-1, j];
            matr[matr.GetLength(0)-1, j] = temp;
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
int[,] matrix = GetRandomMatrix(rowsCount, columnsCount);
PrintMatrix(matrix);
Console.WriteLine();
ReplaceStrings(matrix);
PrintMatrix(matrix);
