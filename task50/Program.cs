// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> такого числа в массиве нет


//считывает целое число от пользователя
int ReadInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] GetRandomMatrix(int rows, int columns, int leftRange = -10, int rightRange = 10)
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

int row = ReadInt("Введите номер строки");
int column = ReadInt("Введите номер столбца");

const int ROWSCOUNT = 3;
const int COLUMNSCOUNT = 4;

int[,] matrix = GetRandomMatrix(ROWSCOUNT, COLUMNSCOUNT);
PrintMatrix(matrix);
System.Console.WriteLine();
if (row < ROWSCOUNT  & column < COLUMNSCOUNT & row>=0 & column>=0)
{
    Console.WriteLine( matrix[row, column]);
}
else
{
    Console.WriteLine($"{row} {column} -> такого числа в массиве нет");
}