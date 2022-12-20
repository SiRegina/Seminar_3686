// Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12
// ​Доп. условие для 51 задачи: сделать суммирование в один цикл. Матрица может быть прямоугольной

int ReadInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] GetSumMainDiagonal(int rows, int columns, int leftRange = 0, int rightRange = 10)
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

int ChangeMatrix(int[,] matr)
{
    int sum = 0;
    for(int i = 0; i < matr.GetLength(0) && i< matr.GetLength(1); i++)
    {
        sum = sum+matr[i,i];
       
    }
    return sum;
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
int[,] matrix = GetSumMainDiagonal(rowsCount, columnsCount);

PrintMatrix(matrix);
int result = ChangeMatrix(matrix);
Console.WriteLine ();
Console.WriteLine ("Сумма элементов по диагонали" + result);
